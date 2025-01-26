use chrono::{DateTime, Utc};
use rusqlite::{params, Connection, Result};
use uuid::Uuid;

#[derive(Debug, Default, serde::Serialize, serde::Deserialize)]
pub struct Project {
    id: String,
    name: String,
    description: Option<String>,
    created_at: String,
    staging_path: String,
    original_directory_path: String,
}

/// Creates a table for managing projects, if it doesn't already exist
pub fn initialize_projects_table(conn: &Connection) -> Result<()> {
    conn.execute(
        "CREATE TABLE IF NOT EXISTS projects (
            id TEXT PRIMARY KEY,
            name TEXT NOT NULL,
            description TEXT,
            created_at TEXT NOT NULL,
            staging_path TEXT NOT NULL,
            original_directory_path TEXT NOT NULL
        )",
        [], // No parameters
    )?;
    Ok(())
}

/// Adds a new project to the database
#[tauri::command]
pub fn create_project(
    name: &str,
    description: Option<&str>,
    staging_path: &str,
    original_directory_path: &str,
) -> Result<Project, String> {
    let conn = match Connection::open("projects.db") {
        Ok(connection) => connection,
        Err(e) => panic!("Failed to connect to database: {}", e),
    };

    let id = match Uuid::new_v4() {
        uuid => uuid.to_string(),
    };
    let created_at = match chrono::Utc::now().to_rfc3339() {
        time => time,
    };
    match conn.execute(
        "INSERT INTO projects (id, name, description, created_at, staging_path, original_directory_path) VALUES (?1, ?2, ?3, ?4, ?5, ?6)",
        params![id, name, description, created_at, staging_path, original_directory_path],
    ) {
        Ok(_) => (),
        Err(e) => return Err(e.to_string()),
    };
    let movedId = id.clone();
    let project = Project {
        id: movedId,
        name: name.to_string(),
        description: description.map(|s| s.to_string()),
        created_at,
        staging_path: staging_path.to_string(),
        original_directory_path: original_directory_path.to_string(),
    };

    // create folder with project id and name concatenated, and copy original game folder to the new directory
    use std::fs;
    use std::path::Path;

    let new_directory_name = format!("{}_{}", id, name);
    let new_directory_path = Path::new(&staging_path).join(new_directory_name);

    if let Err(e) = fs::create_dir_all(&new_directory_path) {
        return Err(format!("Failed to create project directory: {}", e));
    }

    if let Err(e) = fs::copy(original_directory_path, &new_directory_path) {
        return Err(format!("Failed to copy original directory: {}", e));
    }
    println!("Project '{}' has been created.", name);
    Ok(project)
}

/// Lists all projects in the database
#[tauri::command]
pub fn list_projects() -> Result<Vec<Project>, String> {
    let conn = Connection::open("projects.db").map_err(|e| e.to_string())?;

    let mut stmt = conn.prepare("SELECT id, name, description, created_at, staging_path, original_directory_path FROM projects")
        .map_err(|e| e.to_string())?;

    let project_iter = stmt
        .query_map([], |row| {
            Ok(Project {
                id: row.get(0)?,
                name: row.get(1)?,
                description: row.get(2)?,
                created_at: row.get(3)?,
                staging_path: row.get(4)?,
                original_directory_path: row.get(5)?,
            })
        })
        .map_err(|e| e.to_string())?;

    let projects: Result<Vec<_>, _> = project_iter.collect();
    projects.map_err(|e| e.to_string())
}

// fn main() -> Result<()> {
//     // Initialize SQLite connection
//     let conn = Connection::open("projects.db")?;

//     // Initialize the database structure
//     initialize_database(&conn)?;

//     // Example usage
//     create_project(&conn, "Project A", Some("A sample project"))?;
//     create_project(&conn, "Project B", None)?;

//     println!("\nListing all projects:");
//     list_projects(&conn)?;

//     println!("\nDeleting a project:");
//     delete_project(&conn, 1)?;

//     println!("\nListing all projects again:");
//     list_projects(&conn)?;

//     Ok(())
// }
