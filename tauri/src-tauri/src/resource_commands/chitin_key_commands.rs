use tauri::command;
use crate::domain::odyssey_api::chitin::ChitinKey;



#[command]
pub fn open_and_store(path: &str) -> Result<(), String> {
    let mut file = std::fs::File::open(path).map_err(|e| e.to_string())?;
    let chitin_key = ChitinKey::read_chitin_key(&mut file).map_err(|e| e.to_string())?;
    
    let conn = rusqlite::Connection::open("chitin_keys.db").map_err(|e| e.to_string())?;
    
    conn.execute(
        "CREATE TABLE IF NOT EXISTS chitin_keys (
            path TEXT PRIMARY KEY,
            key_data TEXT NOT NULL
        )",
        [],
    ).map_err(|e| e.to_string())?;

    let key_json = serde_json::to_string(&chitin_key).map_err(|e| e.to_string())?;
    
    conn.execute(
        "INSERT OR REPLACE INTO chitin_keys (path, key_data) VALUES (?1, ?2)",
        [path, &key_json],
    ).map_err(|e| e.to_string())?;

    Ok(())
}

#[command]
pub fn peek_key_from_path(path: &str) -> Result<ChitinKey, String> {
    let conn = rusqlite::Connection::open("chitin_keys.db").map_err(|e| e.to_string())?;
    
    let mut stmt = conn.prepare(
        "SELECT key_data FROM chitin_keys WHERE path = ?1"
    ).map_err(|e| e.to_string())?;

    let key_json: String = stmt.query_row([path], |row| row.get(0))
        .map_err(|e| e.to_string())?;

    serde_json::from_str(&key_json).map_err(|e| e.to_string())
}
