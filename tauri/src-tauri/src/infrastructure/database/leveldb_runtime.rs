use leveldb::database::Database;
use leveldb::kv::KV;
use leveldb::options::{Options, ReadOptions, WriteOptions};
use std::path::Path;

pub struct LevelDbRuntime {
    database: Option<Database<i32>>,
}

impl LevelDbRuntime {
    pub fn new() -> Self {
        LevelDbRuntime { database: None }
    }

    pub fn open(&mut self, path: &str) -> Result<(), String> {
        let path = Path::new(path);
        let mut options = Options::new();
        options.create_if_missing = true;

        match Database::open(path, options) {
            Ok(db) => {
                self.database = Some(db);
                Ok(())
            }
            Err(e) => Err(e.to_string()),
        }
    }

    pub fn close(&mut self) {
        self.database = None;
    }

    pub fn get(&self, key: &[u8]) -> Result<Option<Vec<u8>>, String> {
        match &self.database {
            Some(db) => {
                let read_opts = ReadOptions::new();
                match db.get(read_opts, key) {
                    Ok(value) => Ok(value),
                    Err(e) => Err(e.to_string()),
                }
            }
            None => Err("Database not opened".to_string()),
        }
    }

    pub fn put(&self, key: &[u8], value: &[u8]) -> Result<(), String> {
        match &self.database {
            Some(db) => {
                let write_opts = WriteOptions::new();
                match db.put(write_opts, key, value) {
                    Ok(_) => Ok(()),
                    Err(e) => Err(e.to_string()),
                }
            }
            None => Err("Database not opened".to_string()),
        }
    }

    pub fn delete(&self, key: &[u8]) -> Result<(), String> {
        match &self.database {
            Some(db) => {
                let write_opts = WriteOptions::new();
                match db.delete(write_opts, key) {
                    Ok(_) => Ok(()),
                    Err(e) => Err(e.to_string()),
                }
            }
            None => Err("Database not opened".to_string()),
        }
    }
}
