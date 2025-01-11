use serde::Serialize;
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

/// Gets the contents of the parent directory for a given path
///
/// # Arguments
///
/// * `path` - A string representing the path whose parent directory contents should be retrieved
///
/// # Returns
///
/// * `Result<serde_json::Value, String>` - On success, returns a JSON value containing the parent directory contents.
///   On failure, returns an error message string.
///
/// # Errors
///
/// Returns an error if:
/// * The given path has no parent directory
/// * The parent path is invalid (contains non-UTF8 characters)
/// * The underlying `get_directory_contents` call fails
#[tauri::command]
async fn get_parent_directory_contents(path: String) -> Result<serde_json::Value, String> {
    use std::path::PathBuf;

    // Get parent directory path
    let current_path = PathBuf::from(path);
    let parent_path = current_path
        .parent()
        .ok_or("No parent directory found".to_string())?
        .to_str()
        .ok_or("Invalid parent path")?
        .to_string();

    // Reuse existing get_directory_contents command
    get_directory_contents(parent_path).await
}

#[derive(Serialize)]
struct DirectoryItem {
    name: String,
    path: String,
    size: u64,
    created: u64,
    modified: u64,
    is_hidden: bool,
    #[serde(rename = "type")]
    file_type: String,
    readonly: bool,
}

#[derive(Serialize)]
struct DirectoryContents {
    path: String,
    contents: Vec<DirectoryItem>,
    total_items: usize,
}

#[tauri::command]
async fn get_directory_contents(path: String) -> Result<serde_json::Value, String> {
    use std::fs;
    use std::time::SystemTime;

    let directory = fs::read_dir(&path).map_err(|e| e.to_string())?;
    let mut contents = Vec::new();

    for entry in directory {
        let entry = entry.map_err(|e| e.to_string())?;
        let metadata = entry.metadata().map_err(|e| e.to_string())?;
        let file_name = entry.file_name();
        let file_name = file_name.to_str().ok_or("Invalid filename")?;

        let modified = metadata.modified().map_err(|e| e.to_string())?;
        let modified = modified
            .duration_since(SystemTime::UNIX_EPOCH)
            .map_err(|e| e.to_string())?
            .as_secs();

        let created = metadata.created().map_err(|e| e.to_string())?;
        let created = created
            .duration_since(SystemTime::UNIX_EPOCH)
            .map_err(|e| e.to_string())?
            .as_secs();

        let file_type = if metadata.is_dir() {
            "directory"
        } else if metadata.is_file() {
            "file"
        } else {
            "other"
        };

        let item = DirectoryItem {
            name: file_name.to_string(),
            path: entry.path().to_str().ok_or("Invalid path")?.to_string(),
            size: metadata.len(),
            created,
            modified,
            is_hidden: false, // TODO: Implement for Windows
            file_type: file_type.to_string(),
            readonly: metadata.permissions().readonly(),
        };

        contents.push(item);
    }
    let contents = contents;
    let total_items = contents.len();

    Ok(serde_json::to_value(DirectoryContents {
        path,
        contents,
        total_items: total_items,
    })
    .map_err(|e| e.to_string())?)
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
            list_directory_from_root,
            get_directory_contents,
            get_parent_directory_contents
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
