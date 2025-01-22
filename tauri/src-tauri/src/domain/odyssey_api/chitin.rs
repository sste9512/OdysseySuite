use byteorder::{LittleEndian, ReadBytesExt};
use serde::{Deserialize, Serialize};
use std::io::{self, Read};

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct ChitinKey {
    pub header: KeyHeader,
    pub file_entries: Vec<FileEntry>,
    pub filenames: Vec<String>,
    pub key_entries: Vec<KeyEntry>,
}

pub trait ChitinKeyReader {
    fn read_chitin_key<R: Read>(reader: &mut R) -> io::Result<ChitinKey>;
    fn read_key_header<R: Read>(reader: &mut R) -> io::Result<KeyHeader>;
    fn read_file_entries<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<FileEntry>>;
    fn read_filenames<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<String>>;
    fn read_key_entries<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<KeyEntry>>;
}

impl ChitinKeyReader for ChitinKey {
    /// Reads a complete ChitinKey structure from the provided reader.
    ///
    /// This function reads all components of a ChitinKey in sequence:
    /// 1. The key header containing file metadata
    /// 2. The file entries table
    /// 3. The filenames table
    /// 4. The key entries table
    ///
    /// # Arguments
    /// * `reader` - Any type that implements Read trait to read bytes from
    ///
    /// # Returns
    /// * `io::Result<ChitinKey>` - The parsed ChitinKey structure or an IO error
    fn read_chitin_key<R: Read>(reader: &mut R) -> io::Result<ChitinKey> {
        let header = Self::read_key_header(reader)?;
        let file_entries = Self::read_file_entries(reader, header.bif_count)?;
        let filenames = Self::read_filenames(reader, header.bif_count)?;
        let key_entries = Self::read_key_entries(reader, header.key_count)?;

        Ok(ChitinKey {
            header,
            file_entries,
            filenames,
            key_entries,
        })
    }

    fn read_key_header<R: Read>(reader: &mut R) -> io::Result<KeyHeader> {
        let mut header = KeyHeader::new();
        let mut file_type_buf = [0u8; 4];

        reader.read_exact(&mut file_type_buf)?;
        header.file_type = file_type_buf.map(|b| b as char);

        let mut file_version_buf = [0u8; 4];
        reader.read_exact(&mut file_version_buf)?;
        for (i, &byte) in file_version_buf.iter().enumerate() {
            header.file_version[i] = byte as char;
        }

        header.bif_count = reader.read_u32::<LittleEndian>()?;
        header.key_count = reader.read_u32::<LittleEndian>()?;
        header.offset_to_file_table = reader.read_u32::<LittleEndian>()?;
        header.offset_to_key_table = reader.read_u32::<LittleEndian>()?;
        header.build_year = reader.read_u32::<LittleEndian>()?;
        header.build_day = reader.read_u32::<LittleEndian>()?;
        reader.read_exact(&mut header.reserved)?;
        Ok(header)
    }

    fn read_file_entries<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<FileEntry>> {
        let mut entries = Vec::with_capacity(count as usize);
        for _ in 0..count {
            let mut entry = FileEntry::new();
            entry.file_size = reader.read_u32::<LittleEndian>()?;
            entry.filename_offset = reader.read_u32::<LittleEndian>()?;
            entry.filename_size = reader.read_u16::<LittleEndian>()?;
            entry.drives = reader.read_u16::<LittleEndian>()?;
            entries.push(entry);
        }
        Ok(entries)
    }

    fn read_filenames<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<String>> {
        let mut names = Vec::with_capacity(count as usize);
        for _ in 0..count {
            let mut name = String::new();
            reader.read_u32::<LittleEndian>()?;
            names.push(name);
        }
        Ok(names)
    }

    fn read_key_entries<R: Read>(reader: &mut R, count: u32) -> io::Result<Vec<KeyEntry>> {
        let mut entries = Vec::with_capacity(count as usize);
        for _ in 0..count {
            let mut entry = KeyEntry::new();
            let mut resref_buf = [0u8; 16];
            reader.read_exact(&mut resref_buf)?;
            // TODO: Fix this to read entirety of string
            // Resource: aps10.bifdata\l (Type: 26473, ID: 1634563176)
            // Resource: ps11.bifdata\li (Type: 26727, ID: 1885433204)
            // Resource: s12.bifdata\lig (Type: 29800, ID: 1936744813)
            // Resource: 13.bifdata\ligh (Type: 28020, ID: 846426209)
            // Resource: .bifdata\lightm (Type: 28769, ID: 1647194995)
            // Resource: ifdata\lightmap (Type: 13427, ID: 1718182446)
            // Resource: data\lightmaps5 (Type: 25134, ID: 1677747817)
            // Resource: ata\lightmaps6.b (Type: 26217, ID: 1952539648)
            // Resource: a\lightmaps7.bif (Type: 25600, ID: 1549890657)
            // Resource: lightmaps8.bifd (Type: 29793, ID: 1768709217)
            // Resource: ghtmaps9.bifdat (Type: 23649, ID: 1701080941) --> Currently getting shortened strings
            entry.resref = resref_buf.map(|b| b as char);
            entry.resource_type = reader.read_u16::<LittleEndian>()?;
            entry.res_id = reader.read_u32::<LittleEndian>()?;
            entries.push(entry);
        }
        Ok(entries)
    }
}

#[derive(Debug, Serialize, Deserialize)]
pub enum ResourceType {
    Invalid = 0xFFFF,
    Bmp = 1,
    Tga = 3,
    Wav = 4,
    Plt = 6,
    Ini = 7,
    Text = 10,
    Mdl = 2002,
    Nss = 2009,
    Ncs = 2010,
    Are = 2012,
    Set = 2013,
    Ifo = 2014,
    Bic = 2015,
    Wok = 2016,
    TwoDA = 2017,
    Txi = 2022,
    Git = 2023,
    Uti = 2025,
    Utc = 2027,
    Dlg = 2029,
    Itp = 2030,
    Utt = 2032,
    Dds = 2033,
    Uts = 2035,
    Ltr = 2036,
    Gff = 2037,
    Fac = 2038,
    Ute = 2040,
    Utd = 2042,
    Utp = 2044,
    Dft = 2045,
    Gic = 2046,
    Gui = 2047,
    Utm = 2051,
    Dwk = 2052,
    Pwk = 2053,
    Jrl = 2056,
    Utw = 2058,
    Ssf = 2060,
    Ndb = 2064,
    Ptm = 2065,
    Ptt = 2066,
}

#[derive(Debug, Serialize, Deserialize)]
pub enum ContentType {
    Binary,
    Text,
    TextIni,
    Gff,
    Mdl,
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct KeyHeader {
    pub file_type: [char; 4],
    pub file_version: [char; 4],
    pub bif_count: u32,
    pub key_count: u32,
    pub offset_to_file_table: u32,
    pub offset_to_key_table: u32,
    pub build_year: u32,
    pub build_day: u32,
    pub reserved: [u8; 32],
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct FileEntry {
    pub file_size: u32,
    pub filename_offset: u32,
    pub filename_size: u16,
    pub drives: u16,
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct FilenameEntry {
    pub filename: String,
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct KeyEntry {
    pub resref: [char; 16],
    pub resource_type: u16,
    pub res_id: u32,
}

impl KeyEntry {
    pub fn new() -> Self {
        Self {
            resref: ['\0'; 16],
            resource_type: 0,
            res_id: 0,
        }
    }

    pub fn get_bif_index(&self) -> u32 {
        self.res_id >> 20
    }

    pub fn get_resource_index(&self) -> u32 {
        self.res_id & 0xFFFFF // Bottom 20 bits
    }
}

impl FilenameEntry {
    pub fn new(filename: String) -> Self {
        Self { filename }
    }
}

impl FileEntry {
    pub fn new() -> Self {
        Self {
            file_size: 0,
            filename_offset: 0,
            filename_size: 0,
            drives: 0,
        }
    }
}

impl KeyHeader {
    pub fn new() -> Self {
        Self {
            file_type: ['\0'; 4],
            file_version: ['\0'; 4],
            bif_count: 0,
            key_count: 0,
            offset_to_file_table: 0,
            offset_to_key_table: 0,
            build_year: 0,
            build_day: 0,
            reserved: [0; 32],
        }
    }
}
