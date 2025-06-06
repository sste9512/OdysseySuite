use chrono::NaiveDateTime;
use diesel::prelude::*;
use serde::{Deserialize, Serialize};

use crate::infrastructure::database::schema::*;

/// Database model for OdysseyFileHeader
#[derive(Debug, Queryable, Selectable, Identifiable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_file_headers)]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyFileHeaderModel {
    pub id: i32,
    pub flag_binary: i32,
    pub mdl_data_size: i32,
    pub mdx_data_size: i32,
    pub model_data_offset: i32,
    pub raw_data_offset: i32,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyFileHeader
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_file_headers)]
pub struct NewOdysseyFileHeaderModel {
    pub flag_binary: i32,
    pub mdl_data_size: i32,
    pub mdx_data_size: i32,
    pub model_data_offset: i32,
    pub raw_data_offset: i32,
}

/// Database model for OdysseyGeometryHeader
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = odyssey_geometry_headers)]
#[diesel(belongs_to(OdysseyFileHeaderModel, foreign_key = file_header_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyGeometryHeaderModel {
    pub id: i32,
    pub file_header_id: i32,
    pub mdx_offset: i32,
    pub mdx_length: i32,
    pub padding: i32,
    pub root_node_offset2: i32,
    pub function_pointer0: i32,
    pub function_pointer1: i32,
    pub model_name: String,
    pub root_node_offset: i32,
    pub node_count: i32,
    pub ref_count: i32,
    pub geometry_type: i32,
    pub unknown4: Option<Vec<u8>>,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyGeometryHeader
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_geometry_headers)]
pub struct NewOdysseyGeometryHeaderModel {
    pub file_header_id: i32,
    pub mdx_offset: i32,
    pub mdx_length: i32,
    pub padding: i32,
    pub root_node_offset2: i32,
    pub function_pointer0: i32,
    pub function_pointer1: i32,
    pub model_name: String,
    pub root_node_offset: i32,
    pub node_count: i32,
    pub ref_count: i32,
    pub geometry_type: i32,
    pub unknown4: Option<Vec<u8>>,
}

/// Database model for OdysseyArrayDefinition
#[derive(Debug, Queryable, Selectable, Identifiable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_array_definitions)]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyArrayDefinitionModel {
    pub id: i32,
    pub parent_type: String,
    pub parent_id: i32,
    pub array_type: String,
    pub offset: i32,
    pub count: i32,
    pub count2: i32,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyArrayDefinition
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_array_definitions)]
pub struct NewOdysseyArrayDefinitionModel {
    pub parent_type: String,
    pub parent_id: i32,
    pub array_type: String,
    pub offset: i32,
    pub count: i32,
    pub count2: i32,
}

/// Database model for OdysseyModelHeader
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_headers)]
#[diesel(belongs_to(OdysseyGeometryHeaderModel, foreign_key = geometry_header_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyModelHeaderModel {
    pub id: i32,
    pub geometry_header_id: i32,
    pub classification: i32,
    pub sub_classification: i32,
    pub smoothing: bool,
    pub fogged: bool,
    pub child_model_count: i32,
    pub parent_model_pointer: i32,
    pub bounding_min_x: f32,
    pub bounding_min_y: f32,
    pub bounding_min_z: f32,
    pub bounding_max_x: f32,
    pub bounding_max_y: f32,
    pub bounding_max_z: f32,
    pub radius: f32,
    pub scale: f32,
    pub super_model_name: String,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyModelHeader
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_headers)]
pub struct NewOdysseyModelHeaderModel {
    pub geometry_header_id: i32,
    pub classification: i32,
    pub sub_classification: i32,
    pub smoothing: bool,
    pub fogged: bool,
    pub child_model_count: i32,
    pub parent_model_pointer: i32,
    pub bounding_min_x: f32,
    pub bounding_min_y: f32,
    pub bounding_min_z: f32,
    pub bounding_max_x: f32,
    pub bounding_max_y: f32,
    pub bounding_max_z: f32,
    pub radius: f32,
    pub scale: f32,
    pub super_model_name: String,
}

/// Database model for OdysseyModel
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = odyssey_models)]
#[diesel(belongs_to(OdysseyFileHeaderModel, foreign_key = file_header_id))]
#[diesel(belongs_to(OdysseyGeometryHeaderModel, foreign_key = geometry_header_id))]
#[diesel(belongs_to(OdysseyModelHeaderModel, foreign_key = model_header_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyModelModel {
    pub id: i32,
    pub file_header_id: i32,
    pub geometry_header_id: i32,
    pub model_header_id: i32,
    pub engine: i32,
    pub mdl_data: Option<Vec<u8>>,
    pub mdx_data: Option<Vec<u8>>,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyModel
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_models)]
pub struct NewOdysseyModelModel {
    pub file_header_id: i32,
    pub geometry_header_id: i32,
    pub model_header_id: i32,
    pub engine: i32,
    pub mdl_data: Option<Vec<u8>>,
    pub mdx_data: Option<Vec<u8>>,
}

/// Database model for OdysseyModelNode
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_nodes)]
#[diesel(belongs_to(OdysseyModelModel, foreign_key = model_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyModelNodeModel {
    pub id: i32,
    pub model_id: i32,
    pub parent_id: Option<i32>,
    pub name: String,
    pub node_type: i32,
    pub position_x: f32,
    pub position_y: f32,
    pub position_z: f32,
    pub rotation_x: f32,
    pub rotation_y: f32,
    pub rotation_z: f32,
    pub rotation_w: f32,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyModelNode
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_nodes)]
pub struct NewOdysseyModelNodeModel {
    pub model_id: i32,
    pub parent_id: Option<i32>,
    pub name: String,
    pub node_type: i32,
    pub position_x: f32,
    pub position_y: f32,
    pub position_z: f32,
    pub rotation_x: f32,
    pub rotation_y: f32,
    pub rotation_z: f32,
    pub rotation_w: f32,
}

/// Database model for OdysseyModelAnimation
#[derive(Debug, Queryable, Selectable, Identifiable, Associations, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_animations)]
#[diesel(belongs_to(OdysseyModelModel, foreign_key = model_id))]
#[diesel(check_for_backend(diesel::sqlite::Sqlite))]
pub struct OdysseyModelAnimationModel {
    pub id: i32,
    pub model_id: i32,
    pub name: String,
    pub length: f32,
    pub transition_time: f32,
    pub animation_root: String,
    pub created_at: NaiveDateTime,
    pub updated_at: NaiveDateTime,
}

/// Insertable model for OdysseyModelAnimation
#[derive(Debug, Insertable, Serialize, Deserialize)]
#[diesel(table_name = odyssey_model_animations)]
pub struct NewOdysseyModelAnimationModel {
    pub model_id: i32,
    pub name: String,
    pub length: f32,
    pub transition_time: f32,
    pub animation_root: String,
}

// Conversion functions between domain models and database models
impl From<&crate::domain::odyssey_api::odyssey_model::OdysseyFileHeader> for NewOdysseyFileHeaderModel {
    fn from(header: &crate::domain::odyssey_api::odyssey_model::OdysseyFileHeader) -> Self {
        Self {
            flag_binary: header.flag_binary as i32,
            mdl_data_size: header.mdl_data_size as i32,
            mdx_data_size: header.mdx_data_size as i32,
            model_data_offset: header.model_data_offset as i32,
            raw_data_offset: header.raw_data_offset as i32,
        }
    }
}

impl From<&crate::domain::odyssey_api::odyssey_model::OdysseyArrayDefinition> for NewOdysseyArrayDefinitionModel {
    fn from(def: &crate::domain::odyssey_api::odyssey_model::OdysseyArrayDefinition) -> Self {
        Self {
            parent_type: String::new(), // This needs to be set by the caller
            parent_id: 0,               // This needs to be set by the caller
            array_type: String::new(),  // This needs to be set by the caller
            offset: def.offset as i32,
            count: def.count as i32,
            count2: def.count2 as i32,
        }
    }
}