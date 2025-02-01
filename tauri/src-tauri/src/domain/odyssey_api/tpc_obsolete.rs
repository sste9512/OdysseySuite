use byteorder::{LittleEndian, ReadBytesExt};
use serde::Serialize;
use std::io::{Cursor, Read};

#[derive(Debug, Serialize)]
pub struct TpcData {
    pub width: u32,
    pub height: u32,
    pub pixels: Vec<u8>,
    pub encoding_type: u8,
    pub mipmap_count: u8,
}

#[derive(Debug)]
struct TpcHeader {
    pub size: u32,
    pub unknown_float: f32,
    pub width: u16,
    pub height: u16,
    pub encoding_type: u8,
    pub mipmap_count: u8,
}

pub fn decode_dxt1_block(
    data: &[u8],
    output: &mut [u8],
    width: u32,
    x: u32,
    y: u32,
) -> Result<(), String> {
    let color0 = u16::from_le_bytes([data[0], data[1]]);
    let color1 = u16::from_le_bytes([data[2], data[3]]);

    // Extract RGB components
    let r0 = ((color0 >> 11) & 0x1F) << 3;
    let g0 = ((color0 >> 5) & 0x3F) << 2;
    let b0 = (color0 & 0x1F) << 3;

    let r1 = ((color1 >> 11) & 0x1F) << 3;
    let g1 = ((color1 >> 5) & 0x3F) << 2;
    let b1 = (color1 & 0x1F) << 3;

    let colors = [
        [r0 as u8, g0 as u8, b0 as u8, 255],
        [r1 as u8, g1 as u8, b1 as u8, 255],
        [
            ((2 * r0 + r1) / 3) as u8,
            ((2 * g0 + g1) / 3) as u8,
            ((2 * b0 + b1) / 3) as u8,
            255,
        ],
        [
            ((r0 + 2 * r1) / 3) as u8,
            ((g0 + 2 * g1) / 3) as u8,
            ((b0 + 2 * b1) / 3) as u8,
            255,
        ],
    ];

    let indices = u32::from_le_bytes([data[4], data[5], data[6], data[7]]);

    for by in 0..4 {
        for bx in 0..4 {
            let idx = ((indices >> (2 * (4 * by + bx))) & 0x3) as usize;
            let px = x + bx;
            let py = y + by;
            if px < width && py < width {
                let pixel_idx = (py * width + px) as usize * 4;
                output[pixel_idx..pixel_idx + 4].copy_from_slice(&colors[idx]);
            }
        }
    }

    Ok(())
}

pub async fn decode_tpc_data_from_bytes(data: Vec<u8>) -> Result<TpcData, String> {
    let mut cursor = Cursor::new(&data);
    
    // Skip signature (4 bytes)
    cursor.set_position(4);
    
    // Read header
    let _data_size = cursor.read_u32::<LittleEndian>().map_err(|e| e.to_string())?;
    let width = cursor.read_u16::<LittleEndian>().map_err(|e| e.to_string())? as u32;
    let height = cursor.read_u16::<LittleEndian>().map_err(|e| e.to_string())? as u32;
    let encoding = cursor.read_u32::<LittleEndian>().map_err(|e| e.to_string())?;
    
    // Skip to pixel data (offset 128)
    cursor.set_position(128);
    
    let pixels = match encoding {
        0 => {
            let mut pixels = vec![0u8; (width * height * 4) as usize];
            cursor.read_exact(&mut pixels).map_err(|e| e.to_string())?;
            pixels
        },
        2 => {
            let mut output = vec![0u8; (width * height * 4) as usize];
            let block_count_x = (width + 3) / 4;
            let block_count_y = (height + 3) / 4;
            
            for by in 0..block_count_y {
                for bx in 0..block_count_x {
                    let mut block = [0u8; 8];
                    cursor.read_exact(&mut block).map_err(|e| e.to_string())?;
                    decode_dxt1_block(&block, &mut output, width, bx * 4, by * 4)?;
                }
            }
            output
        },
        _ => return Err(format!("Unsupported encoding type: {}", encoding))
    };
    
    Ok(TpcData {
        width,
        height,
        pixels,
        encoding_type: encoding as u8,
        mipmap_count: 1,
    })
}

fn decode_dxt_colors(color0: u16, color1: u16) -> [[u8; 4]; 4] {
    let r0 = (((color0 >> 11) & 0x1F) * 255 + 15) / 31;
    let g0 = (((color0 >> 5) & 0x3F) * 255 + 31) / 63;
    let b0 = ((color0 & 0x1F) * 255 + 15) / 31;
    
    let r1 = (((color1 >> 11) & 0x1F) * 255 + 15) / 31;
    let g1 = (((color1 >> 5) & 0x3F) * 255 + 31) / 63;
    let b1 = ((color1 & 0x1F) * 255 + 15) / 31;
    
    let mut colors = [[0u8; 4]; 4];
    colors[0] = [r0 as u8, g0 as u8, b0 as u8, 255];
    colors[1] = [r1 as u8, g1 as u8, b1 as u8, 255];
    
    if color0 > color1 {
        colors[2] = [
            ((2 * r0 + r1) / 3) as u8,
            ((2 * g0 + g1) / 3) as u8,
            ((2 * b0 + b1) / 3) as u8,
            255,
        ];
        colors[3] = [
            ((r0 + 2 * r1) / 3) as u8,
            ((g0 + 2 * g1) / 3) as u8,
            ((b0 + 2 * b1) / 3) as u8,
            255,
        ];
    } else {
        colors[2] = [
            ((r0 + r1) / 2) as u8,
            ((g0 + g1) / 2) as u8,
            ((b0 + b1) / 2) as u8,
            255,
        ];
        colors[3] = [0, 0, 0, 0];
    }
    
    colors
}

pub fn decode_dxt5_block(
    data: &[u8],
    output: &mut [u8],
    width: u32,
    x: u32,
    y: u32,
) -> Result<(), String> {
    // Read alpha values
    let alpha0 = data[0];
    let alpha1 = data[1];

    // Create alpha lookup table
    let mut alpha_table = [0u8; 8];
    alpha_table[0] = alpha0;
    alpha_table[1] = alpha1;

    if alpha0 > alpha1 {
        // 8-alpha block: derive 6 intermediate alphas
        for i in 2..8 {
            alpha_table[i] =
                (((8 - i) as u16 * alpha0 as u16 + (i - 1) as u16 * alpha1 as u16) / 7) as u8;
        }
    } else {
        // 6-alpha block: derive 4 intermediate alphas, plus 0 and 255
        for i in 2..6 {
            alpha_table[i] =
                (((6 - i) as u16 * alpha0 as u16 + (i - 1) as u16 * alpha1 as u16) / 5) as u8;
        }
        alpha_table[6] = 0;
        alpha_table[7] = 255;
    }

    // Read alpha indices (3 bits per pixel)
    let alpha_indices =
        u64::from_le_bytes([data[2], data[3], data[4], data[5], data[6], data[7], 0, 0]);

    // Handle color part (DXT1 format starting at byte 8)
    let color0 = u16::from_le_bytes([data[8], data[9]]);
    let color1 = u16::from_le_bytes([data[10], data[11]]);
    let color_indices = u32::from_le_bytes([data[12], data[13], data[14], data[15]]);

    // Decode colors
    let colors = decode_dxt_colors(color0, color1);

    // Write pixels
    for by in 0..4 {
        for bx in 0..4 {
            let px = x + bx;
            let py = y + by;
            if px < width && py < width {
                let pixel_pos = ((py * width + px) * 4) as usize;
                if pixel_pos + 3 < output.len() && pixel_pos < output.len() {
                    // Get alpha index (3 bits)
                    let alpha_shift = 3 * (4 * by + bx);
                    let alpha_idx = ((alpha_indices >> alpha_shift) & 0x7) as usize;

                    // Get color index (2 bits)
                    let color_shift = 2 * (4 * by + bx);
                    let color_idx = ((color_indices >> color_shift) & 0x3) as usize;

                    // Write RGB from color table
                    output[pixel_pos..pixel_pos + 3].copy_from_slice(&colors[color_idx][..3]);
                    // Write alpha from alpha table
                    output[pixel_pos + 3] = alpha_table[alpha_idx];
                }
            }
        }
    }

    Ok(())
}

pub fn read_tpc_header(cursor: &mut Cursor<&Vec<u8>>) -> Result<TpcHeader, String> {
    let size = cursor
        .read_u32::<LittleEndian>()
        .map_err(|e| e.to_string())?;
    let unknown_float = cursor
        .read_f32::<LittleEndian>()
        .map_err(|e| e.to_string())?;
    let width = cursor
        .read_u16::<LittleEndian>()
        .map_err(|e| e.to_string())?;
    let height = cursor
        .read_u16::<LittleEndian>()
        .map_err(|e| e.to_string())?;
    let encoding_type = cursor.read_u8().map_err(|e| e.to_string())?;
    let mipmap_count = cursor.read_u8().map_err(|e| e.to_string())?;

    Ok(TpcHeader {
        size,
        unknown_float,
        width,
        height,
        encoding_type,
        mipmap_count,
    })
}

pub fn decode_dxt1(
    cursor: &mut Cursor<&Vec<u8>>,
    width: u32,
    height: u32,
) -> Result<Vec<u8>, String> {
    let mut output = vec![0u8; (width * height * 4) as usize];

    for y in (0..height).step_by(4) {
        for x in (0..width).step_by(4) {
            let mut block = [0u8; 8];
            cursor.read_exact(&mut block).map_err(|e| e.to_string())?;
            decode_dxt1_block(&block, &mut output, width, x, y)?;
        }
    }

    Ok(output)
}

pub fn decode_dxt5(
    cursor: &mut Cursor<&Vec<u8>>,
    width: u32,
    height: u32,
) -> Result<Vec<u8>, String> {
    let mut output = vec![0u8; (width * height * 4) as usize];

    for y in (0..height).step_by(4) {
        for x in (0..width).step_by(4) {
            let mut block = [0u8; 16];
            cursor.read_exact(&mut block).map_err(|e| e.to_string())?;
            decode_dxt5_block(&block, &mut output, width, x, y)?;
        }
    }

    Ok(output)
}
