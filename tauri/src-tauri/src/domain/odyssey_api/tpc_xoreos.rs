use std::io::{Read, Seek, SeekFrom};
use std::mem;
use std::ops::Deref;
use byteorder::ReadBytesExt;
use serde::{Deserialize, Serialize};

use crate::domain::odyssey_api::s3tc;

use crate::domain::odyssey_api::util;
use crate::domain::odyssey_api::tpc::PixelFormat;
use crate::domain::odyssey_api::decoder::images::{Decoder, MipMap};

const ENCODING_GRAY: u8 = 0x01;
const ENCODING_RGB: u8 = 0x02;
const ENCODING_RGBA: u8 = 0x04;
const ENCODING_SWIZZLED_BGRA: u8 = 0x0C;


#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TPC {
    pub mip_maps: Vec<MipMap>,
    pub format: PixelFormat,
    pub txi_data: Option<Vec<u8>>,
    pub txi_data_size: usize,
    pub is_animated: bool,
    pub layer_count: u32,
    pub is_cube_map: bool,
}

impl TPC {
    pub fn new<S: Read + Seek>(tpc: &mut S) -> Result<Self, String> {
        let mut decoder = TPC {
            mip_maps: Vec::new(),
            format: PixelFormat::R8G8B8A8,
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

    fn load<S: Read + Seek>(&mut self, tpc: &mut S) -> Result<(), String> {
        let encoding = self.read_header(tpc)?;
        self.read_data(tpc, encoding)?;
        self.fixup_cube_map()?;
        Ok(())
    }

    pub fn get_txi(&self) -> Option<&[u8]> {
        self.txi_data.as_deref()
    }

    fn read_header<S: Read + Seek>(&mut self, tpc: &mut S) -> Result<u8, String> {
        // Step 1: Read the data size from the first 4 bytes
        // This indicates the total size of pixel data for one full image
        let mut buf = [0u8; 4];
        tpc.read_exact(&mut buf).map_err(|e| e.to_string())?;
        let data_size = u32::from_le_bytes(buf);
        let is_uncompressed = data_size == 0;

        // Step 2: Skip 4 bytes containing a float value (alpha test value)
        tpc.seek(SeekFrom::Current(4)).map_err(|e| e.to_string())?;

        // Step 3: Read image width (2 bytes)
        let mut width_bytes = [0u8; 2];
        tpc.read_exact(&mut width_bytes).map_err(|e| e.to_string())?;
        let width = u16::from_le_bytes(width_bytes);

        // Step 4: Read image height (2 bytes) 
        let mut height_bytes = [0u8; 2];
        tpc.read_exact(&mut height_bytes).map_err(|e| e.to_string())?;
        let height = u16::from_le_bytes(height_bytes);

        // Step 5: Validate image dimensions are not too large
        if width >= 0x8000 || height >= 0x8000 {
            return Err(format!(
                "Unsupported image dimensions ({}x{})",
                width, height
            ));
        }

        // Step 6: Read the pixel data encoding format (1 byte)
        let encoding = tpc.read_u8().map_err(|e| e.to_string())?;

        // Step 7: Read number of mip maps in the image (1 byte)
        let mip_map_count = tpc.read_u8().map_err(|e| e.to_string())? as usize;

        // Step 8: Calculate total data size based on encoding
        let data_size = if is_uncompressed {
            match encoding {
                ENCODING_GRAY => width as u32 * height as u32,
                ENCODING_RGB => width as u32 * height as u32 * 3,
                ENCODING_RGBA | ENCODING_SWIZZLED_BGRA => width as u32 * height as u32 * 4,
                _ => {
                    return Err(format!(
                        "Invalid encoding for uncompressed image: {}",
                        encoding
                    ))
                }
            }
        } else {
            // For compressed textures, validate dimensions and use provided size
            s3tc::check_cube_map(width as u32, height as u32)?;
            data_size
        };

        // Step 9: Get minimum data size and pixel format based on encoding
        let min_data_size = util::get_min_data_size(is_uncompressed, encoding)?;
        self.format = util::get_pixel_format(is_uncompressed, encoding)?;

        // Step 10: Calculate total data size including all mip maps
        let mut complete_data_size = data_size;
        let mut w = width as u32;
        let mut h = height as u32;

        for _ in 1..mip_map_count {
            w = (w >> 1).max(1);
            h = (h >> 1).max(1);
            let width = w.try_into().unwrap();
            let height = h.try_into().unwrap();
            complete_data_size += util::get_data_size(self.format, width, height)?;
        }

        // Step 11: Multiply by layer count for total size
        complete_data_size *= self.layer_count;

        // Step 12: Skip reserved section (114 bytes) and data section
        match tpc.seek(SeekFrom::Current(114)) {
            Ok(_) => (),
            Err(e) => return Err(e.to_string()),
        };
        match tpc.seek(SeekFrom::Current(complete_data_size as i64)) {
            Ok(_) => (),
            Err(e) => return Err(e.to_string()),
        };

        // Step 13: Read TXI (Texture Information) data
        self.read_txi_data(tpc)?;

        // Step 14: Check if texture is animated
        self.is_animated = util::check_animated(width as u32, height as u32, data_size)?;

        // Step 15: Validate data size for compressed formats
        if !is_uncompressed {
            match encoding {
                ENCODING_RGB => {
                    // S3TC DXT1 compression
                    if data_size != ((width as u32 * height as u32) / 2) && !self.is_animated {
                        return Err(format!(
                            "Invalid data size for {}x{} texture with format {}",
                            width, height, encoding
                        ));
                    }
                }
                ENCODING_RGBA => {
                    // S3TC DXT5 compression
                    if data_size != (width as u32 * height as u32) && !self.is_animated {
                        return Err(format!(
                            "Invalid data size for {}x{} texture with format {}",
                            width, height, encoding
                        ));
                    }
                }
                _ => return Err(format!("Unknown TPC encoding: {}", encoding)),  
            }
        }

        // Step 16: Seek to start of pixel data
        tpc.seek(SeekFrom::Start(128)).map_err(|e| e.to_string())?;

        // Step 17: Final validation of image dimensions
        if !util::has_valid_dimensions(self.format, width as i32, height as i32) {
            return Err(format!(
                "Invalid dimensions ({}x{}) for format {:?}",
                width, height, self.format
            ));
        }

        // Step 18: Return the encoding type
        Ok(encoding)
    }

    fn read_txi_data<S: Read + Seek>(&mut self, tpc: &mut S) -> Result<(), String> {
        // TXI data for the rest of the TPC
        let current_pos = tpc
            .stream_position()
            .map_err(|_| "Failed to get stream position".to_string())?;

        let file_size = tpc
            .seek(SeekFrom::End(0))
            .map_err(|_| "Failed to seek to end".to_string())?;

        // Seek back to where we were
        tpc.seek(SeekFrom::Start(current_pos))
            .map_err(|_| "Failed to seek back to position".to_string())?;

        self.txi_data_size = (file_size - current_pos) as usize;

        if self.txi_data_size == 0 {
            return Ok(());
        }

        let mut txi_data = vec![0u8; self.txi_data_size];

        tpc.read_exact(&mut txi_data)
            .map_err(|_| "Failed to read TXI data".to_string())?;

        self.txi_data = Some(txi_data);

        Ok(())
    }




    fn read_data<S: Read + Seek>(&mut self, tpc: &mut S, encoding: u8) -> Result<(), String> {
        // Process each mipmap level in the texture
        for mipmap_level in &mut self.mip_maps {
            // Step 1: Check if texture needs to be deswizzled
            // Width being power of two indicates swizzled memory layout
            let is_width_power_of_two = (mipmap_level.width & (mipmap_level.width - 1)) == 0;
            let needs_deswizzling = (encoding == ENCODING_SWIZZLED_BGRA) && is_width_power_of_two;

            // Step 2: Allocate buffer for the mipmap data
            let mut processed_data = vec![0u8; mipmap_level.size];

            if needs_deswizzling {
                // Step 3a: Handle swizzled texture data
                // Create temporary buffer for the swizzled data
                let mut swizzled_data = vec![0u8; mipmap_level.size];

                // Read the swizzled data into temp buffer
                tpc.read_exact(&mut swizzled_data)
                    .map_err(|_| "Read error".to_string())?;

                // Deswizzle the data into the final buffer
                util::de_swizzle(
                    &mut processed_data,
                    &swizzled_data,
                    mipmap_level.width as u32,
                    mipmap_level.height as u32
                );

            } else {
                // Step 3b: Handle non-swizzled texture data
                // Read data directly into the buffer
                tpc.read_exact(&mut processed_data)
                    .map_err(|_| "Read error".to_string())?;

                // Step 4: Convert grayscale to RGB if needed
                if encoding == ENCODING_GRAY {
                    // Store original grayscale data
                    let grayscale_data = processed_data;

                    // Calculate new size for RGB format (3 bytes per pixel)
                    let rgb_size = mipmap_level.width * mipmap_level.height * 3;
                    let mut rgb_data = vec![0u8; rgb_size];

                    // Convert each grayscale pixel to RGB
                    // Each gray value is copied to R, G, and B channels
                    for pixel_index in 0..(mipmap_level.width * mipmap_level.height) {
                        let gray_value = grayscale_data[pixel_index];
                        let rgb_offset = pixel_index * 3;

                        rgb_data[rgb_offset] = gray_value;     // R
                        rgb_data[rgb_offset + 1] = gray_value; // G
                        rgb_data[rgb_offset + 2] = gray_value; // B
                    }

                    processed_data = rgb_data;
                }
            }

            // Step 5: Store the processed data in the mipmap
            mipmap_level.data = Some(processed_data.into_boxed_slice());
        }

        // Step 6: Return success
        Ok(())
    }

    fn de_swizzle(&self, dst: &mut [u8], src: &[u8], width: u32, height: u32) {
        for y in 0..height {
            for x in 0..width {
                let offset = util::de_swizzle_offset(x, y, width, height) * 4;
                let dst_offset = ((y * width + x) * 4) as usize;
                dst[dst_offset] = src[offset as usize];
                dst[dst_offset + 1] = src[offset as usize + 1];

                dst[dst_offset + 2] = src[offset as usize + 2]; 
                dst[dst_offset + 3] = src[offset as usize + 3];
            }
        }
    }

    fn fixup_cube_map(&mut self) -> Result<(), String> {
        // Return early if not a cube map
        if !self.is_cube_map {
            return Ok(());
        }

        // Validate dimensions across layers
        for j in 0..self.get_mip_map_count() {
            let index0 = j;
            if index0 >= self.mip_maps.len() {
                return Err("Invalid mipmap index".to_string());
            }

            let width = self.mip_maps[index0].width;
            let height = self.mip_maps[index0].height;
            let size = self.mip_maps[index0].size;

            for i in 1..self.layer_count as usize {
                let index = i * self.get_mip_map_count() + j;
                if index >= self.mip_maps.len() {
                    return Err("Invalid mipmap index".to_string());
                }

                if width != self.mip_maps[index].width
                    || height != self.mip_maps[index].height
                    || size != self.mip_maps[index].size
                {
                    return Err("Cube map layer dimensions mismatch".to_string());
                }
            }
        }

        // Decompress before rotating
        self.decompress()?;

        // Rotate cube sides
        let rotation = [3, 1, 0, 2, 2, 0];
        let bpp = util::get_bytes_per_pixel(self.format);

        for i in 0..self.layer_count as usize {
            for j in 0..self.get_mip_map_count() {
                let index = i * self.get_mip_map_count() + j;
                if index >= self.mip_maps.len() {
                    return Err("Invalid mipmap index".to_string());
                }

                let width = self.mip_maps[index].width as i32;
                let height = self.mip_maps[index].height as i32;

                

                util::rotate_90(&mut self.mip_maps[index].data.as_mut().unwrap(), width, height, bpp, rotation[i])?;

                self.mip_maps[index].data = self.mip_maps[index].data.clone();
            }
        }



        // Swap first two sides of cube maps
        for j in 0..self.get_mip_map_count() {
            let index0 = j;
            let index1 = self.get_mip_map_count() + j;

            if index1 >= self.mip_maps.len() {
                return Err("Invalid mipmap index".to_string());
            }

            self.mip_maps.swap(index0, index1);
        }

        Ok(())
    }




    fn decompress(&mut self) -> Result<(), String> {
        if !self.is_compressed() {
            return Ok(());
        }

        for mip_map in &mut self.mip_maps {
            let mut decompressed = MipMap::new();
            util::decompress_mipmap(&mut decompressed, mip_map, self.format)?;
            std::mem::swap(mip_map, &mut decompressed);
        }


        self.format = PixelFormat::R8G8B8A8;
        Ok(())
    }




    fn is_compressed(&self) -> bool {
        matches!(
            self.format,
            PixelFormat::DXT1 | PixelFormat::DXT3 | PixelFormat::DXT5
        )
    }

  

    fn get_mip_map_count(&self) -> usize {
        self.mip_maps.len() / self.layer_count as usize
    }
}
