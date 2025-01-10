mod libs {
    pub mod greetings;
}

mod domain {
    pub mod document_operations;
}

#[tauri::command]
fn greet(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust!", name)
}

#[tauri::command]
fn open_url(url: String) -> String {
    format!("Hello, {}! You've been greeted from Rust!", url)
}

#[tauri::command]
async fn get_drive_info() -> Result<Vec<String>, String> {
    use std::path::Path;
    let mut drives = Vec::new();

    // Get system drive from environment variable
    if let Ok(system_drive) = std::env::var("SystemDrive") {
        drives.push(system_drive);
    }

    // Check common Windows drive letters
    for letter in b'A'..=b'Z' {
        let drive = format!("{}:\\", letter as char);
        if Path::new(&drive).exists() {
            drives.push(drive);
        }
    }

    if drives.is_empty() {
        return Err("No drives found".to_string());
    }

    Ok(drives)
}

#[tauri::command]
async fn get_drive_statistics() -> Result<Vec<serde_json::Value>, String> {
    use std::path::Path;
    use sysinfo::{Disks, System};
    let mut sys = System::new();
    let disks = Disks::new_with_refreshed_list();

    let mut drive_stats = Vec::new();

    for disk in disks.list() {
        let mount_point = disk.mount_point().to_string_lossy().to_string();

        // Only include if path exists
        if Path::new(&mount_point).exists() {
            let total_space = disk.total_space();
            let available_space = disk.available_space();
            let used_space = total_space - available_space;
            let usage_percent = (used_space as f64 / total_space as f64 * 100.0) as u64;

            let stats = serde_json::json!({
                "path": mount_point,
                "total_gb": total_space / 1024 / 1024 / 1024,
                "used_gb": used_space / 1024 / 1024 / 1024,
                "available_gb": available_space / 1024 / 1024 / 1024,
                "usage_percent": usage_percent,
                "name": disk.name().to_string_lossy(),
                "file_system": disk.file_system().to_string_lossy()
            });

            drive_stats.push(stats);
        }
    }

    if drive_stats.is_empty() {
        return Err("No drives found".to_string());
    }

    Ok(drive_stats)
}

#[tauri::command]
async fn list_directory_from_root() -> Result<Vec<String>, String> {
    use std::fs;
    let path = std::env::var("SystemDrive").unwrap_or_else(|_| "C:".to_string());
    let directory = fs::read_dir(path).map_err(|e| e.to_string())?;
    let mut files: Vec<String> = Vec::new();
    for entry in directory {
        let entry = entry.map_err(|e| e.to_string())?;
        files.push(entry.file_name().to_str().unwrap().to_string());
    }
    Ok(files)
}

#[tauri::command]
async fn list_directory(path: String) -> Result<Vec<String>, String> {
    use std::fs;
    let directory = fs::read_dir(path).map_err(|e| e.to_string())?;
    let mut files: Vec<String> = Vec::new();
    for entry in directory {
        let entry = entry.map_err(|e| e.to_string())?;
        files.push(entry.file_name().to_str().unwrap().to_string());
    }
    Ok(files)
}

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {
    tauri::Builder::default()
        .plugin(tauri_plugin_opener::init())
        .invoke_handler(tauri::generate_handler![
            greet,
            open_url,
            list_directory,
            get_drive_info,
            get_drive_statistics,
            libs::greetings::greet_me_so_hard,
            list_directory_from_root
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
