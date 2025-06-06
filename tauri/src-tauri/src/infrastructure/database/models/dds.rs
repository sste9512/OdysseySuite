use chrono::NaiveDateTime;
use diesel::prelude::*;
use serde::{Deserialize, Serialize};

use crate::infrastructure::database::schema::*;

/// Database model for DDS files
#[derive(Debug, Queryable, Selectable, Identifiable, Serialize, Deserialize)]
#[diesel(table_name = dds_files)]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct DdsFileModel {
    pub id: i32,
    pub format: i32,
    pub filepath: String,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for DDS files
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = dds_files)]
pub struct NewDdsFileModel {
    pub format: i32,
    pub filepath: String,
}

/// Database model for MipMap
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = mip_maps)]
#[diesel(belongs_to(DdsFileModel, foreign_key = dds_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct MipMapModel {
    pub id: i32,
    pub dds_id: i32,
    pub width: i32,
    pub height: i32,
    pub size: i32,
    pub data: Option<Vec<u8>>,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for MipMap
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = mip_maps)]
pub struct NewMipMapModel {
    pub dds_id: i32,
    pub width: i32,
    pub height: i32,
    pub size: i32,
    pub data: Option<Vec<u8>>,
}

// Conversion functions between domain models and database models
impl From<&crate::domain::odyssey_api::dds::DDS> for NewDdsFileModel {
    fn from(_dds: &crate::domain::odyssey_api::dds::DDS) -> Self {
        Self {
            format: 0, // This needs to be set by the caller based on the DDS format
            filepath: String::new(), // This needs to be set by the caller
        }
    }
}

// Note: Since the MipMap struct in the domain model is private,
// we can't implement a direct conversion. The caller will need to
// create NewMipMapModel instances manually.