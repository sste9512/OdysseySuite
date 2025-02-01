use std::collections::HashMap;
use std::sync::Mutex;
use crate::domain::odyssey_api::txi;
use crate::domain::odyssey_api::txi::TXI;

const TPC_HEADER_LENGTH: usize = 128;

pub struct TPCOptions {
    pub file: Option<Vec<u8>>,
    pub filename: Option<String>,
    pub pack: Option<u32>,// possibly irrelevant
}

pub struct TPCHeader {
    pub data_size: u32,
    pub alpha_test: f32,
    pub width: u16,
    pub height: u16,
    pub encoding: TPCEncoding,
    pub mip_map_count: u8,
    pub bytes_per_pixel: u8,
    pub bits_per_pixel: u8,
    pub min_data_size: u32,
    pub compressed: bool,
    pub has_alpha: bool,
    pub format: PixelFormat,
    pub is_cubemap: bool,
    pub faces: u8,
}

#[derive(Debug, Copy, Clone)]
pub enum TPCEncoding {
    GRAY = 1,
    RGB = 2,
    RGBA = 4,
    BGRA = 12,
}

pub struct OdysseyCompressedTexture {
    pub width: u32,
    pub height: u32,
    pub mipmaps: Vec<ImageData>,
    pub flip_y: bool,
    pub generate_mipmaps: bool,
}

pub enum PixelFormat {
    R8G8B8 = 1,
    B8G8R8 = 2,
    R8G8B8A8 = 3,
    B8G8R8A8 = 4,
    A1R5G5B5 = 5,
    R5G6B5 = 6,
    Depth16 = 7,
    DXT1 = 8,
    DXT3 = 9,
    DXT5 = 10,
}


/// Represents a TPC (Texture Package Container) file containing texture data.
///
/// The `TPC` structure is designed to handle texture file data, including metadata, pixel data,
/// and TXI (Texture Extended Information). It provides methods to extract and manipulate
/// TPC texture information and operations used in rendering pipelines.
///
/// # Fields
/// - `header`:
///     A [`TPCHeader`] struct that contains metadata information about the TPC file such as width, height, encoding, mipmaps, and more.
/// - `txi`:
///     A [`TXI`] struct that stores extended texture information extracted from the file.
/// - `file`:
///     Raw binary data of the TPC file.
/// - `filename`:
///     Name of the TPC file.
/// - `pack`:
///     Additional metadata, possibly irrelevant to the core TPC functionality.
/// - `canvas`:
///     A thread-safe [`Mutex`] wrapping a [`HashMap<usize, Vec<u8>>`] used to store processed or manipulated texture data in memory.
///
/// # Usage
///
/// To create a new `TPC` instance, use the `new` method with the [`TPCOptions`] struct, providing relevant optional fields.
///
/// ```
/// let options = TPCOptions {
///     file: Some(vec![/* TPC file data as bytes */]),
///     filename: Some(String::from("example.tpc")),
///     pack: Some(123),
/// };
/// let tpc = TPC::new(options);
/// ```
///
/// # Methods
///
/// ## `TPC::new`
///
/// Creates a new `TPC` instance by reading the TPC header, extracting TXI data, and initializing internal fields.
///
/// ## `TPC::read_header`
///
/// Reads the metadata header from the given TPC file and produces a [`TPCHeader`] struct with extracted information.
///
/// ## `TPC::get_txi_data`
///
/// Extracts the TXI data as a string from the TPC file, using offsets and lengths calculated based on the header.
///
/// ## `TPC::get_data_length`
///
/// Calculates the total data length of the TPC file, factoring in compression, mipmaps, and cubemap faces.
///
/// ## `TPC::flip_y`
///
/// Flips the provided pixel data vertically, commonly used for rendering operations where the texture's Y-axis orientation must be adjusted.
///
/// # Examples
///
///
/// let options = TPCOptions {
///     file: Some(vec![/* binary data */]),
///     filename: Some(String::from("sample_texture.tpc")),
///     pack: None,
/// };
/// let texture = TPC::new(options);
///
/// let header = texture.header;
/// println!("Width: {}, Height: {}", header.width, header.height);
///
/// let flipped_data = TPC::flip_y(vec![/* pixel data */], &header);
/// println!("Flipped pixel data: {:?}", flipped_data);
///
pub struct TPC {
    pub header: TPCHeader,
    pub txi: TXI,
    pub file: Vec<u8>,
    pub filename: String,
    pub pack: u32,
    pub canvas: Mutex<HashMap<usize, Vec<u8>>>,
}


impl TPC {
    pub fn new(args: TPCOptions) -> TPC {
        let default = TPCOptions {
            file: None,
            filename: None,
            pack: None,
        };

        let file = args.file.unwrap_or(default.file.unwrap_or_else(Vec::new));
        let filename = args.filename.unwrap_or(default.filename.unwrap_or_else(String::new));
        let pack = args.pack.unwrap_or(default.pack.unwrap_or(0));
        let header = TPC::read_header(&file);
        let txi = txi::new(TPC::get_txi_data(&file, &header));

        TPC {
            header,
            txi,
            file,
            filename,
            pack,
            canvas: Mutex::new(HashMap::new()),
        }
    }

    pub fn get_txi_data(file: &Vec<u8>, header: &TPCHeader) -> String {
        let txi_offset = (TPC::get_data_length(&header) + TPC_HEADER_LENGTH) as usize;
        let txi_data_length = file.len() - txi_offset;

        if txi_data_length > 0 {
            let txi_data = &file[txi_offset..txi_offset + txi_data_length];
            return String::from_utf8(txi_data.to_vec()).unwrap_or_default();
        }

        String::new()
    }

    pub fn read_header(file: &Vec<u8>) -> TPCHeader {
        let mut header = TPCHeader {
            data_size: 0,
            alpha_test: 0.0,
            width: 0,
            height: 0,
            encoding: TPCEncoding::GRAY,
            mip_map_count: 1,
            bytes_per_pixel: 4,
            bits_per_pixel: 32,
            min_data_size: 0,
            compressed: false,
            has_alpha: false,
            format: PixelFormat::R8G8B8A8,
            is_cubemap: false,
            faces: 1,
        };

        header.width = u16::from_le_bytes([file[2], file[3]]);
        header.height = u16::from_le_bytes([file[4], file[5]]);
        header.encoding = match file[6] {
            1 => TPCEncoding::GRAY,
            2 => TPCEncoding::RGB,
            4 => TPCEncoding::RGBA,
            12 => TPCEncoding::BGRA,
            _ => TPCEncoding::GRAY,
        };

        header.mip_map_count = file[7];
        header
    }

    pub fn get_data_length(header: &TPCHeader) -> usize {
        let mut data_length = 0;

        for _face in 0..header.faces {
            let mut width = header.width as usize;
            let mut height = header.height as usize;
            let mut data_size = header.data_size as usize;

            for _mip in 0..header.mip_map_count {
                if !header.compressed {
                    data_length += width * height * header.bytes_per_pixel as usize;
                } else {
                    data_length += data_size;
                }

                width = std::cmp::max(width >> 1, 1);
                height = std::cmp::max(height >> 1, 1);
                data_size = std::cmp::max(data_size >> 2, header.min_data_size as usize);
            }
        }

        data_length
    }

    pub fn flip_y(pixel_data: Vec<u8>, header: &TPCHeader) -> Vec<u8> {
        let stride = (header.width as usize) * 4;
        let mut flipped_data = vec![0; pixel_data.len()];

        for (n, row) in pixel_data.chunks(stride).enumerate() {
            let y_offset = (pixel_data.len() - ((n + 1) * stride)) as usize;
            flipped_data[y_offset..y_offset + stride].copy_from_slice(row);
        }

        flipped_data
    }
}





pub struct ImageData {
    pub data: Vec<u8>,
    pub width: u32,
    pub height: u32,
}