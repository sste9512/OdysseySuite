use crate::domain::entities::user::{User, UserError};
use crate::infrastructure::database::surreal_db_runtime::SurrealDbRuntime;
use chrono::{DateTime, Utc};
use serde_json::json;
use std::result::Result;

pub struct AuthorizationService {
    db_runtime: SurrealDbRuntime,
}

impl AuthorizationService {
    pub fn new() -> Self {
        Self {
            db_runtime: SurrealDbRuntime::new(),
        }
    }

    pub async fn initialize(&mut self) -> Result<(), UserError> {
        match self.db_runtime.open("surrealdb.db").await {
            Ok(_) => {
                println!("Successfully opened database connection");

                // Use the aurora namespace and database
                if let Some(db) = self.db_runtime.get_db() {
                    match db.use_ns("aurora").use_db("aurora").await {
                        Ok(_) => {
                            println!("Successfully connected to aurora namespace and database");
                            Ok(())
                        }
                        Err(e) => {
                            println!("Failed to use namespace/database: {}", e);
                            Err(UserError::DatabaseError(format!(
                                "Failed to use namespace/database: {}",
                                e
                            )))
                        }
                    }
                } else {
                    Err(UserError::DatabaseError(
                        "Failed to get database instance".to_string(),
                    ))
                }
            }
            Err(e) => {
                println!("Failed to open database: {}", e);
                Err(UserError::DatabaseError(format!(
                    "Failed to open database: {}",
                    e
                )))
            }
        }
    }

    pub async fn sign_in(&self, username: &str, password: &str) -> Result<User, UserError> {
        println!("Starting user sign-in process for username: {}", username);

        // Validate input
        if username.is_empty() {
            return Err(UserError::EmptyUsername);
        }
        if password.is_empty() {
            return Err(UserError::EmptyPassword);
        }

        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        // Check if user already exists in the database
        let existing_user_query = format!("SELECT * FROM users WHERE username = '{}'", username);
        println!(
            "Checking if user already exists with query: {}",
            existing_user_query
        );

        match db.query(existing_user_query).await {
            Ok(mut response) => {
                match response.take::<Vec<serde_json::Value>>(0) {
                    Ok(users) => {
                        let now = Utc::now();
                        let user_id = uuid::Uuid::new_v4().to_string();

                        if users.is_empty() {
                            println!("User does not exist in database, creating new user");
                            self.create_new_user(&user_id, username, password, now)
                                .await?;
                        } else {
                            println!("User already exists in database, updating login time");
                            self.update_user_login_time(username, now).await?;

                            // Extract user ID from existing user
                            if let Some(existing_user) = users.first() {
                                if let Some(id) = existing_user.get("id").and_then(|v| v.as_str()) {
                                    return self
                                        .build_user_from_database(id, username, password)
                                        .await;
                                }
                            }
                        }

                        self.build_user_response(&user_id, username, password, now)
                    }
                    Err(e) => {
                        println!("Error processing user query results: {}", e);
                        Err(UserError::DatabaseError(format!(
                            "Error checking for existing user: {}",
                            e
                        )))
                    }
                }
            }
            Err(e) => {
                println!("Failed to query for existing user: {}", e);
                Err(UserError::DatabaseError(format!(
                    "Failed to check if user exists: {}",
                    e
                )))
            }
        }
    }

    async fn create_new_user(
        &self,
        user_id: &str,
        username: &str,
        password: &str,
        now: DateTime<Utc>,
    ) -> Result<(), UserError> {
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let user_data = json!({
            "id": user_id,
            "username": username,
            "password": password, // Note: In a real app, store hashed passwords
            "email": format!("{}@example.com", username), // Default email
            "created_at": now.to_rfc3339(),
            "updated_at": now.to_rfc3339(),
            "is_active": true,
            "is_admin": false,
            "profile_picture": null,
            "login_time": now.to_rfc3339()
        });
        println!("Created user data JSON for new user");

        match db
            .update(surrealdb::opt::Resource::from("users"))
            .content(user_data)
            .await
        {
            Ok(_) => {
                println!("Successfully created new user in database");
                Ok(())
            }
            Err(e) => {
                println!("Failed to create new user: {}", e);
                Err(UserError::DatabaseError(format!(
                    "Failed to create new user: {}",
                    e
                )))
            }
        }
    }

    async fn update_user_login_time(
        &self,
        username: &str,
        now: DateTime<Utc>,
    ) -> Result<(), UserError> {
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let update_query = format!(
            "UPDATE users SET login_time = '{}', updated_at = '{}' WHERE username = '{}'",
            now.to_rfc3339(),
            now.to_rfc3339(),
            username
        );

        match db.query(update_query).await {
            Ok(_) => {
                println!("Successfully updated user login time");
                Ok(())
            }
            Err(e) => {
                println!("Failed to update user login time: {}", e);
                Err(UserError::DatabaseError(format!(
                    "Failed to update user login time: {}",
                    e
                )))
            }
        }
    }

    async fn build_user_from_database(
        &self,
        user_id: &str,
        username: &str,
        password: &str,
    ) -> Result<User, UserError> {
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let query = format!("SELECT * FROM users WHERE id = '{}'", user_id);

        match db.query(query).await {
            Ok(mut response) => match response.take::<Vec<serde_json::Value>>(0) {
                Ok(users) => {
                    if let Some(user_data) = users.first() {
                        let now = Utc::now();
                        Ok(User {
                            id: user_id.to_string(),
                            username: username.to_string(),
                            password: password.to_string(),
                            email: user_data
                                .get("email")
                                .and_then(|v| v.as_str())
                                .unwrap_or(&format!("{}@example.com", username))
                                .to_string(),
                            created_at: user_data
                                .get("created_at")
                                .and_then(|v| v.as_str())
                                .and_then(|s| DateTime::parse_from_rfc3339(s).ok())
                                .map(|dt| dt.with_timezone(&Utc))
                                .unwrap_or(now),
                            updated_at: now,
                            is_active: user_data
                                .get("is_active")
                                .and_then(|v| v.as_bool())
                                .unwrap_or(true),
                            is_admin: user_data
                                .get("is_admin")
                                .and_then(|v| v.as_bool())
                                .unwrap_or(false),
                            profile_picture: user_data
                                .get("profile_picture")
                                .and_then(|v| v.as_str())
                                .map(|s| s.to_string()),
                        })
                    } else {
                        Err(UserError::UserNotFound)
                    }
                }
                Err(e) => Err(UserError::DatabaseError(format!(
                    "Failed to parse user data: {}",
                    e
                ))),
            },
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to query user: {}",
                e
            ))),
        }
    }

    fn build_user_response(
        &self,
        user_id: &str,
        username: &str,
        password: &str,
        now: DateTime<Utc>,
    ) -> Result<User, UserError> {
        let user = User {
            id: user_id.to_string(),
            username: username.to_string(),
            password: password.to_string(),
            email: format!("{}@example.com", username),
            created_at: now,
            updated_at: now,
            is_active: true,
            is_admin: false,
            profile_picture: None,
        };

        match user.validate() {
            Ok(_) => {
                println!("Created User object for return");
                println!("Sign-in process completed successfully");
                Ok(user)
            }
            Err(e) => Err(e),
        }
    }

    pub async fn sign_out(&self, user_id: &str) -> Result<(), UserError> {
        println!("Starting user sign-out process for user ID: {}", user_id);

        if user_id.is_empty() {
            return Err(UserError::DatabaseError(
                "User ID cannot be empty".to_string(),
            ));
        }

        // For now, just ensure database connection is available
        // In a real implementation, you might want to invalidate tokens, update last_logout_time, etc.
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let now = Utc::now();
        let update_query = format!(
            "UPDATE users SET last_logout_time = '{}', updated_at = '{}' WHERE id = '{}'",
            now.to_rfc3339(),
            now.to_rfc3339(),
            user_id
        );

        match db.query(update_query).await {
            Ok(_) => {
                println!("Successfully updated user logout time");
                Ok(())
            }
            Err(e) => {
                println!("Failed to update user logout time: {}", e);
                // Don't fail the logout process if we can't update the database
                // Just log the error and continue
                println!("Warning: Could not update logout time, but logout process continues");
                Ok(())
            }
        }
    }

    pub async fn validate_user(&self, username: &str, password: &str) -> Result<bool, UserError> {
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let query = format!(
            "SELECT * FROM users WHERE username = '{}' AND password = '{}'",
            username, password
        );

        match db.query(query).await {
            Ok(mut response) => match response.take::<Vec<serde_json::Value>>(0) {
                Ok(users) => Ok(!users.is_empty()),
                Err(e) => Err(UserError::DatabaseError(format!(
                    "Failed to validate user: {}",
                    e
                ))),
            },
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to query user validation: {}",
                e
            ))),
        }
    }

    pub async fn get_user_by_id(&self, user_id: &str) -> Result<Option<User>, UserError> {
        let db = self
            .db_runtime
            .get_db()
            .ok_or_else(|| UserError::DatabaseError("Database not initialized".to_string()))?;

        let query = format!("SELECT * FROM users WHERE id = '{}'", user_id);

        match db.query(query).await {
            Ok(mut response) => match response.take::<Vec<serde_json::Value>>(0) {
                Ok(users) => {
                    if let Some(user_data) = users.first() {
                        let now = Utc::now();
                        let user = User {
                            id: user_data
                                .get("id")
                                .and_then(|v| v.as_str())
                                .unwrap_or(user_id)
                                .to_string(),
                            username: user_data
                                .get("username")
                                .and_then(|v| v.as_str())
                                .unwrap_or("")
                                .to_string(),
                            password: user_data
                                .get("password")
                                .and_then(|v| v.as_str())
                                .unwrap_or("")
                                .to_string(),
                            email: user_data
                                .get("email")
                                .and_then(|v| v.as_str())
                                .unwrap_or("")
                                .to_string(),
                            created_at: user_data
                                .get("created_at")
                                .and_then(|v| v.as_str())
                                .and_then(|s| DateTime::parse_from_rfc3339(s).ok())
                                .map(|dt| dt.with_timezone(&Utc))
                                .unwrap_or(now),
                            updated_at: user_data
                                .get("updated_at")
                                .and_then(|v| v.as_str())
                                .and_then(|s| DateTime::parse_from_rfc3339(s).ok())
                                .map(|dt| dt.with_timezone(&Utc))
                                .unwrap_or(now),
                            is_active: user_data
                                .get("is_active")
                                .and_then(|v| v.as_bool())
                                .unwrap_or(true),
                            is_admin: user_data
                                .get("is_admin")
                                .and_then(|v| v.as_bool())
                                .unwrap_or(false),
                            profile_picture: user_data
                                .get("profile_picture")
                                .and_then(|v| v.as_str())
                                .map(|s| s.to_string()),
                        };
                        Ok(Some(user))
                    } else {
                        Ok(None)
                    }
                }
                Err(e) => Err(UserError::DatabaseError(format!(
                    "Failed to parse user data: {}",
                    e
                ))),
            },
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to query user: {}",
                e
            ))),
        }
    }
}

impl Default for AuthorizationService {
    fn default() -> Self {
        Self::new()
    }
}
