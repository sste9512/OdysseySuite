-- Create tables for Odyssey API structs

-- OdysseyFileHeader table
CREATE TABLE odyssey_file_headers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    flag_binary INTEGER NOT NULL,
    mdl_data_size INTEGER NOT NULL,
    mdx_data_size INTEGER NOT NULL,
    model_data_offset INTEGER NOT NULL,
    raw_data_offset INTEGER NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- OdysseyGeometryHeader table
CREATE TABLE odyssey_geometry_headers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    file_header_id INTEGER NOT NULL,
    mdx_offset INTEGER NOT NULL,
    mdx_length INTEGER NOT NULL,
    padding INTEGER NOT NULL,
    root_node_offset2 INTEGER NOT NULL,
    function_pointer0 INTEGER NOT NULL,
    function_pointer1 INTEGER NOT NULL,
    model_name TEXT NOT NULL,
    root_node_offset INTEGER NOT NULL,
    node_count INTEGER NOT NULL,
    ref_count INTEGER NOT NULL,
    geometry_type INTEGER NOT NULL,
    unknown4 BLOB,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (file_header_id) REFERENCES odyssey_file_headers(id) ON DELETE CASCADE
);

-- OdysseyArrayDefinition table
CREATE TABLE odyssey_array_definitions (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    parent_type TEXT NOT NULL,
    parent_id INTEGER NOT NULL,
    array_type TEXT NOT NULL,
    offset INTEGER NOT NULL,
    count INTEGER NOT NULL,
    count2 INTEGER NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- OdysseyModelHeader table
CREATE TABLE odyssey_model_headers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    geometry_header_id INTEGER NOT NULL,
    classification INTEGER NOT NULL,
    sub_classification INTEGER NOT NULL,
    smoothing BOOLEAN NOT NULL,
    fogged BOOLEAN NOT NULL,
    child_model_count INTEGER NOT NULL,
    parent_model_pointer INTEGER NOT NULL,
    bounding_min_x REAL NOT NULL,
    bounding_min_y REAL NOT NULL,
    bounding_min_z REAL NOT NULL,
    bounding_max_x REAL NOT NULL,
    bounding_max_y REAL NOT NULL,
    bounding_max_z REAL NOT NULL,
    radius REAL NOT NULL,
    scale REAL NOT NULL,
    super_model_name TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (geometry_header_id) REFERENCES odyssey_geometry_headers(id) ON DELETE CASCADE
);

-- OdysseyModel table
CREATE TABLE odyssey_models (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    file_header_id INTEGER NOT NULL,
    geometry_header_id INTEGER NOT NULL,
    model_header_id INTEGER NOT NULL,
    engine INTEGER NOT NULL,
    mdl_data BLOB,
    mdx_data BLOB,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (file_header_id) REFERENCES odyssey_file_headers(id) ON DELETE CASCADE,
    FOREIGN KEY (geometry_header_id) REFERENCES odyssey_geometry_headers(id) ON DELETE CASCADE,
    FOREIGN KEY (model_header_id) REFERENCES odyssey_model_headers(id) ON DELETE CASCADE
);

-- OdysseyModelNode table
CREATE TABLE odyssey_model_nodes (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    model_id INTEGER NOT NULL,
    parent_id INTEGER,
    name TEXT NOT NULL,
    node_type INTEGER NOT NULL,
    position_x REAL NOT NULL,
    position_y REAL NOT NULL,
    position_z REAL NOT NULL,
    rotation_x REAL NOT NULL,
    rotation_y REAL NOT NULL,
    rotation_z REAL NOT NULL,
    rotation_w REAL NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (model_id) REFERENCES odyssey_models(id) ON DELETE CASCADE,
    FOREIGN KEY (parent_id) REFERENCES odyssey_model_nodes(id) ON DELETE SET NULL
);

-- OdysseyModelAnimation table
CREATE TABLE odyssey_model_animations (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    model_id INTEGER NOT NULL,
    name TEXT NOT NULL,
    length REAL NOT NULL,
    transition_time REAL NOT NULL,
    animation_root TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (model_id) REFERENCES odyssey_models(id) ON DELETE CASCADE
);

-- DDS table
CREATE TABLE dds_files (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    format INTEGER NOT NULL,
    filepath TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- MipMap table
CREATE TABLE mip_maps (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    dds_id INTEGER NOT NULL,
    width INTEGER NOT NULL,
    height INTEGER NOT NULL,
    size INTEGER NOT NULL,
    data BLOB,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (dds_id) REFERENCES dds_files(id) ON DELETE CASCADE
);

-- ErfFile table
CREATE TABLE erf_files (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    file_path TEXT NOT NULL UNIQUE,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP
);

-- ErfHeader table
CREATE TABLE erf_headers (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    erf_id INTEGER NOT NULL,
    file_type BLOB NOT NULL,
    version BLOB NOT NULL,
    language_count INTEGER NOT NULL,
    localized_string_size INTEGER NOT NULL,
    entry_count INTEGER NOT NULL,
    offset_to_localized_string INTEGER NOT NULL,
    offset_to_key_list INTEGER NOT NULL,
    offset_to_resource_list INTEGER NOT NULL,
    build_year INTEGER NOT NULL,
    build_day INTEGER NOT NULL,
    description_strref INTEGER NOT NULL,
    reserved BLOB,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (erf_id) REFERENCES erf_files(id) ON DELETE CASCADE
);

-- ErfLocalizedString table
CREATE TABLE erf_localized_strings (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    erf_id INTEGER NOT NULL,
    language_id INTEGER NOT NULL,
    string_size INTEGER NOT NULL,
    string TEXT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (erf_id) REFERENCES erf_files(id) ON DELETE CASCADE
);

-- ErfKeyEntry table
CREATE TABLE erf_key_entries (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    erf_id INTEGER NOT NULL,
    filename BLOB NOT NULL,
    resource_id INTEGER NOT NULL,
    resource_type INTEGER NOT NULL,
    unused INTEGER NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (erf_id) REFERENCES erf_files(id) ON DELETE CASCADE
);

-- ErfResourceEntry table
CREATE TABLE erf_resource_entries (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    erf_id INTEGER NOT NULL,
    offset_to_resource INTEGER NOT NULL,
    resource_size INTEGER NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (erf_id) REFERENCES erf_files(id) ON DELETE CASCADE
);

-- Create indexes for better performance
CREATE INDEX idx_odyssey_geometry_headers_file_header_id ON odyssey_geometry_headers(file_header_id);
CREATE INDEX idx_odyssey_model_headers_geometry_header_id ON odyssey_model_headers(geometry_header_id);
CREATE INDEX idx_odyssey_models_file_header_id ON odyssey_models(file_header_id);
CREATE INDEX idx_odyssey_models_geometry_header_id ON odyssey_models(geometry_header_id);
CREATE INDEX idx_odyssey_models_model_header_id ON odyssey_models(model_header_id);
CREATE INDEX idx_odyssey_model_nodes_model_id ON odyssey_model_nodes(model_id);
CREATE INDEX idx_odyssey_model_nodes_parent_id ON odyssey_model_nodes(parent_id);
CREATE INDEX idx_odyssey_model_animations_model_id ON odyssey_model_animations(model_id);
CREATE INDEX idx_mip_maps_dds_id ON mip_maps(dds_id);
CREATE INDEX idx_erf_headers_erf_id ON erf_headers(erf_id);
CREATE INDEX idx_erf_localized_strings_erf_id ON erf_localized_strings(erf_id);
CREATE INDEX idx_erf_key_entries_erf_id ON erf_key_entries(erf_id);
CREATE INDEX idx_erf_resource_entries_erf_id ON erf_resource_entries(erf_id);