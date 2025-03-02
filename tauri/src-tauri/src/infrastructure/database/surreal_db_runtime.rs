use surrealdb::engine::local::{Db, RocksDb};
use surrealdb::Surreal;
use std::path::Path;

pub struct SurrealDbRuntime {
    db: Option<Surreal<Db>>,
}

impl SurrealDbRuntime {
    pub fn new() -> Self {
        SurrealDbRuntime { db: None }
    }

    pub async fn open(&mut self, path: &str) -> Result<(), String> {
        // Ensure parent directory exists
        if let Some(parent) = Path::new(path).parent() {
            std::fs::create_dir_all(parent).map_err(|e| e.to_string())?;
        }

        match Surreal::new::<RocksDb>(path).await {
            Ok(db) => {
                self.db = Some(db);
                Ok(())
            }
            Err(e) => Err(e.to_string())
        }
    }

    pub async fn close(&mut self) -> Result<(), String> {
        if let Some(db) = self.db.take() {
            db.close().await.map_err(|e| e.to_string())?;
        }
        Ok(())
    }

    pub fn get_db(&self) -> Option<&Surreal<Db>> {
        self.db.as_ref()
    }


    pub async fn create_resource_file_definition(&self) -> Result<(), String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;

        // Define the resource_files table schema
        let define_query = "
            DEFINE TABLE resource_files SCHEMAFULL;
            DEFINE FIELD filepath ON resource_files TYPE string;
            DEFINE FIELD filename ON resource_files TYPE string;
            DEFINE FIELD resource_count ON resource_files TYPE int;
            DEFINE FIELD file_size ON resource_files TYPE int;
            DEFINE FIELD last_modified ON resource_files TYPE string;
            DEFINE FIELD file_type ON resource_files TYPE string;
            DEFINE INDEX resourceFilePathIndex ON resource_files FIELDS filepath UNIQUE;
        ";

        db.query(define_query)
            .await
            .map_err(|e| e.to_string())?;

        Ok(())
    }

    
}


    pub async fn create_user_definition(&self) -> Result<(), String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;

        // Define the user table schema
        let define_query = "
            DEFINE TABLE users SCHEMAFULL;
            DEFINE FIELD username ON users TYPE string;
            DEFINE FIELD email ON users TYPE string;
            DEFINE FIELD created_at ON users TYPE datetime;
            DEFINE FIELD updated_at ON users TYPE datetime;
            DEFINE INDEX userEmailIndex ON users FIELDS email UNIQUE;
            DEFINE INDEX userNameIndex ON users FIELDS username UNIQUE;
        ";

        db.query(define_query)
            .await
            .map_err(|e| e.to_string())?;

        Ok(())
    }


    pub async fn create_user(&self, username: &str, email: &str) -> Result<(), String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;
        
        let user = serde_json::json!({
            "username": username,
            "email": email,
            "created_at": chrono::Utc::now().to_rfc3339()
        });

        db.create(("users", username))
            .content(user)
            .await
            .map_err(|e| e.to_string())?;

        Ok(())
    }

    pub async fn get_user(&self, username: &str) -> Result<Option<serde_json::Value>, String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;
        
        let result = db.select(("users", username))
            .await
            .map_err(|e| e.to_string())?;
            
        Ok(result)
    }

    pub async fn update_user(&self, username: &str, email: &str) -> Result<(), String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;

        let updates = serde_json::json!({
            "email": email,
            "updated_at": chrono::Utc::now().to_rfc3339()
        });

        db.update(("users", username))
            .merge(updates)
            .await
            .map_err(|e| e.to_string())?;

        Ok(())
    }

    pub async fn delete_user(&self, username: &str) -> Result<(), String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;

        db.delete(("users", username))
            .await
            .map_err(|e| e.to_string())?;

        Ok(())
    }

    pub async fn list_users(&self) -> Result<Vec<serde_json::Value>, String> {
        let db = self.db.as_ref().ok_or("Database not initialized")?;

        let users = db.select("users")
            .await
            .map_err(|e| e.to_string())?;

        Ok(users)
    }

