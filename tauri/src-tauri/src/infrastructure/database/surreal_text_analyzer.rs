use std::collections::HashMap;
use serde::{Serialize, Deserialize};
use serde_json::json;

/// Represents the types of text analyzers available in SurrealDB
#[derive(Debug, Clone, Serialize, Deserialize)]
pub enum AnalyzerType {
    Blank,
    Classification,
    Delimiter,
    Ngram,
    Pattern,
    Snowball,
    Standard,
}

impl ToString for AnalyzerType {
    fn to_string(&self) -> String {
        match self {
            AnalyzerType::Blank => "blank".to_string(),
            AnalyzerType::Classification => "classification".to_string(),
            AnalyzerType::Delimiter => "delimiter".to_string(),
            AnalyzerType::Ngram => "ngram".to_string(),
            AnalyzerType::Pattern => "pattern".to_string(),
            AnalyzerType::Snowball => "snowball".to_string(),
            AnalyzerType::Standard => "standard".to_string(),
        }
    }
}

/// Represents a SurrealDB text analyzer configuration
#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TextAnalyzer {
    pub name: String,
    pub analyzer_type: AnalyzerType,
    pub options: HashMap<String, serde_json::Value>,
}

/// Builder for creating SurrealDB text analyzers
pub struct TextAnalyzerBuilder {
    name: String,
    analyzer_type: AnalyzerType,
    options: HashMap<String, serde_json::Value>,
}

impl TextAnalyzerBuilder {
    /// Create a new text analyzer builder with the specified name and type
    pub fn new(name: &str, analyzer_type: AnalyzerType) -> Self {
        TextAnalyzerBuilder {
            name: name.to_string(),
            analyzer_type,
            options: HashMap::new(),
        }
    }

    /// Add an option to the analyzer configuration
    pub fn with_option<T: Serialize>(mut self, key: &str, value: T) -> Result<Self, String> {
        match serde_json::to_value(value) {
            Ok(json_value) => {
                self.options.insert(key.to_string(), json_value);
                Ok(self)
            },
            Err(e) => Err(format!("Failed to serialize option value: {}", e)),
        }
    }

    /// Add multiple options to the analyzer configuration
    pub fn with_options(mut self, options: HashMap<String, serde_json::Value>) -> Self {
        self.options.extend(options);
        self
    }

    /// Build the text analyzer
    pub fn build(self) -> TextAnalyzer {
        TextAnalyzer {
            name: self.name,
            analyzer_type: self.analyzer_type,
            options: self.options,
        }
    }

    /// Generate the SurrealQL definition for this analyzer
    pub fn to_surreal_query(&self) -> String {
        let options_str = if self.options.is_empty() {
            "".to_string()
        } else {
            let options = self.options.iter()
                .map(|(k, v)| format!("{}: {}", k, v))
                .collect::<Vec<_>>()
                .join(", ");
            format!(" {{ {} }}", options)
        };

        format!(
            "DEFINE ANALYZER {} TYPE {}{}",
            self.name,
            self.analyzer_type.to_string(),
            options_str
        )
    }
}

/// Helper functions for common analyzer types
pub mod analyzers {
    use super::*;

    /// Create a standard analyzer
    pub fn standard(name: &str) -> TextAnalyzerBuilder {
        TextAnalyzerBuilder::new(name, AnalyzerType::Standard)
    }

    /// Create a snowball analyzer with the specified language
    pub fn snowball(name: &str, language: &str) -> Result<TextAnalyzerBuilder, String> {
        TextAnalyzerBuilder::new(name, AnalyzerType::Snowball)
            .with_option("language", language)
    }

    /// Create an ngram analyzer with the specified token length
    pub fn ngram(name: &str, min: u32, max: u32) -> Result<TextAnalyzerBuilder, String> {
        TextAnalyzerBuilder::new(name, AnalyzerType::Ngram)
            .with_option("min", min)?
            .with_option("max", max)
    }

    /// Create a delimiter analyzer with the specified delimiter
    pub fn delimiter(name: &str, delimiter: &str) -> Result<TextAnalyzerBuilder, String> {
        TextAnalyzerBuilder::new(name, AnalyzerType::Delimiter)
            .with_option("delimiter", delimiter)
    }
}
