use byteorder::{LittleEndian, ReadBytesExt};
use serde::{Deserialize, Serialize};
use std::convert::TryInto;
use std::fs::File;
use std::io::{self, Read, Seek, SeekFrom};

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct BiffHeader {
    pub file_type: [char; 4],
    pub file_version: [char; 4],
    pub variable_resource_count: u32,
    pub fixed_resource_count: u32,
    pub variable_table_offset: u32,
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct VResourceEntry {
    pub id: u32,
    pub offset: u32,
    pub file_size: u32,
    pub resource_type: u32,
}

impl BiffHeader {
    pub fn new() -> Self {
        Self {
            file_type: ['\0'; 4],
            file_version: ['\0'; 4],
            variable_resource_count: 0,
            fixed_resource_count: 0,
            variable_table_offset: 0,
        }
    }
}

impl VResourceEntry {
    pub fn new() -> Self {
        Self {
            id: 0,
            offset: 0,
            file_size: 0,
            resource_type: 0,
        }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct FResourceEntry {
    pub id: u32,
    pub offset: u32,
    pub part_count: u32,
    pub file_size: u32,
    pub resource_type: u32,
}

impl FResourceEntry {
    pub fn new() -> Self {
        Self {
            id: 0,
            offset: 0,
            part_count: 0,
            file_size: 0,
            resource_type: 0,
        }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct VariableResourceData {
    pub data: Vec<u8>,
}

impl VariableResourceData {
    pub fn new() -> Self {
        Self { data: Vec::new() }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct FixedResourceData {
    pub data: Vec<u8>,
}

impl FixedResourceData {
    pub fn new() -> Self {
        Self { data: Vec::new() }
    }
}

#[derive(Debug, Default, Serialize, Deserialize)]
pub struct Biff {
    pub header: BiffHeader,
    pub variable_resources: Vec<VResourceEntry>,
    pub fixed_resources: Vec<FResourceEntry>,
    pub variable_resource_data: Vec<VariableResourceData>,
    pub fixed_resource_data: Vec<FixedResourceData>,
}

///  **`header: BiffHeader`**:
/// - Contains the basic metadata about the BIFF file format, such as the type of file, version,
///   count of variable and fixed resources, and the offset to resource tables.
///
///  **`variable_resources: Vec<VResourceEntry>`**:
/// - A collection of variable resource descriptors. Each entry contains an ID, offset, size,
///   and type of the resource.
///
///  **`fixed_resources: Vec<FResourceEntry>`**:
/// - A collection of fixed resource descriptors. Includes similar metadata as `VResourceEntry`
///   but may contain additional fields like `part_count`.
///
///  **`variable_resource_data: Vec<VariableResourceData>`**:
/// - A collection of variable resource data blobs. Each entry corresponds to the actual binary
///   data for a variable resource.
///
///  **`fixed_resource_data: Vec<FixedResourceData>`**:
/// - A collection of fixed resource data blobs. Each entry corresponds to the actual binary
///   data for a fixed resource.
impl Biff {
    pub fn new() -> Self {
        Self {
            header: BiffHeader::new(),
            variable_resources: Vec::new(),
            fixed_resources: Vec::new(),
            variable_resource_data: Vec::new(),
            fixed_resource_data: Vec::new(),
        }
    }

    /// Reads a BIFF file and returns a parsed Biff structure.
    pub fn read_biff_file(file_path: &str) -> io::Result<Self> {
        let mut file = File::open(file_path)?;
        let mut biff = Biff::new();

        // Read the BIFF header
        let mut header = BiffHeader::new();

        // Read file type and version as bytes first
        let mut file_type_bytes = [0u8; 4];
        let mut file_version_bytes = [0u8; 4];
        file.read_exact(&mut file_type_bytes)?;
        file.read_exact(&mut file_version_bytes)?;

        // Convert bytes to chars
        header.file_type = file_type_bytes.map(|b| b as char);
        header.file_version = file_version_bytes.map(|b| b as char);

        header.variable_resource_count = file.read_u32::<LittleEndian>()?;
        header.fixed_resource_count = file.read_u32::<LittleEndian>()?;
        header.variable_table_offset = file.read_u32::<LittleEndian>()?;

        biff.header = header;

        // Pre-allocate vectors with known sizes to avoid reallocations
        biff.variable_resources
            .reserve_exact(biff.header.variable_resource_count as usize);
        biff.variable_resource_data
            .reserve_exact(biff.header.variable_resource_count as usize);
        biff.fixed_resources
            .reserve_exact(biff.header.fixed_resource_count as usize);
        biff.fixed_resource_data
            .reserve_exact(biff.header.fixed_resource_count as usize);

        // Seek to the variable resource table offset
        file.seek(SeekFrom::Start(biff.header.variable_table_offset.into()))?;

        // Read Variable Resource Entries
        for _ in 0..biff.header.variable_resource_count {
            let v_resource = VResourceEntry {
                id: file.read_u32::<LittleEndian>()?,
                offset: file.read_u32::<LittleEndian>()?,
                file_size: file.read_u32::<LittleEndian>()?,
                resource_type: file.read_u32::<LittleEndian>()?,
            };
            biff.variable_resources.push(v_resource);
        }

        // Read Variable Resource Data with size checks
        for v_resource in &biff.variable_resources {
            file.seek(SeekFrom::Start(v_resource.offset.into()))?;

            // Add size limit check to prevent allocation of extremely large buffers
            if v_resource.file_size > 100_000_000 {
                // 100MB limit example
                return Err(io::Error::new(
                    io::ErrorKind::InvalidData,
                    "Resource size exceeds maximum allowed",
                ));
            }

            let mut data = vec![0; v_resource.file_size as usize];
            file.read_exact(&mut data)?;
            biff.variable_resource_data
                .push(VariableResourceData { data });
        }

        // Read Fixed Resource Entries
        for _ in 0..biff.header.fixed_resource_count {
            let f_resource = FResourceEntry {
                id: file.read_u32::<LittleEndian>()?,
                offset: file.read_u32::<LittleEndian>()?,
                part_count: file.read_u32::<LittleEndian>()?,
                file_size: file.read_u32::<LittleEndian>()?,
                resource_type: file.read_u32::<LittleEndian>()?,
            };
            biff.fixed_resources.push(f_resource);
        }

        // Read Fixed Resource Data with size checks
        for f_resource in &biff.fixed_resources {
            file.seek(SeekFrom::Start(f_resource.offset.into()))?;

            // Add size limit check
            if f_resource.file_size > 100_000_000 {
                // 100MB limit example
                return Err(io::Error::new(
                    io::ErrorKind::InvalidData,
                    "Resource size exceeds maximum allowed",
                ));
            }

            let mut data = vec![0; f_resource.file_size as usize];
            file.read_exact(&mut data)?;
            biff.fixed_resource_data.push(FixedResourceData { data });
        }

        Ok(biff)
    }
}
