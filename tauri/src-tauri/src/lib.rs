use crate::application::project_commands::initialize_projects_table;
use rusqlite::Connection;

mod libs {
    pub mod greetings;
}

mod domain {
    pub mod odyssey_api;
}

mod application {
    pub mod aurora_commands;
    pub mod file_system_commands;
    pub mod project_commands;
    pub mod image_commands;
}

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {

    
    let conn = match Connection::open("projects.db") {
        Ok(connection) => connection,
        Err(e) => panic!("Failed to connect to database: {}", e),
    };

    // Initialize the database structure
    match initialize_projects_table(&conn) {
        Ok(_) => (),
        Err(e) => panic!("Failed to initialize projects table: {}", e),
    };
    tauri::Builder::default()
        .plugin(tauri_plugin_opener::init())
        .invoke_handler(tauri::generate_handler![
            application::file_system_commands::list_directory_from_root,
            application::file_system_commands::get_directory_contents,
            application::file_system_commands::get_parent_directory_contents,
            application::file_system_commands::get_drive_info,
            application::file_system_commands::get_drive_statistics,
            application::file_system_commands::search_files_by_extension,
            application::aurora_commands::read_chitin_key,
            application::aurora_commands::read_biff,
            application::aurora_commands::read_erf,
            application::aurora_commands::read_rim,
            application::project_commands::create_project,
            application::project_commands::list_projects,
            application::aurora_commands::get_erf_resource_data,
            application::image_commands::read_tpc_data_from_bytes
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
