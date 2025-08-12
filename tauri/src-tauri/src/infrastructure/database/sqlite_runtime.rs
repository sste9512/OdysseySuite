use rusqlite::{ Connection, Result };

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
                return Err(
                    rusqlite::Error::InvalidParameterName(
                        "No database connection available".to_string()
                    )
                );
            }
        };

        // Create biffs table
        conn.execute(
            "CREATE TABLE IF NOT EXISTS biffs (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                filepath TEXT NOT NULL UNIQUE,
                filename TEXT NOT NULL,
                resource_count INTEGER NOT NULL,
                file_size INTEGER NOT NULL,
                last_modified DATETIME NOT NULL
            )",
            []
        )?;

        // Create rim files table
        conn.execute(
            "CREATE TABLE IF NOT EXISTS rims (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                filepath TEXT NOT NULL UNIQUE,
                filename TEXT NOT NULL,
                resource_count INTEGER NOT NULL,
                file_size INTEGER NOT NULL,
                last_modified DATETIME NOT NULL
            )",
            []
        )?;

        // Create chitin key table
        conn.execute(
            "CREATE TABLE IF NOT EXISTS chitin_keys (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                filepath TEXT NOT NULL UNIQUE,
                filename TEXT NOT NULL,
                biff_count INTEGER NOT NULL,
                resource_count INTEGER NOT NULL,
                file_size INTEGER NOT NULL,
                last_modified DATETIME NOT NULL
            )",
            []
        )?;

        // Create erf files table
        conn.execute(
            "CREATE TABLE IF NOT EXISTS erfs (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                filepath TEXT NOT NULL UNIQUE,
                filename TEXT NOT NULL,
                description TEXT,
                resource_count INTEGER NOT NULL,
                language_count INTEGER NOT NULL,
                file_size INTEGER NOT NULL,
                last_modified DATETIME NOT NULL
            )",
            []
        )?;

        // Create tpc files table
        conn.execute(
            "CREATE TABLE IF NOT EXISTS tpcs (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                filepath TEXT NOT NULL UNIQUE,
                filename TEXT NOT NULL,
                width INTEGER NOT NULL,
                height INTEGER NOT NULL,
                format INTEGER NOT NULL,
                file_size INTEGER NOT NULL,
                last_modified DATETIME NOT NULL
            )",
            []
        )?;

        // Create resources table to track individual resources within containers
        conn.execute(
            "CREATE TABLE IF NOT EXISTS resources (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                container_type TEXT NOT NULL,
                container_id INTEGER NOT NULL,
                resref TEXT NOT NULL,
                restype INTEGER NOT NULL,
                offset INTEGER NOT NULL,
                size INTEGER NOT NULL,
                FOREIGN KEY (container_id) REFERENCES biffs(id)
                    ON DELETE CASCADE
                    ON UPDATE CASCADE,
                FOREIGN KEY (container_id) REFERENCES rims(id)
                    ON DELETE CASCADE
                    ON UPDATE CASCADE,
                FOREIGN KEY (container_id) REFERENCES erfs(id)
                    ON DELETE CASCADE
                    ON UPDATE CASCADE,
                FOREIGN KEY (container_id) REFERENCES tpcs(id)
                    ON DELETE CASCADE
                    ON UPDATE CASCADE
            )",
            []
        )?;

        // Create tables if they don't exist
        let result = conn.execute(
            "CREATE TABLE IF NOT EXISTS user_actions (
                id TEXT PRIMARY KEY,
                category TEXT NOT NULL,
                description TEXT NOT NULL,
                timestamp DATETIME NOT NULL
            )",
            []
        )?;
        if result == 0 {
            // Table already existed

        } else {
            // Table was created

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
                return Err(
                    rusqlite::Error::InvalidParameterName(
                        "No database connection available".to_string()
                    )
                );
            }
        };

        conn.execute_batch("BEGIN; ROLLBACK;")?;

        Ok(())
    }
}
