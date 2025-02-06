use std::io::{Cursor, Read, Seek, SeekFrom};
use byteorder::{LittleEndian, ReadBytesExt};

const TGA_HEADER_LENGTH: usize = 18;
const TGA_FOOTER_LENGTH: usize = 26;

#[derive(Debug)]
pub enum TGAImageType {
    NoImageData = 0,
    UncompressedColorMapped = 1,
    UncompressedTrueColor = 2,
    UncompressedBW = 3,
    RLEColorMapped = 9,
    RLETrueColor = 10,
    RLEBW = 11,
}

#[derive(Debug)]
pub struct TGAHeader {
    id_length: u8,
    color_map_type: u8,
    image_type: TGAImageType,
    width: u16,
    height: u16,
    pixel_depth: u8,
    image_descriptor: u8,
}

pub struct TGA {
    header: TGAHeader,
    data: Vec<u8>,
}

impl TGA {
    pub fn new_from_stream<R: Read + Seek>(mut stream: R) -> Result<Self, String> {
        let header = Self::read_header(&mut Cursor::new(&{
            let mut header_data = vec![0u8; TGA_HEADER_LENGTH];
            stream.read_exact(&mut header_data)
                .map_err(|e| format!("Failed to read TGA header: {}", e))?;
            header_data
        }))?;
        
        // Skip the ID field if present
        if header.id_length > 0 {
            stream.seek(SeekFrom::Current(header.id_length as i64))
                .map_err(|e| format!("Failed to skip ID field: {}", e))?;
        }

        let mut image_data = Vec::new();

        match header.image_type {
            TGAImageType::UncompressedTrueColor => {
                let mut data = Vec::new();
                stream.read_to_end(&mut data)
                    .map_err(|e| format!("Failed to read image data: {}", e))?;
                Self::read_uncompressed_true_color(&data, &header, &mut image_data)?;
            },
            TGAImageType::RLETrueColor => {
                let mut data = Vec::new();
                stream.read_to_end(&mut data)
                    .map_err(|e| format!("Failed to read image data: {}", e))?;
                Self::read_rle_true_color(&mut Cursor::new(&data), &header, &mut image_data)?;
            },
            TGAImageType::UncompressedBW => {
                let mut data = Vec::new();
                stream.read_to_end(&mut data)
                    .map_err(|e| format!("Failed to read image data: {}", e))?;
                Self::read_uncompressed_bw(&data, &header, &mut image_data)?;
            },
            _ => return Err(format!("Unsupported TGA image type")),
        }

        Ok(TGA {
            header,
            data: image_data,
        })
    }
    pub fn new(data: Vec<u8>) -> Result<Self, String> {
        let mut cursor = Cursor::new(&data);
        let header = Self::read_header(&mut cursor)?;
        
        // Skip the ID field if present
        if header.id_length > 0 {
            cursor.seek(SeekFrom::Current(header.id_length as i64))
                .map_err(|e| format!("Failed to skip ID field: {}", e))?;
        }

        let data_start = TGA_HEADER_LENGTH + header.id_length as usize;
        let mut image_data = Vec::new();

        match header.image_type {
            TGAImageType::UncompressedTrueColor => {
                Self::read_uncompressed_true_color(&data[data_start..], &header, &mut image_data)?;
            },
            TGAImageType::RLETrueColor => {
                Self::read_rle_true_color(&mut cursor, &header, &mut image_data)?;
            },
            TGAImageType::UncompressedBW => {
                Self::read_uncompressed_bw(&data[data_start..], &header, &mut image_data)?;
            },
            _ => return Err(format!("Unsupported TGA image type")),
        }

        Ok(TGA {
            header,
            data: image_data,
        })
    }

    fn read_header(cursor: &mut Cursor<&Vec<u8>>) -> Result<TGAHeader, String> {
        let id_length = cursor.read_u8()
            .map_err(|e| format!("Failed to read ID length: {}", e))?;

        let color_map_type = cursor.read_u8()
            .map_err(|e| format!("Failed to read color map type: {}", e))?;

        if color_map_type != 0 {
            return Err("Color mapped TGA images are not supported".to_string());
        }

        let image_type = cursor.read_u8()
            .map_err(|e| format!("Failed to read image type: {}", e))?;

        // Skip color map specification (5 bytes) and x/y origin (4 bytes)
        cursor.seek(SeekFrom::Current(9))
            .map_err(|e| format!("Failed to skip color map specification: {}", e))?;

        let width = cursor.read_u16::<LittleEndian>()
            .map_err(|e| format!("Failed to read width: {}", e))?;

        let height = cursor.read_u16::<LittleEndian>()
            .map_err(|e| format!("Failed to read height: {}", e))?;

        let pixel_depth = cursor.read_u8()
            .map_err(|e| format!("Failed to read pixel depth: {}", e))?;

        let image_descriptor = cursor.read_u8()
            .map_err(|e| format!("Failed to read image descriptor: {}", e))?;

        let image_type = match image_type {
            0 => TGAImageType::NoImageData,
            1 => TGAImageType::UncompressedColorMapped,
            2 => TGAImageType::UncompressedTrueColor,
            3 => TGAImageType::UncompressedBW,
            9 => TGAImageType::RLEColorMapped,
            10 => TGAImageType::RLETrueColor,
            11 => TGAImageType::RLEBW,
            _ => return Err(format!("Invalid image type: {}", image_type)),
        };

        Ok(TGAHeader {
            id_length,
            color_map_type,
            image_type,
            width,
            height,
            pixel_depth,
            image_descriptor,
        })
    }

    fn read_uncompressed_true_color(data: &[u8], header: &TGAHeader, image_data: &mut Vec<u8>) -> Result<(), String> {
        let pixel_size = (header.pixel_depth / 8) as usize;
        let expected_size = header.width as usize * header.height as usize * pixel_size;
        
        if data.len() < expected_size {
            return Err("Image data is truncated".to_string());
        }

        match header.pixel_depth {
            24 => {
                for chunk in data.chunks(3).take(expected_size / 3) {
                    if chunk.len() == 3 {
                        image_data.extend_from_slice(&[chunk[2], chunk[1], chunk[0], 255]);
                    }
                }
            },
            32 => {
                for chunk in data.chunks(4).take(expected_size / 4) {
                    if chunk.len() == 4 {
                        image_data.extend_from_slice(&[chunk[2], chunk[1], chunk[0], chunk[3]]);
                    }
                }
            },
            _ => return Err(format!("Unsupported pixel depth: {}", header.pixel_depth)),
        }

        Ok(())
    }

    fn read_uncompressed_bw(data: &[u8], header: &TGAHeader, image_data: &mut Vec<u8>) -> Result<(), String> {
        if header.pixel_depth != 8 {
            return Err(format!("Invalid pixel depth for BW image: {}", header.pixel_depth));
        }

        let expected_size = header.width as usize * header.height as usize;
        if data.len() < expected_size {
            return Err("Image data is truncated".to_string());
        }

        for &gray in data.iter().take(expected_size) {
            image_data.extend_from_slice(&[gray, gray, gray, 255]);
        }

        Ok(())
    }

    fn read_rle_true_color(cursor: &mut Cursor<&Vec<u8>>, header: &TGAHeader, image_data: &mut Vec<u8>) -> Result<(), String> {
        let pixel_size = (header.pixel_depth / 8) as usize;
        let total_pixels = header.width as usize * header.height as usize;
        let mut pixels_read = 0;

        while pixels_read < total_pixels {
            let packet_header = cursor.read_u8()
                .map_err(|e| format!("Failed to read RLE packet header: {}", e))?;

            let run_length = ((packet_header & 0x7f) + 1) as usize;
            let is_rle = (packet_header & 0x80) != 0;

            if is_rle {
                // RLE packet
                let mut pixel = vec![0; pixel_size];
                cursor.read_exact(&mut pixel)
                    .map_err(|e| format!("Failed to read RLE pixel data: {}", e))?;

                for _ in 0..run_length {
                    if header.pixel_depth == 24 {
                        image_data.extend_from_slice(&[pixel[2], pixel[1], pixel[0], 255]);
                    } else {
                        image_data.extend_from_slice(&[pixel[2], pixel[1], pixel[0], pixel[3]]);
                    }
                }
            } else {
                // Raw packet
                for _ in 0..run_length {
                    let mut pixel = vec![0; pixel_size];
                    cursor.read_exact(&mut pixel)
                        .map_err(|e| format!("Failed to read raw pixel data: {}", e))?;

                    if header.pixel_depth == 24 {
                        image_data.extend_from_slice(&[pixel[2], pixel[1], pixel[0], 255]);
                    } else {
                        image_data.extend_from_slice(&[pixel[2], pixel[1], pixel[0], pixel[3]]);
                    }
                }
            }

            pixels_read += run_length;
        }

        Ok(())
    }

    pub fn get_rgba_data(&self) -> &[u8] {
        &self.data
    }

    pub fn dimensions(&self) -> (u16, u16) {
        (self.header.width, self.header.height)
    }
}