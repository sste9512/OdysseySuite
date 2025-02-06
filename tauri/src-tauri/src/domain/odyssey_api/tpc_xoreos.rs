use std::io::{Read, Seek, SeekFrom};
use std::mem;

use crate::common::error::Error;
use crate::common::readstream::ReadStream;
use crate::images::{Decoder, MipMap, PixelFormat};

const ENCODING_GRAY: u8 = 0x01;
const ENCODING_RGB: u8 = 0x02;
const ENCODING_RGBA: u8 = 0x04;
const ENCODING_SWIZZLED_BGRA: u8 = 0x0C;

pub struct TPC {
    mip_maps: Vec<MipMap>,
    format: PixelFormat,
    txi_data: Option<Vec<u8>>,
    txi_data_size: usize,
    is_animated: bool,
    layer_count: u32,
    is_cube_map: bool,
}

impl TPC {
    pub fn new<S: Read + Seek>(tpc: &mut S) -> Result<Self, Error> {
        let mut decoder = TPC {
            mip_maps: Vec::new(),
            format: PixelFormat::BGR8,
            txi_data: None,
            txi_data_size: 0,
            is_animated: false,
            layer_count: 1,
            is_cube_map: false,
        };
        
        decoder.load(tpc)?;
        decoder.decompress()?;
        Ok(decoder)
    }

    fn load<S: Read + Seek>(&mut self, tpc: &mut S) -> Result<(), Error> {
        let encoding = self.read_header(tpc)?;
        self.read_data(tpc, encoding)?;
        self.fixup_cube_map()?;
        Ok(())
    }

    pub fn get_txi(&self) -> Option<&[u8]> {
        self.txi_data.as_deref()
    }

    fn read_header<S: Read + Seek>(&mut self, tpc: &mut S) -> Result<u8, Error> {
        // Number of bytes for the pixel data in one full image
        let data_size = tpc.read_u32::<LittleEndian>()?;
        let is_uncompressed = data_size == 0;

        // Skip float
        tpc.seek(SeekFrom::Current(4))?;

        // Image dimensions
        let width = tpc.read_u16::<LittleEndian>()?;
        let height = tpc.read_u16::<LittleEndian>()?;

        if width >= 0x8000 || height >= 0x8000 {
            return Err(Error::new(&format!(
                "Unsupported image dimensions ({}x{})",
                width, height
            )));
        }

        // How's the pixel data encoded?
        let encoding = tpc.read_u8()?;

        // Number of mip maps in the image
        let mip_map_count = tpc.read_u8()? as usize;

        // Calculate data size if uncompressed
        let data_size = if is_uncompressed {
            match encoding {
                ENCODING_GRAY => width as u32 * height as u32,
                ENCODING_RGB => width as u32 * height as u32 * 3,
                ENCODING_RGBA | ENCODING_SWIZZLED_BGRA => width as u32 * height as u32 * 4,
                _ => return Err(Error::new("Invalid encoding for uncompressed image")),
            }
        } else {
            self.check_cube_map(width as u32, height as u32)?;
            data_size
        };

        let min_data_size = self.get_min_data_size(is_uncompressed, encoding)?;
        self.format = self.get_pixel_format(is_uncompressed, encoding)?;

        // Calculate complete data size for mipmaps
        let mut complete_data_size = data_size;
        let mut w = width as u32;
        let mut h = height as u32;
        
        for _ in 1..mip_map_count {
            w = (w >> 1).max(1);
            h = (h >> 1).max(1);
            complete_data_size += self.get_data_size(self.format, w, h)?;
        }

        complete_data_size *= self.layer_count;

        // Skip reserved section and data
        tpc.seek(SeekFrom::Current(114))?;
        tpc.seek(SeekFrom::Current(complete_data_size as i64))?;
        
        self.read_txi_data(tpc)?;

        self.is_animated = self.check_animated(width as u32, height as u32, data_size)?;

        // Validate data size for compressed formats
        if !is_uncompressed {
            match encoding {
                ENCODING_RGB => {
                    // S3TC DXT1
                    if data_size != ((width as u32 * height as u32) / 2) && !self.is_animated {
                        return Err(Error::new(&format!(
                            "Invalid data size for {}x{} texture with format {}",
                            width, height, encoding
                        )));
                    }
                }
                ENCODING_RGBA => {
                    // S3TC DXT5
                    if data_size != (width as u32 * height as u32) && !self.is_animated {
                        return Err(Error::new(&format!(
                            "Invalid data size for {}x{} texture with format {}",
                            width, height, encoding
                        )));
                    }
                }
                _ => return Err(Error::new(&format!("Unknown TPC encoding: {}", encoding))),
            }
        }

        tpc.seek(SeekFrom::Start(128))?;

        // Validate dimensions
        if !self.has_valid_dimensions(self.format, width as u32, height as u32) {
            return Err(Error::new(&format!(
                "Invalid dimensions ({}x{}) for format {:?}",
                width, height, self.format
            )));
        }

        Ok(encoding)
    }

    // More implementation to follow...
}