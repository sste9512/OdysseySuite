use serde::{Deserialize, Serialize};

#[derive(Serialize, Deserialize)]
pub struct ResourceFile<T> {
    id: String,
    project_id: String,
    user_id: String,
    item_id: String,
    filepath: String,
    filename: String,
    resource_count: i32,
    file_size: i64,
    last_modified: String,
    file_type: String,
    data: T,
}
