use crate::domain::odyssey_api::error::{OdysseyError, Result as OdysseyResult};
use serde::{Deserialize, Serialize};
use std::fmt;
use std::str::FromStr;

/*

  Represents a path that does not physically exist, such as C:Chitinkey:action.2da
  Used to pass target file paths to and from the consuming user functions
  The goal of this class is to provide a way to bridge gap between virtual and real paths,
   preventing us from having to eagerly write and resolve paths

*/
#[derive(Debug, Default, Clone, Serialize, Deserialize, PartialEq, Eq)]
pub struct VirtualFilePath {
    pub fullpath: String,
    pub filename: String,
}

pub trait VirtualFilePathReader {
    fn construct_virtual_filepath(&self, resref_name: &str) -> OdysseyResult<VirtualFilePath>
}

// symbolic string marking, for literal and virtual translation
// ie.   "r:C//Chitinkey//$v:action.2da
// r = real path
// v = virtual path
// chain = possible combination of real and virtual paths
// o = outward, path points towards references not in the root of the current path
// [[action.2da, inner.2da, something.2da]] = virtual path collection

pub const REAL_PATH_PREFIX: &str = "r:";
pub const REAL_PATH_SUFFIX: &str = "r";
pub const VIRTUAL_PATH_PREFIX: &str = "$v:";
pub const VIRTUAL_PATH_SUFFIX: &str = "$v";

pub const VIRTUAL_PATH_COLLECTION_PREFIX: &str = "[[";
pub const VIRTUAL_PATH_COLLECTION_SUFFIX: &str = "]]";

impl VirtualFilePath {
    pub fn new(path: impl Into<String>, filename: impl Into<String>) -> VirtualFilePath {
        VirtualFilePath {
            fullpath: path.into(),
            filename: filename.into(),
        }
    }

    /// Splits the fullpath into its components using "//" as the separator.
    pub fn parts(&self) -> Vec<String> {
        self.fullpath.split("//").map(|s| s.to_string()).collect()
    }

    /// Returns only the virtual components from the fullpath (those starting with $v:).
    pub fn get_virtual_files(&self) -> Vec<String> {
        self.parts()
            .into_iter()
            .filter(|p| p.starts_with(VIRTUAL_PATH_PREFIX))
            .map(|p| p.replace(VIRTUAL_PATH_PREFIX, ""))
            .collect()
    }

    pub fn append_virtual_path(&mut self, path: impl Into<String>) {
        self.fullpath.push_str("//");
        self.fullpath.push_str(VIRTUAL_PATH_COLLECTION_PREFIX);
        self.fullpath.push_str(VIRTUAL_PATH_PREFIX);
        self.fullpath.push_str(path.into().as_str());
        self.fullpath.push_str(VIRTUAL_PATH_COLLECTION_SUFFIX);
    }

    /// Returns the real path component (starts with r:) or None if it doesn't exist.
    pub fn get_real_path(&self) -> Option<String> {
        self.parts()
            .into_iter()
            .find(|p| p.starts_with(REAL_PATH_PREFIX))
            .map(|p| p.replace(REAL_PATH_PREFIX, ""))
    }

    pub fn get_virtual_targets(&self) -> &str {
        &self.fullpath
    }

    pub fn to_standard_uri(&self) -> String {
        format!("file:///{}", self.fullpath)
    }

    pub fn to_concrete_path(&self) -> String {
        self.fullpath
            .replace("//", "")
            .replace("$v:", "")
            .replace("r:", "")
    }

    pub fn print_tree(&self) {
        let parts = self.parts();

        for (i, part) in parts.iter().enumerate() {
            let is_last = i == parts.len() - 1;
            let prefix = if i == 0 {
                ""
            } else if is_last {
                "└── "
            } else {
                "├── "
            };

            let indent = "    ".repeat(i.saturating_sub(1));

            let cleaned_part = part
                .trim_start_matches(VIRTUAL_PATH_COLLECTION_PREFIX)
                .trim_end_matches(VIRTUAL_PATH_COLLECTION_SUFFIX)
                .trim_start_matches(REAL_PATH_PREFIX)
                .trim_start_matches(VIRTUAL_PATH_PREFIX);

            let type_label = if part.starts_with(REAL_PATH_PREFIX) {
                "[REAL] "
            } else if part.contains(VIRTUAL_PATH_PREFIX) {
                "[VIRTUAL] "
            } else {
                ""
            };

            if i == 0 {
                println!("{}{}{}", prefix, type_label, cleaned_part);
            } else {
                println!("{}{}{}{}", indent, prefix, type_label, cleaned_part);
            }
        }
    }

    pub fn from_standard_uri(uri: &str) -> OdysseyResult<VirtualFilePath> {
        if !uri.starts_with("file:///") {
            return Err(OdysseyError::InvalidUri(format!(
                "Expected file:/// prefix, got {}",
                uri
            )));
        }
        let path = uri.replace("file:///", "");
        if path.is_empty() {
            return Err(OdysseyError::InvalidUri("Empty path in URI".to_string()));
        }

        // Determine the filename. If there's a virtual path, the filename is the last virtual component.
        // Otherwise, it's the last part of the path.
        let parts: Vec<&str> = path.split("//").collect();
        let filename = parts
            .iter()
            .rev()
            .find(|p| p.starts_with(VIRTUAL_PATH_PREFIX))
            .map(|p| p.replace(VIRTUAL_PATH_PREFIX, ""))
            .unwrap_or_else(|| parts.last().unwrap_or(&"").to_string());

        Ok(VirtualFilePath::new(path.clone(), filename))
    }
}

impl fmt::Display for VirtualFilePath {
    fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
        write!(f, "{}", self.fullpath)
    }
}

impl FromStr for VirtualFilePath {
    type Err = OdysseyError;

    fn from_str(s: &str) -> Result<Self, Self::Err> {
        if s.is_empty() {
            return Err(OdysseyError::ParseError(
                "Empty string cannot be parsed into VirtualFilePath".to_string(),
            ));
        }

        let parts: Vec<&str> = s.split("//").collect();
        let filename = parts
            .iter()
            .rev()
            .find(|p| p.starts_with(VIRTUAL_PATH_PREFIX))
            .map(|p| p.replace(VIRTUAL_PATH_PREFIX, ""))
            .unwrap_or_else(|| parts.last().unwrap_or(&"").to_string());

        Ok(VirtualFilePath::new(s, filename))
    }
}

impl AsRef<str> for VirtualFilePath {
    fn as_ref(&self) -> &str {
        &self.fullpath
    }
}

impl From<VirtualFilePath> for String {
    fn from(v: VirtualFilePath) -> Self {
        v.fullpath
    }
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn test_new() {
        let vfp = VirtualFilePath::new("path/to/file", "file");
        assert_eq!(vfp.fullpath, "path/to/file");
        assert_eq!(vfp.filename, "file");
    }

    #[test]
    fn test_display() {
        let vfp = VirtualFilePath::new("path/to/file", "file");
        assert_eq!(format!("{}", vfp), "path/to/file");
    }

    #[test]
    fn test_from_str() {
        let vfp: VirtualFilePath = "path/to/file".parse().unwrap();
        assert_eq!(vfp.fullpath, "path/to/file");
        assert_eq!(vfp.filename, "path/to/file");
    }

    #[test]
    fn test_uri() {
        let vfp = VirtualFilePath::new("r:C://Chitinkey//$v:action.2da", "action.2da");
        let uri = vfp.to_standard_uri();
        assert_eq!(uri, "file:///r:C://Chitinkey//$v:action.2da");

        let vfp2 = VirtualFilePath::from_standard_uri(&uri).unwrap();
        assert_eq!(vfp2.fullpath, "r:C://Chitinkey//$v:action.2da");
        assert_eq!(vfp2.filename, "action.2da");
    }

    #[test]
    fn test_parts_and_virtual_extraction() {
        let path = "r:C://Chitinkey//$v:action.2da";
        let vfp = VirtualFilePath::from_str(path).unwrap();

        assert_eq!(vfp.parts(), vec!["r:C", "Chitinkey", "$v:action.2da"]);
        assert_eq!(vfp.get_virtual_files(), vec!["action.2da"]);
        assert_eq!(vfp.get_real_path(), Some("C".to_string()));
        assert_eq!(vfp.filename, "action.2da");
    }

    #[test]
    fn test_multiple_virtual_files() {
        let path = "r:C://archive.erf//$v:inner.erf//$v:resource.2da";
        let vfp = VirtualFilePath::from_str(path).unwrap();

        assert_eq!(vfp.get_virtual_files(), vec!["inner.erf", "resource.2da"]);
        assert_eq!(vfp.filename, "resource.2da");
    }

    #[test]
    fn test_invalid_uri() {
        let res = VirtualFilePath::from_standard_uri("not-a-uri");
        assert!(res.is_err());
        match res.unwrap_err() {
            OdysseyError::InvalidUri(_) => (),
            _ => panic!("Expected InvalidUri error"),
        }
    }
}
