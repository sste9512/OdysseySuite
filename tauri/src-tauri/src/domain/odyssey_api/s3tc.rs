use crate::domain::odyssey_api::seekablereadstream::*;
use crate::domain::odyssey_api::util::*;
use std::io::Read;

pub fn check_cube_map(width: u32, height: u32) -> Result<(), String> {
    // Check if dimensions are valid for a cube map
    if width == 0 || height == 0 {
        return Err("Invalid dimensions".to_string());
    }
    
    // For a cube map, height should be 6 times the width
    if height == width * 6 {
        Ok(())
    } else {
        Err("Not a cube map".to_string())
    }
}


    use byteorder::ReadBytesExt;

    use super::*;

    fn convert565_to_8888(color: u16) -> u32 {
        (((color & 0x1F) as u32) << 11)
            | (((color & 0x7E0) as u32) << 13)
            | (((color & 0xF800) as u32) << 16)
            | 0xFF
    }

    fn interpolate32(weight: f64, color_0: u32, color_1: u32) -> u32 {
        let mut r = [0u8; 3];
        let mut g = [0u8; 3];
        let mut b = [0u8; 3];
        let mut a = [0u8; 3];
        r[0] = (color_0 >> 24) as u8;
        r[1] = (color_1 >> 24) as u8;
        r[2] = ((1.0 - weight) * (r[0] as f64) + weight * (r[1] as f64)) as u8;
        g[0] = ((color_0 >> 16) & 0xFF) as u8;
        g[1] = ((color_1 >> 16) & 0xFF) as u8;
        g[2] = ((1.0 - weight) * (g[0] as f64) + weight * (g[1] as f64)) as u8;
        b[0] = ((color_0 >> 8) & 0xFF) as u8;
        b[1] = ((color_1 >> 8) & 0xFF) as u8;
        b[2] = ((1.0 - weight) * (b[0] as f64) + weight * (b[1] as f64)) as u8;
        a[0] = (color_0 & 0xFF) as u8;
        a[1] = (color_1 & 0xFF) as u8;
        a[2] = ((1.0 - weight) * (a[0] as f64) + weight * (a[1] as f64)) as u8;
        ((r[2] as u32) << 24) | ((g[2] as u32) << 16) | ((b[2] as u32) << 8) | (a[2] as u32)
    }

    #[repr(C)]
    struct DXT1Texel {
        color_0: u16,
        color_1: u16,
        pixels: u32,
    }

    macro_rules! read_dxt1_texel {
        ($src:expr, $x:expr) => {
            let mut buf = [0u8; 2];
            $src.read_exact(&mut buf).unwrap();
            $x.color_0 = u16::from_le_bytes(buf);
            

            $src.read_exact(&mut buf).unwrap();
            $x.color_1 = u16::from_le_bytes(buf);
            

            let mut buf = [0u8; 4];
            $src.read_exact(&mut buf).unwrap();
            $x.pixels = u32::from_be_bytes(buf);

        };
    }

    // pub fn decompress_dxt1(
    //     dest: &mut [u8],
    //     src: &mut dyn SeekableReadStream,
    //     width: u32,
    //     height: u32,
    //     pitch: u32,
    // ) {
    //     let mut ty = height as i32;
    //     while ty > 0 {
    //         for tx in (0..width).step_by(4) {
    //             let mut tex = DXT1Texel {
    //                 color_0: 0,
    //                 color_1: 0,
    //                 pixels: 0,
    //             };
    //             read_dxt1_texel!(src, tex);
    //             let mut blended = [0u32; 4];

    //             blended[0] = convert565_to_8888(tex.color_0);
    //             blended[1] = convert565_to_8888(tex.color_1);

    //             if tex.color_0 > tex.color_1 {
    //                 blended[2] = interpolate32(0.333333, blended[0], blended[1]);
    //                 blended[3] = interpolate32(0.666666, blended[0], blended[1]);
    //             } else {
    //                 blended[2] = interpolate32(0.5, blended[0], blended[1]);
    //                 blended[3] = 0;
    //             }

    //             let mut cpx = tex.pixels;
    //             let block_width = width.min(4);
    //             let block_height = height.min(4);

    //             for y in 0..block_height {
    //                 for x in 0..block_width {
    //                     let dest_x = tx + x;
    //                     let dest_y = height - 1 - (ty as u32 - block_height + y);
    //                     let pixel = blended[(cpx & 3) as usize];
    //                     cpx >>= 2;

    //                     if dest_x < width && dest_y < height {
    //                         let offset = (dest_y * pitch + dest_x * 4) as usize;
    //                         dest[offset..offset + 4].copy_from_slice(&pixel.to_be_bytes());
    //                     }
    //                 }
    //             }
    //         }
    //         ty -= 4;
    //     }
    // }

    pub fn decompress_dxt1_std<R: std::io::Read + std::io::Seek>(
        dest: &mut [u8],
        src: &mut R,
        width: u32,
        height: u32,
        pitch: u32,
    ) {
        let mut ty = height as i32;
        while ty > 0 {
            for tx in (0..width).step_by(4) {
                let mut tex = DXT1Texel {
                    color_0: 0,
                    color_1: 0,
                    pixels: 0,
                };

                // Read color values using standard Read trait
                let mut color_0_bytes = [0u8; 2];
                let mut color_1_bytes = [0u8; 2];
                let mut pixels_bytes = [0u8; 4];

                src.read_exact(&mut color_0_bytes).unwrap();
                src.read_exact(&mut color_1_bytes).unwrap();
                src.read_exact(&mut pixels_bytes).unwrap();


                tex.color_0 = u16::from_le_bytes(color_0_bytes);
                tex.color_1 = u16::from_le_bytes(color_1_bytes);
                tex.pixels = u32::from_be_bytes(pixels_bytes);

                let mut blended = [0u32; 4];

                blended[0] = convert565_to_8888(tex.color_0);
                blended[1] = convert565_to_8888(tex.color_1);

                if tex.color_0 > tex.color_1 {
                    blended[2] = interpolate32(0.333333, blended[0], blended[1]);
                    blended[3] = interpolate32(0.666666, blended[0], blended[1]);
                } else {
                    blended[2] = interpolate32(0.5, blended[0], blended[1]);
                    blended[3] = 0;
                }

                let mut cpx = tex.pixels;
                let block_width = width.min(4);
                let block_height = height.min(4);

                for y in 0..block_height {
                    for x in 0..block_width {
                        let dest_x = tx + x;
                        let dest_y = height - 1 - (ty as u32 - block_height + y);
                        let pixel = blended[(cpx & 3) as usize];
                        cpx >>= 2;

                        if dest_x < width && dest_y < height {
                            let offset = (dest_y * pitch + dest_x * 4) as usize;
                            dest[offset..offset + 4].copy_from_slice(&pixel.to_be_bytes());
                        }
                    }
                }
            }
            ty -= 4;
        }
      
    }

    struct DXT23Texel {
        color_0: u16,
        color_1: u16,
        pixels: u32,
        alpha: [u16; 4],
    }

    macro_rules! read_dxt3_texel {
        ($src:expr, $x:expr) => {{
            let mut buf = [0u8; 2];
            $src.read_exact(&mut buf).unwrap();
            $x.alpha[0] = u16::from_le_bytes(buf);
            $src.read_exact(&mut buf).unwrap();
            $x.alpha[1] = u16::from_le_bytes(buf);

            $src.read_exact(&mut buf).unwrap();
            $x.alpha[2] = u16::from_le_bytes(buf);
            $src.read_exact(&mut buf).unwrap();

            $x.alpha[3] = u16::from_le_bytes(buf);

            read_dxt1_texel!($src, $x);
        }};
    }
    pub fn decompress_dxt3_std(
        dest: &mut [u8],
        mut src: &mut std::io::Cursor<&[u8]>,
        width: u32,
        height: u32,
        pitch: u32,
    ) {
        let mut ty = height;
        while ty > 0 {
            ty -= 4;
            let mut tx = 0;

            while tx < width {
                let mut tex = DXT23Texel {
                    color_0: 0,
                    color_1: 0,
                    pixels: 0,
                    alpha: [0; 4],
                };

                let mut blended = [0u32; 4];
                read_dxt3_texel!(src, tex);

                blended[0] = convert565_to_8888(tex.color_0) & 0xFFFFFF00;
                blended[1] = convert565_to_8888(tex.color_1) & 0xFFFFFF00;
                blended[2] = interpolate32(0.333333, blended[0], blended[1]);
                blended[3] = interpolate32(0.666666, blended[0], blended[1]);

                let mut cpx = tex.pixels;
                let block_width = width.min(4);
                let block_height = height.min(4);

                for y in 0..block_height {
                    for x in 0..block_width {
                        let dest_x = tx + x;
                        let dest_y = height - 1 - (ty - block_height + y);

                        let alpha = ((tex.alpha[y as usize] >> (x * 4)) & 0xF) as u32;
                        let pixel = blended[(cpx & 3) as usize] | alpha << 4;

                        cpx >>= 2;

                        if dest_x < width && dest_y < height {
                            dest[(dest_y * pitch + dest_x * 4) as usize..]
                                .copy_from_slice(&pixel.to_be_bytes());
                        }
                    }
                }

                tx += 4;
            }
        }
    }

    // pub fn decompress_dxt3(
    //     dest: &mut [u8],
    //     mut src: &mut dyn SeekableReadStream,
    //     width: u32,
    //     height: u32,
    //     pitch: u32,
    // ) {
    //     let mut ty = height;
    //     while ty > 0 {
    //         ty -= 4;
    //         let mut tx = 0;

    //         while tx < width {
    //             let mut tex = DXT23Texel {
    //                 color_0: 0,
    //                 color_1: 0,
    //                 pixels: 0,
    //                 alpha: [0; 4],
    //             };

    //             let mut blended = [0u32; 4];
    //             read_dxt3_texel!(src, tex);

    //             blended[0] = convert565_to_8888(tex.color_0) & 0xFFFFFF00;
    //             blended[1] = convert565_to_8888(tex.color_1) & 0xFFFFFF00;
    //             blended[2] = interpolate32(0.333333, blended[0], blended[1]);
    //             blended[3] = interpolate32(0.666666, blended[0], blended[1]);

    //             let mut cpx = tex.pixels;
    //             let block_width = width.min(4);
    //             let block_height = height.min(4);

    //             for y in 0..block_height {
    //                 for x in 0..block_width {
    //                     let dest_x = tx + x;
    //                     let dest_y = height - 1 - (ty - block_height + y);

    //                     let alpha = ((tex.alpha[y as usize] >> (x * 4)) & 0xF) as u32;
    //                     let pixel = blended[(cpx & 3) as usize] | alpha << 4;

    //                     cpx >>= 2;

    //                     if dest_x < width && dest_y < height {
    //                         dest[(dest_y * pitch + dest_x * 4) as usize..]
    //                             .copy_from_slice(&pixel.to_be_bytes());
    //                     }
    //                 }
    //             }

    //             tx += 4;
    //         }
    //     }
    // }

    struct DXT45Texel {
        color_0: u16,
        color_1: u16,
        pixels: u32,
        alpha_0: u8,
        alpha_1: u8,
        alphabl: u64,
    }

    fn read_uint48_le(src: &mut dyn SeekableReadStream) -> u64 {
        let mut output = src.read_u32_le().unwrap() as u64;
        output |= (src.read_u16_le().unwrap() as u64) << 32;
        output
    }

    impl DXT45Texel {
        /// Reads a DXT4/5 texel from the input stream
        ///
        /// # Steps:
        /// 1. Read alpha values (2 bytes)
        /// 2. Read alpha blend table (6 bytes)
        /// 3. Read color values (4 bytes)
        /// 4. Read pixel indices (4 bytes)
        fn read_from(src: &mut dyn SeekableReadStream) -> Self {
            // Read alpha values (2 bytes total)
            let alpha_0 = match src.read_u8() {
                Ok(val) => val,
                Err(e) => {
                    return Self {
                        alpha_0: 0,
                        alpha_1: 0,
                        alphabl: 0,
                        color_0: 0,
                        color_1: 0,
                        pixels: 0,
                    }
                }
            };

            let alpha_1 = match src.read_u8() {
                Ok(val) => val,
                Err(e) => {
                    return Self {
                        alpha_0,
                        alpha_1: 0,
                        alphabl: 0,
                        color_0: 0,
                        color_1: 0,
                        pixels: 0,
                    }
                }
            };

            // Read 6-byte alpha blend lookup table
            let alphabl = read_uint48_le(src);

            // Read color values (4 bytes total)
            let color_0 = match src.read_u16_le() {
                Ok(val) => val,
                Err(e) => {
                    return Self {
                        alpha_0,
                        alpha_1,
                        alphabl,
                        color_0: 0,
                        color_1: 0,
                        pixels: 0,
                    }
                }
            };

            let color_1 = match src.read_u16_le() {
                Ok(val) => val,
                Err(e) => {
                    return Self {
                        alpha_0,
                        alpha_1,
                        alphabl,
                        color_0,
                        color_1: 0,
                        pixels: 0,
                    }
                }
            };

            // Read 4 bytes of pixel indices
            let pixels = match src.read_u32_be() {
                Ok(val) => val,
                Err(e) => {
                    return Self {
                        alpha_0,
                        alpha_1,
                        alphabl,
                        color_0,
                        color_1,
                        pixels: 0,
                    }
                }
            };

            // Construct and return the texel
            Self {
                alpha_0,
                alpha_1,
                alphabl,
                color_0,
                color_1,
                pixels,
            }
        }

        fn read_from_std<R: std::io::Read>(src: &mut R) -> std::io::Result<Self> {
            // Read alpha values (2 bytes total)
            let mut alpha_buf = [0u8; 2];
            src.read_exact(&mut alpha_buf)?;
            let alpha_0 = alpha_buf[0];
            let alpha_1 = alpha_buf[1];

            // Read 6-byte alpha blend lookup table
            let mut alphabl_buf = [0u8; 6];
            src.read_exact(&mut alphabl_buf)?;
            let alphabl = u64::from_le_bytes([
                alphabl_buf[0], alphabl_buf[1], alphabl_buf[2],
                alphabl_buf[3], alphabl_buf[4], alphabl_buf[5],
                0, 0
            ]);

            // Read color values (4 bytes total)
            let mut color_buf = [0u8; 4];
            src.read_exact(&mut color_buf)?;
            let color_0 = u16::from_le_bytes([color_buf[0], color_buf[1]]);
            let color_1 = u16::from_le_bytes([color_buf[2], color_buf[3]]);

            // Read 4 bytes of pixel indices
            let mut pixels_buf = [0u8; 4];
            src.read_exact(&mut pixels_buf)?;
            let pixels = u32::from_be_bytes(pixels_buf);

            Ok(Self {
                alpha_0,
                alpha_1,
                alphabl,
                color_0,
                color_1,
                pixels,
            })
        }
    }

    pub fn decompress_dxt5(
        dest: &mut [u8],
        src: &mut dyn SeekableReadStream,
        width: u32,
        height: u32,
        pitch: u32,
    ) {
        let mut ty = height as i32;

        while ty > 0 {
            ty -= 4;
            for tx in (0..width).step_by(4) {
                let tex = DXT45Texel::read_from(src);
                let mut blended = [0u32; 4];
                let mut alphab = [0u8; 8];

                alphab[0] = tex.alpha_0;
                alphab[1] = tex.alpha_1;

                if tex.alpha_0 > tex.alpha_1 {
                    alphab[2] = (6.0 * alphab[0] as f64 + 1.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[3] = (5.0 * alphab[0] as f64 + 2.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[4] = (4.0 * alphab[0] as f64 + 3.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[5] = (3.0 * alphab[0] as f64 + 4.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[6] = (2.0 * alphab[0] as f64 + 5.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[7] = (1.0 * alphab[0] as f64 + 6.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                } else {
                    alphab[2] = (4.0 * alphab[0] as f64 + 1.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[3] = (3.0 * alphab[0] as f64 + 2.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[4] = (2.0 * alphab[0] as f64 + 3.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[5] = (1.0 * alphab[0] as f64 + 4.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[6] = 0;
                    alphab[7] = 255;
                }

                blended[0] = convert565_to_8888(tex.color_0) & 0xFFFFFF00;
                blended[1] = convert565_to_8888(tex.color_1) & 0xFFFFFF00;
                blended[2] = interpolate32(0.333333, blended[0], blended[1]);
                blended[3] = interpolate32(0.666666, blended[0], blended[1]);

                let mut cpx = tex.pixels;
                let block_width = width.min(4);
                let block_height = height.min(4);

                for y in 0..block_height {
                    for x in 0..block_width {
                        let dest_x = tx + x;
                        let dest_y = height - 1 - (ty as u32 - block_height + y);

                        let alpha = alphab[((tex.alphabl >> (3 * (4 * (3 - y) + x))) & 7) as usize];
                        let pixel = blended[(cpx & 3) as usize] | alpha as u32;

                        cpx >>= 2;

                        if (dest_x < width) && (dest_y < height) {
                            dest[(dest_y * pitch + dest_x * 4) as usize..]
                                .copy_from_slice(&pixel.to_be_bytes());
                        }
                    }
                }
            }
        }
    }

    pub fn decompress_dxt5_std(
        dest: &mut [u8],
        src: &mut std::io::Cursor<&[u8]>,
        width: u32,
        height: u32,
        pitch: u32,
    ) {
        let mut ty = height as i32;

        while ty > 0 {
            ty -= 4;
                for tx in (0..width).step_by(4) {
                    let tex = DXT45Texel::read_from_std(src).unwrap();
                let mut blended = [0u32; 4];
                let mut alphab = [0u8; 8];


                alphab[0] = tex.alpha_0;
                alphab[1] = tex.alpha_1;

                if tex.alpha_0 > tex.alpha_1 {
                    alphab[2] = (6.0 * alphab[0] as f64 + 1.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[3] = (5.0 * alphab[0] as f64 + 2.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[4] = (4.0 * alphab[0] as f64 + 3.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[5] = (3.0 * alphab[0] as f64 + 4.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[6] = (2.0 * alphab[0] as f64 + 5.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                    alphab[7] = (1.0 * alphab[0] as f64 + 6.0 * alphab[1] as f64 + 3.0) as u8 / 7;
                } else {
                    alphab[2] = (4.0 * alphab[0] as f64 + 1.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[3] = (3.0 * alphab[0] as f64 + 2.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[4] = (2.0 * alphab[0] as f64 + 3.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[5] = (1.0 * alphab[0] as f64 + 4.0 * alphab[1] as f64 + 2.0) as u8 / 5;
                    alphab[6] = 0;
                    alphab[7] = 255;
                }

                blended[0] = convert565_to_8888(tex.color_0) & 0xFFFFFF00;
                blended[1] = convert565_to_8888(tex.color_1) & 0xFFFFFF00;
                blended[2] = interpolate32(0.333333, blended[0], blended[1]);
                blended[3] = interpolate32(0.666666, blended[0], blended[1]);

                let mut cpx = tex.pixels;
                let block_width = width.min(4);
                let block_height = height.min(4);

                for y in 0..block_height {
                    for x in 0..block_width {
                        let dest_x = tx + x;
                        let dest_y = height - 1 - (ty as u32 - block_height + y);

                        let alpha = alphab[((tex.alphabl >> (3 * (4 * (3 - y) + x))) & 7) as usize];
                        let pixel = blended[(cpx & 3) as usize] | alpha as u32;

                        cpx >>= 2;

                        if (dest_x < width) && (dest_y < height) {
                            dest[(dest_y * pitch + dest_x * 4) as usize..]
                                .copy_from_slice(&pixel.to_be_bytes());
                        }
                    }
                }
            }
        }
    }

