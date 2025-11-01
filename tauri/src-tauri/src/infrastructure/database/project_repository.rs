use serde_json::{ json, Value };
use surrealdb::RecordId;
use uuid::Uuid;
use chrono::Utc;

use super::document_service::{ DocumentService, DocumentResult, QueryBuilder };
use crate::{
    application::project_commands::{Project, ProjectMetrics},
    infrastructure::database::document_service::DocumentError,
};


/// Adapter function to convert a string to a SurrealDB RecordId
///
/// # Arguments
/// * `table` - The table name for the record
/// * `id` - The string ID to convert
///
/// # Returns
/// * `Result<RecordId, String>` - The RecordId or an error message
pub fn string_to_record_id(table: &str, id: &str) -> RecordId {
    RecordId::from((table, id))
}

/// Alternative: Direct conversion using the From trait
/// This is simpler when you know the table name
pub fn create_record_id(table: &str, id: &str) -> RecordId {
    RecordId::from((table, id))
}

/// Repository for project-related database operations
pub struct ProjectRepository {
    document_service: DocumentService,
}

impl ProjectRepository {
    pub fn new() -> Self {
        Self {
            document_service: DocumentService::new(),
        }
    }

    /// Initialize the repository with database connection
    pub async fn initialize(&mut self, db_path: &str) -> DocumentResult<()> {
        self.document_service.initialize(db_path).await?;
        self.ensure_projects_table().await?;
        Ok(())
    }

    async fn ensure_metrics_table(&self) -> DocumentResult<()> {
        let table_definition =
            r#"
            DEFINE TABLE metrics SCHEMAFULL;
            DEFINE FIELD project_id ON metrics TYPE string;
            DEFINE FIELD file_count ON metrics TYPE int;
            DEFINE FIELD directory_count ON metrics TYPE int;
            DEFINE FIELD total_bytes ON metrics TYPE int;
            DEFINE FIELD operating_system ON metrics TYPE string;
            DEFINE FIELD last_updated ON metrics TYPE string;
            DEFINE FIELD file_types ON metrics TYPE object;
            DEFINE FIELD largest_file_path ON metrics TYPE option<string>;
            DEFINE FIELD largest_file_size ON metrics TYPE int;
        "#;

        self.document_service.define_table(table_definition).await
    }

    /// Ensure the projects table is defined with proper schema
    async fn ensure_projects_table(&self) -> DocumentResult<()> {
        let table_definition =
            r#"
            DEFINE TABLE projects SCHEMAFULL;
            DEFINE FIELD id ON projects TYPE string;
            DEFINE FIELD user_id ON projects TYPE string;
            DEFINE FIELD name ON projects TYPE string;
            DEFINE FIELD description ON projects TYPE option<string>;
            DEFINE FIELD created_at ON projects TYPE string;
            DEFINE FIELD staging_path ON projects TYPE string;
            DEFINE FIELD original_directory_path ON projects TYPE string;
            DEFINE FIELD metrics ON projects TYPE object;
            DEFINE INDEX projectUserIndex ON projects FIELDS user_id;
            DEFINE INDEX projectNameIndex ON projects FIELDS name;
        "#;

        self.ensure_metrics_table().await?;

        self.document_service.define_table(table_definition).await
    }










    /// Create a new project
    pub async fn create_project(
        &self,
        user_id: &str,
        name: &str,
        description: Option<&str>,
        staging_path: &str,
        original_directory_path: &str
    ) -> DocumentResult<Project> {
        println!("Step 1: Generating new UUID for project");
        let id = Uuid::new_v4().to_string();

        println!("Step 2: Setting creation timestamp");
        let created_at = Utc::now().to_rfc3339();

        println!("Step 3: Initializing project metrics");
        let metrics = ProjectMetrics::new(&id);

        let project: Project = Project {
            id: string_to_record_id("projects", &id),
            metrics: metrics,
            user_id: user_id.to_string(),
            name: name.to_string(),
            description: description.map(|s| s.to_string()),
            created_at,
            staging_path: staging_path.to_string(),
            original_directory_path: original_directory_path.to_string()
        };

        let metrics_clone = project.metrics.clone();

        let metrics_data = json!({
            "project_id": project.id.to_string(),
            "file_count": metrics_clone.file_count,
            "directory_count": metrics_clone.directory_count,
            "total_bytes": metrics_clone.total_bytes,
            "operating_system": project.metrics.operating_system,
            "last_updated": metrics_clone.last_updated,
            "file_types": metrics_clone.file_types,
            "largest_file_path": metrics_clone.largest_file_path,
            "largest_file_size": metrics_clone.largest_file_size
        });

        println!("Step 4: Preparing project data JSON structure");
        // Create project data WITHOUT the id field - let SurrealDB handle it
        let project_data = json!({
            "user_id": user_id,
            "name": name,
            "description": description,
            "created_at": project.created_at,
            "staging_path": staging_path,
            "original_directory_path": original_directory_path,
            "metrics": metrics_data.clone()
        });

        println!("Step 5: Creating project in database with ID: {}", id);
        // Use create_with_id to control the ID - SurrealDB will add the id field automatically
        let result = match self.document_service.create_with_id::<Project>(
            "projects",
            &id,
            project_data
        ).await {
            Ok(project) => {
                println!("Step 6: Project created successfully");
                project
            },
            Err(e) => {
                println!("Step 6: Failed to create project - {}", e);
                return Err(DocumentError::SerializationError(e.to_string()));
            }
        };

        println!("Step 7: Returning created project - Result: {:?}", result);
        Ok(result)
    }

    /// Get a project by ID
    pub async fn get_project(&self, id: &str) -> DocumentResult<Option<Project>> {
        self.document_service.read("projects", id).await
    }

    /// List all projects for a specific user
    pub async fn list_projects_by_user(&self, user_id: &str) -> DocumentResult<Vec<Project>> {
        let builder = QueryBuilder::new("projects")
            .where_eq("user_id", json!(user_id))
            .order_by("created_at", "DESC");

        self.document_service.query_with_builder(builder).await
    }

    /// List all projects (admin function)
    pub async fn list_all_projects(&self) -> DocumentResult<Vec<Project>> {
        self.document_service.read_all("projects").await
    }













    /// Update a project
    pub async fn update_project(
        &self,
        id: &str,
        name: Option<&str>,
        description: Option<Option<&str>>,
        staging_path: Option<&str>
    ) -> DocumentResult<Option<Project>> {
        let mut update_data = json!({
            "updated_at": Utc::now().to_rfc3339()
        });

        if let Some(name) = name {
            update_data["name"] = json!(name);
        }

        if let Some(description) = description {
            update_data["description"] = json!(description);
        }

        if let Some(staging_path) = staging_path {
            update_data["staging_path"] = json!(staging_path);
        }

        self.document_service.merge("projects", id, update_data).await
    }

    /// Delete a project
    pub async fn delete_project(&self, id: &str) -> DocumentResult<Option<Project>> {
        self.document_service.delete("projects", id).await
    }

    /// Check if a project exists
    pub async fn project_exists(&self, id: &str) -> DocumentResult<bool> {
        self.document_service.exists("projects", id).await
    }

    /// Count projects for a user
    pub async fn count_user_projects(&self, user_id: &str) -> DocumentResult<i64> {
        let count_query = "SELECT count() FROM projects WHERE user_id = $user_id GROUP ALL";

        #[derive(serde::Deserialize)]
        struct CountResult {
            count: i64,
        }

        let results: Vec<CountResult> = self.document_service.query(
            &count_query,
            std::collections::HashMap::from([("user_id".to_string(), json!(user_id))])
        ).await?;

        Ok(
            results
                .first()
                .map(|r| r.count)
                .unwrap_or(0)
        )
    }

    /// Search projects by name pattern
    pub async fn search_projects_by_name(
        &self,
        user_id: &str,
        name_pattern: &str
    ) -> DocumentResult<Vec<Project>> {
        let builder = QueryBuilder::new("projects")
            .where_eq("user_id", json!(user_id))
            .where_like("name", name_pattern)
            .order_by("name", "ASC");

        self.document_service.query_with_builder(builder).await
    }

    /// Get recent projects for a user
    pub async fn get_recent_projects(
        &self,
        user_id: &str,
        limit: usize
    ) -> DocumentResult<Vec<Project>> {
        let builder = QueryBuilder::new("projects")
            .where_eq("user_id", json!(user_id))
            .order_by("created_at", "DESC")
            .limit(limit);

        self.document_service.query_with_builder(builder).await
    }

    /// Batch create projects
    pub async fn batch_create_projects(
        &self,
        projects_data: Vec<Value>
    ) -> DocumentResult<Vec<Project>> {
        let mut results = Vec::new();

        for mut project_data in projects_data {
            let id = Uuid::new_v4().to_string();
            project_data["id"] = json!(id);
            project_data["created_at"] = json!(Utc::now().to_rfc3339());

            let result: serde_json::Value = self.document_service.create_with_id(
                "projects",
                &id,
                project_data
            ).await?;
            let project: Project = serde_json
                ::from_value(result)
                .map_err(|e| DocumentError::SerializationError(e.to_string()))?;
            results.push(project);
        }

        Ok(results)
    }
}

impl Default for ProjectRepository {
    fn default() -> Self {
        Self::new()
    }
}
