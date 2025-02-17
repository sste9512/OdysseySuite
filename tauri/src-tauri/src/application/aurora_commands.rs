use serde_json::Value;
use std::io::{BufReader, Cursor};
use std::{fs::File, path::Path};
use serde::Serialize;
use std::io::{self, Read, Seek, SeekFrom};
use byteorder::{LittleEndian, ReadBytesExt};
use crate::domain::odyssey_api::tpc::TPC;


use crate::domain::odyssey_api::{
    biff::Biff,
    chitin::{ChitinKey, ChitinKeyReader},
    erf::ErfFile,
    rim::Rim,
};

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
        println!("BIF {}: {} (size: {} bytes)", i, name.filename, entry.file_size);
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
pub fn extract_biff_resource(biff_path: &str, resource_id: u32, output_path: &str) -> Result<(), String> {
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
            println!("Successfully wrote resource {} to {}", resource_id, output_path);
            Ok(())
        },
        Err(e) => {
            println!("Error writing resource data to file: {}", e);
            Err(e.to_string())
        }
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
        Ok(erf) => {
            match erf.read_resource_data(resource_id) {
                Ok(data) => {
                    println!("Successfully read resource data for ID: {}", resource_id);
                    Ok(data)
                }
                Err(e) => {
                    println!("Error reading resource data: {}", e);
                    Err(e.to_string())
                }
            }
        }
        Err(e) => {
            println!("Error loading ERF file: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub fn extract_erf_resource(erf_path: &str, resource_id: u32, output_path: &str) -> Result<(), String> {
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
            println!("Successfully extracted resource {} to {}", resource_id, output_path);
            Ok(())
        }
        Err(e) => {
            println!("Error writing resource data to file: {}", e);
            Err(e.to_string())
        }
    }
}


#[tauri::command]
pub fn extract_rim_resource(rim_path: &str, resource_id: u32, output_path: &str) -> Result<(), String> {
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
            println!("Successfully extracted resource {} to {}", resource_id, output_path);
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
