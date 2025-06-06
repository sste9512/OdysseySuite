use diesel::prelude::*;
use diesel::r2d2::{self, ConnectionManager};
use diesel::sqlite::SqliteConnection;
use diesel_migrations::{embed_migrations, EmbeddedMigrations, MigrationHarness};
use std::env;
use std::sync::Arc;
use std::sync::Mutex;

pub const MIGRATIONS: EmbeddedMigrations = embed_migrations!("migrations");

pub type DbPool = r2d2::Pool<ConnectionManager<SqliteConnection>>;
pub type DbConnection = r2d2::PooledConnection<ConnectionManager<SqliteConnection>>;

/// Diesel SQLite runtime for database operations
pub struct DieselSqliteRuntime {
    pool: Arc<Mutex<Option<DbPool>>>,
}

impl DieselSqliteRuntime {
    /// Create a new DieselSqliteRuntime instance
    pub fn new() -> Self {
        DieselSqliteRuntime {
            pool: Arc::new(Mutex::new(None)),
        }
    }

    /// Initialize the database connection pool
    pub fn initialize(&self, database_url: Option<String>) -> Result<(), String> {
        let database_url = match database_url {
            Some(url) => url,
            None => env::var("DATABASE_URL").map_err(|_| {
                "DATABASE_URL must be set in environment or provided as parameter".to_string()
            })?,
        };

        let manager = ConnectionManager::<SqliteConnection>::new(database_url);
        let pool = r2d2::Pool::builder()
            .build(manager)
            .map_err(|e| format!("Failed to create connection pool: {}", e))?;

        // Run migrations
        let mut conn = pool
            .get()
            .map_err(|e| format!("Failed to get connection from pool: {}", e))?;

        conn.run_pending_migrations(MIGRATIONS)
            .map_err(|e| format!("Failed to run migrations: {}", e))?;

        let mut pool_guard = self.pool.lock().unwrap();
        *pool_guard = Some(pool);

        Ok(())
    }

    /// Get a connection from the pool
    pub fn get_connection(&self) -> Result<DbConnection, String> {
        let pool_guard = self.pool.lock().unwrap();
        match &*pool_guard {
            Some(pool) => pool
                .get()
                .map_err(|e| format!("Failed to get connection from pool: {}", e)),
            None => Err("Database not initialized. Call initialize() first.".to_string()),
        }
    }

    /// Close all connections in the pool
    pub fn close(&self) -> Result<(), String> {
        let mut pool_guard = self.pool.lock().unwrap();
        *pool_guard = None;
        Ok(())
    }

    /// Check if the database is initialized
    pub fn is_initialized(&self) -> bool {
        let pool_guard = self.pool.lock().unwrap();
        pool_guard.is_some()
    }
}

// Implement Default for DieselSqliteRuntime
impl Default for DieselSqliteRuntime {
    fn default() -> Self {
        Self::new()
    }
}

// Implement Clone for DieselSqliteRuntime
impl Clone for DieselSqliteRuntime {
    fn clone(&self) -> Self {
        DieselSqliteRuntime {
            pool: Arc::clone(&self.pool),
        }
    }
}

// Repository implementations for each model
pub mod repositories {
    use super::*;
    use crate::infrastructure::database::models::dds::*;
    use crate::infrastructure::database::models::erf::*;
    use crate::infrastructure::database::models::odyssey_model::*;
    use crate::infrastructure::database::schema::*;

    // OdysseyModel repository
    pub struct OdysseyModelRepository {
        runtime: DieselSqliteRuntime,
    }

    impl OdysseyModelRepository {
        pub fn new(runtime: DieselSqliteRuntime) -> Self {
            Self { runtime }
        }

        // Save an OdysseyModel to the database
        pub fn save_model(
            &self,
            model: &crate::domain::odyssey_api::odyssey_model::OdysseyModel,
        ) -> Result<i32, String> {
            let mut conn = self.runtime.get_connection()?;

            // Start a transaction
            conn.transaction(|conn| {
                // Insert file header
                let file_header = NewOdysseyFileHeaderModel::from(&model.file_header);
                let file_header_id = diesel::insert_into(odyssey_file_headers::table)
                    .values(&file_header)
                    .returning(odyssey_file_headers::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert file header: {}", e))?;

                // Insert geometry header
                let mut geometry_header = NewOdysseyGeometryHeaderModel::from(&model.geometry_header);
                geometry_header.file_header_id = file_header_id;
                let geometry_header_id = diesel::insert_into(odyssey_geometry_headers::table)
                    .values(&geometry_header)
                    .returning(odyssey_geometry_headers::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert geometry header: {}", e))?;

                // Insert model header
                let mut model_header = NewOdysseyModelHeaderModel::from(&model.model_header);
                model_header.geometry_header_id = geometry_header_id;
                let model_header_id = diesel::insert_into(odyssey_model_headers::table)
                    .values(&model_header)
                    .returning(odyssey_model_headers::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert model header: {}", e))?;

                // Insert model
                let new_model = NewOdysseyModelModel {
                    file_header_id,
                    geometry_header_id,
                    model_header_id,
                    engine: model.engine as i32,
                    mdl_data: Some(model.mdl_reader.get_ref().clone()),
                    mdx_data: Some(model.mdx_reader.get_ref().clone()),
                };

                let model_id = diesel::insert_into(odyssey_models::table)
                    .values(&new_model)
                    .returning(odyssey_models::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert model: {}", e))?;

                // Insert array definitions
                let names_array_def = NewOdysseyArrayDefinitionModel {
                    parent_type: "OdysseyModel".to_string(),
                    parent_id: model_id,
                    array_type: "names".to_string(),
                    offset: model.names_array_definition.offset as i32,
                    count: model.names_array_definition.count as i32,
                    count2: model.names_array_definition.count2 as i32,
                };

                diesel::insert_into(odyssey_array_definitions::table)
                    .values(&names_array_def)
                    .execute(conn)
                    .map_err(|e| format!("Failed to insert names array definition: {}", e))?;

                // Insert animations
                for animation in &model.animations {
                    let new_animation = NewOdysseyModelAnimationModel {
                        model_id,
                        name: "Animation".to_string(), // Animation name not available in the struct
                        length: 0.0, // Animation length not available in the struct
                        transition_time: 0.0, // Transition time not available in the struct
                        animation_root: "Root".to_string(), // Animation root not available in the struct
                    };

                    diesel::insert_into(odyssey_model_animations::table)
                        .values(&new_animation)
                        .execute(conn)
                        .map_err(|e| format!("Failed to insert animation: {}", e))?;
                }

                // Insert nodes (if root_node is available)
                if let Some(root_node) = &model.root_node {
                    self.save_node(conn, root_node, model_id, None)?;
                }

                Ok(model_id)
            })
        }

        // Helper method to save a node and its children recursively
        fn save_node(
            &self,
            conn: &mut SqliteConnection,
            node: &crate::domain::odyssey_api::odyssey_model_node::OdysseyModelNode,
            model_id: i32,
            parent_id: Option<i32>,
        ) -> Result<i32, String> {
            // Insert the node
            let new_node = NewOdysseyModelNodeModel {
                model_id,
                parent_id,
                name: node.name.clone(),
                node_type: node.node_type as i32,
                position_x: node.position[0],
                position_y: node.position[1],
                position_z: node.position[2],
                rotation_x: node.rotation[0],
                rotation_y: node.rotation[1],
                rotation_z: node.rotation[2],
                rotation_w: node.rotation[3],
            };

            let node_id = diesel::insert_into(odyssey_model_nodes::table)
                .values(&new_node)
                .returning(odyssey_model_nodes::id)
                .get_result::<i32>(conn)
                .map_err(|e| format!("Failed to insert node: {}", e))?;

            // Recursively save children
            for child in &node.children {
                self.save_node(conn, child, model_id, Some(node_id))?;
            }

            Ok(node_id)
        }

        // Get an OdysseyModel from the database by ID
        pub fn get_model_by_id(&self, id: i32) -> Result<OdysseyModelModel, String> {
            let conn = self.runtime.get_connection()?;

            odyssey_models::table
                .find(id)
                .first::<OdysseyModelModel>(&conn)
                .map_err(|e| format!("Failed to get model with ID {}: {}", id, e))
        }

        // List all OdysseyModels in the database
        pub fn list_models(&self) -> Result<Vec<OdysseyModelModel>, String> {
            let conn = self.runtime.get_connection()?;

            odyssey_models::table
                .load::<OdysseyModelModel>(&conn)
                .map_err(|e| format!("Failed to list models: {}", e))
        }

        // Delete an OdysseyModel from the database by ID
        pub fn delete_model(&self, id: i32) -> Result<(), String> {
            let conn = self.runtime.get_connection()?;

            diesel::delete(odyssey_models::table.find(id))
                .execute(&conn)
                .map_err(|e| format!("Failed to delete model with ID {}: {}", id, e))?;

            Ok(())
        }
    }

    // ErfFile repository
    pub struct ErfFileRepository {
        runtime: DieselSqliteRuntime,
    }

    impl ErfFileRepository {
        pub fn new(runtime: DieselSqliteRuntime) -> Self {
            Self { runtime }
        }

        // Save an ErfFile to the database
        pub fn save_erf(&self, erf: &crate::domain::odyssey_api::erf::ErfFile) -> Result<i32, String> {
            let mut conn = self.runtime.get_connection()?;

            // Start a transaction
            conn.transaction(|conn| {
                // Insert erf file
                let new_erf = NewErfFileModel::from(erf);
                let erf_id = diesel::insert_into(erf_files::table)
                    .values(&new_erf)
                    .returning(erf_files::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert erf file: {}", e))?;

                // Insert header
                let mut header = NewErfHeaderModel::from(&erf.header);
                header.erf_id = erf_id;
                diesel::insert_into(erf_headers::table)
                    .values(&header)
                    .execute(conn)
                    .map_err(|e| format!("Failed to insert erf header: {}", e))?;

                // Insert localized strings
                for string in &erf.localized_strings.strings {
                    let mut new_string = NewErfLocalizedStringModel::from(string);
                    new_string.erf_id = erf_id;
                    diesel::insert_into(erf_localized_strings::table)
                        .values(&new_string)
                        .execute(conn)
                        .map_err(|e| format!("Failed to insert localized string: {}", e))?;
                }

                // Insert key entries
                for key in &erf.key_list.entries {
                    let mut new_key = NewErfKeyEntryModel::from(key);
                    new_key.erf_id = erf_id;
                    diesel::insert_into(erf_key_entries::table)
                        .values(&new_key)
                        .execute(conn)
                        .map_err(|e| format!("Failed to insert key entry: {}", e))?;
                }

                // Insert resource entries
                for resource in &erf.resource_list.entries {
                    let mut new_resource = NewErfResourceEntryModel::from(resource);
                    new_resource.erf_id = erf_id;
                    diesel::insert_into(erf_resource_entries::table)
                        .values(&new_resource)
                        .execute(conn)
                        .map_err(|e| format!("Failed to insert resource entry: {}", e))?;
                }

                Ok(erf_id)
            })
        }

        // Get an ErfFile from the database by ID
        pub fn get_erf_by_id(&self, id: i32) -> Result<ErfFileModel, String> {
            let conn = self.runtime.get_connection()?;

            erf_files::table
                .find(id)
                .first::<ErfFileModel>(&conn)
                .map_err(|e| format!("Failed to get erf with ID {}: {}", id, e))
        }

        // List all ErfFiles in the database
        pub fn list_erfs(&self) -> Result<Vec<ErfFileModel>, String> {
            let conn = self.runtime.get_connection()?;

            erf_files::table
                .load::<ErfFileModel>(&conn)
                .map_err(|e| format!("Failed to list erfs: {}", e))
        }

        // Delete an ErfFile from the database by ID
        pub fn delete_erf(&self, id: i32) -> Result<(), String> {
            let conn = self.runtime.get_connection()?;

            diesel::delete(erf_files::table.find(id))
                .execute(&conn)
                .map_err(|e| format!("Failed to delete erf with ID {}: {}", id, e))?;

            Ok(())
        }
    }

    // DDS repository
    pub struct DdsFileRepository {
        runtime: DieselSqliteRuntime,
    }

    impl DdsFileRepository {
        pub fn new(runtime: DieselSqliteRuntime) -> Self {
            Self { runtime }
        }

        // Save a DDS file to the database
        pub fn save_dds(
            &self,
            dds: &crate::domain::odyssey_api::dds::DDS,
            format: i32,
            filepath: String,
            mip_maps: Vec<NewMipMapModel>,
        ) -> Result<i32, String> {
            let mut conn = self.runtime.get_connection()?;

            // Start a transaction
            conn.transaction(|conn| {
                // Insert DDS file
                let new_dds = NewDdsFileModel {
                    format,
                    filepath,
                };

                let dds_id = diesel::insert_into(dds_files::table)
                    .values(&new_dds)
                    .returning(dds_files::id)
                    .get_result::<i32>(conn)
                    .map_err(|e| format!("Failed to insert dds file: {}", e))?;

                // Insert mip maps
                for mut mip_map in mip_maps {
                    mip_map.dds_id = dds_id;
                    diesel::insert_into(mip_maps::table)
                        .values(&mip_map)
                        .execute(conn)
                        .map_err(|e| format!("Failed to insert mip map: {}", e))?;
                }

                Ok(dds_id)
            })
        }

        // Get a DDS file from the database by ID
        pub fn get_dds_by_id(&self, id: i32) -> Result<DdsFileModel, String> {
            let conn = self.runtime.get_connection()?;

            dds_files::table
                .find(id)
                .first::<DdsFileModel>(&conn)
                .map_err(|e| format!("Failed to get dds with ID {}: {}", id, e))
        }

        // List all DDS files in the database
        pub fn list_dds_files(&self) -> Result<Vec<DdsFileModel>, String> {
            let conn = self.runtime.get_connection()?;

            dds_files::table
                .load::<DdsFileModel>(&conn)
                .map_err(|e| format!("Failed to list dds files: {}", e))
        }

        // Delete a DDS file from the database by ID
        pub fn delete_dds(&self, id: i32) -> Result<(), String> {
            let conn = self.runtime.get_connection()?;

            diesel::delete(dds_files::table.find(id))
                .execute(&conn)
                .map_err(|e| format!("Failed to delete dds with ID {}: {}", id, e))?;

            Ok(())
        }
    }
}