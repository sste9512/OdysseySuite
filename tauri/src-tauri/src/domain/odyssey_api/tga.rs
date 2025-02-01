#[derive(Debug, Clone, Copy)]
pub enum TGAType {
    NoData = 0,
    Indexed = 1,
    RGB = 2,
    Grey = 3,
    RLEIndexed = 9,
    RLERGB = 10,
    RLEGrey = 11,
}

pub struct TGAHeader {
    id_length: u8,
    color_map_type: u8,
    image_type: TGAType,
    color_map_origin: u16,
    color_map_length: u16,
    color_map_depth: u8,
    x_origin: u16,
    y_origin: u16,
    width: u16,
    height: u16,
    bits_per_pixel: u8,
    image_descriptor: u8,
}

pub fn convert_tpc_to_tga(tpc_data: &[u8]) -> Result<Vec<u8>, String> {
    // Create TGA header
    let header = TGAHeader {
        id_length: 0,
        color_map_type: 0,
        image_type: TGAType::RGB,
        color_map_origin: 0,
        color_map_length: 0,
        color_map_depth: 0,
        x_origin: 0,
        y_origin: 0,
        width: 0,  // Set from TPC header
        height: 0, // Set from TPC header
        bits_per_pixel: 32,
        image_descriptor: 0x28, // Top-left origin, 8 bits alpha
    };

    let mut tga_data = Vec::new();

    // Write TGA header
    tga_data.extend_from_slice(&[
        header.id_length,
        header.color_map_type,
        header.image_type as u8,
        (header.color_map_origin & 0xFF) as u8,
        (header.color_map_origin >> 8) as u8,
        (header.color_map_length & 0xFF) as u8,
        (header.color_map_length >> 8) as u8,
        header.color_map_depth,
        (header.x_origin & 0xFF) as u8,
        (header.x_origin >> 8) as u8,
        (header.y_origin & 0xFF) as u8,
        (header.y_origin >> 8) as u8,
        (header.width & 0xFF) as u8,
        (header.width >> 8) as u8,
        (header.height & 0xFF) as u8,
        (header.height >> 8) as u8,
        header.bits_per_pixel,
        header.image_descriptor,
    ]);

    // Parse TPC data
    // TPC format typically includes:
    // - Header with width, height, mipmap count, etc.
    // - Compressed or uncompressed pixel data

    // Convert pixel data
    // TPC usually stores pixels in RGBA format
    // TGA expects BGRA format
    for pixel in tpc_data.chunks(4) {
        if pixel.len() == 4 {
            tga_data.push(pixel[2]); // Blue
            tga_data.push(pixel[1]); // Green
            tga_data.push(pixel[0]); // Red
            tga_data.push(pixel[3]); // Alpha
        }
    }

    // Add TGA footer
    tga_data.extend_from_slice(b"TRUEVISION-XFILE.\0");

    Ok(tga_data)
}

// Helper function to decompress TPC data if needed
fn decompress_tpc(data: &[u8]) -> Result<Vec<u8>, String> {
    // Implement decompression based on TPC compression format
    // TPC might use DXT1, DXT3, or DXT5 compression
    todo!("Implement TPC decompression")
}