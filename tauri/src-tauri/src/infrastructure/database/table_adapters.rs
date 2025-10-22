use surrealdb::RecordId;

/// Adapter function to convert a string to a SurrealDB RecordId
/// 
/// # Arguments
/// * `table` - The table name for the record
/// * `id` - The string ID to convert
/// 
/// # Returns
/// * `Result<RecordId, String>` - The RecordId or an error message
pub fn string_to_record_id(table: &str, id: &str) -> RecordId {
    RecordId::from((table, id))
}

/// Alternative: Direct conversion using the From trait
/// This is simpler when you know the table name
pub fn create_record_id(table: &str, id: &str) -> RecordId {
    RecordId::from((table, id))
}

// Adapter function to convert a string to a SurrealDB RecordId
//  
// # Arguments
//  * `table` - The table name for the record
//  * `id` - The string ID to convert
//  
//  # Returns
// * `RecordId` - The RecordId for the given table and id
// macro_rules! string_to_record_id {
//     ($table:expr, $id:expr) => {
//         RecordId::from(($table, $id))
//     };
// }

// /// Alternative macro: Direct conversion using the From trait
// /// This is simpler when you know the table name
// macro_rules! create_record_id {
//     ($table:expr, $id:expr) => {
//         RecordId::from(($table, $id))
//     };
// }

// // Export the macros for use in other modules
// pub(crate) use string_to_record_id;
// pub(crate) use create_record_id;