use rusqlite::{Connection, Result};

pub struct SqliteRuntime {
    connection: Option<Connection>,
}

impl SqliteRuntime {
    pub fn new() -> Self {
        SqliteRuntime { connection: None }
    }

    pub fn open(&mut self, path: &str) -> Result<&Connection> {
        match Connection::open(path) {
            Ok(conn) => {
                self.connection = Some(conn);
                Ok(self.connection.as_ref().unwrap())
            }
            Err(e) => Err(e),
        }
    }

    pub fn close(&mut self) -> Result<()> {
        if let Some(conn) = self.connection.take() {
            conn.close().map_err(|e| e.1)?;
        }
        Ok(())
    }

    pub fn get_connection(&self) -> Option<&Connection> {
        self.connection.as_ref()
    }

    pub fn run_migrations(&self) -> Result<()> {
        let conn = match self.connection.as_ref() {
            Some(c) => c,
            None => {
                return Err(rusqlite::Error::InvalidParameterName(
                    "No database connection available".to_string(),
                ))
            }
        };

        // Create tables if they don't exist
        let result = conn.execute(
            "CREATE TABLE IF NOT EXISTS user_actions (
                id TEXT PRIMARY KEY,
                category TEXT NOT NULL,
                description TEXT NOT NULL,
                timestamp DATETIME NOT NULL
            )",
            [],
        )?;
        if result == 0 {
            // Table already existed
            Ok(())
        } else {
            // Table was created
            Ok(())
        }

        // Add any additional migrations here
        // Version tracking could be added by creating a migrations table
        // and checking/updating version numbers

        Ok(())
    }

    pub fn ensure_database_ready(&mut self, path: &str) -> Result<()> {
        // Open database if not already open
        if self.connection.is_none() {
            self.open(path)?;
        }

        // Run migrations to ensure schema is up to date
        self.run_migrations()?;

        // Verify database is writable by attempting a test transaction
        let conn = match self.connection.as_ref() {
            Some(c) => c,
            None => {
                return Err(rusqlite::Error::InvalidParameterName(
                    "No database connection available".to_string(),
                ))
            }
        };

        conn.execute_batch("BEGIN; ROLLBACK;")?;

        Ok(())
    }
}
