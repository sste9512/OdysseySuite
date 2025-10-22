use serde::{Serialize, Deserialize};


#[derive(Serialize, Deserialize)]
pub struct References {
    pub from_id: String,
    pub to_id: String,
    pub reference_type: String,
    pub reference_name: String,
    pub description: String,
}

#[derive(Serialize, Deserialize)]
pub struct ReferencesMany {
    pub from_id: String,
    pub to_ids: Vec<String>,
    pub reference_type: String,
    pub reference_name: String,
    pub description: String,
}