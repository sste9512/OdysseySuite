
use tauri::command;

#[command]
pub fn greet_me_so_hard(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust2!", name)
}



#[command]
pub fn open_and_store(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust2!", name)
}


#[command]
pub fn peek_key_from_path(name: &str) -> String {
    format!("Hello, {}! You've been greeted from Rust2!", name)
}
