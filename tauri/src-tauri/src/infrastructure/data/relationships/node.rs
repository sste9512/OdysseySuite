use serde::{Serialize, Deserialize};


#[derive(Serialize, Deserialize)]
pub struct Node {
    pub id: String,
    pub name: String,
    pub description: String,
    pub is_root: bool,
    pub is_leaf: bool,
    pub is_parent: bool,
    pub parent_id: String,
    pub children_ids: Vec<String>,  
    pub siblings_ids: Vec<String>
}

