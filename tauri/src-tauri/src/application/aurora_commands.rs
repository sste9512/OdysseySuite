use serde_json::Value;
use std::io::BufReader;
use std::{fs::File, path::Path};

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
        println!("BIF {}: {} (size: {} bytes)", i, name, entry.file_size);
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
