use std::fs;
use std::io;
use std::path::Path;
use surrealdb::RecordId;
use tauri::async_runtime::Mutex;
use uuid::Uuid;

use crate::AppState;
use crate::infrastructure::database::project_repository::ProjectRepository;

#[derive(Debug, serde::Serialize, serde::Deserialize)]
pub struct Project {
    pub id: RecordId,
    pub user_id: String,
    pub name: String,
    pub description: Option<String>,
    pub created_at: String,
    pub staging_path: String,
    pub original_directory_path: String,
    pub metrics: ProjectMetrics,
}

// For Collecting Metrics and overall diff comparisons later
#[derive(Debug, serde::Serialize, serde::Deserialize, Clone)]
pub struct ProjectMetrics {
    pub project_id: String,
    pub file_count: usize,
    pub directory_count: usize,
    pub total_bytes: u64,
    pub operating_system: String,
    pub last_updated: String,
    pub file_types: std::collections::HashMap<String, usize>,
    pub largest_file_path: Option<String>,
    pub largest_file_size: u64,
}

impl ProjectMetrics {
    pub fn new(project_id: &str) -> Self {
        ProjectMetrics {
            project_id: project_id.to_string(),
            file_count: 0,
            directory_count: 0,
            total_bytes: 0,
            operating_system: std::env::consts::OS.to_string(),
            last_updated: chrono::Utc::now().to_rfc3339(),
            file_types: std::collections::HashMap::new(),
            largest_file_path: None,
            largest_file_size: 0,
        }
    }

    pub fn update_from_path(&mut self, path: &Path) -> Result<(), String> {
        self.last_updated = chrono::Utc::now().to_rfc3339();
        
        if !path.exists() {
            return Err(format!("Path does not exist: {:?}", path));
        }

        self.collect_metrics(path)
    }

    fn collect_metrics(&mut self, path: &Path) -> Result<(), String> {
        if path.is_dir() {
            self.directory_count += 1;
            
            let entries = match fs::read_dir(path) {
                Ok(entries) => entries,
                Err(e) => return Err(format!("Failed to read directory: {}", e)),
            };

            for entry in entries {
                match entry {
                    Ok(entry) => {
                        let path = entry.path();
                        if path.is_dir() {
                            self.collect_metrics(&path)?;
                        } else {
                            self.process_file(&path)?;
                        }
                    },
                    Err(e) => return Err(format!("Failed to access entry: {}", e)),
                }
            }
        } else {
            self.process_file(path)?;
        }

        Ok(())
    }

    fn process_file(&mut self, path: &Path) -> Result<(), String> {
        self.file_count += 1;
        
        // Get file size
        let metadata = match fs::metadata(path) {
            Ok(metadata) => metadata,
            Err(e) => return Err(format!("Failed to get file metadata: {}", e)),
        };
        
        let file_size = metadata.len();
        self.total_bytes += file_size;
        
        // Track file extension
        if let Some(extension) = path.extension() {
            if let Some(ext_str) = extension.to_str() {
                let ext = ext_str.to_lowercase();
                *self.file_types.entry(ext).or_insert(0) += 1;
            }
        }
        
        // Track largest file
        if file_size > self.largest_file_size {
            self.largest_file_size = file_size;
            self.largest_file_path = path.to_str().map(String::from);
        }
        
        Ok(())
    }
}



// Add this helper function for recursive directory copying
fn copy_dir_recursive(src: impl AsRef<Path>, dst: impl AsRef<Path>) -> io::Result<()> {
    let src = src.as_ref();
    let dst = dst.as_ref();

    println!("Starting directory copy from {:?} to {:?}", src, dst);

    if !src.is_dir() {
        println!("Error: Source path is not a directory: {:?}", src);
        return Err(io::Error::new(io::ErrorKind::InvalidInput, "Source path is not a directory"));
    }

    println!("Creating destination directory: {:?}", dst);
    match fs::create_dir_all(dst) {
        Ok(_) => println!("Successfully created destination directory"),
        Err(e) => println!("Error creating destination directory: {}", e),
    }
    fs::create_dir_all(dst)?;

    println!("Reading source directory contents");
    let read_dir_result = fs::read_dir(src);
    let entries = match read_dir_result {
        Ok(entries) => {
            println!("Successfully read directory contents");
            entries
        },
        Err(e) => {
            println!("Error reading directory contents: {}", e);
            return Err(e);
        }
    };

    for entry_result in entries {
        let entry = match entry_result {
            Ok(entry) => entry,
            Err(e) => {
                println!("Error accessing directory entry: {}", e);
                return Err(e);
            }
        };
        
        let src_path = entry.path();
        let dst_path = dst.join(entry.file_name());
        
        println!("Processing: {:?} -> {:?}", src_path, dst_path);

        if src_path.is_dir() {
            println!("Found subdirectory: {:?}, recursing", src_path);
            match copy_dir_recursive(&src_path, &dst_path) {
                Ok(_) => println!("Successfully copied subdirectory: {:?}", src_path),
                Err(e) => {
                    println!("Error copying subdirectory {:?}: {}", src_path, e);
                    return Err(e);
                }
            }
        } else {
            println!("Copying file: {:?} -> {:?}", src_path, dst_path);
            match fs::copy(&src_path, &dst_path) {
                Ok(bytes) => println!("Successfully copied {} bytes", bytes),
                Err(e) => {
                    println!("Error copying file {:?}: {}", src_path, e);
                    return Err(e);
                }
            }
        }
    }

    println!("Directory copy completed successfully");
    Ok(())
}



/// Adds a new project to the database
/// Attempt to create a new project in the database
/// If the project already exists, return the existing project
/// Call the app state through the state parameter and extract the current user id
/// Attach the user id to the project
#[tauri::command]
pub async fn create_project(
    state: tauri::State<'_, Mutex<AppState>>,
    name: &str,
    description: Option<&str>,
    staging_path: &str,
    original_directory_path: &str
) -> Result<Project, String> {
    // Get user ID from app state
    let guard = state.lock().await;
    let user_id = match &guard.current_user {
        Some(user) => user.id.clone(),
        None => {
            println!("No user found in app state");
            return Err("No user found in app state".to_string());
        }
    };
    drop(guard); // Release the lock early

    // Initialize repository
    let mut repository = ProjectRepository::new();
    match repository.initialize("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            return Err(format!("Failed to initialize repository: {}", e));
        }
    }

    // Generate unique ID for directory creation
    let id = Uuid::new_v4().to_string();

    // Create folder with project id and name concatenated
    let new_directory_name = format!("{}_{}", id, name);
    let new_directory_path = Path::new(&staging_path).join(new_directory_name);


    if let Err(e) = fs::create_dir_all(&new_directory_path) {
        return Err(format!("Failed to create project directory: {}", e));
    }

    // Copy original game folder to the new directory
    if let Err(e) = copy_dir_recursive(original_directory_path, &new_directory_path) {
        return Err(format!("Failed to copy original directory: {}", e));
    }

    // Create project in database using repository
    match repository.create_project(
        &user_id,
        name,
        description,
        staging_path,
        original_directory_path
    ).await {
        Ok(project) => {
            println!("Project '{}' has been created.", name);
            // Update metrics
            let mut metrics = ProjectMetrics::new(&project.id.to_string());
            metrics.update_from_path(Path::new(&new_directory_path)).map_err(|e| format!("Failed to update metrics: {}", e))?;
            let mut project = project;
            project.metrics = metrics.clone();
            // Update project in database
            match repository.update_project(&project.id.to_string(), Some(name), Some(description), Some(staging_path)).await {
                Ok(Some(updated_project)) => {
                    println!("Project metrics updated successfully");
                    Ok(updated_project)
                }
                Ok(None) => Err("Project not found".to_string()),
                Err(e) => Err(format!("Failed to update project metrics: {}", e)),
            }
        }
        Err(e) => Err(format!("Failed to create project in database: {}", e)),
    }
}








/// Lists all projects in the database
#[tauri::command]
pub async fn list_projects(user_id: &str) -> Result<Vec<Project>, String> {
    // Initialize repository
    let mut repository = ProjectRepository::new();
    match repository.initialize("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            return Err(format!("Failed to initialize repository: {}", e));
        }
    }

    // Fetch projects for the user
    match repository.list_projects_by_user(user_id).await {
        Ok(projects) => {
            println!("Found {} projects for user {}", projects.len(), user_id);
            Ok(projects)
        }
        Err(e) => Err(format!("Failed to fetch projects: {}", e)),
    }
}








#[tauri::command]
pub async fn update_project(
    id: &str,
    name: &str,
    description: Option<&str>,
    staging_path: &str
) -> Result<Project, String> {
    // Initialize repository
    let mut repository = ProjectRepository::new();
    match repository.initialize("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            return Err(format!("Failed to initialize repository: {}", e));
        }
    }

    // Update project using repository
    match repository.update_project(
        id,
        Some(name),
        Some(description),
        Some(staging_path)
    ).await {
        Ok(Some(project)) => Ok(project),
        Ok(None) => Err("Project not found".to_string()),
        Err(e) => Err(format!("Failed to update project: {}", e)),
    }
}

#[tauri::command]
pub async fn delete_project(id: &str) -> Result<(), String> {
    // Initialize repository
    let mut repository = ProjectRepository::new();
    match repository.initialize("surrealdb.db").await {
        Ok(_) => {}
        Err(e) => {
            return Err(format!("Failed to initialize repository: {}", e));
        }
    }

    // Delete project using repository
    match repository.delete_project(id).await {
        Ok(_) => Ok(()),
        Err(e) => Err(format!("Failed to delete project: {}", e)),
    }
}
