use crate::domain::odyssey_api::tpc_data::{decode_tpc_data_from_bytes, TpcData};


#[tauri::command]
pub async fn read_tpc_data_from_bytes(data: Vec<u8>) -> Result<TpcData, String> {
    decode_tpc_data_from_bytes(data).await
}