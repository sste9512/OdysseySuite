use serde::{Serialize, Deserialize};


[derive(Serialize, Deserialize)]
pub struct Owns {
    pub user_id: String,
    pub project_id: String,
}

[derive(Serialize, Deserialize)]
pub struct OwnsMany {
    pub user_id: String,
    pub project_ids: Vec<String>,
}

[derive(Serialize, Deserialize)]
pub struct OwnsOnly {
    pub user_id: String,
    pub project_id: String,
}