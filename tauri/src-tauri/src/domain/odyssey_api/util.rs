use std::cmp;
use std::convert::TryInto;
use std::ptr;
use std::fmt;
use std::error::Error;


use crate::domain::odyssey_api::seekablereadstream::SeekableReadStream;
use crate::domain::odyssey_api::{dumptga, util};
use crate::domain::odyssey_api::tpc::PixelFormat;
use crate::domain::odyssey_api::dumptga::images::dump_tga;
use crate::domain::odyssey_api::s3tc;

use crate::domain::odyssey_api::maths;

use super::decoder::images::MipMap;
use super::maths::int_log2;


/** Return the number of bytes per pixel in this format. */

pub fn get_bpp(format: PixelFormat) -> i32 {
    match format {
        PixelFormat::R8G8B8 | PixelFormat::B8G8R8 => 3,
        PixelFormat::R8G8B8A8 | PixelFormat::B8G8R8A8 => 4,
        PixelFormat::A1R5G5B5 | PixelFormat::R5G6B5 | PixelFormat::Depth16 => 2,
        _ => 0,
    }
}

/** Flip an image vertically. */
pub fn flip_vertically(data: &mut [u8], width: usize, height: usize, bpp: usize) {
    if width == 0 || height == 0 || bpp == 0 {
        return;
    }

    let pitch = bpp * width;
    let mut buffer = vec![0u8; pitch];
    let mut half_height = height / 2;

    while half_height > 0 {
        let (top_half, bottom_half) = data.split_at_mut((height - half_height) * pitch);
        let top_row_start = (half_height - 1) * pitch;
        let bottom_row_start = 0;

        buffer.copy_from_slice(&top_half[top_row_start..top_row_start + pitch]);
        top_half[top_row_start..top_row_start + pitch].copy_from_slice(&bottom_half[bottom_row_start..bottom_row_start + pitch]);
        bottom_half[bottom_row_start..bottom_row_start + pitch].copy_from_slice(&buffer);

        half_height -= 1;
    }
}

/** Return the number of bytes necessary to hold an image of these dimensions
 * and in this format. */
pub fn get_data_size(format: PixelFormat, width: i32, height: i32) -> Result<u32, String> {
    if width < 0 || width >= 0x8000 || height < 0 || height >= 0x8000 {
        return Err(format!("Invalid dimensions {}x{}", width, height))?;
    }
    return match format {
        PixelFormat::R8G8B8 | PixelFormat::B8G8R8 => {
            let size: i32 = width * height * 3;
            match size.try_into() {
                Ok(s) => Ok(s),
                Err(e) => Err(e.to_string()),
            }
        },
        PixelFormat::R8G8B8A8 | PixelFormat::B8G8R8A8 => {
            let size: i32 = width * height * 4;
            match size.try_into() {
                Ok(s) => Ok(s),
                Err(e) => Err(e.to_string()),
            }
        },

        PixelFormat::A1R5G5B5 | PixelFormat::R5G6B5 | PixelFormat::Depth16 => {
            let size: i32 = width * height * 2;
            match size.try_into() {
                Ok(s) => Ok(s),
                Err(e) => Err(e.to_string()),
            }
        }


        PixelFormat::DXT1 => cmp::max(
            Ok(8),
            match (((width + 3) / 4) * ((height + 3) / 4) * 8).try_into() {
                Ok(s) => Ok(s),
                Err(e) => Err(e.to_string()),
            },
        ),

        PixelFormat::DXT3 | PixelFormat::DXT5 => cmp::max(
            Ok(16),
            match (((width + 3) / 4) * ((height + 3) / 4) * 16).try_into() {
                Ok(s) => Ok(s),
                Err(e) => Err(e.to_string()),
            },
        ),
        _ => return Err(format!("Invalid pixel format {}", format as u32))?,

    }
}

/** Are these image dimensions valid for this format? */
pub fn has_valid_dimensions(format: PixelFormat, width: i32, height: i32) -> bool {
    if width < 0 || width >= 0x8000 || height < 0 || height >= 0x8000 {
        return false;
    }

    return matches!(
        format,
        PixelFormat::R8G8B8
            | PixelFormat::B8G8R8
            | PixelFormat::R8G8B8A8
            | PixelFormat::B8G8R8A8
            | PixelFormat::A1R5G5B5
            | PixelFormat::R5G6B5
            | PixelFormat::Depth16
            | PixelFormat::DXT1
            | PixelFormat::DXT3
            | PixelFormat::DXT5
    )
}

/** Flip an image horizontally. */
pub fn flip_horizontally(data: &mut [u8], width: usize, height: usize, bpp: usize) {
    if width == 0 || height == 0 || bpp == 0 {
        return;
    }

    let half_width = width / 2;
    let pitch = bpp * width;

    let mut buffer = vec![0u8; bpp];

    let mut data = data;
    for _ in 0..height {
        let mut data_start = data.as_mut_ptr();
        let mut data_end = unsafe { data.as_mut_ptr().add(pitch - bpp) };

        for _ in 0..half_width {
            unsafe {
                ptr::copy_nonoverlapping(data_start, buffer.as_mut_ptr(), bpp);
                ptr::copy_nonoverlapping(data_end, data_start, bpp);
                ptr::copy_nonoverlapping(buffer.as_ptr(), data_end, bpp);

                data_start = data_start.add(bpp);
                data_end = data_end.sub(bpp);
            }
        }

        data = &mut data[pitch..];
    }
}

/** Rotate a square image in 90° steps, clock-wise. */
pub fn rotate_90(data: &mut [u8], width: i32, height: i32, bpp: i32, mut steps: i32) -> Result<(), String> {
    if width <= 0 || height <= 0 || bpp <= 0 {
        return Ok(());
    }

    if width != height {
        return Err("Image must be square to rotate".to_string());
    }

    while steps > 0 {
        let n = width as usize;
        let w = n / 2;
        let h = (n + 1) / 2;

        for x in 0..w {
            for y in 0..h {
                let d0 = (y * n + x) * bpp as usize;
                let d1 = ((n - 1 - x) * n + y) * bpp as usize;
                let d2 = ((n - 1 - y) * n + (n - 1 - x)) * bpp as usize;
                let d3 = (x * n + (n - 1 - y)) * bpp as usize;

                for p in 0..bpp as usize {
                    let tmp = data[d0 + p];
                    data[d0 + p] = data[d1 + p];
                    data[d1 + p] = data[d2 + p];
                    data[d2 + p] = data[d3 + p];
                    data[d3 + p] = tmp;
                }
            }
        }

        steps -= 1;
    }

    Ok(())
}


pub fn de_swizzle(dst: &mut [u8], src: &[u8], width: u32, height: u32) {
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

pub fn decompress_mipmap(out: &mut MipMap, inp: &MipMap, format: PixelFormat) -> Result<(), String> {
    if !matches!(format, PixelFormat::DXT1 | PixelFormat::DXT3 | PixelFormat::DXT5) {
        return Err(format!("Unknown compressed format {:?}", format));
    }

    if !util::has_valid_dimensions(format, inp.width as i32, inp.height as i32) {
        return Err(format!(
            "Invalid dimensions ({}x{}) for format {:?}",
            inp.width, inp.height, format
        ));
    }

    out.width = inp.width;
    out.height = inp.height;
    out.size = std::cmp::max(out.width * out.height * 4, 64);
    out.data = Some(vec![0; out.size].into_boxed_slice());

    let mut stream = std::io::Cursor::new(inp.data.as_ref().ok_or("Input data is None")?.as_ref());

    match format {
        PixelFormat::DXT1 => {
            s3tc::decompress_dxt1_std(
                out.data.as_mut().unwrap(),
                &mut stream,
                out.width as u32,
                out.height as u32,
                out.width as u32 * 4,
            );
        }
        PixelFormat::DXT3 => {
            s3tc::decompress_dxt3_std(
                out.data.as_mut().unwrap(),
                &mut stream,
                out.width as u32,
                out.height as u32,
                out.width as u32 * 4,

            );
        }
        PixelFormat::DXT5 => {
            s3tc::decompress_dxt5_std(
                out.data.as_mut().unwrap(),
                &mut stream,
                out.width as u32,
                out.height as u32,
                out.width as u32 * 4,

            );
        }
        _ => {}
    }

    Ok(())
}
/** De-"swizzle" a texture pixel offset. */
pub fn de_swizzle_offset(
    mut x: u32,
    mut y: u32,
    mut width: u32,
    mut height: u32,
) -> u32 {
    width = int_log2(width) as u32;
    height = int_log2(height) as u32;


    let mut offset = 0;
    let mut shift_count = 0;

    while width | height > 0 {
        if width > 0 {
            offset |= (x & 0x01) << shift_count;

            x >>= 1;

            shift_count += 1;
            width -= 1;
        }

        if height > 0 {
            offset |= (y & 0x01) << shift_count;

            y >>= 1;

            shift_count += 1;
            height -= 1;
        }
    }

    offset
}

pub fn get_min_data_size(is_uncompressed: bool, encoding: u8) -> Result<u32, String> {
    if is_uncompressed {
        match encoding {
            1 => Ok(1), // GRAY
            2 => Ok(3), // RGB
            4 | 12 => Ok(4), // RGBA or SWIZZLED_BGRA
            _ => Err(format!("Invalid encoding for uncompressed image: {}", encoding))
        }
    } else {
        match encoding {
            2 => Ok(8),  // RGB (DXT1)
            4 => Ok(16), // RGBA (DXT5)
            _ => Err(format!("Invalid encoding for compressed image: {}", encoding))
        }
    }
}

pub fn get_pixel_format(is_uncompressed: bool, encoding: u8) -> Result<PixelFormat, String> {
    if is_uncompressed {
        match encoding {
            1 => Ok(PixelFormat::R8G8B8),    // GRAY
            2 => Ok(PixelFormat::R8G8B8),    // RGB
            4 => Ok(PixelFormat::R8G8B8A8),  // RGBA
            12 => Ok(PixelFormat::B8G8R8A8), // SWIZZLED_BGRA
            _ => Err(format!("Invalid encoding for uncompressed image: {}", encoding))
        }
    } else {
        match encoding {
            2 => Ok(PixelFormat::DXT1), // RGB
            4 => Ok(PixelFormat::DXT5), // RGBA
            _ => Err(format!("Invalid encoding for compressed image: {}", encoding))
        }
    }
}

pub fn check_animated(width: u32, height: u32, data_size: u32) -> Result<bool, String> {
    // Check if dimensions and data size match what would be expected for an animated texture
    if width == 0 || height == 0 {
        return Err("Invalid dimensions".to_string());
    }
    
    // Animated textures typically have height = N * width where N is the number of frames
    if height % width != 0 {
        return Ok(false);
    }
    
    let frame_count = height / width;
    let expected_size = width * width * 4 * frame_count; // Assuming 4 bytes per pixel
    
    Ok(data_size == expected_size)
}

/** Return the number of bytes per pixel in this format. */
pub fn get_bytes_per_pixel(format: PixelFormat) -> i32 {
    match format {
        PixelFormat::R8G8B8 | PixelFormat::B8G8R8 => 3,
        PixelFormat::R8G8B8A8 | PixelFormat::B8G8R8A8 => 4,
        PixelFormat::A1R5G5B5 | PixelFormat::R5G6B5 | PixelFormat::Depth16 => 2,
        PixelFormat::DXT1 => 8,
        PixelFormat::DXT3 | PixelFormat::DXT5 => 16,
        _ => 0,
    }
}

