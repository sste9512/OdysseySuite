use crate::domain::entities::user::{User, UserError};
use crate::infrastructure::database::document_service::{DocumentService, DocumentError, QueryBuilder};
use crate::infrastructure::database::project_repository::string_to_record_id;
use chrono::{DateTime, Utc};
use serde::{Deserialize, Serialize};
use serde_json::json;
use surrealdb::opt::auth::Record;
use surrealdb::RecordId;
use std::result::Result;
use uuid::Uuid;

/// Database representation of a user (with additional fields for database storage)
#[derive(Debug, Clone, Serialize, Deserialize)]
struct UserRecord {
    pub id: RecordId,
    pub username: String,
    pub password: String,
    pub email: String,
    pub created_at: String,
    pub updated_at: String,
    pub is_active: bool,
    pub is_admin: bool,
    pub profile_picture: Option<String>,
    pub login_time: Option<String>,
    pub last_logout_time: Option<String>,
    pub login_count: i32,
    pub failed_login_attempts: i32,
}

impl UserRecord {
    /// Convert UserRecord to domain User entity
    fn to_user(&self) -> Result<User, UserError> {
        Ok(User {
            id: self.id.to_string(),
            username: self.username.clone(),
            password: self.password.clone(),
            email: self.email.clone(),
            created_at: DateTime::parse_from_rfc3339(&self.created_at)
                .map_err(|e| UserError::DatabaseError(format!("Invalid created_at date: {}", e)))?
                .with_timezone(&Utc),
            updated_at: DateTime::parse_from_rfc3339(&self.updated_at)
                .map_err(|e| UserError::DatabaseError(format!("Invalid updated_at date: {}", e)))?
                .with_timezone(&Utc),
            is_active: self.is_active,
            is_admin: self.is_admin,
            profile_picture: self.profile_picture.clone(),
        })
    }

    /// Convert domain User to UserRecord
    fn from_user(user: &User) -> Self {
        Self {
            id: string_to_record_id("users", &user.id.clone()),
            username: user.username.clone(),
            password: user.password.clone(),
            email: user.email.clone(),
            created_at: user.created_at.to_rfc3339(),
            updated_at: user.updated_at.to_rfc3339(),
            is_active: user.is_active,
            is_admin: user.is_admin,
            profile_picture: user.profile_picture.clone(),
            login_time: None,
            last_logout_time: None,
            login_count: 0,
            failed_login_attempts: 0,
        }
    }
}

/// Authorization service for user management
pub struct AuthorizationService {
    document_service: DocumentService,
}

impl AuthorizationService {
    const USERS_TABLE: &'static str = "users";
    const MAX_FAILED_ATTEMPTS: i32 = 5;

    pub fn new() -> Self {
        Self {
            document_service: DocumentService::new(),
        }
    }

    /// Initialize the authorization service with database
    pub async fn initialize(&mut self) -> Result<(), UserError> {
        match self.document_service.initialize("surrealdb.db").await {
            Ok(_) => {
                println!("Successfully initialized document service");
                self.ensure_users_table().await?;
                Ok(())
            }
            Err(e) => {
                println!("Failed to initialize document service: {}", e);
                Err(UserError::DatabaseError(format!(
                    "Failed to initialize database: {}",
                    e
                )))
            }
        }
    }

    /// Ensure the users table is defined with proper schema
    async fn ensure_users_table(&self) -> Result<(), UserError> {
        let table_definition = r#"
            DEFINE TABLE users SCHEMAFULL;
            DEFINE FIELD id ON users TYPE string;
            DEFINE FIELD username ON users TYPE string;
            DEFINE FIELD password ON users TYPE string;
            DEFINE FIELD email ON users TYPE string;
            DEFINE FIELD created_at ON users TYPE string;
            DEFINE FIELD updated_at ON users TYPE string;
            DEFINE FIELD is_active ON users TYPE bool;
            DEFINE FIELD is_admin ON users TYPE bool;
            DEFINE FIELD profile_picture ON users TYPE option<string>;
            DEFINE FIELD login_time ON users TYPE option<string>;
            DEFINE FIELD last_logout_time ON users TYPE option<string>;
            DEFINE FIELD login_count ON users TYPE int DEFAULT 0;
            DEFINE FIELD failed_login_attempts ON users TYPE int DEFAULT 0;
            DEFINE INDEX usernameIndex ON users FIELDS username UNIQUE;
            DEFINE INDEX emailIndex ON users FIELDS email UNIQUE;
        "#;

        match self.document_service.define_table(table_definition).await {
            Ok(_) => Ok(()),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to define users table: {}",
                e
            ))),
        }
    }




    
    /// Sign in user - creates user if doesn't exist, updates login time if exists
    pub async fn sign_in(&self, username: &str, password: &str) -> Result<User, UserError> {
        println!("Starting user sign-in process for username: {}", username);

        // Validate input
        if username.is_empty() {
            return Err(UserError::EmptyUsername);
        }
        if password.is_empty() {
            return Err(UserError::EmptyPassword);
        }

        // Check if user exists
        match self.find_user_by_username(username).await? {
            Some(mut user_record) => {
                println!("User found in database, validating credentials");
                
                // Enforce account lockout policy
                if user_record.failed_login_attempts >= Self::MAX_FAILED_ATTEMPTS {
                    println!("Account locked due to too many failed attempts");
                    return Err(UserError::DatabaseError(
                        "Account is locked due to too many failed login attempts".to_string()
                    ));
                }

                // Enforce active user policy
                if !user_record.is_active {
                    println!("User account is inactive");
                    return Err(UserError::DatabaseError("User account is inactive".to_string()));
                }

                // Validate password
                if user_record.password != password {
                    println!("Invalid password attempt");
                    user_record.failed_login_attempts += 1;
                    self.update_failed_attempts(&user_record.id.to_string(), user_record.failed_login_attempts).await?;
                    return Err(UserError::AuthenticationFailed);
                }

                // Successful login - update login info
                println!("Authentication successful, updating login time");
                self.update_user_on_login(&user_record.id.to_string()).await?;
                
                user_record.to_user()
            }
            None => {
                println!("User does not exist, creating new user");
                let user = self.create_new_user(username, password).await?;
                Ok(user)
            }
        }
    }

    /// Find user by username
    async fn find_user_by_username(&self, username: &str) -> Result<Option<UserRecord>, UserError> {
        let builder = QueryBuilder::new(Self::USERS_TABLE)
            .where_eq("username", json!(username));

        match self.document_service.query_with_builder::<UserRecord>(builder).await {
            Ok(users) => Ok(users.into_iter().next()),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to query user: {}",
                e
            ))),
        }
    }

    /// Create a new user
    async fn create_new_user(&self, username: &str, password: &str) -> Result<User, UserError> {
        let user_id = Uuid::new_v4().to_string();
        let now = Utc::now();

        let user_record = UserRecord {
            id: string_to_record_id("users", &user_id.clone()),
            username: username.to_string(),
            password: password.to_string(),
            email: format!("{}@example.com", username),
            created_at: now.to_rfc3339(),
            updated_at: now.to_rfc3339(),
            is_active: true,
            is_admin: false,
            profile_picture: None,
            login_time: Some(now.to_rfc3339()),
            last_logout_time: None,
            login_count: 1,
            failed_login_attempts: 0,
        };

        match self.document_service.create_with_id(Self::USERS_TABLE, &user_id, user_record.clone()).await {
            Ok(_) => {
                println!("Successfully created new user in database");
                user_record.to_user()
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

    /// Update user login information
    async fn update_user_on_login(&self, user_id: &str) -> Result<(), UserError> {
        let now = Utc::now();
        
        let update_data = json!({
            "login_time": now.to_rfc3339(),
            "updated_at": now.to_rfc3339(),
            "failed_login_attempts": 0,
            "login_count": json!("login_count + 1"), // Increment login count
        });

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(_) => {
                println!("Successfully updated user login information");
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

    /// Update failed login attempts
    async fn update_failed_attempts(&self, user_id: &str, attempts: i32) -> Result<(), UserError> {
        let update_data = json!({
            "failed_login_attempts": attempts,
            "updated_at": Utc::now().to_rfc3339(),
        });

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(_) => Ok(()),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to update failed attempts: {}",
                e
            ))),
        }
    }

    /// Sign out user
    pub async fn sign_out(&self, user_id: &str) -> Result<(), UserError> {
        println!("Starting user sign-out process for user ID: {}", user_id);

        if user_id.is_empty() {
            return Err(UserError::DatabaseError(
                "User ID cannot be empty".to_string(),
            ));
        }

        let now = Utc::now();
        let update_data = json!({
            "last_logout_time": now.to_rfc3339(),
            "updated_at": now.to_rfc3339(),
        });

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(_) => {
                println!("Successfully updated user logout time");
                Ok(())
            }
            Err(e) => {
                println!("Failed to update user logout time: {}", e);
                // Don't fail the logout process if we can't update the database
                Ok(())
            }
        }
    }

    /// Validate user credentials
    pub async fn validate_user(&self, username: &str, password: &str) -> Result<bool, UserError> {
        match self.find_user_by_username(username).await? {
            Some(user_record) => {
                Ok(user_record.password == password 
                   && user_record.is_active 
                   && user_record.failed_login_attempts < Self::MAX_FAILED_ATTEMPTS)
            }
            None => Ok(false),
        }
    }

    /// Get user by ID
    pub async fn get_user_by_id(&self, user_id: &str) -> Result<Option<User>, UserError> {
        match self.document_service.read::<UserRecord>(Self::USERS_TABLE, user_id).await {
            Ok(Some(user_record)) => Ok(Some(user_record.to_user()?)),
            Ok(None) => Ok(None),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to query user: {}",
                e
            ))),
        }
    }

    /// Update user profile
    pub async fn update_user_profile(
        &self,
        user_id: &str,
        email: Option<&str>,
        profile_picture: Option<Option<&str>>,
    ) -> Result<Option<User>, UserError> {
        let mut update_data = json!({
            "updated_at": Utc::now().to_rfc3339()
        });

        if let Some(email) = email {
            update_data["email"] = json!(email);
        }

        if let Some(profile_picture) = profile_picture {
            update_data["profile_picture"] = json!(profile_picture);
        }

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(Some(user_record)) => Ok(Some(user_record.to_user()?)),
            Ok(None) => Ok(None),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to update user profile: {}",
                e
            ))),
        }
    }

    /// Deactivate user account (soft delete)
    pub async fn deactivate_user(&self, user_id: &str) -> Result<(), UserError> {
        let update_data = json!({
            "is_active": false,
            "updated_at": Utc::now().to_rfc3339(),
        });

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(_) => Ok(()),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to deactivate user: {}",
                e
            ))),
        }
    }

    /// Activate user account
    pub async fn activate_user(&self, user_id: &str) -> Result<(), UserError> {
        let update_data = json!({
            "is_active": true,
            "failed_login_attempts": 0,
            "updated_at": Utc::now().to_rfc3339(),
        });

        match self.document_service.merge::<UserRecord>(Self::USERS_TABLE, user_id, update_data).await {
            Ok(_) => Ok(()),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to activate user: {}",
                e
            ))),
        }
    }

    /// Reset failed login attempts (admin function)
    pub async fn reset_failed_attempts(&self, user_id: &str) -> Result<(), UserError> {
        self.update_failed_attempts(user_id, 0).await
    }

    /// List all users (admin function)
    pub async fn list_all_users(&self) -> Result<Vec<User>, UserError> {
        match self.document_service.read_all::<UserRecord>(Self::USERS_TABLE).await {
            Ok(user_records) => {
                user_records.into_iter()
                    .map(|record| record.to_user())
                    .collect()
            }
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to list users: {}",
                e
            ))),
        }
    }

    /// Count total users
    pub async fn count_users(&self) -> Result<i64, UserError> {
        match self.document_service.count(Self::USERS_TABLE).await {
            Ok(count) => Ok(count),
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to count users: {}",
                e
            ))),
        }
    }

    /// Delete user permanently (admin function)
    pub async fn delete_user(&self, user_id: &str) -> Result<(), UserError> {
        match self.document_service.delete::<UserRecord>(Self::USERS_TABLE, user_id).await {
            Ok(_) => {
                println!("Successfully deleted user: {}", user_id);
                Ok(())
            }
            Err(e) => Err(UserError::DatabaseError(format!(
                "Failed to delete user: {}",
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
