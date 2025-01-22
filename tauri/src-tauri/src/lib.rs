mod libs {
    pub mod greetings;
}

mod domain {
    pub mod odyssey_api;
}

mod application {
    pub mod aurora_commands;
    pub mod file_system_commands;
}

#[tauri::command]
fn greet(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust!", name)
}

#[tauri::command]
fn open_url(url: String) -> String {
    format!("Hello, {}! You've been greeted from Rust!", url)
}

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {
    tauri::Builder::default()
        .plugin(tauri_plugin_opener::init())
        .invoke_handler(tauri::generate_handler![
            greet,
            open_url,
            libs::greetings::greet_me_so_hard,
            application::file_system_commands::list_directory_from_root,
            application::file_system_commands::get_directory_contents,
            application::file_system_commands::get_parent_directory_contents,
            application::file_system_commands::get_drive_info,
            application::file_system_commands::get_drive_statistics,
            application::aurora_commands::read_chitin_key,
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
