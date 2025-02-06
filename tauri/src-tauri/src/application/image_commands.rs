use std::fs::File;
use std::io::Write;

use crate::domain::odyssey_api::tpc::TPC;


#[tauri::command]
pub async fn get_tpc_from_file(path: String, offset: u32, size: u32) -> Result<TPC, String> {
    match std::fs::read(&path) {
        Ok(file_bytes) => {
            let file_bytes = file_bytes[offset as usize..(offset + size) as usize].to_vec();
            let tpc = TPC::new(crate::domain::odyssey_api::tpc::TPCOptions {
                file: Some(file_bytes),
                filename: Some(path),
                pack: None,
            });
            Ok(tpc)
        },
        Err(err) => Err(format!("Failed to read TPC file '{}': {}", path, err))
    }
}



#[tauri::command]
pub async fn convert_bytes_to_tpc(resource_data: Vec<u8>) -> Result<TPC, String> {
    Ok(TPC::new(crate::domain::odyssey_api::tpc::TPCOptions {
        file: Some(resource_data),
        filename: None,
        pack: None,
    }))
}

#[tauri::command]
pub async fn convert_file_to_tpc(path: String) -> Result<TPC, String> {
    match std::fs::read(&path) {
        Ok(bytes) => Ok(TPC::new(crate::domain::odyssey_api::tpc::TPCOptions {
            file: Some(bytes),
            filename: Some(path),
            pack: None,
        })),
        Err(err) => Err(format!("Failed to read file '{}': {}", path, err)),
    }
}

#[tauri::command]
pub async fn write_tpc_to_file(path: String, tpc_data: TPC) -> Result<(), String> {
    // Try to create/open the file for writing
    let mut file = match File::create(&path) {
        Ok(f) => f,
        Err(e) => return Err(format!("Failed to create file '{}': {}", path, e)),
    };
    // Write the TPC data to the file
    match file.write_all(&tpc_data.file) {
        Ok(_) => Ok(()),
        Err(e) => Err(format!("Failed to write TPC data to file: {}", e)),
    }
}

#[tauri::command]
pub async fn convert_tpc_to_dds(tpc_data: TPC) -> Result<Vec<u8>, String> {
    match tpc_data.to_dds() {
        Ok(dds_data) => Ok(dds_data),
        Err(e) => Err(format!("Failed to convert TPC to DDS: {}", e)),
    }
}

