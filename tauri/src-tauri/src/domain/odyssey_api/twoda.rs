use serde::{Deserialize, Serialize};
use std::fs::File;
use std::io::{self, BufRead, BufReader, Write};
use std::path::Path;
use crate::domain::odyssey_api::error::{OdysseyError, Result as OdysseyResult};

#[derive(Debug, Clone, PartialEq, Serialize, Deserialize)]
pub enum TwoDaValue {
    String(String),
    Integer(i32),
    Float(f32),
    Blank,
}

impl TwoDaValue {
    pub fn as_string(&self) -> String {
        match self {
            TwoDaValue::String(s) => s.clone(),
            TwoDaValue::Integer(i) => i.to_string(),
            TwoDaValue::Float(f) => f.to_string(),
            TwoDaValue::Blank => String::new(),
        }
    }

    pub fn as_int(&self) -> Result<i32, String> {
        match self {
            TwoDaValue::Integer(i) => Ok(*i),
            TwoDaValue::Float(f) => Ok(*f as i32),
            TwoDaValue::String(s) => s.parse::<i32>()
                .map_err(|_| format!("Cannot convert '{}' to integer", s)),
            TwoDaValue::Blank => Ok(0),
        }
    }

    pub fn as_float(&self) -> Result<f32, String> {
        match self {
            TwoDaValue::Float(f) => Ok(*f),
            TwoDaValue::Integer(i) => Ok(*i as f32),
            TwoDaValue::String(s) => s.parse::<f32>()
                .map_err(|_| format!("Cannot convert '{}' to float", s)),
            TwoDaValue::Blank => Ok(0.0),
        }
    }

    pub fn is_blank(&self) -> bool {
        matches!(self, TwoDaValue::Blank)
    }

    fn from_str(s: &str) -> Self {
        if s == "****" {
            return TwoDaValue::Blank;
        }

        if let Ok(i) = s.parse::<i32>() {
            return TwoDaValue::Integer(i);
        }

        if let Ok(f) = s.parse::<f32>() {
            return TwoDaValue::Float(f);
        }

        TwoDaValue::String(s.to_string())
    }

    fn to_2da_string(&self) -> String {
        match self {
            TwoDaValue::Blank => "****".to_string(),
            TwoDaValue::String(s) => {
                if s.contains(' ') || s.is_empty() {
                    format!("\"{}\"", s)
                } else {
                    s.clone()
                }
            },
            TwoDaValue::Integer(i) => i.to_string(),
            TwoDaValue::Float(f) => f.to_string(),
        }
    }
}

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TwoDaRow {
    pub index: usize,
    pub values: Vec<TwoDaValue>,
}

impl TwoDaRow {
    pub fn new(index: usize, column_count: usize) -> Self {
        Self {
            index,
            values: vec![TwoDaValue::Blank; column_count],
        }
    }

    pub fn get(&self, column_index: usize) -> Option<&TwoDaValue> {
        self.values.get(column_index)
    }

    pub fn set(&mut self, column_index: usize, value: TwoDaValue) -> Result<(), String> {
        if column_index >= self.values.len() {
            return Err(format!("Column index {} out of bounds", column_index));
        }
        self.values[column_index] = value;
        Ok(())
    }

    pub fn is_deleted(&self) -> bool {
        self.values.iter().all(|v| v.is_blank())
    }
}

#[derive(Debug, Clone, Serialize, Deserialize)]
pub struct TwoDaFile {
    pub version: String,
    pub default_value: Option<String>,
    pub columns: Vec<String>,
    pub rows: Vec<TwoDaRow>,
}

impl TwoDaFile {
    pub fn new() -> Self {
        Self {
            version: "2DA V2.0".to_string(),
            default_value: None,
            columns: Vec::new(),
            rows: Vec::new(),
        }
    }

    pub fn read_from_bytes(data: &[u8]) -> OdysseyResult<Self> {
        let cursor = std::io::Cursor::new(data);
        let reader = BufReader::new(cursor);
        Self::read_from_reader(reader)
    }

    pub fn read_from_file(path: &str) -> OdysseyResult<Self> {
        let normalized_path = path.replace('\\', "/");
        let file = File::open(&normalized_path)
            .map_err(|e| OdysseyError::IoError(
                format!("Failed to open 2DA file '{}': {}", normalized_path, e)
            ))?;

        let reader = BufReader::new(file);
        Self::read_from_reader(reader)
    }

    pub fn read_from_reader<R: BufRead>(reader: R) -> OdysseyResult<Self> {
        let mut lines = reader.lines();

        let version = lines.next()
            .ok_or_else(|| OdysseyError::InvalidData("Empty file".to_string()))??
            .trim()
            .to_string();

        if !version.starts_with("2DA") {
            return Err(OdysseyError::InvalidData(
                format!("Invalid 2DA version header: {}", version)
            ));
        }

        let second_line = lines.next()
            .ok_or_else(|| OdysseyError::InvalidData("Missing second line".to_string()))??;

        let default_value = if second_line.trim().starts_with("DEFAULT:") {
            let default_text = second_line.trim()[8..].trim();
            if default_text.starts_with('"') && default_text.ends_with('"') {
                Some(default_text[1..default_text.len()-1].to_string())
            } else {
                Some(default_text.to_string())
            }
        } else {
            None
        };

        let column_line = lines.next()
            .ok_or_else(|| OdysseyError::InvalidData("Missing column header line".to_string()))??;

        let columns = Self::parse_columns(&column_line)?;

        if columns.is_empty() {
            return Err(OdysseyError::InvalidData(
                "No columns found in header".to_string()
            ));
        }

        let mut rows = Vec::new();

        for (line_num, line_result) in lines.enumerate() {
            let line = line_result?;
            let trimmed = line.trim();

            if trimmed.is_empty() {
                continue;
            }

            let row = Self::parse_row(trimmed, &columns, line_num + 4)?;
            rows.push(row);
        }

        Ok(TwoDaFile {
            version,
            default_value,
            columns,
            rows,
        })
    }

    fn parse_columns(line: &str) -> OdysseyResult<Vec<String>> {
        let mut columns = Vec::new();
        let parts: Vec<&str> = line.split_whitespace().collect();

        for part in parts {
            if !part.is_empty() {
                columns.push(part.to_string());
            }
        }

        Ok(columns)
    }

    fn parse_row(line: &str, columns: &[String], line_num: usize) -> OdysseyResult<TwoDaRow> {
        let mut values = Vec::new();
        let mut chars = line.chars().peekable();
        let mut current_token = String::new();
        let mut in_quotes = false;
        let mut row_index = None;

        while let Some(ch) = chars.next() {
            match ch {
                '"' => {
                    if in_quotes {
                        if row_index.is_some() {
                            values.push(TwoDaValue::String(current_token.clone()));
                        }
                        current_token.clear();
                        in_quotes = false;
                    } else {
                        in_quotes = true;
                    }
                },
                ' ' | '\t' if !in_quotes => {
                    if !current_token.is_empty() {
                        if row_index.is_none() {
                            row_index = Some(current_token.parse::<usize>()
                                .map_err(|_| io::Error::new(
                                    io::ErrorKind::InvalidData,
                                    format!("Invalid row index at line {}", line_num)
                                ))?);
                        } else {
                            values.push(TwoDaValue::from_str(&current_token));
                        }
                        current_token.clear();
                    }
                },
                _ => {
                    current_token.push(ch);
                }
            }
        }

        if !current_token.is_empty() {
            if row_index.is_none() {
                row_index = Some(current_token.parse::<usize>()
                    .map_err(|_| io::Error::new(
                        io::ErrorKind::InvalidData,
                        format!("Invalid row index at line {}", line_num)
                    ))?);
            } else {
                values.push(TwoDaValue::from_str(&current_token));
            }
        }

        let index = row_index.ok_or_else(|| OdysseyError::InvalidData(
            format!("Missing row index at line {}", line_num)
        ))?;

        if values.len() != columns.len() {
            return Err(OdysseyError::InvalidData(
                format!("Row {} has {} values but expected {} columns", 
                    index, values.len(), columns.len())
            ));
        }

        Ok(TwoDaRow { index, values })
    }

    pub fn write_to_file(&self, path: &str) -> OdysseyResult<()> {
        let normalized_path = path.replace('\\', "/");
        let mut file = File::create(&normalized_path)
            .map_err(|e| OdysseyError::IoError(
                format!("Failed to create 2DA file '{}': {}", normalized_path, e)
            ))?;

        self.write_to_writer(&mut file)
    }

    pub fn write_to_writer<W: Write>(&self, writer: &mut W) -> OdysseyResult<()> {
        writeln!(writer, "{}", self.version)?;

        if let Some(ref default) = self.default_value {
            if default.contains(' ') {
                writeln!(writer, "DEFAULT: \"{}\"", default)?;
            } else {
                writeln!(writer, "DEFAULT: {}", default)?;
            }
        } else {
            writeln!(writer)?;
        }

        let mut col_widths = self.columns.iter()
            .map(|c| c.len())
            .collect::<Vec<_>>();

        for row in &self.rows {
            for (i, value) in row.values.iter().enumerate() {
                let value_str = value.to_2da_string();
                if value_str.len() > col_widths[i] {
                    col_widths[i] = value_str.len();
                }
            }
        }

        let index_width = self.rows.iter()
            .map(|r| r.index.to_string().len())
            .max()
            .unwrap_or(1);

        write!(writer, "{:width$}", "", width = index_width)?;
        for (i, col) in self.columns.iter().enumerate() {
            write!(writer, " {:width$}", col, width = col_widths[i])?;
        }
        writeln!(writer)?;

        for row in &self.rows {
            write!(writer, "{:width$}", row.index, width = index_width)?;
            for (i, value) in row.values.iter().enumerate() {
                write!(writer, " {:width$}", value.to_2da_string(), width = col_widths[i])?;
            }
            writeln!(writer)?;
        }

        Ok(())
    }

    pub fn get_row(&self, index: usize) -> Option<&TwoDaRow> {
        self.rows.iter().find(|r| r.index == index)
    }

    pub fn get_row_mut(&mut self, index: usize) -> Option<&mut TwoDaRow> {
        self.rows.iter_mut().find(|r| r.index == index)
    }

    pub fn get_value(&self, row_index: usize, column_index: usize) -> Option<&TwoDaValue> {
        self.get_row(row_index)?.get(column_index)
    }

    pub fn get_value_by_name(&self, row_index: usize, column_name: &str) -> Option<&TwoDaValue> {
        let col_idx = self.columns.iter().position(|c| c == column_name)?;
        self.get_value(row_index, col_idx)
    }

    pub fn set_value(&mut self, row_index: usize, column_index: usize, value: TwoDaValue) -> Result<(), String> {
        let row = self.get_row_mut(row_index)
            .ok_or_else(|| format!("Row {} not found", row_index))?;
        row.set(column_index, value)
    }

    pub fn set_value_by_name(&mut self, row_index: usize, column_name: &str, value: TwoDaValue) -> Result<(), String> {
        let col_idx = self.columns.iter().position(|c| c == column_name)
            .ok_or_else(|| format!("Column '{}' not found", column_name))?;
        self.set_value(row_index, col_idx, value)
    }

    pub fn add_row(&mut self, values: Vec<TwoDaValue>) -> Result<usize, String> {
        if values.len() != self.columns.len() {
            return Err(format!("Expected {} values but got {}", self.columns.len(), values.len()));
        }

        let index = self.rows.iter().map(|r| r.index).max().unwrap_or(0) + 1;
        self.rows.push(TwoDaRow { index, values });
        Ok(index)
    }

    pub fn delete_row(&mut self, row_index: usize) -> Result<(), String> {
        let row = self.get_row_mut(row_index)
            .ok_or_else(|| format!("Row {} not found", row_index))?;
        
        for i in 0..row.values.len() {
            row.values[i] = TwoDaValue::Blank;
        }
        
        Ok(())
    }

    pub fn add_column(&mut self, name: String, default_value: TwoDaValue) -> Result<(), String> {
        if self.columns.contains(&name) {
            return Err(format!("Column '{}' already exists", name));
        }

        self.columns.push(name);
        
        for row in &mut self.rows {
            row.values.push(default_value.clone());
        }

        Ok(())
    }

    pub fn row_count(&self) -> usize {
        self.rows.len()
    }

    pub fn column_count(&self) -> usize {
        self.columns.len()
    }

    pub fn get_column_index(&self, column_name: &str) -> Option<usize> {
        self.columns.iter().position(|c| c == column_name)
    }
}

impl Default for TwoDaFile {
    fn default() -> Self {
        Self::new()
    }
}

#[cfg(test)]
mod tests {
    use super::*;
    use std::io::Cursor;

    #[test]
    fn test_parse_simple_2da() {
        let data = r#"2DA V2.0

    LABEL         STRREF STRING          HasLegs  Personal_Space
0   Chicken       2013   Chicken         1        0.13
1   ****          ****   ****            ****     ****
2   Battle_Horror 1996   "Battle Horror" 0        0.3
3   Bear_Polar    1999   "Polar Bear"    1        0.6
4   Deer          2017   Deer            1        0.6
"#;

        let cursor = Cursor::new(data.as_bytes());
        let twoda = TwoDaFile::read_from_reader(BufReader::new(cursor)).unwrap();

        assert_eq!(twoda.version, "2DA V2.0");
        assert_eq!(twoda.columns.len(), 5);
        assert_eq!(twoda.rows.len(), 5);
        assert_eq!(twoda.columns[0], "LABEL");
        assert_eq!(twoda.columns[4], "Personal_Space");

        let row0 = twoda.get_row(0).unwrap();
        assert_eq!(row0.values[0].as_string(), "Chicken");
        assert_eq!(row0.values[1].as_int().unwrap(), 2013);

        let row1 = twoda.get_row(1).unwrap();
        assert!(row1.is_deleted());

        let row2 = twoda.get_row(2).unwrap();
        assert_eq!(row2.values[2].as_string(), "Battle Horror");
    }

    #[test]
    fn test_parse_with_default() {
        let data = r#"2DA V2.0
DEFAULT: ****
    Name   Value
0   Test   123
"#;

        let cursor = Cursor::new(data.as_bytes());
        let twoda = TwoDaFile::read_from_reader(BufReader::new(cursor)).unwrap();

        assert_eq!(twoda.default_value, Some("****".to_string()));
    }

    #[test]
    fn test_write_2da() {
        let mut twoda = TwoDaFile::new();
        twoda.columns = vec!["Name".to_string(), "Value".to_string()];
        
        let row0 = TwoDaRow {
            index: 0,
            values: vec![
                TwoDaValue::String("Test".to_string()),
                TwoDaValue::Integer(123),
            ],
        };
        twoda.rows.push(row0);

        let mut output = Vec::new();
        twoda.write_to_writer(&mut output).unwrap();
        
        let result = String::from_utf8(output).unwrap();
        assert!(result.contains("2DA V2.0"));
        assert!(result.contains("Name"));
        assert!(result.contains("Test"));
        assert!(result.contains("123"));
    }

    #[test]
    fn test_value_conversion() {
        let int_val = TwoDaValue::Integer(42);
        assert_eq!(int_val.as_int().unwrap(), 42);
        assert_eq!(int_val.as_float().unwrap(), 42.0);

        let blank_val = TwoDaValue::Blank;
        assert_eq!(blank_val.as_int().unwrap(), 0);
        assert_eq!(blank_val.as_float().unwrap(), 0.0);
        assert_eq!(blank_val.as_string(), "");
    }
}
