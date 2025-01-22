# Tauri + Vue + TypeScript



## Recommended IDE Setup

### Odyssey Suite: Summary



#### Key Features:

1. **Unified Development Experience**:  
   Combines a solid desktop development stack with powerful tools like Tauri, Vue 3, and TypeScript.

2. **Modern Frontend**:
    - Leverages **Vue 3** for a progressive JavaScript framework.
    - Built-in TypeScript support for type-safe application logic.

3. **Backend Powered by Tauri**:
    - Lightweight and secure desktop applications.
    - Rust-powered backend ensures robust performance and reliability.

4. **Optimized Development Workflow**:
    - Uses **Vite** for fast development builds.
    - Recommended editors (e.g., VS Code) and extensions (Volar, Tauri) for an enhanced coding experience.

5. **Cross-Platform Desktop Applications**:  
   Develop applications that are lightweight, cross-platform, and secure without compromising performance.

#### Ideal Use Cases:

- Creating desktop applications with a modern user interface.
- Projects requiring a secure, fast, and lightweight runtime.
- Applications needing seamless communication between frontend and backend.



## Type Support For `.vue` Imports in TS

Since TypeScript cannot handle type information for `.vue` imports, they are shimmed to be a generic Vue component type by default. In most cases this is fine if you don't really care about component prop types outside of templates. However, if you wish to get actual prop types in `.vue` imports (for example to get props validation when using manual `h(...)` calls), you can enable Volar's Take Over mode by following these steps:

1. Run `Extensions: Show Built-in Extensions` from VS Code's command palette, look for `TypeScript and JavaScript Language Features`, then right click and select `Disable (Workspace)`. By default, Take Over mode will enable itself if the default TypeScript extension is disabled.
2. Reload the VS Code window by running `Developer: Reload Window` from the command palette.

 
# Chitin Key File Format Documentation

## Overview
The Chitin Key file format is used in Aurora Engine games to manage and index game resources. It consists of four main components read in sequence:

1. Key Header
2. File Entries Table
3. Filenames Table
4. Key Entries Table

## Structure Details

### Key Header
Contains metadata about the key file:
```rust
struct KeyHeader {
    file_type: [char; 4],      // File type identifier
    file_version: [char; 4],   // Version information
    bif_count: u32,           // Number of BIF (Binary Index File) entries
    key_count: u32,           // Number of key entries
    offset_to_file_table: u32, // Offset to file entries table
    offset_to_key_table: u32,  // Offset to key entries table
    build_year: u32,          // Build year
    build_day: u32,           // Build day
    reserved: [u8; 32]        // Reserved space
}
```

### File Entry
Describes individual file entries:
```rust
struct FileEntry {
    file_size: u32,        // Size of the file
    filename_offset: u32,   // Offset to filename in filenames table
    filename_size: u16,     // Length of filename
    drives: u16            // Drive identifier
}
```

### Key Entry
Contains resource references:
```rust
struct KeyEntry {
    resref: [char; 16],    // Resource reference name
    resource_type: u16,    // Type of resource
    res_id: u32           // Resource identifier
}
```

## Resource Types
Common resource types include:
```rust
enum ResourceType {
    Ini = 7,
    Text = 10,
    Mdl = 2002,
    Nss = 2009,
    Ncs = 2010,
    Are = 2012,
    Set = 2013,
    Ifo = 2014,
    Bic = 2015,
}
```

## Storage
The data is stored in SQLite with the following schema:
```sql
CREATE TABLE chitin_keys (
    path TEXT PRIMARY KEY,
    key_data TEXT NOT NULL
)
```

## Implementation Notes
- All numeric values are stored in little-endian format
- The file is read sequentially, following the offsets specified in the header
- Data is serialized to JSON for database storage
- File operations use Rust's standard I/O with error handling
