use serde_json::Value;
use std::io::{BufReader, Cursor};
use std::{fs::File, path::Path};

use crate::domain::odyssey_api::tpc::TPC;
use byteorder::{LittleEndian, ReadBytesExt};
use std::io::{self, Read, Seek, SeekFrom};

use crate::domain::odyssey_api::{
    biff::Biff,
    chitin::{ChitinKey, ChitinKeyReader},
    erf::ErfFile,
    rim::Rim,
    twoda::TwoDaFile,
};

use serde::{Deserialize, Serialize};
use std::time::SystemTime;

#[derive(Serialize, Deserialize)]
struct ResourceFile {
    filepath: String,
    filename: String,
    resource_count: i32,
    file_size: i64,
    last_modified: String,
    file_type: String,
}
// #[derive(Serialize, Deserialize)]
// struct ResourceFile<T> {
//     filepath: String,
//     filename: String,
//     resource_count: i32,
//     file_size: i64,
//     last_modified: String,
//     file_type: String,
//     data: T
// }
// #[tauri::command]
// pub async fn scan_and_store_resources(db_runtime: tauri::State<'_, SurrealDbRuntime>, path: String) -> Result<(), String> {
//     let db = match db_runtime.get_db() {
//         Some(db) => db,
//         None => return Err("Database not initialized".to_string())
//     };

//     // Scan for resource files
//     let paths = std::fs::read_dir(&path).map_err(|e| e.to_string())?;

//     for path in paths {
//         let path = path.map_err(|e| e.to_string())?.path();
//         let metadata = std::fs::metadata(&path).map_err(|e| e.to_string())?;

//         // Get last modified time
//         let last_modified = metadata.modified().map_err(|e| e.to_string())?;
//         let last_modified = last_modified.duration_since(SystemTime::UNIX_EPOCH)
//             .map_err(|e| e.to_string())?
//             .as_secs()
//             .to_string();

//         let filepath = path.to_str().ok_or("Invalid path")?;
//         let filename = path.file_name()
//             .ok_or("No filename")?
//             .to_str()
//             .ok_or("Invalid filename")?
//             .to_string();

//         // Check file extension and process accordingly
//         if let Some(extension) = path.extension() {
//             match extension.to_str() {
//                 Some("bif") => {
//                     if let Ok(biff) = Biff::read_biff_file(filepath) {
//                         let resource = ResourceFile {
//                             filepath: filepath.to_string(),
//                             filename,
//                             resource_count: biff.header.variable_resource_count as i32,
//                             file_size: metadata.len() as i64,
//                             last_modified,
//                             file_type: "bif".to_string()
//                         };
//                         db.create(("resource_files", &filepath))
//                             .content(resource)
//                             .await
//                             .map_err(|e| e.to_string())?;
//                     }
//                 },
//                 Some("rim") => {
//                     if let Ok(rim) = Rim::read_from_file(filepath) {
//                         let resource = ResourceFile {
//                             filepath: filepath.to_string(),
//                             filename,
//                             resource_count: rim.entry_count as i32,
//                             file_size: metadata.len() as i64,
//                             last_modified,
//                             file_type: "rim".to_string()
//                         };
//                         db.create(("resource_files", &filepath))
//                             .content(resource)
//                             .await
//                             .map_err(|e| e.to_string())?;
//                     }
//                 },
//                 Some("erf") => {
//                     if let Ok(erf) = ErfFile::read_from_file(filepath) {
//                         let resource = ResourceFile {
//                             filepath: filepath.to_string(),
//                             filename,
//                             resource_count: erf.header.entry_count as i32,
//                             file_size: metadata.len() as i64,
//                             last_modified,
//                             file_type: "erf".to_string()
//                         };
//                         db.create(("resource_files", &filepath))
//                             .content(resource)
//                             .await
//                             .map_err(|e| e.to_string())?;
//                     }
//                 },
//                 Some("key") => {
//                     if let Ok(file) = File::open(filepath) {
//                         let mut reader = BufReader::new(file);
//                         if let Ok(key) = ChitinKey::read_chitin_key(&mut reader) {
//                             let resource = ResourceFile {
//                                 filepath: filepath.to_string(),
//                                 filename,
//                                 resource_count: key.header.key_count as i32,
//                                 file_size: metadata.len() as i64,
//                                 last_modified,
//                                 file_type: "key".to_string()
//                             };
//                             db.create(("resource_files", &filepath))
//                                 .content(resource)
//                                 .await
//                                 .map_err(|e| e.to_string())?;
//                         }
//                     }
//                 },
//                 _ => continue
//             }
//         }
//     }

//     Ok(())
// }

#[tauri::command]
pub async fn read_chitin_key(path: &str) -> Result<Value, String> {
    // Open the chitin.key file (typically found in your game directory)
    let file = match File::open(path) {
        Ok(f) => f,
        Err(e) => {
            println!("Error opening chitin.key: {}", e);
            return Err(e.to_string());
        }
    };

    let mut reader = BufReader::new(file);
    // Read the entire chitin key structure
    let chitin_key = match ChitinKey::read_chitin_key(&mut reader) {
        Ok(key) => key,
        Err(e) => {
            println!("Error reading chitin.key: {}", e);
            return Err(e.to_string());
        }
    };

    // Print basic information
    println!("BIF files count: {}", chitin_key.header.bif_count);
    println!("Total resources: {}", chitin_key.header.key_count);
    println!(
        "Build date: Year {} Day {}",
        chitin_key.header.build_year, chitin_key.header.build_day
    );

    // Print information about each resource file
    for (i, (entry, name)) in chitin_key
        .file_entries
        .iter()
        .zip(chitin_key.filenames.iter())
        .enumerate()
    {
        println!(
            "BIF {}: {} (size: {} bytes)",
            i, name.filename, entry.file_size
        );
    }

    // Print some resource entries
    for entry in chitin_key.key_entries.iter().take(20) {
        let resref: String = entry.resref.iter().collect();
        println!(
            "Resource: {} (Type: {}, ID: {})",
            resref.trim_end_matches('\0'),
            entry.resource_type,
            entry.res_id
        );
    }
    Ok(serde_json::to_value(&chitin_key).unwrap())
}

#[tauri::command]
pub fn extract_biff_resource(
    biff_path: &str,
    resource_id: u32,
    output_path: &str,
) -> Result<(), String> {
    // Read the BIFF file
    let biff = match Biff::read_biff_file(biff_path) {
        Ok(b) => b,
        Err(e) => {
            println!("Error reading BIFF file: {}", e);
            return Err(e.to_string());
        }
    };

    // Find the resource entry
    let resource_data = match biff.read_resource_data(resource_id) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading resource data: {}", e);
            return Err(e.to_string());
        }
    };

    // Write the resource data to file
    match std::fs::write(output_path, resource_data) {
        Ok(_) => {
            println!(
                "Successfully wrote resource {} to {}",
                resource_id, output_path
            );
            Ok(())
        }
        Err(e) => {
            println!("Error writing resource data to file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn read_model_files(
    file_path: &str,
    mdl_id: u32,
    mdx_id: u32,
) -> Result<(Vec<u8>, Vec<u8>), String> {
    // Try to detect file type from extension
    let file_type = if file_path.to_lowercase().ends_with(".bif") {
        "BIFF"
    } else if file_path.to_lowercase().ends_with(".rim") {
        "RIM"
    } else if file_path.to_lowercase().ends_with(".erf") {
        "ERF"
    } else {
        return Err("Unsupported file type. Must be BIFF, RIM or ERF".to_string());
    };

    // Read the MDL and MDX data based on file type
    match file_type {
        "BIFF" => {
            let biff = match Biff::read_biff_file(file_path) {
                Ok(b) => b,
                Err(e) => return Err(format!("Error reading BIFF file: {}", e)),
            };

            let mdl_data = match biff.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDL data: {}", e)),
            };

            let mdx_data = match biff.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDX data: {}", e)),
            };

            Ok((mdl_data, mdx_data))
        }
        "RIM" => {
            let rim = match Rim::read_from_file(file_path) {
                Ok(r) => r,
                Err(e) => return Err(format!("Error reading RIM file: {}", e)),
            };

            let mdl_data = match rim.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDL data: {}", e)),
            };

            let mdx_data = match rim.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDX data: {}", e)),
            };

            Ok((mdl_data, mdx_data))
        }
        "ERF" => {
            let erf = match ErfFile::read_from_file(file_path) {
                Ok(e) => e,
                Err(e) => return Err(format!("Error reading ERF file: {}", e)),
            };

            let mdl_data = match erf.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDL data: {}", e)),
            };

            let mdx_data = match erf.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => return Err(format!("Error reading MDX data: {}", e)),
            };

            Ok((mdl_data, mdx_data))
        }
        _ => Err("Unsupported file type".to_string()),
    }
}

#[tauri::command]
pub fn read_biff(path: &str) -> Result<Biff, String> {
    // Read the BIFF file
    match Biff::read_biff_file(path) {
        Ok(biff) => Ok(biff),
        Err(e) => {
            println!("Error reading BIFF file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn read_erf(path: &str) -> Result<ErfFile, String> {
    match ErfFile::read_from_file(path) {
        Ok(erf) => {
            println!("Successfully loaded ERF file");
            println!("Number of resources: {}", erf.header.entry_count);
            println!("Number of languages: {}", erf.header.language_count);
            Ok(erf)
        }
        Err(e) => {
            println!("Error loading ERF file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn get_erf_resource_data(filepath: &str, resource_id: u32) -> Result<Vec<u8>, String> {
    match ErfFile::read_from_file(filepath) {
        Ok(erf) => match erf.read_resource_data(resource_id) {
            Ok(data) => {
                println!("Successfully read resource data for ID: {}", resource_id);
                Ok(data)
            }
            Err(e) => {
                println!("Error reading resource data: {}", e);
                Err(e.to_string())
            }
        },
        Err(e) => {
            println!("Error loading ERF file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn extract_erf_resource(
    erf_path: &str,
    resource_id: u32,
    output_path: &str,
) -> Result<(), String> {
    // Read the ERF file
    let erf = match ErfFile::read_from_file(erf_path) {
        Ok(erf) => erf,
        Err(e) => {
            println!("Error loading ERF file: {}", e);
            return Err(e.to_string());
        }
    };

    // Get the resource data
    let data = match erf.read_resource_data(resource_id) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading resource data: {}", e);
            return Err(e.to_string());
        }
    };

    // Write the data to the output file
    match std::fs::write(output_path, data) {
        Ok(_) => {
            println!(
                "Successfully extracted resource {} to {}",
                resource_id, output_path
            );
            Ok(())
        }
        Err(e) => {
            println!("Error writing resource data to file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn extract_rim_resource(
    rim_path: &str,
    resource_id: u32,
    output_path: &str,
) -> Result<(), String> {
    // Read the RIM file
    let file_data = match std::fs::read(rim_path) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading RIM file: {}", e);
            return Err(format!("Error reading RIM file: {}", e));
        }
    };

    let rim = Rim::new(file_data);

    // Get the resource data
    let data = match rim.read_resource_data(resource_id) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading resource data: {}", e);
            return Err(e.to_string());
        }
    };

    // Write the data to the output file
    match std::fs::write(output_path, data) {
        Ok(_) => {
            println!(
                "Successfully extracted resource {} to {}",
                resource_id, output_path
            );
            Ok(())
        }
        Err(e) => {
            println!("Error writing resource data to file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn read_rim(path: &str) -> Result<Rim, String> {
    if !Path::new(path).exists() {
        println!("RIM file does not exist at path: {}", path);
        return Err(format!("RIM file does not exist at path: {}", path));
    }

    let file_data = match std::fs::read(path) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading RIM file: {}", e);
            return Err(format!("Error reading RIM file: {}", e));
        }
    };

    let rim = Rim::new(file_data);
    println!("Successfully loaded RIM file");
    println!("Entry count: {}", rim.entry_count);
    Ok(rim)
}

#[tauri::command]
pub fn read_twoda(path: &str) -> Result<TwoDaFile, String> {
    if !Path::new(path).exists() {
        println!("TWODA file does not exist at path: {}", path);
        return Err(format!("TWODA file does not exist at path: {}", path));
    }

    let file_data = match std::fs::read(path) {
        Ok(data) => data,
        Err(e) => {
            println!("Error reading TWODA file: {}", e);
            return Err(format!("Error reading TWODA file: {}", e));
        }
    };

    let twoda = TwoDaFile::read_from_file(path);
    match twoda {
        Ok(two) => {
            println!("Successfully loaded TWODA file");
            Ok(two)
        }
        Err(e) => {
            println!("Error loading TWODA file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn read_twoda_from_name(chitin_path: &str, file_name: &str) -> Result<TwoDaFile, String> {
    // First we need to get the chitin.key path and read it
    // Then search for the 2DA file by name in the key entries
    // Finally extract and parse the 2DA data

    // This function needs the chitin.key path and the game directory to work
    // For now, we'll assume the caller provides the raw data
    // You'll need to modify this to accept the chitin path or use a cached version

    let file_name_lower = file_name.to_lowercase();
    let search_name = if file_name_lower.ends_with(".2da") {
        file_name_lower.trim_end_matches(".2da")
    } else {
        &file_name_lower
    };

    // Note: This requires access to the chitin.key file path
    // You may want to store this in app state or pass it as a parameter
    return Err(
        "read_twoda_from_name requires chitin.key path - please use read_twoda_from_chitin instead"
            .to_string(),
    );

    // Example of how this would work with chitin.key access:; // You need to implement this
    let mut file = File::open(&chitin_path).map_err(|e| e.to_string())?;
    let mut reader = BufReader::new(&mut file);
    let chitin_key = ChitinKey::read_chitin_key(&mut reader).map_err(|e| e.to_string())?;

    let data = chitin_key
        .extract_resource_by_name(&mut reader, search_name)
        .map_err(|e| e.to_string())?
        .ok_or_else(|| format!("Resource '{}' not found in chitin.key", file_name))?;

    let twoda = TwoDaFile::read_from_bytes(data);
    match twoda {
        Ok(two) => {
            println!("Successfully loaded TWODA file from bytes");
            Ok(two)
        }
        Err(e) => {
            println!("Error loading TWODA file from bytes: {}", e);
            Err(e.to_string())
        }
    }
}
