use crate::AppState;
use chrono::{DateTime, Utc};
use serde_json::{json, Value};
use std::io::{BufReader, Cursor};
use std::{fs::File, path::Path};
use surrealdb::opt::Resource;
use tauri::async_runtime::Mutex;

use crate::domain::odyssey_api::chitin;
use crate::domain::odyssey_api::tpc::TPC;
use byteorder::{LittleEndian, ReadBytesExt};
use std::io::{self, Read, Seek, SeekFrom};

use crate::domain::odyssey_api::{
    biff::Biff,
    chitin::{ChitinKey, ChitinKeyReader},
    erf::ErfFile,
    rim::Rim,
};

use crate::infrastructure::data::resource_file;

use crate::infrastructure::data::resource_file::ResourceFile;
use serde::{Deserialize, Serialize};
use std::time::SystemTime;




#[tauri::command]
pub async fn read_chitin_key(
    state: tauri::State<'_, Mutex<AppState>>,
    path: &str,
) -> Result<Value, String> {
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

    // Get SurrealDB runtime instance
    let mut db_runtime =
        crate::infrastructure::database::surreal_db_runtime::SurrealDbRuntime::new();
    match db_runtime.open("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            println!("Error opening database: {}", e);
            return Err(e.to_string());
        }
    }
    // Get user ID from app state
    let guard = state.lock().await;
    let user_id = match &guard.current_user {
        Some(user) => user.id.clone(),
        None => {
            println!("No user found in app state");
            return Err("No user found in app state".to_string());
        }
    };
    let project_id = match &guard.current_project {
        Some(project) => project.id.clone().to_string(),
        None => String::new(),
    };

    // Save to SurrealDB database
    match (async {
        // Ensure the database is initialized
        if let Some(db) = db_runtime.get_db() {
            // Create a record for the chitin key

            let chitin_key_data = serde_json::json!({
                "id": uuid::Uuid::new_v4().to_string(),
                "user_id": user_id,
                "project_id": project_id,
                "item_id": uuid::Uuid::new_v4().to_string(),
                "filepath": path,
                "filename": std::path::Path::new(path).file_name()
                    .and_then(|name| name.to_str())
                    .unwrap_or("unknown"),
                "biff_count": chitin_key.header.bif_count,
                "resource_count": chitin_key.header.key_count,
                "file_size": std::fs::metadata(path).map_or(0, |m| m.len()),
                "last_modified": std::fs::metadata(path)
                    .and_then(|m| m.modified())
                    .map_or_else(
                        |_| chrono::Utc::now().to_rfc3339(),
                        |time| chrono::DateTime::<chrono::Utc>::from(time).to_rfc3339()
                    ),
                "file_type": "chitin_key",
                "data": serde_json::to_string(&chitin_key).unwrap()

            });

            match db.use_ns("aurora").use_db("aurora").await {
                Ok(_) => {}
                Err(e) => {
                    return Err(e.to_string());
                }
            }

            // Use the clean resource_file object instead of the raw chitin_key
            match db
                .create(Resource::from("resource_files"))
                .content(chitin_key_data)
                .await
            {
                Ok(_) => Ok(()),
                Err(e) => Err(e.to_string()),
            }
        } else {
            Err("Database not initialized".to_string())
        }
    })
    .await
    {
        Ok(_) => Ok(serde_json::to_value(&chitin_key).unwrap()),
        Err(e) => {
            println!("Error saving chitin key to database: {}", e);
            Err(e.to_string())
        }
    }
}

#[tauri::command]
pub async fn get_saved_chitin_key_files() -> Vec<ResourceFile<ChitinKey>> {
    // Get SurrealDB runtime instance
    let mut db_runtime =
        crate::infrastructure::database::surreal_db_runtime::SurrealDbRuntime::new();

    match db_runtime.open("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            println!("Error opening database: {}", e);
            return Vec::new();
        }
    }

    // Retrieve chitin key files from SurrealDB database
    match (async {
        // Ensure the database is initialized
        if let Some(db) = db_runtime.get_db() {
            match db
                .use_ns("aurora")
                .use_db("aurora")
                .await
                .map_err(|e| e.to_string())
            {
                Ok(_) => {}
                Err(e) => {
                    return Err(e);
                }
            }

            // Query for resource files that are chitin keys
            let res: Vec<ResourceFile<ChitinKey>> =
                match db.select("resource_files").await.map_err(|e| e.to_string()) {
                    Ok(res) => res,
                    Err(e) => {
                        return Err(e);
                    }
                };

            Ok(res)
        } else {
            Err("Database not initialized".to_string())
        }
    })
    .await
    {
        Ok(records) => {
            println!("Successfully retrieved {} chitin key files", records.len());
            records
        }
        Err(e) => {
            println!("Error getting saved chitin key files: {}", e);
            Vec::new()
        }
    }
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
                Err(e) => {
                    return Err(format!("Error reading BIFF file: {}", e));
                }
            };

            let mdl_data = match biff.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDL data: {}", e));
                }
            };

            let mdx_data = match biff.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDX data: {}", e));
                }
            };

            Ok((mdl_data, mdx_data))
        }
        "RIM" => {
            let rim = match Rim::read_from_file(file_path) {
                Ok(r) => r,
                Err(e) => {
                    return Err(format!("Error reading RIM file: {}", e));
                }
            };

            let mdl_data = match rim.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDL data: {}", e));
                }
            };

            let mdx_data = match rim.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDX data: {}", e));
                }
            };

            Ok((mdl_data, mdx_data))
        }
        "ERF" => {
            let erf = match ErfFile::read_from_file(file_path) {
                Ok(e) => e,
                Err(e) => {
                    return Err(format!("Error reading ERF file: {}", e));
                }
            };

            let mdl_data = match erf.read_resource_data(mdl_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDL data: {}", e));
                }
            };

            let mdx_data = match erf.read_resource_data(mdx_id) {
                Ok(data) => data,
                Err(e) => {
                    return Err(format!("Error reading MDX data: {}", e));
                }
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
