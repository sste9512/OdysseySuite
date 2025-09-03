use serde::{ Deserialize, Serialize };
use uuid::Uuid;
use std::fmt;
use chrono::{ DateTime, Utc };

/// Represents a user in the system
#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct User {
    pub id: String,
    pub username: String,
    #[serde(skip_serializing)]
    pub password: String,
    pub email: String,
    pub created_at: DateTime<Utc>,
    pub updated_at: DateTime<Utc>,
    pub is_active: bool,
    pub is_admin: bool,
    pub profile_picture: Option<String>,
}

/// Represents user authorization data
#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct Authorization {
    pub user_id: String,
    pub token: String,
    pub token_type: String,
    pub expires_at: DateTime<Utc>,
    pub refresh_token: Option<String>,
    pub refresh_token_expires_at: Option<DateTime<Utc>>,
    pub scopes: Vec<String>,
    pub created_at: DateTime<Utc>,
    pub last_used_at: DateTime<Utc>,
    pub is_revoked: bool,
}

impl Authorization {
    /// Creates a new authorization for a user
    pub fn new(
        user_id: String,
        token: String,
        token_type: String,
        expires_at: DateTime<Utc>,
        scopes: Vec<String>
    ) -> Self {
        let now = Utc::now();
        Self {
            user_id,
            token,
            token_type,
            expires_at,
            refresh_token: None,
            refresh_token_expires_at: None,
            scopes,
            created_at: now,
            last_used_at: now,
            is_revoked: false,
        }
    }

    /// Creates a new authorization with refresh token
    pub fn with_refresh_token(
        user_id: String,
        token: String,
        token_type: String,
        expires_at: DateTime<Utc>,
        refresh_token: String,
        refresh_token_expires_at: DateTime<Utc>,
        scopes: Vec<String>
    ) -> Self {
        let now = Utc::now();
        Self {
            user_id,
            token,
            token_type,
            expires_at,
            refresh_token: Some(refresh_token),
            refresh_token_expires_at: Some(refresh_token_expires_at),
            scopes,
            created_at: now,
            last_used_at: now,
            is_revoked: false,
        }
    }

    /// Checks if the authorization is valid (not expired and not revoked)
    pub fn is_valid(&self) -> bool {
        !self.is_revoked && self.expires_at > Utc::now()
    }

    /// Updates the last used timestamp
    pub fn update_last_used(&mut self) {
        self.last_used_at = Utc::now();
    }

    /// Revokes this authorization
    pub fn revoke(&mut self) {
        self.is_revoked = true;
    }

    /// Checks if the refresh token is valid
    pub fn is_refresh_token_valid(&self) -> bool {
        match (self.refresh_token.as_ref(), self.refresh_token_expires_at) {
            (Some(_), Some(expires_at)) => !self.is_revoked && expires_at > Utc::now(),
            _ => false,
        }
    }
}

impl User {
    /// Creates a new user with a generated UUID
    pub fn new(username: String, password: String, email: String) -> Self {
        let now = Utc::now();
        Self {
            id: Uuid::new_v4().to_string(),
            username,
            password,
            email,
            created_at: now,
            updated_at: now,
            is_active: true,
            is_admin: false,
            profile_picture: None,
        }
    }

    /// Creates a user with a specific ID
    pub fn with_id(id: String, username: String, password: String, email: String) -> Self {
        let now = Utc::now();
        Self {
            id,
            username,
            password,
            email,
            created_at: now,
            updated_at: now,
            is_active: true,
            is_admin: false,
            profile_picture: None,
        }
    }

    /// Validates if the user data is correct
    pub fn validate(&self) -> Result<(), UserError> {
        if self.username.is_empty() {
            return Err(UserError::EmptyUsername);
        }
        if self.password.is_empty() {
            return Err(UserError::EmptyPassword);
        }
        Ok(())
    }
}

/// Errors that can occur when working with users
#[derive(Debug)]
pub enum UserError {
    EmptyUsername,
    EmptyPassword,
    AuthenticationFailed,
    UserNotFound,
    DatabaseError(String),
}

impl fmt::Display for UserError {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        match self {
            UserError::EmptyUsername => write!(f, "Username cannot be empty"),
            UserError::EmptyPassword => write!(f, "Password cannot be empty"),
            UserError::AuthenticationFailed => write!(f, "Authentication failed"),
            UserError::UserNotFound => write!(f, "User not found"),
            UserError::DatabaseError(err) => write!(f, "Database error: {}", err),
        }
    }
}

impl std::error::Error for UserError {}
