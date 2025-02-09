use std::collections::HashMap;
use std::io::Cursor;
use std::sync::Mutex;
use byteorder::{LittleEndian, ReadBytesExt};
use serde::{Serialize, Deserialize};
use image::{ImageBuffer, Rgba};


use crate::domain::odyssey_api::txi;
use crate::domain::odyssey_api::txi::{TXIInput, TXI};

const TPC_HEADER_LENGTH: usize = 128;

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TPCOptions {
    pub file: Option<Vec<u8>>,
    pub filename: Option<String>,
    pub pack: Option<u32>,// possibly irrelevant
}

#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub struct TPCHeader {
    pub data_size: u32,
    pub alpha_test: f32,
    pub width: u16,
    pub height: u16,
    pub encoding: TPCEncoding,
    pub mip_map_count: u8,
    pub bytes_per_pixel: u8,
    pub bits_per_pixel: u8,
    pub min_data_size: u32,
    pub compressed: bool,
    pub has_alpha: bool,
    pub format: PixelFormat,
    pub is_cubemap: bool,
    pub faces: u8,
}

#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub enum TPCEncoding {
    GRAY = 1,
    RGB = 2,
    RGBA = 4,
    BGRA = 12,
}

#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub enum TPCCompression {
    None = 0,
    DXT1 = 1,
    DXT3 = 2,
    DXT5 = 3,
}

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct OdysseyCompressedTexture {
    pub width: u32,
    pub height: u32,
    pub mipmaps: Vec<ImageData>,
    pub flip_y: bool,
    pub generate_mipmaps: bool,
}

#[derive(Debug, Copy, Clone, Serialize, Deserialize)]
pub enum PixelFormat {
    R8G8B8 = 1,
    B8G8R8 = 2,
    R8G8B8A8 = 3,
    B8G8R8A8 = 4,
    A1R5G5B5 = 5,
    R5G6B5 = 6,
    Depth16 = 7,
    DXT1 = 8,
    DXT3 = 9,
    DXT5 = 10,
}


/// Represents a TPC (Texture Package Container) file containing texture data.
///
/// The `TPC` structure is designed to handle texture file data, including metadata, pixel data,
/// and TXI (Texture Extended Information). It provides methods to extract and manipulate
/// TPC texture information and operations used in rendering pipelines.
///
/// # Fields
/// - `header`:
///     A [`TPCHeader`] struct that contains metadata information about the TPC file such as width, height, encoding, mipmaps, and more.
/// - `txi`:
///     A [`TXI`] struct that stores extended texture information extracted from the file.
/// - `file`:
///     Raw binary data of the TPC file.
/// - `filename`:
///     Name of the TPC file.
/// - `pack`:
///     Additional metadata, possibly irrelevant to the core TPC functionality.
/// - `canvas`:
///     A thread-safe [`Mutex`] wrapping a [`HashMap<usize, Vec<u8>>`] used to store processed or manipulated texture data in memory.
///
/// # Usage
///
/// To create a new `TPC` instance, use the `new` method with the [`TPCOptions`] struct, providing relevant optional fields.
///
///
/// let options = TPCOptions {
///     file: Some(vec![/* TPC file data as bytes */]),
///     filename: Some(String::from("example.tpc")),
///     pack: Some(123),
/// };
/// let tpc = TPC::new(options);
///
///
/// # Methods
///
/// ## `TPC::new`
///
/// Creates a new `TPC` instance by reading the TPC header, extracting TXI data, and initializing internal fields.
///
/// ## `TPC::read_header`
///
/// Reads the metadata header from the given TPC file and produces a [`TPCHeader`] struct with extracted information.
///
/// ## `TPC::get_txi_data`
///
/// Extracts the TXI data as a string from the TPC file, using offsets and lengths calculated based on the header.
///
/// ## `TPC::get_data_length`
///
/// Calculates the total data length of the TPC file, factoring in compression, mipmaps, and cubemap faces.
///
/// ## `TPC::flip_y`
///
/// Flips the provided pixel data vertically, commonly used for rendering operations where the texture's Y-axis orientation must be adjusted.
///
/// # Examples
///
///
/// let options = TPCOptions {
///     file: Some(vec![/* binary data */]),
///     filename: Some(String::from("sample_texture.tpc")),
///     pack: None,
/// };
/// let texture = TPC::new(options);
///
/// let header = texture.header;
/// println!("Width: {}, Height: {}", header.width, header.height);
///
/// let flipped_data = TPC::flip_y(vec![/* pixel data */], &header);
/// println!("Flipped pixel data: {:?}", flipped_data);
///
#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TPC {
    pub header: TPCHeader,
    pub txi: TXI,
    pub file: Vec<u8>,
    pub filename: String,
    pub pack: u32
}


impl TPC {
    pub fn new(args: TPCOptions) -> TPC {
        let default = TPCOptions {
            file: None,
            filename: None,
            pack: None,
        };

        let file = args.file.unwrap_or(default.file.unwrap_or_else(Vec::new));
        let filename = args.filename.unwrap_or(default.filename.unwrap_or_else(String::new));
        let pack = args.pack.unwrap_or(default.pack.unwrap_or(0));
        let header = TPC::read_header(&file).unwrap();
        let txi = match TPC::get_txi_data(&file, &header) {
            Ok(txi_data) => TXI::create_from_options(TXIInput::from(txi_data)),
            Err(_) => TXI::create_from_options(TXIInput::String(String::new())),
        };

        TPC {
            header,
            txi,
            file,
            filename,
            pack
        }
    }


    pub fn to_dds(&self) -> Result<Vec<u8>, &'static str> {
        // Create DDS header
        let mut dds_header = vec![
            0x44, 0x44, 0x53, 0x20, // "DDS " magic number
            124, 0, 0, 0,  // dwSize = 124 bytes
        ];

        let mut flags = 0x1007; // DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT
        if self.header.mip_map_count > 1 {
            flags |= 0x20000; // DDSD_MIPMAPCOUNT
        }
        if self.header.compressed {
            flags |= 0x80000; // DDSD_LINEARSIZE
        } else {
            flags |= 0x8; // DDSD_PITCH
        }
        // Add flags
        dds_header.extend_from_slice(&(flags as u32).to_le_bytes());
        
        // Add height, width
        dds_header.extend_from_slice(&(self.header.height as u32).to_le_bytes());
        dds_header.extend_from_slice(&(self.header.width as u32).to_le_bytes());

        // Add pitch/linear size
        let pitch_or_linear_size = if self.header.compressed {
            match self.header.encoding {
                TPCEncoding::RGB => ((self.header.width as u32 * self.header.height as u32) / 2) as u32,
                TPCEncoding::RGBA => ((self.header.width as u32 * self.header.height as u32) / 4) as u32,
                _ => return Err("Invalid encoding for compressed texture")
            }
        } else {
            (self.header.width as u32 * self.header.bytes_per_pixel as u32)
        };
        dds_header.extend_from_slice(&pitch_or_linear_size.to_le_bytes());

        // Add depth (unused)
        dds_header.extend_from_slice(&0u32.to_le_bytes());

        // Add mipmap count
        dds_header.extend_from_slice(&(self.header.mip_map_count as u32).to_le_bytes());

        // Add reserved1[11]
        for _ in 0..11 {
            dds_header.extend_from_slice(&0u32.to_le_bytes());
        }

        // Add pixel format structure
        let mut pf_flags = if self.header.compressed {
            0x4 // DDPF_FOURCC
        } else {
            0x40 // DDPF_RGB
        };
        if self.header.has_alpha {
            pf_flags |= 0x1; // DDPF_ALPHAPIXELS
        }

        // Pixel format
        dds_header.extend_from_slice(&32u32.to_le_bytes()); // dwSize
        dds_header.extend_from_slice(&(pf_flags as u32).to_le_bytes()); // dwFlags

        // Add FourCC or bit masks
        if self.header.compressed {
            let fourcc = match self.header.encoding {
                TPCEncoding::RGB => 0x31545844, // "DXT1"
                TPCEncoding::RGBA => 0x35545844, // "DXT5"
                _ => return Err("Invalid encoding for compressed texture")
            };
            dds_header.extend_from_slice(&(fourcc as u32).to_le_bytes());
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwRGBBitCount
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwRBitMask
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwGBitMask
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwBBitMask
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwABitMask
        } else {
            dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwFourCC
            dds_header.extend_from_slice(&(self.header.bits_per_pixel as u32).to_le_bytes());
            dds_header.extend_from_slice(&0x00ff0000u32.to_le_bytes()); // dwRBitMask
            dds_header.extend_from_slice(&0x0000ff00u32.to_le_bytes()); // dwGBitMask
            dds_header.extend_from_slice(&0x000000ffu32.to_le_bytes()); // dwBBitMask
            dds_header.extend_from_slice(&0xff000000u32.to_le_bytes()); // dwABitMask
        }

        // Add caps
        let mut caps = 0x1000; // DDSCAPS_TEXTURE
        if self.header.mip_map_count > 1 {
            caps |= 0x400008u32; // DDSCAPS_COMPLEX | DDSCAPS_MIPMAP
        }
        dds_header.extend_from_slice(&(caps as u32).to_le_bytes());

        // Add caps2 (cubemap flags if needed)
        let caps2 = if self.header.is_cubemap { 0xFE00u32 } else { 0u32 };
        dds_header.extend_from_slice(&caps2.to_le_bytes());

        // Add remaining header fields
        dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwCaps3
        dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwCaps4
        dds_header.extend_from_slice(&0u32.to_le_bytes()); // dwReserved2

        // Combine header with image data
        let data_start = TPC_HEADER_LENGTH;
        let data_end = data_start + TPC::get_data_length(&self.header);
        
        if data_end > self.file.len() {
            return Err("File data is shorter than expected");
        }

        let mut dds_file = dds_header;
        dds_file.extend_from_slice(&self.file[data_start..data_end]);

        Ok(dds_file)
    }


    

    pub fn get_txi_data(file: &Vec<u8>, header: &TPCHeader) -> Result<String, String> {
        let data_length = TPC::get_data_length(&header);
        let txi_offset = data_length.checked_add(TPC_HEADER_LENGTH)
            .ok_or_else(|| "Arithmetic overflow calculating TXI offset".to_string())?;

        if txi_offset > file.len() {
            return Err("TXI offset is beyond file length".to_string());
        }

        let txi_data_length = file.len().checked_sub(txi_offset as usize)
            .ok_or_else(|| "Arithmetic overflow calculating TXI data length".to_string())?;

        if txi_data_length == 0 {
            return Ok(String::new());
        }

        let txi_end = txi_offset.checked_add(txi_data_length)
            .ok_or_else(|| "Arithmetic overflow calculating TXI end offset".to_string())?;

        if txi_end > file.len() {
            return Err("TXI data extends beyond file length".to_string());
        }

        let txi_data = &file[txi_offset..txi_end];
        Ok(String::from_utf8(txi_data.to_vec())
            .map_err(|e| format!("Invalid UTF-8 in TXI data: {}", e))?)
    }




    

    pub fn read_header(buffer: &[u8]) -> Result<TPCHeader, &'static str> {
        let mut cursor = Cursor::new(&buffer[..]);
        let mut header = TPCHeader {
            data_size: cursor.read_u32::<LittleEndian>().map_err(|_| "Failed to read data size")?,
            alpha_test: cursor.read_f32::<LittleEndian>().map_err(|_| "Failed to read alpha test")?,
            width: cursor.read_u16::<LittleEndian>().map_err(|_| "Failed to read width")?,
            height: cursor.read_u16::<LittleEndian>().map_err(|_| "Failed to read height")?,
            encoding: {
                let encoding_byte = cursor.read_u8().map_err(|_| "Failed to read encoding byte")?;
                match encoding_byte {
                    0 => TPCEncoding::GRAY,
                    1 => TPCEncoding::RGB,
                    2 => TPCEncoding::RGBA,
                    3 => TPCEncoding::BGRA,
                    _ => TPCEncoding::RGBA,
                }
            },
            mip_map_count: std::cmp::max(1, cursor.read_u8().map_err(|_| "Failed to read mip map count")?),
            bytes_per_pixel: 4,
            bits_per_pixel: 32, // 4 * 8
            min_data_size: 0,
            compressed: false,
            has_alpha: false,
            format: PixelFormat::R8G8B8, // Default value, will be set below
            is_cubemap: false,
            faces: 1,
        };

        if header.data_size == 0 {
            // Uncompressed
            header.compressed = false;
            match header.encoding {
                TPCEncoding::GRAY => {
                    header.has_alpha = false;
                    header.format = PixelFormat::R8G8B8;
                    header.min_data_size = 1;
                    header.data_size = (header.width as u32) * (header.height as u32);
                }
                TPCEncoding::RGB => {
                    header.has_alpha = false;
                    header.format = PixelFormat::R8G8B8;
                    header.min_data_size = 3;
                    header.data_size = (header.width as u32) * (header.height as u32) * 3;
                }
                TPCEncoding::RGBA => {
                    header.has_alpha = true;
                    header.format = PixelFormat::R8G8B8A8;
                    header.min_data_size = 4;
                    header.data_size = (header.width as u32) * (header.height as u32) * 4;
                }
                TPCEncoding::BGRA => {
                    header.has_alpha = true;
                    header.format = PixelFormat::B8G8R8A8;
                    header.min_data_size = 4;
                    header.data_size = (header.width as u32) * (header.height as u32) * 4;
                }
            }
        } else {
            match header.encoding {
                TPCEncoding::RGB => {
                    // S3TC DXT1
                    header.compressed = true;
                    header.has_alpha = false;
                    header.format = PixelFormat::DXT1;
                    header.min_data_size = 8;
                }
                TPCEncoding::RGBA => {
                    // S3TC DXT5
                    header.compressed = true;
                    header.has_alpha = true;
                    header.format = PixelFormat::DXT5;
                    header.min_data_size = 16;
                }
                _ => return Err("Invalid encoding for compressed texture"),
            }
        }

        // Check for cubemap
        if (header.height as f32 / header.width as f32) == 6.0 {
            header.is_cubemap = true;
            header.height = header.width;
        }

        header.faces = if header.is_cubemap { 6 } else { 1 };

        Ok(header)
    }

    pub fn get_data_length(header: &TPCHeader) -> usize {
        let mut data_length = 0;

        for _face in 0..header.faces {
            let mut width = header.width as usize;
            let mut height = header.height as usize;
            let mut data_size = header.data_size as usize;

            for _mip in 0..header.mip_map_count {
                if !header.compressed {
                    data_length += width * height * header.bytes_per_pixel as usize;
                } else {
                    data_length += data_size;
                }

                width = std::cmp::max(width >> 1, 1);
                height = std::cmp::max(height >> 1, 1);
                data_size = std::cmp::max(data_size >> 2, header.min_data_size as usize);
            }
        }

        data_length
    }

    pub fn flip_y(pixel_data: Vec<u8>, header: &TPCHeader) -> Vec<u8> {
        let stride = (header.width as usize) * 4;
        let mut flipped_data = vec![0; pixel_data.len()];

        for (n, row) in pixel_data.chunks(stride).enumerate() {
            let y_offset = (pixel_data.len() - ((n + 1) * stride)) as usize;
            flipped_data[y_offset..y_offset + stride].copy_from_slice(row);
        }

        flipped_data
    }
}





#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct ImageData {
    pub data: Vec<u8>,
    pub width: u32,
    pub height: u32,
}





#[cfg(test)]
mod tests {
        use super::*;
        use std::sync::Mutex;

        /// Creates a dummy TPCHeader for testing.
        fn create_dummy_header() -> TPCHeader {
        TPCHeader {
            data_size: 128,
            alpha_test: 0.5,
            width: 256,
            height: 128,
            encoding: TPCEncoding::RGBA,
            mip_map_count: 4,
            bytes_per_pixel: 4,
            bits_per_pixel: 32,
            min_data_size: 1024,
            compressed: false,
            has_alpha: true,
            format: PixelFormat::R8G8B8A8,
            is_cubemap: false,
            faces: 1,
        }
    }

    /// Creates a dummy TPC file with fake data for testing.
    fn create_dummy_tpc_file() -> Vec < u8 > {
        let mut file: Vec < u8 > = Vec::new();

        // Adding fake header data.
        file.extend( &[0, 0]); // Reserved bytes
        file.extend( & (256 as u16).to_le_bytes()); // Width
        file.extend( & (128 as u16).to_le_bytes()); // Height
        file.push(4); // Encoding (RGBA)
        file.push(3); // Mipmap count
        file.resize(64, 0); // Fill remaining header bytes

        // Adding fake data.
        file.resize(64 + 128, 255); // Simulating texture data size
        file.extend("Dummy TXI Data".as_bytes()); // Adding fake TXI data

        file
    }

    # [test]
    fn test_new() {
        let file = create_dummy_tpc_file();
        let options = TPCOptions {
            file: Some(file.clone()),
            filename: Some("test_texture.tpc".to_string()),
            pack: Some(42),
        };

        let tpc = TPC::new(options);

        assert_eq ! (tpc.filename, "test_texture.tpc");
        assert_eq ! (tpc.pack, 42);
        assert_eq ! (tpc.file, file);
    }

    # [test]
    fn test_get_txi_data() {
        let file = create_dummy_tpc_file();
        let header = TPC::read_header( & file);

        let txi_data = TPC::get_txi_data( & file, & header);

        assert_eq ! (txi_data, "Dummy TXI Data");
    }

    # [test]
    fn test_read_header() {
        let file = create_dummy_tpc_file();
        let header = TPC::read_header( & file);

        assert_eq !(header.width, 256);
        assert_eq !(header.height, 128);
       // assert_eq !(header.encoding, TPCEncoding::RGBA);
        assert_eq ! (header.mip_map_count, 3);
    }

    # [test]
    fn test_get_data_length() {
        let header = create_dummy_header();
        let data_length = TPC::get_data_length( & header);

        let expected_length = (header.width * header.height * header.bytes_per_pixel as u16) as usize;
        assert! (data_length >= expected_length); // The data length should be accurate
    }

    # [test]
    fn test_flip_y() {
        let original_data: Vec < u8 > = vec ![
            1, 2, 3, 4, 5, 6, 7, 8,
            9, 10, 11, 12, 13, 14, 15, 16
        ];
        let flipped_data = TPC::flip_y(original_data.clone(), & create_dummy_header());

        assert_eq ! (flipped_data.len(), original_data.len());
    }
}