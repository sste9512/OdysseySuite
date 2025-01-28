use serde::{Deserialize, Serialize};
use std::fs::File;
use std::io::{self, Read, Seek, Write};

// The Encapsulated Resource File (ERF) format is one of BioWare's methods of packing multiple files into a
// single file so that they may be treated as a single unit. In this regard, it is similar to .zip, .tar, or .rar.
// BioWare Aurora Engine/Toolset files that use the ERF format include the following: .erf, .hak, .mod, and
// .nwm.

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfFile {
    pub header: ErfHeader,
    pub localized_strings: ErfLocalizedStringTable,
    pub key_list: ErfKeyTable,
    pub resource_list: ErfResourceTable,
    pub resource_data: ErfResourceData,
    pub file_path: String,
}

impl ErfFile {
   
    pub fn get_resource_info(&self, resource_id: u32) -> Option<(&ErfKeyEntry, &ErfResourceEntry)> {
        if resource_id as usize >= self.key_list.entries.len() {
            return None;
        }

        Some((
            &self.key_list.entries[resource_id as usize],
            &self.resource_list.entries[resource_id as usize]
        ))
    }

 

    // Update the read_from_file function to store the file path
    /// Reads an ERF (Encapsulated Resource File) from the specified file path.
    ///
    /// # Arguments
    ///
    /// * `path` - A string slice containing the path to the ERF file to read
    ///
    /// # Returns
    ///
    /// * `io::Result<Self>` - Returns the parsed ERF file structure on success, or an IO error on failure
    ///
    /// # Errors
    ///
    /// This function will return an error if:
    /// * The file cannot be opened
    /// * The file is not a regular file
    /// * The file is larger than 100MB
    /// * The file metadata cannot be read
    /// * The file contents are invalid or corrupted
    pub fn read_from_file(path: &str) -> io::Result<Self> {
        // Convert backslashes to forward slashes for cross-platform compatibility
        let normalized_path = path.replace('\\', "/");
        
        // Try to open the file with better error handling
        let mut file = match File::open(&normalized_path) {
            Ok(f) => f,
            Err(e) => {
                return Err(io::Error::new(
                    io::ErrorKind::Other,
                    format!("Failed to open ERF file '{}': {}", normalized_path, e)
                ));
            }
        };

        // Get file metadata to verify size and access
        match file.metadata() {
            Ok(metadata) => {
                if !metadata.is_file() {
                    return Err(io::Error::new(
                        io::ErrorKind::Other, 
                        "Path exists but is not a regular file"
                    ));
                }
                // // Add size check to prevent loading extremely large files
                // if metadata.len() > 100_000_000 { // 100MB limit
                //     return Err(io::Error::new(
                //         io::ErrorKind::Other,
                //         "File is too large to process"
                //     ));
                // }
            },
            Err(e) => {
                return Err(io::Error::new(
                    io::ErrorKind::Other,
                    format!("Failed to read file metadata: {}", e)
                ));
            }
        }

        // Log: Reading header
        println!("Reading ERF header...");
        let header = ErfHeader::read_from_file(&mut file)?;
        println!("Found {} entries and {} languages", header.entry_count, header.language_count);
        
        // Pre-allocate vectors with known sizes
        let mut localized_strings = ErfLocalizedStringTable::new();
        localized_strings.strings.reserve_exact(header.language_count as usize);
        
        let mut key_list = ErfKeyTable::new();
        key_list.entries.reserve_exact(header.entry_count as usize);
        
        let mut resource_list = ErfResourceTable::new();
        resource_list.entries.reserve_exact(header.entry_count as usize);

        // Log: Reading localized strings
        println!("Reading {} localized strings...", header.language_count);
        file.seek(std::io::SeekFrom::Start(header.offset_to_localized_string as u64))?;
        for i in 0..header.language_count {
            let localized_string = ErfLocalizedString::read_from_file(&mut file)?;
            println!("Read localized string {}/{}", i+1, header.language_count);
            localized_strings.strings.push(localized_string);
        }

        // Log: Reading key list
        println!("Reading {} key entries...", header.entry_count);
        file.seek(std::io::SeekFrom::Start(header.offset_to_key_list as u64))?;
        for i in 0..header.entry_count {  
            let mut filename = [0u8; 16];
            let mut resource_id = [0u8; 4];
            let mut resource_type = [0u8; 2];
            let mut unused = [0u8; 2];

            file.read_exact(&mut filename)?;
            file.read_exact(&mut resource_id)?;
            file.read_exact(&mut resource_type)?;
            file.read_exact(&mut unused)?;

            key_list.entries.push(ErfKeyEntry {
                filename,
                resource_id: u32::from_le_bytes(resource_id),
                resource_type: u16::from_le_bytes(resource_type),
                unused: u16::from_le_bytes(unused),
            });
           // println!("Read key entry {}/{}", i+1, header.entry_count);
        }

        // Log: Reading resource list
        println!("Reading {} resource entries...", header.entry_count);
        file.seek(std::io::SeekFrom::Start(header.offset_to_resource_list as u64))?;
        for i in 0..header.entry_count {
            let mut offset = [0u8; 4];
            let mut size = [0u8; 4];

            file.read_exact(&mut offset)?;
            file.read_exact(&mut size)?;

            resource_list.entries.push(ErfResourceEntry {
                offset_to_resource: u32::from_le_bytes(offset),
                resource_size: u32::from_le_bytes(size),
            });
            //println!("Read resource entry {}/{}", i+1, header.entry_count);
        }

        // Initialize resource data container
        let resource_data = ErfResourceData::new();

        Ok(ErfFile {
            header,
            localized_strings,
            key_list,
            resource_list,
            resource_data,
            file_path: normalized_path,
        })
    }

    
    pub fn read_resource_data(&self, resource_id: u32) -> io::Result<Vec<u8>> {
        // Find the resource entry and key entry that match the resource_id
        let resource_entry = self.resource_list.entries.get(resource_id as usize)
            .ok_or_else(|| std::io::Error::new(
                std::io::ErrorKind::NotFound,
                format!("Resource ID {} not found", resource_id)
            ))?;

        // Open the file and seek to the resource data position
        let mut file = std::fs::File::open(&self.file_path)?;
        file.seek(std::io::SeekFrom::Start(resource_entry.offset_to_resource as u64))?;

        // Read the resource data
        let mut data = vec![0u8; resource_entry.resource_size as usize];
        file.read_exact(&mut data)?;

        Ok(data)
    }


}

const BYTECOUNT: usize = 116;

#[derive(Debug, Serialize, Deserialize)]
pub struct ErfHeader {
    /* File signature - "ERF ", "MOD ", "SAV ", or "HAK " */
    pub file_type: [u8; 4],
    // Version signature - "V1.0"
    pub version: [u8; 4],
    // Number of strings in localized string table
    pub language_count: u32,
    // Total size in bytes of localized string table
    pub localized_string_size: u32,
    // Number of files packed into ERF
    pub entry_count: u32,
    // Offset from start of file to localized string table
    pub offset_to_localized_string: u32,
    // Offset from start of file to key list
    pub offset_to_key_list: u32,
    // Offset from start of file to resource list
    pub offset_to_resource_list: u32,
    // Build year (since 1900)
    pub build_year: u32,
    // Build day (since January 1st)
    pub build_day: u32,
    // Description string reference
    pub description_strref: u32,
    // Reserved bytes - store as Vec to avoid serialization issues
    pub reserved: Vec<u8>,
}

impl Default for ErfHeader {
    fn default() -> Self {
        Self {
            file_type: [0; 4],
            version: [0; 4],
            language_count: 0,
            localized_string_size: 0,
            entry_count: 0,
            offset_to_localized_string: 0,
            offset_to_key_list: 0,
            offset_to_resource_list: 0,
            build_year: 0,
            build_day: 0,
            description_strref: 0,
            reserved: vec![0; BYTECOUNT],
        }
    }
}

pub trait ErfHeaderReader {
    fn read_from_file<R: Read>(reader: &mut R) -> io::Result<Self>
    where
        Self: Sized;
}


impl ErfHeaderReader for ErfHeader {
    fn read_from_file<R: Read>(reader: &mut R) -> io::Result<Self> {
        let mut file_type = [0; 4];
        let mut version = [0; 4];
        let mut language_count = [0; 4];
        let mut localized_string_size = [0; 4];
        let mut entry_count = [0; 4];
        let mut offset_to_localized_string = [0; 4];
        let mut offset_to_key_list = [0; 4];
        let mut offset_to_resource_list = [0; 4];
        let mut build_year = [0; 4];
        let mut build_day = [0; 4];
        let mut description_strref = [0; 4];
        let mut reserved = vec![0; BYTECOUNT];

        reader.read_exact(&mut file_type)?;
        reader.read_exact(&mut version)?;
        reader.read_exact(&mut language_count)?;
        reader.read_exact(&mut localized_string_size)?;
        reader.read_exact(&mut entry_count)?;
        reader.read_exact(&mut offset_to_localized_string)?;
        reader.read_exact(&mut offset_to_key_list)?;
        reader.read_exact(&mut offset_to_resource_list)?;
        reader.read_exact(&mut build_year)?;
        reader.read_exact(&mut build_day)?;
        reader.read_exact(&mut description_strref)?;
        reader.read_exact(&mut reserved)?;

        Ok(Self {
            file_type,
            version,
            language_count: u32::from_le_bytes(language_count),
            localized_string_size: u32::from_le_bytes(localized_string_size),
            entry_count: u32::from_le_bytes(entry_count),
            offset_to_localized_string: u32::from_le_bytes(offset_to_localized_string),
            offset_to_key_list: u32::from_le_bytes(offset_to_key_list),
            offset_to_resource_list: u32::from_le_bytes(offset_to_resource_list),
            build_year: u32::from_le_bytes(build_year),
            build_day: u32::from_le_bytes(build_day),
            description_strref: u32::from_le_bytes(description_strref),
            reserved,
        })
    }
}
#[derive(Debug, Clone, Copy)]
pub enum LanguageId {
    English = 0,
    French = 1,
    German = 2,
    Italian = 3,
    Spanish = 4,
    Polish = 5,
    Korean = 128,
    ChineseTraditional = 129,
    ChineseSimplified = 130,
    Japanese = 131,
}

impl From<u32> for LanguageId {
    fn from(value: u32) -> Self {
        match value {
            0 => LanguageId::English,
            1 => LanguageId::French,
            2 => LanguageId::German,
            3 => LanguageId::Italian,
            4 => LanguageId::Spanish,
            5 => LanguageId::Polish,
            128 => LanguageId::Korean,
            129 => LanguageId::ChineseTraditional,
            130 => LanguageId::ChineseSimplified,
            131 => LanguageId::Japanese,
            _ => LanguageId::English, // Default to English for unknown values
        }
    }
}

impl From<LanguageId> for u32 {
    fn from(language: LanguageId) -> Self {
        language as u32
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfLocalizedString {
    // Language ID (0=English, 1=French, 2=German, 3=Italian, 4=Spanish)
    pub language_id: u32,
    // Size of the string in bytes
    pub string_size: u32,
    // The actual string content
    pub string: String,
}

impl ErfLocalizedString {
    pub fn new() -> Self {
        Self {
            language_id: 0,
            string_size: 0,
            string: String::new(),
        }
    }

    fn read_from_file<R: Read>(reader: &mut R) -> io::Result<Self> {
        let mut language_id = [0; 4];
        let mut string_size = [0; 4];

        reader.read_exact(&mut language_id)?;
        reader.read_exact(&mut string_size)?;

        let string_size = u32::from_le_bytes(string_size);
        let mut string_bytes = vec![0u8; string_size as usize];
        reader.read_exact(&mut string_bytes)?;

        Ok(Self {
            language_id: u32::from_le_bytes(language_id),
            string_size,
            string: String::from_utf8_lossy(&string_bytes).into_owned(),
        })
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfLocalizedStringTable {
    // Total size of the string table in bytes
    pub table_size: u32,
    // Vector of localized strings
    pub strings: Vec<ErfLocalizedString>,
}

impl ErfLocalizedStringTable {
    pub fn new() -> Self {
        Self {
            table_size: 0,
            strings: Vec::new(),
        }
    }
}
#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfKeyEntry {
    // ResRef: Filename (16 bytes, alphanumeric/underscore, lowercase, null-padded)
    pub filename: [u8; 16],
    // Resource ID (32-bit, auto-incrementing from 0)
    pub resource_id: u32,
    // Resource Type (16-bit, determines file extension)
    pub resource_type: u16,
    // Unused padding (16-bit)
    pub unused: u16,
}

impl ErfKeyEntry {
    pub fn new() -> Self {
        Self {
            filename: [0; 16],
            resource_id: 0,
            resource_type: 0,
            unused: 0,
        }
    }

    pub fn get_filename_string(&self) -> String {
        let null_pos = self.filename.iter().position(|&x| x == 0).unwrap_or(16);
        String::from_utf8_lossy(&self.filename[0..null_pos]).to_string()
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfKeyTable {
    pub entries: Vec<ErfKeyEntry>,
}

impl ErfKeyTable {
    pub fn new() -> Self {
        Self {
            entries: Vec::new(),
        }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfResourceEntry {
    // Offset to file data from beginning of ERF (32-bit)
    pub offset_to_resource: u32,
    // Number of bytes of file data (32-bit)
    pub resource_size: u32,
}

impl ErfResourceEntry {
    pub fn new() -> Self {
        Self {
            offset_to_resource: 0,
            resource_size: 0,
        }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfResourceTable {
    pub entries: Vec<ErfResourceEntry>,
}

impl ErfResourceTable {
    pub fn new() -> Self {
        Self {
            entries: Vec::new(),
        }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ErfResourceData {
    pub data: Vec<u8>,
}

impl ErfResourceData {
    pub fn new() -> Self {
        Self { data: Vec::new() }
    }

    pub fn get_resource_data(&self, entry: &ErfResourceEntry) -> Vec<u8> {
        let start = entry.offset_to_resource as usize;
        let end = start + entry.resource_size as usize;
        self.data[start..end].to_vec()
    }
}











// match ErfFile::read_from_file(erf_path) {
//     Ok(erf) => {
//         println!("Successfully loaded ERF file");
//         println!("Number of resources: {}", erf.header.entry_count);
//         println!("Number of languages: {}", erf.header.language_count);
//         // println!("Resource data: {:?}", erf);
//         // println!("Resource data: {:?}", erf.resource_list.entries);
//         // println!("Resource data: {:?}", erf.resource_list.entries[0].offset_to_resource);
//         // println!("Resource data: {:?}", erf.resource_list.entries[0].resource_size);
//     },
//     Err(e) => println!("Error loading ERF file: {}", e),
// }