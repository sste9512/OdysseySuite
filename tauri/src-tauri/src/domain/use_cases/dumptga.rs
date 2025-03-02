use crate::domain::odyssey_api::tpc::PixelFormat;
use std::convert::TryInto;
use std::fs::File;
use std::io::{self, Write};

pub mod common {
    use std::fs::File;
    use std::io::{self, Write};

    pub type UString = String;

    pub struct WriteStream {
        file: File,
    }

    impl WriteStream {
        pub fn new(file: File) -> Self {
            Self { file }
        }

        pub fn write_byte(&mut self, byte: u8) -> io::Result<()> {
            self.file.write_all(&[byte])
        }

        pub fn write_uint32_le(&mut self, value: u32) -> io::Result<()> {
            self.file.write_all(&value.to_le_bytes())
        }

        pub fn write_uint16_le(&mut self, value: u16) -> io::Result<()> {
            self.file.write_all(&value.to_le_bytes())
        }

        pub fn flush(&mut self) -> io::Result<()> {
            self.file.flush()
        }
    }
}

pub mod decoder {
    use crate::domain::odyssey_api::tpc::PixelFormat;
    use std::sync::Arc;

    pub struct MipMap {
        pub width: u32,
        pub height: u32,
        pub data: Arc<Vec<u8>>,
    }

    pub struct Decoder {
        pub layers: Vec<MipMap>,
        pub format: PixelFormat,
    }

    impl Decoder {
        pub fn get_layer_count(&self) -> usize {
            self.layers.len()
        }

        pub fn get_format(&self) -> PixelFormat {
            self.format
        }

        pub fn get_mipmap(&self, layer: usize, index: usize) -> &MipMap {
            &self.layers[layer + index]
        }

        pub fn get_mipmap_count(&self) -> usize {
            self.layers.len()
        }
    }
}

pub mod images {
    use super::common::{UString, WriteStream};
    use super::decoder::{Decoder, MipMap};
    use crate::domain::odyssey_api::tpc::PixelFormat;
    use std::fs::File;
    use std::io;

    fn read_le_uint16(data: &[u8]) -> u16 {
        u16::from_le_bytes(data[..2].try_into().unwrap())
    }

    fn write_pixel(
        file: &mut WriteStream,
        data: &mut &[u8],
        format: PixelFormat,
    ) -> io::Result<()> {
        match format {
            PixelFormat::R8G8B8 => {
                file.write_byte(data[2])?;
                file.write_byte(data[1])?;
                file.write_byte(data[0])?;
                file.write_byte(0xFF)?;
                *data = &data[3..];
            }
            PixelFormat::B8G8R8 => {
                file.write_byte(data[0])?;
                file.write_byte(data[1])?;
                file.write_byte(data[2])?;
                file.write_byte(0xFF)?;
                *data = &data[3..];
            }
            PixelFormat::R8G8B8A8 => {
                file.write_byte(data[2])?;
                file.write_byte(data[1])?;
                file.write_byte(data[0])?;
                file.write_byte(data[3])?;
                *data = &data[4..];
            }
            PixelFormat::B8G8R8A8 => {
                file.write_byte(data[0])?;
                file.write_byte(data[1])?;
                file.write_byte(data[2])?;
                file.write_byte(data[3])?;
                *data = &data[4..];
            }
            PixelFormat::R5G6B5 => {
                let color = read_le_uint16(data);
                file.write_byte((color & 0x001F) as u8)?;
                file.write_byte(((color & 0x07E0) >> 5) as u8)?;
                file.write_byte(((color & 0xF800) >> 11) as u8)?;
                file.write_byte(0xFF)?;
                *data = &data[2..];
            }
            PixelFormat::A1R5G5B5 => {
                let color = read_le_uint16(data);
                file.write_byte((color & 0x001F) as u8)?;
                file.write_byte(((color & 0x03E0) >> 5) as u8)?;
                file.write_byte(((color & 0x7C00) >> 10) as u8)?;
                file.write_byte(if (color & 0x8000) != 0 { 0xFF } else { 0x00 })?;
                *data = &data[2..];
            }
            PixelFormat::Depth16 => {
                let color = read_le_uint16(data);
                let value = (color / 128) as u8;
                file.write_byte(value)?;
                file.write_byte(value)?;
                file.write_byte(value)?;
                file.write_byte(if color >= 0x7FFF { 0x00 } else { 0xFF })?;
                *data = &data[2..];
            }
            _ => panic!("Unsupported pixel format"),
        }
        Ok(())
    }

    fn open_tga(file_name: &UString, width: u32, height: u32) -> io::Result<WriteStream> {
        let file = File::create(file_name)?;
        let mut stream = WriteStream::new(file);

        stream.write_byte(0)?; // ID Length
        stream.write_byte(0)?; // Palette size
        stream.write_byte(2)?; // Unmapped RGB
        stream.write_uint32_le(0)?; // Color map
        stream.write_byte(0)?; // Color map
        stream.write_uint16_le(0)?; // X
        stream.write_uint16_le(0)?; // Y

        stream.write_uint16_le(width as u16)?;
        stream.write_uint16_le(height as u16)?;

        stream.write_byte(32)?; // Pixel depths
        stream.write_byte(0)?; // Image descriptor

        Ok(stream)
    }

    fn write_mipmap(
        stream: &mut WriteStream,
        mipmap: &MipMap,
        format: PixelFormat,
    ) -> io::Result<()> {
        let mut data = mipmap.data.as_ref();

        let count = mipmap.width * mipmap.height;
        for _ in 0..count {
            write_pixel(stream, &mut data.as_ref(), format)?;
        }

        Ok(())
    }

    pub fn dump_tga(file_name: &UString, image: &Decoder) -> io::Result<()> {
        if image.get_layer_count() < 1 || image.get_mipmap_count() < 1 {
            panic!("No image");
        }

        let width = image.get_mipmap(0, 0).width as i32;
        let mut height = 0;

        for i in 0..image.get_layer_count() {
            let mipmap = image.get_mipmap(0, i);

            if mipmap.width as i32 != width {
                panic!("dumpTGA(): Unsupported image with variable layer width");
            }

            height += mipmap.height as i32;
        }

        let mut file = open_tga(file_name, width as u32, height as u32)?;

        for i in 0..image.get_layer_count() {
            let mipmap = image.get_mipmap(0, i);
            write_mipmap(&mut file, mipmap, image.get_format())?;
        }

        file.flush()
    }
}
