// use clap::{ArgAction, Parser};
// use std::fs::File;
// use std::io::{self, Read, Seek};
// use std::path::Path;

// use crate::domain::odyssey_api::aurora::{detect_file_type, FileType};
// use crate::domain::odyssey_api::common::{FilePath, ReadFile, WriteFile};
// use crate::domain::odyssey_api::tga::TGA;
// use crate::domain::odyssey_api::tpc::TPC;
// use crate::domain::odyssey_api::dds::DDS;

// use super::decoder::images::Decoder;


// #[derive(Parser)]
// pub struct ConversionArgs {
//     input: String,
//     output: String,
//     auto: bool,
//     dds: bool,
//     sbm: bool,
//     tpc: bool,
//     txb: bool,
//     tga: bool,
//     flip: bool,
//     deswizzle: bool,
// }

// fn is_valid_type(file_type: FileType) -> bool {
//     matches!(
//         file_type,
//         FileType::DDS | FileType::SBM | FileType::TPC | FileType::TXB | FileType::TGA
//     )
// }

// fn detect_type_from_stream<R: Read + Seek>(file: &mut R) -> io::Result<FileType> {
//     if DDS::detect(file)? {
//         Ok(FileType::DDS)
//     } else {
//         Ok(FileType::None)
//     }
// }

// fn detect_type_from_path(path: &Path) -> FileType {
//     let file_type = detect_file_type(path);
//     if is_valid_type(file_type) {
//         file_type
//     } else {
//         FileType::None
//     }
// }

// fn open_image<R: Read + Seek>(
//     stream: R,
//     file_type: FileType,
//     deswizzle: bool,
// ) -> io::Result<Decoder> {
//     match file_type {
//         FileType::DDS => Ok(Box::new(DDS::new(stream)?)),
//         FileType::SBM => Ok(Box::new(SBM::new(stream, deswizzle)?)),
//         FileType::TPC => Ok(Box::new(TPC::new(stream)?)),
//         FileType::TXB => Ok(Box::new(TXB::new(stream)?)),
//         FileType::TGA => Ok(Box::new(TGA::new(stream)?)),
//         _ => Err(io::Error::new(
//             io::ErrorKind::InvalidData,
//             format!("Invalid image type {}", file_type as i32),
//         )),
//     }
// }

// fn convert(
//     input_path: &Path,
//     output_path: &Path,
//     file_type: FileType,
//     flip: bool,
//     deswizzle: bool,
// ) -> io::Result<()> {
//     let mut input = ReadFile::open(input_path)?;

//     let file_type = if file_type == FileType::None {
//         // Detect by file contents
//         let detected = detect_type_from_stream(&mut input)?;

//         if detected == FileType::None {
//             // Detect by file name
//             let detected = detect_type_from_path(input_path);

//             if detected == FileType::None {
//                 return Err(io::Error::new(
//                     io::ErrorKind::InvalidData,
//                     format!("Failed to detect type of file {:?}", input_path),
//                 ));
//             }
//             detected
//         } else {
//             detected
//         }
//     } else {
//         file_type
//     };

//     let mut image = open_image(input, file_type, deswizzle)?;

//     if flip {
//         image.flip_vertically();
//     }

//     image.dump_tga(&output_path.to_string_lossy().to_string());

//     if let Some(txi_data) = image.get_txi() {
//         let txi_path = FilePath::change_extension(output_path, "txi");
//         let mut txi_file = WriteFile::create(txi_path)?;
//         io::copy(&mut txi_data, &mut txi_file)?;
//     }


//     Ok(())
// }

// // fn main() -> io::Result<()> {
// //     let args = Args::parse();

// //     let file_type = if args.dds {
// //         FileType::DDS
// //     } else if args.sbm {
// //         FileType::SBM
// //     } else if args.tpc {
// //         FileType::TPC
// //     } else if args.txb {
// //         FileType::TXB
// //     } else if args.tga {
// //         FileType::TGA
// //     } else {
// //         FileType::None
// //     };

// //     convert(
// //         Path::new(&args.input),
// //         Path::new(&args.output),
// //         file_type,
// //         args.flip,
// //         args.deswizzle
// //     )
// // }
