use byteorder::{LittleEndian, ReadBytesExt};
use std::io::{Cursor, Read, Seek, SeekFrom};

pub struct OdysseyModelUtility;

// impl OdysseyModelUtility {
//     pub fn read_array(
//         stream: &mut Cursor<Vec<u8>>,
//         offset: u32,
//         count: u32,
//     ) -> Result<Vec<u32>, String> {
//         let pos_cache = stream.position();
//         stream
//             .seek(SeekFrom::Start(offset as u64))
//             .map_err(|e| e.to_string())?;

//         let mut values = Vec::with_capacity(count as usize);
//         for _ in 0..count {
//             values.push(
//                 stream
//                     .read_u32::<LittleEndian>()
//                     .map_err(|e| e.to_string())?,
//             );
//         }

//         stream
//             .seek(SeekFrom::Start(pos_cache))
//             .map_err(|e| e.to_string())?;
//         Ok(values)
//     }

//     pub fn read_array_floats(
//         stream: &mut Cursor<Vec<u8>>,
//         offset: u32,
//         count: u32,
//     ) -> Result<Vec<f32>, String> {
//         let pos_cache = stream.position();
//         stream
//             .seek(SeekFrom::Start(offset as u64))
//             .map_err(|e| e.to_string())?;

//         let mut values = Vec::with_capacity(count as usize);
//         for _ in 0..count {
//             values.push(
//                 stream
//                     .read_f32::<LittleEndian>()
//                     .map_err(|e| e.to_string())?,
//             );
//         }

//         stream
//             .seek(SeekFrom::Start(pos_cache))
//             .map_err(|e| e.to_string())?;
//         Ok(values)
//     }

//     pub fn read_array_definition(
//         stream: &mut Cursor<Vec<u8>>,
//     ) -> Result<OdysseyArrayDefinition, String> {
//         Ok(OdysseyArrayDefinition {
//             offset: stream
//                 .read_u32::<LittleEndian>()
//                 .map_err(|e| e.to_string())?
//                 & 0xFFFFFFFF,
//             count: stream
//                 .read_u32::<LittleEndian>()
//                 .map_err(|e| e.to_string())?
//                 & 0xFFFFFFFF,
//             count2: stream
//                 .read_u32::<LittleEndian>()
//                 .map_err(|e| e.to_string())?
//                 & 0xFFFFFFFF,
//         })
//     }

//     pub fn read_strings(
//         stream: &mut Cursor<Vec<u8>>,
//         offsets: &[u32],
//         base_offset: u32,
//     ) -> Result<Vec<String>, String> {
//         let pos_cache = stream.position();
//         let mut strings = Vec::with_capacity(offsets.len());

//         for &offset in offsets {
//             stream
//                 .seek(SeekFrom::Start((base_offset + offset) as u64))
//                 .map_err(|e| e.to_string())?;

//             let mut string = String::new();
//             loop {
//                 let char = stream.read_u8().map_err(|e| e.to_string())?;
//                 if char == 0 {
//                     break;
//                 }
//                 string.push(char as char);
//             }

//             strings.push(string);
//         }

//         stream
//             .seek(SeekFrom::Start(pos_cache))
//             .map_err(|e| e.to_string())?;
//         Ok(strings)
//     }
// }
