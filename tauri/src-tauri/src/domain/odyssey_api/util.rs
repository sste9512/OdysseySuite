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
use crate::domain::odyssey_api::s3tc::images;
use crate::domain::odyssey_api::maths;

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
pub fn rotate90(data: &mut [u8], width: i32, height: i32, bpp: i32, mut steps: i32) {
    if width <= 0 || height <= 0 || bpp <= 0 {
        return;
    }

    assert_eq!(width, height);

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

