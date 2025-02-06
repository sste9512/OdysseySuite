#[cfg(test)]
mod tests {
        use super::*;
        use std::sync::Mutex;

        /// Creates a dummy TPCHeader for testing.
        fn create_dummy_header() -> TPCHeader {
        TPCHeader {
            data_size: 128,
            alpha_test: 0.5,
            width: 256,
            height: 128,
            encoding: TPCEncoding::RGBA,
            mip_map_count: 4,
            bytes_per_pixel: 4,
            bits_per_pixel: 32,
            min_data_size: 1024,
            compressed: false,
            has_alpha: true,
            format: PixelFormat::R8G8B8A8,
            is_cubemap: false,
            faces: 1,
        }
    }

    /// Creates a dummy TPC file with fake data for testing.
    fn create_dummy_tpc_file() -> Vec < u8 > {
        let mut file: Vec < u8 > = Vec::new();

        // Adding fake header data.
        file.extend( &[0, 0]); // Reserved bytes
        file.extend( & (256 as u16).to_le_bytes()); // Width
        file.extend( & (128 as u16).to_le_bytes()); // Height
        file.push(4); // Encoding (RGBA)
        file.push(3); // Mipmap count
        file.resize(64, 0); // Fill remaining header bytes

        // Adding fake data.
        file.resize(64 + 128, 255); // Simulating texture data size
        file.extend("Dummy TXI Data".as_bytes()); // Adding fake TXI data

        file
    }

    # [test]
    fn test_new() {
        let file = create_dummy_tpc_file();
        let options = TPCOptions {
            file: Some(file.clone()),
            filename: Some("test_texture.tpc".to_string()),
            pack: Some(42),
        };

        let tpc = TPC::new(options);

        assert_eq ! (tpc.filename, "test_texture.tpc");
        assert_eq ! (tpc.pack, 42);
        assert_eq ! (tpc.file, file);
    }

    # [test]
    fn test_get_txi_data() {
        let file = create_dummy_tpc_file();
        let header = TPC::read_header( & file);

        let txi_data = TPC::get_txi_data( & file, & header);

        assert_eq ! (txi_data, "Dummy TXI Data");
    }

    # [test]
    fn test_read_header() {
        let file = create_dummy_tpc_file();
        let header = TPC::read_header( & file);

        assert_eq !(header.width, 256);
        assert_eq !(header.height, 128);
        assert_eq !(header.encoding, TPCEncoding::RGBA);
        assert_eq ! (header.mip_map_count, 3);
    }

    # [test]
    fn test_get_data_length() {
        let header = create_dummy_header();
        let data_length = TPC::get_data_length( & header);

        let expected_length = (header.width * header.height * header.bytes_per_pixel as u16) as usize;
        assert! (data_length >= expected_length); // The data length should be accurate
    }

    # [test]
    fn test_flip_y() {
        let original_data: Vec < u8 > = vec ![
            1, 2, 3, 4, 5, 6, 7, 8,
            9, 10, 11, 12, 13, 14, 15, 16
        ];
        let flipped_data = TPC::flip_y(original_data.clone(), & create_dummy_header());

        assert_eq ! (flipped_data.len(), original_data.len());
    }
}