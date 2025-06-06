use chrono::NaiveDateTime;
use diesel::prelude::*;
use serde::{Deserialize, Serialize};

use crate::infrastructure::database::schema::*;

/// Database model for ErfFile
#[derive(Debug, Queryable, Selectable, Identifiable, Serialize, Deserialize)]
#[diesel(table_name = erf_files)]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct ErfFileModel {
    pub id: i32,
    pub file_path: String,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for ErfFile
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = erf_files)]
pub struct NewErfFileModel {
    pub file_path: String,
}

/// Database model for ErfHeader
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = erf_headers)]
#[diesel(belongs_to(ErfFileModel, foreign_key = erf_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct ErfHeaderModel {
    pub id: i32,
    pub erf_id: i32,
    pub file_type: Vec<u8>,
    pub version: Vec<u8>,
    pub language_count: i32,
    pub localized_string_size: i32,
    pub entry_count: i32,
    pub offset_to_localized_string: i32,
    pub offset_to_key_list: i32,
    pub offset_to_resource_list: i32,
    pub build_year: i32,
    pub build_day: i32,
    pub description_strref: i32,
    pub reserved: Option<Vec<u8>>,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for ErfHeader
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = erf_headers)]
pub struct NewErfHeaderModel {
    pub erf_id: i32,
    pub file_type: Vec<u8>,
    pub version: Vec<u8>,
    pub language_count: i32,
    pub localized_string_size: i32,
    pub entry_count: i32,
    pub offset_to_localized_string: i32,
    pub offset_to_key_list: i32,
    pub offset_to_resource_list: i32,
    pub build_year: i32,
    pub build_day: i32,
    pub description_strref: i32,
    pub reserved: Option<Vec<u8>>,
}

/// Database model for ErfLocalizedString
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = erf_localized_strings)]
#[diesel(belongs_to(ErfFileModel, foreign_key = erf_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct ErfLocalizedStringModel {
    pub id: i32,
    pub erf_id: i32,
    pub language_id: i32,
    pub string_size: i32,
    pub string: String,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for ErfLocalizedString
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = erf_localized_strings)]
pub struct NewErfLocalizedStringModel {
    pub erf_id: i32,
    pub language_id: i32,
    pub string_size: i32,
    pub string: String,
}

/// Database model for ErfKeyEntry
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = erf_key_entries)]
#[diesel(belongs_to(ErfFileModel, foreign_key = erf_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct ErfKeyEntryModel {
    pub id: i32,
    pub erf_id: i32,
    pub filename: Vec<u8>,
    pub resource_id: i32,
    pub resource_type: i32,
    pub unused: i32,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for ErfKeyEntry
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = erf_key_entries)]
pub struct NewErfKeyEntryModel {
    pub erf_id: i32,
    pub filename: Vec<u8>,
    pub resource_id: i32,
    pub resource_type: i32,
    pub unused: i32,
}

/// Database model for ErfResourceEntry
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = erf_resource_entries)]
#[diesel(belongs_to(ErfFileModel, foreign_key = erf_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct ErfResourceEntryModel {
    pub id: i32,
    pub erf_id: i32,
    pub offset_to_resource: i32,
    pub resource_size: i32,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for ErfResourceEntry
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = erf_resource_entries)]
pub struct NewErfResourceEntryModel {
    pub erf_id: i32,
    pub offset_to_resource: i32,
    pub resource_size: i32,
}

// Conversion functions between domain models and database models
impl From<&crate::domain::odyssey_api::erf::ErfFile> for NewErfFileModel {
    fn from(erf: &crate::domain::odyssey_api::erf::ErfFile) -> Self {
        Self {
            file_path: erf.file_path.clone(),
        }
    }
}

impl From<&crate::domain::odyssey_api::erf::ErfHeader> for NewErfHeaderModel {
    fn from(header: &crate::domain::odyssey_api::erf::ErfHeader) -> Self {
        Self {
            erf_id: 0, // This needs to be set by the caller
            file_type: header.file_type.to_vec(),
            version: header.version.to_vec(),
            language_count: header.language_count as i32,
            localized_string_size: header.localized_string_size as i32,
            entry_count: header.entry_count as i32,
            offset_to_localized_string: header.offset_to_localized_string as i32,
            offset_to_key_list: header.offset_to_key_list as i32,
            offset_to_resource_list: header.offset_to_resource_list as i32,
            build_year: header.build_year as i32,
            build_day: header.build_day as i32,
            description_strref: header.description_strref as i32,
            reserved: Some(header.reserved.clone()),
        }
    }
}

impl From<&crate::domain::odyssey_api::erf::ErfLocalizedString> for NewErfLocalizedStringModel {
    fn from(string: &crate::domain::odyssey_api::erf::ErfLocalizedString) -> Self {
        Self {
            erf_id: 0, // This needs to be set by the caller
            language_id: string.language_id as i32,
            string_size: string.string_size as i32,
            string: string.string.clone(),
        }
    }
}

impl From<&crate::domain::odyssey_api::erf::ErfKeyEntry> for NewErfKeyEntryModel {
    fn from(entry: &crate::domain::odyssey_api::erf::ErfKeyEntry) -> Self {
        Self {
            erf_id: 0, // This needs to be set by the caller
            filename: entry.filename.to_vec(),
            resource_id: entry.resource_id as i32,
            resource_type: entry.resource_type as i32,
            unused: entry.unused as i32,
        }
    }
}

impl From<&crate::domain::odyssey_api::erf::ErfResourceEntry> for NewErfResourceEntryModel {
    fn from(entry: &crate::domain::odyssey_api::erf::ErfResourceEntry) -> Self {
        Self {
            erf_id: 0, // This needs to be set by the caller
            offset_to_resource: entry.offset_to_resource as i32,
            resource_size: entry.resource_size as i32,
        }
    }
}