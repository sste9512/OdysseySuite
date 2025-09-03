# SurrealDB Document Service Wrapper

This module provides a comprehensive wrapper around SurrealDB document operations, making it easier to work with SurrealDB in a type-safe and ergonomic way.

## Components

### 1. DocumentService (`document_service.rs`)

The main service that provides a high-level interface for SurrealDB operations.

#### Key Features:
- **Type-safe operations**: All operations are generic over your data types
- **Query builder**: Fluent API for building complex queries
- **Error handling**: Custom error types with detailed error messages
- **Connection management**: Handles database initialization and connection
- **CRUD operations**: Create, Read, Update, Delete operations
- **Batch operations**: Support for batch creating documents
- **Schema definition**: Define table schemas programmatically

#### Basic Usage:

```rust
use crate::infrastructure::database::document_service::{DocumentService, QueryBuilder};

// Initialize the service
let mut service = DocumentService::new();
service.initialize("database.db").await?;

// Create a document
let user = User { name: "John".to_string(), age: 30 };
let created_user = service.create("users", user).await?;

// Read a document
let user: Option<User> = service.read("users", "user_id").await?;

// Update a document
let updated_user = User { name: "Jane".to_string(), age: 31 };
let result = service.update("users", "user_id", updated_user).await?;

// Query with builder
let builder = QueryBuilder::new("users")
    .where_eq("age", json!(30))
    .order_by("name", "ASC")
    .limit(10);

let users: Vec<User> = service.query_with_builder(builder).await?;
```

### 2. ProjectRepository (`project_repository.rs`)

A specialized repository for project-related database operations, demonstrating the repository pattern.

#### Features:
- **Domain-specific operations**: Methods tailored for project management
- **Automatic schema management**: Ensures project table schema is defined
- **User-scoped operations**: Built-in filtering by user ID
- **Search capabilities**: Search projects by name patterns
- **Batch operations**: Create multiple projects at once

#### Usage:

```rust
use crate::infrastructure::database::project_repository::ProjectRepository;

// Initialize repository
let mut repository = ProjectRepository::new();
repository.initialize("database.db").await?;

// Create a project
let project = repository.create_project(
    "user_123",
    "My Project",
    Some("Project description"),
    "/staging/path",
    "/original/path"
).await?;

// List user's projects
let projects = repository.list_projects_by_user("user_123").await?;

// Search projects
let matching_projects = repository.search_projects_by_name(
    "user_123", 
    "*game*"
).await?;
```

### 3. QueryBuilder

A fluent API for building SurrealDB queries programmatically.

#### Methods:
- `select(fields)`: Specify which fields to select
- `where_eq(field, value)`: Add equality condition
- `where_in(field, values)`: Add IN condition
- `where_like(field, pattern)`: Add pattern matching condition
- `order_by(field, direction)`: Add ordering
- `limit(count)`: Limit results

#### Example:

```rust
let builder = QueryBuilder::new("projects")
    .select(&["id", "name", "created_at"])
    .where_eq("user_id", json!("user_123"))
    .where_like("name", "*web*")
    .order_by("created_at", "DESC")
    .limit(20);

let (query, bindings) = builder.build();
// Results in: "SELECT id, name, created_at FROM projects WHERE user_id = $param_0 AND name ~ $param_1 ORDER BY created_at DESC LIMIT 20"
```

## Error Handling

The service uses a custom `DocumentError` enum that provides detailed error information:

```rust
pub enum DocumentError {
    ConnectionError(String),
    SerializationError(String), 
    QueryError(String),
    NotFound,
    NotInitialized,
    InvalidParameters(String),
}
```

All operations return `DocumentResult<T>` which is `Result<T, DocumentError>`.

## Best Practices

### 1. Repository Pattern
Create domain-specific repositories like `ProjectRepository` that encapsulate business logic:

```rust
pub struct UserRepository {
    document_service: DocumentService,
}

impl UserRepository {
    pub async fn find_active_users(&self) -> DocumentResult<Vec<User>> {
        let builder = QueryBuilder::new("users")
            .where_eq("active", json!(true))
            .order_by("last_login", "DESC");
        
        self.document_service.query_with_builder(builder).await
    }
}
```

### 2. Schema Management
Define your table schemas in the repository initialization:

```rust
async fn ensure_users_table(&self) -> DocumentResult<()> {
    let schema = r#"
        DEFINE TABLE users SCHEMAFULL;
        DEFINE FIELD name ON users TYPE string;
        DEFINE FIELD email ON users TYPE string;
        DEFINE FIELD active ON users TYPE bool DEFAULT true;
        DEFINE INDEX userEmailIndex ON users FIELDS email UNIQUE;
    "#;
    
    self.document_service.define_table(schema).await
}
```

### 3. Type Safety
Always specify your types explicitly for better error messages:

```rust
// Good
let user: User = service.create("users", user_data).await?;

// Better error messages than
let user = service.create("users", user_data).await?;
```

### 4. Error Handling
Handle errors appropriately in your application layer:

```rust
match repository.get_project(id).await {
    Ok(Some(project)) => Ok(project),
    Ok(None) => Err("Project not found".to_string()),
    Err(DocumentError::ConnectionError(e)) => {
        log::error!("Database connection failed: {}", e);
        Err("Database unavailable".to_string())
    }
    Err(e) => Err(format!("Database error: {}", e)),
}
```

## Integration with Tauri Commands

The repository pattern integrates cleanly with Tauri commands:

```rust
#[tauri::command]
pub async fn create_project(
    state: tauri::State<'_, Mutex<AppState>>,
    name: &str,
    description: Option<&str>,
) -> Result<Project, String> {
    let mut repository = ProjectRepository::new();
    repository.initialize("database.db").await
        .map_err(|e| format!("Failed to initialize database: {}", e))?;
    
    // Get user from state
    let guard = state.lock().await;
    let user_id = guard.current_user.as_ref()
        .ok_or("No user logged in")?
        .id.clone();
    drop(guard);
    
    repository.create_project(&user_id, name, description, "/staging", "/original")
        .await
        .map_err(|e| format!("Failed to create project: {}", e))
}
```

## Testing

The service is designed to be easily testable. You can create test databases and repositories:

```rust
#[tokio::test]
async fn test_project_creation() {
    let mut repository = ProjectRepository::new();
    repository.initialize("test_db.db").await.unwrap();
    
    let project = repository.create_project(
        "test_user",
        "Test Project", 
        None,
        "/test/staging",
        "/test/original"
    ).await.unwrap();
    
    assert_eq!(project.name, "Test Project");
    assert_eq!(project.user_id, "test_user");
}
```

This wrapper provides a clean, type-safe, and maintainable way to work with SurrealDB in your Rust applications.
