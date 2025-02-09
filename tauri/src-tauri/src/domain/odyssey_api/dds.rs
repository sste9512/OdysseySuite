

 use std::cmp::max;

 /* Helper macros */
 macro_rules! mktag {
     ($a:expr, $b:expr, $c:expr, $d:expr) => {
         (($a as u32) << 24) | (($b as u32) << 16) | (($c as u32) << 8) | ($d as u32)
     };
 }
 
 const K_DDS_ID: u32 = mktag!('D', 'D', 'S', ' ');
 const K_DXT1_ID: u32 = mktag!('D', 'X', 'T', '1');
 const K_DXT3_ID: u32 = mktag!('D', 'X', 'T', '3');
 const K_DXT5_ID: u32 = mktag!('D', 'X', 'T', '5');
 
 const K_HEADER_FLAGS_HAS_MIP_MAPS: u32 = 0x0002_0000;
 
 const K_PIXEL_FLAGS_HAS_ALPHA: u32 = 0x0000_0001;
 const K_PIXEL_FLAGS_HAS_FOUR_CC: u32 = 0x0000_0004;
 const K_PIXEL_FLAGS_IS_INDEXED: u32 = 0x0000_0020;
 const K_PIXEL_FLAGS_IS_RGB: u32 = 0x0000_0040;
 
 pub struct DDS {
     _mip_maps: Vec<MipMap>,
     _format: u32,
 }
 
 struct DDSPixelFormat {
     size: u32,
     flags: u32,
     four_cc: u32,
     bit_count: u32,
     r_bit_mask: u32,
     g_bit_mask: u32,
     b_bit_mask: u32,
     a_bit_mask: u32,
 }
 
 struct MipMap {
     width: u32,
     height: u32,
     size: usize,
     data: Option<Vec<u8>>,
 }
 
 impl DDS {
     pub fn new(mut dds: &mut dyn SeekableReadStream) -> Self {
         let mut dds_instance = Self {
             _mip_maps: Vec::new(),
             _format: 0,
         };
         dds_instance.load(dds);
         dds_instance
     }
 
     pub fn detect(dds: &mut dyn SeekableReadStream) -> bool {
         let pos = dds.pos();
 
         let mut four_cc: u32 = 0;
         if let Ok(value) = dds.read_u32_le() {
             four_cc = value;
         }
 
         dds.seek(pos);
         four_cc == K_DDS_ID
     }
 
     fn load(&mut self, dds: &mut dyn SeekableReadStream) -> Result<(), String> {
         let mut data_type = 0;
         self.read_header(dds, &mut data_type);
         self.read_data(dds, data_type);
         
         // In xoreos-tools, we always want decompressed images
         self.decompress();
         Ok(())
     }
 
     fn read_header(&mut self, dds: &mut dyn SeekableReadStream, data_type: &mut u32) {
         if dds.read_u32_le().unwrap() == K_DDS_ID {
             self.read_standard_header(dds, data_type);
         } else {
             self.read_bio_ware_header(dds, data_type);
         }
     }
 
     fn read_standard_header(&mut self, mut dds: &mut dyn SeekableReadStream, data_type: &mut u32) {
         if dds.read_u32_le().unwrap() != 124 {
             panic!("Header size invalid");
         }
 
         let flags = dds.read_u32_le().unwrap();
         let mut height = dds.read_u32_le().unwrap();
         let mut width = dds.read_u32_le().unwrap();
 

         if width >= 0x8000 || height >= 0x8000 {
             panic!("Unsupported image dimensions ({}x{})", width, height);
         }
 
         dds.skip(4 + 4);
         let mut mip_map_count = dds.read_u32_le().unwrap();
 
         if (flags & K_HEADER_FLAGS_HAS_MIP_MAPS) == 0 {
             mip_map_count = 1;
         }
 
         dds.skip(44);
 
         let format = DDSPixelFormat {
             size: dds.read_u32_le().unwrap(),
             flags: dds.read_u32_le().unwrap(),
             four_cc: dds.read_u32_le().unwrap(),
             bit_count: dds.read_u32_le().unwrap(),
             r_bit_mask: dds.read_u32_le().unwrap(),
             g_bit_mask: dds.read_u32_le().unwrap(),
             b_bit_mask: dds.read_u32_le().unwrap(),
             a_bit_mask: dds.read_u32_le().unwrap(),
         };
 
         self.detect_format(&format, data_type);
 
         if !has_valid_dimensions(self._format, width, height) {
             panic!("Invalid dimensions ({}x{}) for format {}", width, height, self._format);
         }
 
         dds.skip(16 + 4);
 
         self._mip_maps.reserve(mip_map_count as usize);
         for _ in 0..mip_map_count {
             let mut mip_map = MipMap {
                 width: max(width, 1),
                 height: max(height, 1),
                 size: 0,
                 data: None,
             };
 
             self.set_size(&mut mip_map);
 
             self._mip_maps.push(mip_map);
 
             width >>= 1;
             height >>= 1;
         }
     }
 
     fn read_bio_ware_header(&mut self, mut dds: &mut dyn SeekableReadStream, data_type: &mut u32) {
         *data_type = 0;
 
         dds.seek(0);
 
         let mut width = dds.read_u32_le().unwrap();
         let mut height = dds.read_u32_le().unwrap();
 

         if width >= 0x8000 || height >= 0x8000 {
             panic!("Unsupported image dimensions ({}x{})", width, height);
         }
 
         if !is_power_of_2(width) || !is_power_of_2(height) {
             panic!("Width and height must be powers of 2");
         }
 
         let bpp = dds.read_u32_le().unwrap();
         self._format = match bpp {
             3 => K_PIXEL_FLAGS_HAS_ALPHA,
             4 => K_PIXEL_FLAGS_IS_RGB,
             _ => panic!("Unsupported bytes per pixel value ({})", bpp),
         };
 
         let data_size = dds.read_u32_le().unwrap();
         if (bpp == 3 && data_size != width * height / 2)
             || (bpp == 4 && data_size != width * height)
         {
             panic!("Invalid data size ({}x{}x{} {})", width, height, bpp, data_size);
         }
 
         if !has_valid_dimensions(self._format, width, height) {
             panic!("Invalid dimensions ({}x{}) for format {}", width, height, self._format);
         }
 
         dds.skip(4);
 
         let mut full_data_size = dds.size() - dds.pos() as u64;
 
         loop {
             let mut mip_map = MipMap {
                 width: max(width, 1),
                 height: max(height, 1),
                 size: 0,
                 data: None,
             };
 
             self.set_size(&mut mip_map);
 
             if full_data_size < mip_map.size as u64 {
                 break;
             }
 
             full_data_size -= mip_map.size as u64;
             self._mip_maps.push(mip_map);
 
             width >>= 1;
             height >>= 1;
 
             if width < 1 || height < 1 {
                 break;
             }
         }
     }
 
     fn set_size(&self, mip_map: &mut MipMap) {
         mip_map.size = get_data_size(self._format, mip_map.width, mip_map.height);
     }
 
     fn read_data(&mut self, dds: &mut dyn SeekableReadStream, data_type: u32) {
         for mip_map in &mut self._mip_maps {
             mip_map.data = Some(vec![0; mip_map.size]);
 
             if data_type == K_PIXEL_FLAGS_HAS_ALPHA {
                 let data = mip_map.data.as_mut().unwrap();
                 for i in 0..mip_map.width * mip_map.height {
                     let pixel = dds.read_u16_le().unwrap();
 
                     data[(i * 4) as usize] = ((pixel & 0x0F) << 4) as u8;
                     data[(i * 4 + 1) as usize] = (((pixel & 0xF0) >> 4) << 4) as u8;
                     data[(i * 4 + 2) as usize] = (((pixel & 0x0F00) >> 8) << 4) as u8;
                     data[(i * 4 + 3) as usize] = (((pixel & 0xF000) >> 12) << 4) as u8;
                 }
             } else if dds.read_exact(mip_map.data.as_mut().unwrap()).is_err() {
                 panic!("Read error");
             }
         }
     }
 
     fn detect_format(&mut self, format: &DDSPixelFormat, data_type: &mut u32) {
         *data_type = 0;
 
         if format.flags & K_PIXEL_FLAGS_HAS_FOUR_CC != 0 {
             match format.four_cc {
                 K_DXT1_ID => self._format = K_DXT1_ID,
                 K_DXT3_ID => self._format = K_DXT3_ID,
                 K_DXT5_ID => self._format = K_DXT5_ID,
                 _ => panic!("Unknown format"),
             }
         } else if format.flags & K_PIXEL_FLAGS_IS_RGB != 0
             && format.flags & K_PIXEL_FLAGS_HAS_ALPHA != 0
             && format.bit_count == 32
         {
             // Handle B8G8R8A8 or other logic as required
         } else {
             // Add additional logic for other formats
             panic!("Unknown pixel format");
         }
     }
 
     fn decompress(&self) {
         // Decompression implementation as required
     }
 }
 
 pub trait SeekableReadStream {
     fn pos(&self) -> usize;
     fn read_u32_le(&mut self) -> Result<u32, &str>;
     fn read_u16_le(&mut self) -> Result<u16, &str>;
     fn read_exact(&mut self, buf: &mut [u8]) -> Result<(), &str>;
     fn skip(&mut self, bytes: u64);
     fn seek(&mut self, pos: usize);
     fn size(&self) -> u64;
 }
 
 fn is_power_of_2(x: u32) -> bool {
     x != 0 && (x & (x - 1)) == 0
 }
 
 fn has_valid_dimensions(format: u32, width: u32, height: u32) -> bool {
     // Validate dimensions logic as per format
     true
 }
 
 fn get_data_size(format: u32, width: u32, height: u32) -> usize {
     // Return data size based on format, width, and height
     width as usize * height as usize
 }