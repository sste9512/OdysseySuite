use serde::Serialize;
use std::fmt;

#[derive(Debug, Serialize)]
#[serde(tag = "type", content = "message")]
pub enum OdysseyError {
    InvalidUri(String),
    InvalidPath(String),
    ParseError(String),
    IoError(String),
    InvalidData(String),
    NotFound(String),
    InvalidInput(String),
    Other(String),
}

impl fmt::Display for OdysseyError {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        match self {
            OdysseyError::InvalidUri(msg) => write!(f, "Invalid URI: {}", msg),
            OdysseyError::InvalidPath(msg) => write!(f, "Invalid path: {}", msg),
            OdysseyError::ParseError(msg) => write!(f, "Parse error: {}", msg),
            OdysseyError::IoError(msg) => write!(f, "IO error: {}", msg),
            OdysseyError::InvalidData(msg) => write!(f, "Invalid data: {}", msg),
            OdysseyError::NotFound(msg) => write!(f, "Not found: {}", msg),
            OdysseyError::InvalidInput(msg) => write!(f, "Invalid input: {}", msg),
            OdysseyError::Other(msg) => write!(f, "Error: {}", msg),
        }
    }
}

impl std::error::Error for OdysseyError {}

impl From<std::io::Error> for OdysseyError {
    fn from(err: std::io::Error) -> Self {
        OdysseyError::IoError(err.to_string())
    }
}

pub type Result<T> = std::result::Result<T, OdysseyError>;
