/** @file
 *  Generic image decoder interface.
 */
use std::assert;
use std::cmp;
use std::mem;
use std::sync::Arc;

use crate::domain::odyssey_api::tpc::PixelFormat;

pub mod images {
    use std::borrow::BorrowMut;
    use std::ops::{Deref, DerefMut};

    use tauri::utils;

    use crate::domain::odyssey_api::dumptga::images::dump_tga;
    use crate::domain::odyssey_api::s3tc;
    use crate::domain::odyssey_api::s3tc::images;
    use crate::domain::odyssey_api::seekablereadstream::SeekableReadStream;
    use crate::domain::odyssey_api::tpc::PixelFormat;
    use crate::domain::odyssey_api::{dumptga, util};

    use crate::domain::odyssey_api::util::*;

    use super::*;

    pub struct MipMap {
        pub width: usize,
        pub height: usize,
        pub size: usize,
        pub data: Option<Box<[u8]>>,
    }

    impl MipMap {
        pub fn new() -> Self {
            MipMap {
                width: 0,
                height: 0,
                size: 0,
                data: None,
            }
        }

        pub fn clone_from(&mut self, other: &Self) -> &mut Self {
            self.width = other.width;
            self.height = other.height;
            self.size = other.size;

            if let Some(data) = &other.data {
                self.data = Some(data.clone());
            } else {
                self.data = None;
            }

            self
        }

        pub fn swap(&mut self, other: &mut Self) {
            mem::swap(&mut self.width, &mut other.width);
            mem::swap(&mut self.height, &mut other.height);
            mem::swap(&mut self.size, &mut other.size);
            mem::swap(&mut self.data, &mut other.data);
        }
    }

    #[derive(Clone)]
    pub struct Decoder {
        _format: PixelFormat,
        _layer_count: usize,
        _is_cube_map: bool,
        _mip_maps: Vec<Arc<MipMap>>,
    }

    impl Decoder {
        pub fn new() -> Self {
            Decoder {
                _format: PixelFormat::R8G8B8A8,
                _layer_count: 1,
                _is_cube_map: false,
                _mip_maps: Vec::new(),
            }
        }

        pub fn clone_from(&mut self, other: &Self) -> &mut Self {
            self._format = other._format;
            self._layer_count = other._layer_count;
            self._is_cube_map = other._is_cube_map;
            self._mip_maps.clear();
            self._mip_maps.reserve(other._mip_maps.len());
            for mip_map in &other._mip_maps {
                self._mip_maps.push(mip_map.clone());
            }

            self
        }

        pub fn get_txi(&self) -> Option<Box<dyn SeekableReadStream>> {
            None
        }

        pub fn is_compressed(&self) -> bool {
            matches!(
                self._format,
                PixelFormat::DXT1 | PixelFormat::DXT3 | PixelFormat::DXT5
            )
        }

        pub fn get_format(&self) -> PixelFormat {
            self._format
        }

        pub fn get_mip_map_count(&self) -> usize {
            assert!((self._mip_maps.len() % self._layer_count) == 0);

            self._mip_maps.len() / self._layer_count
        }

        pub fn get_layer_count(&self) -> usize {
            self._layer_count
        }

        pub fn is_cube_map(&self) -> bool {
            assert!(!self._is_cube_map || (self._layer_count == 6));

            self._is_cube_map
        }

        pub fn get_mip_map(&self, mip_map: usize, layer: usize) -> &MipMap {
            assert!(layer < self._layer_count);
            assert!((self._mip_maps.len() % self._layer_count) == 0);

            let index = layer * self.get_mip_map_count() + mip_map;

            assert!(index < self._mip_maps.len());

            &self._mip_maps[index]
        }

        pub fn decompress(&mut self, out: &mut MipMap, inp: &MipMap, format: PixelFormat) {
            if !(matches!(
                format,
                PixelFormat::DXT1 | PixelFormat::DXT3 | PixelFormat::DXT5
            )) {
                panic!("Unknown compressed format {:?}", format);
            }

            if !util::has_valid_dimensions(format, inp.width as i32, inp.height as i32) {
                panic!(
                    "Invalid dimensions ({:?}x{:?}) for format {:?}",
                    inp.width, inp.height, format
                );
            }

            out.width = inp.width;
            out.height = inp.height;
            out.size = cmp::max(out.width * out.height * 4, 64);

            out.data = Some(vec![0; out.size].into_boxed_slice());

            let mut stream = inp.data.as_ref().ok_or("Input data is None").unwrap().as_ref();

            let mut sub_stream = std::io::Cursor::new(stream);
            // replace with with standard stream from rust library
            match format {
                PixelFormat::DXT1 => {
                    // let mut sub_stream = stream;
                    s3tc::images::decompress_dxt1_std(
                        &mut out.data.as_mut().unwrap(),
                        &mut sub_stream,
                        out.width as u32,
                        out.height as u32,
                        out.width as u32 * 4,
                    )
                }
                PixelFormat::DXT3 => s3tc::images::decompress_dxt3_std(
                    &mut out.data.as_mut().unwrap(),
                    &mut sub_stream,
                    out.width as u32,
                    out.height as u32,
                    out.width as u32 * 4,
                ),
                PixelFormat::DXT5 => s3tc::images::decompress_dxt5_std(
                    &mut out.data.as_mut().unwrap(),
                    &mut sub_stream,
                    out.width as u32,
                    out.height as u32,
                    out.width as u32 * 4,
                ),
                _ => (),
            }
        }

        pub fn decompress_all(&mut self) {
            if !self.is_compressed() {
                return;
            }

            let mut decoderclone = self.clone();

            for m in &mut decoderclone._mip_maps {
                let mut decompressed = MipMap::new();

                let format = self._format;

                self.decompress(&mut decompressed, &**m, format);

                if let Some(mip_map) = Arc::get_mut(m) {
                    mip_map.swap(&mut decompressed);
                }
            }

            self._format = PixelFormat::R8G8B8A8;
        }

        pub fn dump_tga(&self, file_name: &str) {
            if self._mip_maps.is_empty() {
                panic!("Image contains no mip maps");
            }

            if !self.is_compressed() {
                dumptga::images::dump_tga(
                    &file_name.to_string(),
                    &dumptga::decoder::Decoder {
                        layers: self
                            ._mip_maps
                            .iter()
                            .map(|m| dumptga::decoder::MipMap {
                                width: m.width as u32,
                                height: m.height as u32,
                                data: Arc::new(m.data.as_ref().unwrap().to_vec()),
                            })
                            .collect(),
                        format: self._format,
                    },
                ).unwrap();
                return;
            }

            let mut decoder = self.clone();
            decoder.decompress_all();

            dumptga::images::dump_tga(
                &file_name.to_string(),
                &dumptga::decoder::Decoder {
                    layers: decoder
                        ._mip_maps
                        .iter()
                        .map(|m| dumptga::decoder::MipMap {
                            width: m.width as u32,
                            height: m.height as u32,
                            data: Arc::new(m.data.as_ref().unwrap().to_vec()),
                        })
                        .collect(),
                    format: decoder._format,
                },
            ).unwrap();
        }

        pub fn flip_horizontally(&mut self) {
            self.decompress_all();

            for m in &mut self._mip_maps {
                let mut mutable_mip_map = m.clone();
                util::flip_horizontally(
                    Arc::get_mut(&mut mutable_mip_map)
                        .unwrap()
                        .data
                        .as_mut()
                        .unwrap(),
                    m.width,
                    m.height,
                    util::get_bpp(self._format) as usize,
                );
            }
        }

        pub fn flip_vertically(&mut self) {
            self.decompress_all();

            for m in &mut self._mip_maps {
                let mut mutable_mip_map = m.clone();
                util::flip_vertically(
                    Arc::get_mut(&mut mutable_mip_map)
                        .unwrap()
                        .data
                        .as_mut()
                        .unwrap(),
                    m.width,
                    m.height,
                    util::get_bpp(self._format) as usize,
                );

            }
        }
    }
}
