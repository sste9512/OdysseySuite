use serde::{Deserialize, Serialize};
use serde_json::{json, Value};
use std::collections::HashMap;
use surrealdb::engine::local::{Db, RocksDb};
use surrealdb::opt::Resource;
use surrealdb::Surreal;

/// Result type for document operations
pub type DocumentResult<T> = Result<T, DocumentError>;

/// Custom error type for document operations
#[derive(Debug, thiserror::Error, Serialize, Deserialize)]
pub enum DocumentError {
    #[error("Database connection error: {0}")]
    ConnectionError(String),
    #[error("Serialization error: {0}")]
    SerializationError(String),
    #[error("Query error: {0}")]
    QueryError(String),
    #[error("Document not found")]
    NotFound,
    #[error("Database not initialized")]
    NotInitialized,
    #[error("Invalid query parameters: {0}")]
    InvalidParameters(String),
}

/// Query builder for constructing SurrealDB queries
#[derive(Debug, Clone)]
pub struct QueryBuilder {
    table: String,
    select_fields: Vec<String>,
    where_conditions: Vec<String>,
    order_by: Option<String>,
    limit: Option<usize>,
    bindings: HashMap<String, Value>,
}

impl QueryBuilder {
    pub fn new(table: &str) -> Self {
        Self {
            table: table.to_string(),
            select_fields: vec!["*".to_string()],
            where_conditions: Vec::new(),
            order_by: None,
            limit: None,
            bindings: HashMap::new(),
        }
    }

    pub fn select(mut self, fields: &[&str]) -> Self {
        self.select_fields = fields.iter().map(|f| f.to_string()).collect();
        self
    }

    pub fn where_eq(mut self, field: &str, value: Value) -> Self {
        let param_name = format!("param_{}", self.bindings.len());
        self.where_conditions.push(format!("{} = ${}", field, param_name));
        self.bindings.insert(param_name, value);
        self
    }

    pub fn where_in(mut self, field: &str, values: Vec<Value>) -> Self {
        let param_name = format!("param_{}", self.bindings.len());
        self.where_conditions.push(format!("{} IN ${}", field, param_name));
        self.bindings.insert(param_name, json!(values));
        self
    }

    pub fn where_like(mut self, field: &str, pattern: &str) -> Self {
        let param_name = format!("param_{}", self.bindings.len());
        self.where_conditions.push(format!("{} ~ ${}", field, param_name));
        self.bindings.insert(param_name, json!(pattern));
        self
    }

    pub fn order_by(mut self, field: &str, direction: &str) -> Self {
        self.order_by = Some(format!("{} {}", field, direction));
        self
    }

    pub fn limit(mut self, limit: usize) -> Self {
        self.limit = Some(limit);
        self
    }

    pub fn build(self) -> (String, HashMap<String, Value>) {
        let mut query = format!("SELECT {} FROM {}", self.select_fields.join(", "), self.table);

        if !self.where_conditions.is_empty() {
            query.push_str(&format!(" WHERE {}", self.where_conditions.join(" AND ")));
        }

        if let Some(order) = self.order_by {
            query.push_str(&format!(" ORDER BY {}", order));
        }

        if let Some(limit) = self.limit {
            query.push_str(&format!(" LIMIT {}", limit));
        }

        (query, self.bindings)
    }
}

/// Document service wrapper for SurrealDB operations
pub struct DocumentService {
    db: Option<Surreal<Db>>,
    namespace: String,
    database: String,
}

impl DocumentService {
    pub fn new() -> Self {
        Self {
            db: None,
            namespace: "aurora".to_string(),
            database: "aurora".to_string(),
        }
    }

    pub fn with_namespace_and_db(namespace: &str, database: &str) -> Self {
        Self {
            db: None,
            namespace: namespace.to_string(),
            database: database.to_string(),
        }
    }

    /// Initialize the database connection
    pub async fn initialize(&mut self, path: &str) -> DocumentResult<()> {
        // Ensure parent directory exists
        if let Some(parent) = std::path::Path::new(path).parent() {
            std::fs::create_dir_all(parent)
                .map_err(|e| DocumentError::ConnectionError(e.to_string()))?;
        }

        // Create database connection
        let db = Surreal::new::<RocksDb>(path)
            .await
            .map_err(|e| DocumentError::ConnectionError(e.to_string()))?;

        // Use namespace and database
        db.use_ns(&self.namespace)
            .use_db(&self.database)
            .await
            .map_err(|e| DocumentError::ConnectionError(e.to_string()))?;

        self.db = Some(db);
        Ok(())
    }

    /// Get database reference
    fn get_db(&self) -> DocumentResult<&Surreal<Db>> {
        self.db.as_ref().ok_or(DocumentError::NotInitialized)
    }

    /// Create a new document
    pub async fn create<T>(&self, table: &str, data: T) -> DocumentResult<T>
    where
        T: Serialize + for<'de> Deserialize<'de> + 'static,
    {
        let db = self.get_db()?;
        
        let result: Vec<T> = db
            .insert(table)
            .content(data)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        // Convert SurrealDB Value to our type
        match result.into_iter().next() {
            Some(item) => Ok(item),
            None => Err(DocumentError::SerializationError("No document was created".to_string()))
        }
    }

    /// Create a document with a specific ID
    pub async fn create_with_id<T>(&self, table: &str, id: &str, data: T) -> DocumentResult<T>
    where
        T: Serialize + for<'de> Deserialize<'de> + 'static,
    {
        let db = self.get_db()?;
        
        let result: Option<T> = db
            .create((table, id))
            .content(data)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        result.ok_or(DocumentError::SerializationError("Failed to create document".to_string()))
    }

    /// Read a document by ID
    pub async fn read<T>(&self, table: &str, id: &str) -> DocumentResult<Option<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let db = self.get_db()?;
        
        let result: Option<T> = db
            .select((table, id))
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(result)
    }

    /// Read all documents from a table
    pub async fn read_all<T>(&self, table: &str) -> DocumentResult<Vec<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let db = self.get_db()?;
        
        let results: Vec<T> = db
            .select(table)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(results)
    }

    /// Update a document
    pub async fn update<T>(&self, table: &str, id: &str, data: T) -> DocumentResult<Option<T>>
    where
        T: Serialize + for<'de> Deserialize<'de> + 'static,
    {
        let db = self.get_db()?;
        
        let result: Option<T> = db
            .update((table, id))
            .content(data)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(result)
    }

    /// Merge data into a document (partial update)
    pub async fn merge<T>(&self, table: &str, id: &str, data: Value) -> DocumentResult<Option<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let db = self.get_db()?;
        
        let result: Option<T> = db
            .update((table, id))
            .merge(data)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(result)
    }

    /// Delete a document
    pub async fn delete<T>(&self, table: &str, id: &str) -> DocumentResult<Option<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let db = self.get_db()?;
        
        let result: Option<T> = db
            .delete((table, id))
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(result)
    }

    /// Execute a custom query with parameters
    pub async fn query<T>(&self, query: &str, params: HashMap<String, Value>) -> DocumentResult<Vec<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let db = self.get_db()?;
        
        let mut query_builder = db.query(query);
        
        // Bind parameters
        for (key, value) in params {
            query_builder = query_builder.bind((key, value));
        }

        let mut response = query_builder
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        let results: Vec<T> = response
            .take(0)
            .map_err(|e| DocumentError::SerializationError(e.to_string()))?;

        Ok(results)
    }

    /// Execute a query using the query builder
    pub async fn query_with_builder<T>(&self, builder: QueryBuilder) -> DocumentResult<Vec<T>>
    where
        T: for<'de> Deserialize<'de>,
    {
        let (query, params) = builder.build();
        self.query(&query, params).await
    }

    /// Count documents in a table
    pub async fn count(&self, table: &str) -> DocumentResult<i64> {
        let db = self.get_db()?;
        
        let query = format!("SELECT count() FROM {} GROUP ALL", table);
        let mut response = db
            .query(query)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        #[derive(Deserialize)]
        struct CountResult {
            count: i64,
        }

        let result: Vec<CountResult> = response
            .take(0)
            .map_err(|e| DocumentError::SerializationError(e.to_string()))?;

        Ok(result.first().map(|r| r.count).unwrap_or(0))
    }

    /// Check if a document exists
    pub async fn exists(&self, table: &str, id: &str) -> DocumentResult<bool> {
        let result: Option<Value> = self.read(table, id).await?;
        Ok(result.is_some())
    }

    /// Define a table schema
    pub async fn define_table(&self, table_definition: &str) -> DocumentResult<()> {
        let db = self.get_db()?;
        
        db.query(table_definition)
            .await
            .map_err(|e| DocumentError::QueryError(e.to_string()))?;

        Ok(())
    }

    /// Batch create multiple documents
    pub async fn batch_create<T>(&self, table: &str, documents: Vec<T>) -> DocumentResult<Vec<T>>
    where
        T: Serialize + for<'de> Deserialize<'de> + 'static,
    {
        let mut results = Vec::new();
        
        for doc in documents {
            let result = self.create(table, doc).await?;
            results.push(result);
        }
        
        Ok(results)
    }

    /// Get database reference for custom operations
    pub fn get_database(&self) -> DocumentResult<&Surreal<Db>> {
        self.get_db()
    }
}

impl Default for DocumentService {
    fn default() -> Self {
        Self::new()
    }
}

/// Helper trait for converting SurrealDB Things to strings
pub trait ThingToString {
    fn extract_id(&self) -> String;
}

impl ThingToString for Value {
    fn extract_id(&self) -> String {
        match self {
            Value::String(s) => s.clone(),
            Value::Object(obj) => {
                if let Some(Value::String(id)) = obj.get("id") {
                    id.clone()
                } else {
                    "unknown".to_string()
                }
            }
            _ => "unknown".to_string(),
        }
    }
}

/// Macro for easy document service operations
#[macro_export]
macro_rules! doc_service {
    ($service:expr, create, $table:expr, $data:expr) => {
        $service.create($table, $data).await
    };
    ($service:expr, read, $table:expr, $id:expr) => {
        $service.read($table, $id).await
    };
    ($service:expr, update, $table:expr, $id:expr, $data:expr) => {
        $service.update($table, $id, $data).await
    };
    ($service:expr, delete, $table:expr, $id:expr) => {
        $service.delete($table, $id).await
    };
}


