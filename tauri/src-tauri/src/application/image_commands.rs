use std::fs::File;
use std::io::{Read, Seek, Write};

use crate::domain::odyssey_api::tpc::TPC;



#[tauri::command]
pub async fn get_tpc_bytes_from_file(path: String, offset: u32, size: u32) -> Result<Vec<u8>, String> {
    match std::fs::read(&path) {
        Ok(file_bytes) => Ok(file_bytes[offset as usize..(offset + size) as usize].to_vec()),
        Err(err) => Err(format!("Failed to read TPC file '{}': {}", path, err))
    }
}


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
pub async fn get_bytes_from_file(path: String) -> Result<Vec<u8>, String> {
    match std::fs::read(&path) {
        Ok(file_bytes) => Ok(file_bytes),
        Err(err) => Err(format!("Failed to read file '{}': {}", path, err))
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
    println!("Attempting to create file at path: {}", path);
    // Try to create/open the file for writing
    let mut file = match File::create(&path) {
        Ok(f) => {
            println!("Successfully created file");
            f
        },
        Err(e) => {
            println!("Failed to create file: {}", e);
            return Err(format!("Failed to create file '{}': {}", path, e));
        }
    };

    println!("Attempting to write {} bytes of TPC data", tpc_data.file.len());
    // Write the TPC data to the file
    match file.write_all(&tpc_data.file) {
        Ok(_) => {
            println!("Successfully wrote TPC data to file");
            Ok(())
        },
        Err(e) => {
            println!("Failed to write TPC data: {}", e);
            Err(format!("Failed to write TPC data to file: {}", e))
        }
    }
}



#[tauri::command]
pub async fn read_bytes_from_detached_file(path: String) -> Result<Vec<u8>, String> {
    match std::fs::read(&path) {
        Ok(bytes) => Ok(bytes),
        Err(e) => Err(format!("Failed to read file '{}': {}", path, e))
    }
}

#[tauri::command]
pub async fn read_tpc_from_detached_file(path: String) -> Result<TPC, String> {
    match std::fs::read(&path) {
        Ok(bytes) => {
            let tpc = TPC::new(crate::domain::odyssey_api::tpc::TPCOptions {
                file: Some(bytes),
                filename: Some(path.clone()),
                pack: None,
            });
            println!("TPC: {:?}", tpc.header.mip_map_count);
            Ok(tpc)
        },
        Err(e) => Err(format!("Failed to read file '{}': {}", path, e))
    }
}


#[tauri::command]
pub async fn convert_tpc_to_dds(tpc_data: TPC) -> Result<Vec<u8>, String> {
    match tpc_data.to_dds() {
        Ok(dds_data) => Ok(dds_data),
        Err(e) => Err(format!("Failed to convert TPC to DDS: {}", e)),
    }
}


#[tauri::command]
pub async fn get_tpc_from_file_xoreos(path: String, offset: u64, size: u64) -> Result<crate::domain::odyssey_api::tpc_xoreos::TPC, String> {
    
    println!("Opening file: {}", path);
    
    // Open the file
    let mut file = match std::fs::File::open(&path) {
        Ok(f) => {
            println!("Successfully opened file");
            f
        },
        Err(e) => {
            println!("Failed to open file: {}", e);
            return Err(format!("Failed to open file '{}': {}", path, e));
        }
    };

    println!("Seeking to offset: {}", offset);
    // Seek to the offset
    if let Err(e) = file.seek(std::io::SeekFrom::Start(offset)) {
        println!("Failed to seek: {}", e);
        return Err(format!("Failed to seek to offset {}: {}", offset, e));
    }
    println!("Successfully seeked to offset");

    println!("Creating TPC from file...");
    // Try to create TPC from the buffer
    match crate::domain::odyssey_api::tpc_xoreos::TPC::new(&mut file) {
        Ok(tpc) => {
            println!("Successfully created TPC with {} mipmaps", tpc.mip_maps.len());
            // Convert mip_maps to bytes
            let bytes: Vec<u8> = tpc.mip_maps.iter()
                .filter_map(|mip| mip.data.as_ref())
                .flat_map(|data| data.iter().copied())
                .collect();
            println!("Converted mipmaps to {} bytes", bytes.len());

            Ok(tpc)
        },
        Err(e) => {
            println!("Failed to create TPC: {}", e);
            Err(format!("Failed to create TPC from file: {}", e))
        }
    }

}



