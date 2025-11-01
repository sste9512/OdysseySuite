use crate::application::project_commands::{Project};

use crate::domain::entities::user::User;
use crate::infrastructure::database::sqlite_runtime::SqliteRuntime;
use tauri::async_runtime::Mutex;
use tauri::WindowEvent;
use tauri::{Manager, Window};

mod domain {
    pub mod entities;
    pub mod odyssey_api;
    pub mod use_cases;
}

mod application {
    pub mod aurora_commands;
    pub mod file_system_commands;
    pub mod image_commands;
    pub mod project_commands;
    pub mod user_commands;
}

mod infrastructure {
    pub mod authorization;
    pub mod data;
    pub mod database;
}

#[derive(Default)]
pub struct AppState {
    counter: u32,
    current_user: Option<User>,
    current_project: Option<Project>,
    is_logged_in: bool,
    is_loading: bool,
    error: Option<String>,
}

// In an event handler:
fn on_window_event(window: &Window, _event: &WindowEvent) {
    let app_handle = window.app_handle().clone();
    tauri::async_runtime::spawn(async move {
        let state = app_handle.state::<Mutex<AppState>>();
        let mut state = state.lock().await;
        state.counter += 1;
        state.current_user = Some(User::with_id(
            "1".to_string(),
            "test".to_string(),
            "test".to_string(),
            "test@example.com".to_string(),
        ));
        state.is_logged_in = true;
        state.is_loading = false;
        state.error = None;
    });
}

#[cfg_attr(mobile, tauri::mobile_entry_point)]
pub fn run() {
    let mut sqlite_runtime = SqliteRuntime::new();
    match sqlite_runtime.ensure_database_ready("projects.db") {
        Ok(_) => (),
        Err(e) => panic!("Failed to ensure database is ready: {}", e),
    }

    let conn = match sqlite_runtime.get_connection() {
        Some(connection) => connection,
        None => panic!("Failed to get database connection after initialization"),
    };

    tauri::Builder::default()
        .setup(|app| {
            app.manage(Mutex::new(AppState::default()));
            Ok(())
        })
        .on_window_event(on_window_event)
        .plugin(tauri_plugin_opener::init())
        .invoke_handler(tauri::generate_handler![
            application::user_commands::user_sign_in,
            application::user_commands::user_register,
            application::user_commands::user_log_out,
            application::file_system_commands::list_directory_from_root,
            application::file_system_commands::get_directory_contents,
            application::file_system_commands::get_parent_directory_contents,
            application::file_system_commands::get_drive_info,
            application::file_system_commands::get_drive_statistics,
            application::file_system_commands::search_files_by_extension,
            application::aurora_commands::read_chitin_key,
            application::aurora_commands::get_saved_chitin_key_files,
            application::aurora_commands::read_biff,
            application::aurora_commands::read_erf,
            application::aurora_commands::read_rim,
            application::aurora_commands::get_erf_resource_data,
            application::aurora_commands::extract_biff_resource,
            application::aurora_commands::extract_erf_resource,
            application::aurora_commands::extract_rim_resource,
            application::aurora_commands::read_model_files,
            application::project_commands::create_project,
            application::project_commands::list_projects,
            application::project_commands::update_project,
            application::project_commands::delete_project,
            application::image_commands::convert_bytes_to_tpc,
            application::image_commands::convert_file_to_tpc,
            application::image_commands::write_tpc_to_file,
            application::image_commands::convert_tpc_to_dds,
            application::image_commands::get_tpc_from_file,
            application::image_commands::read_tpc_from_detached_file,
            application::image_commands::get_tpc_bytes_from_file,
            application::image_commands::read_bytes_from_detached_file,
            application::image_commands::get_bytes_from_file
        ])
        .run(tauri::generate_context!())
        .expect("error while running tauri application");
}
