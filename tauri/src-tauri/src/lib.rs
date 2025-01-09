

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
async fn list_directory_from_root() -> Result<Vec<String>, String> {
    use std::fs;
    let path = "C:\\Users";
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
            libs::greetings::greet_me_so_hard,
            list_directory_from_root
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
