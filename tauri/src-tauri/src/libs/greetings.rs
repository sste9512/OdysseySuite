use tauri::command;

#[command]
pub fn greet_me_so_hard(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust2!", name)
}
