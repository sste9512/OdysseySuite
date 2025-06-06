-- Drop tables in reverse order of creation to respect foreign key constraints

-- Drop indexes first
DROP INDEX IF EXISTS idx_erf_resource_entries_erf_id;
DROP INDEX IF EXISTS idx_erf_key_entries_erf_id;
DROP INDEX IF EXISTS idx_erf_localized_strings_erf_id;
DROP INDEX IF EXISTS idx_erf_headers_erf_id;
DROP INDEX IF EXISTS idx_mip_maps_dds_id;
DROP INDEX IF EXISTS idx_odyssey_model_animations_model_id;
DROP INDEX IF EXISTS idx_odyssey_model_nodes_parent_id;
DROP INDEX IF EXISTS idx_odyssey_model_nodes_model_id;
DROP INDEX IF EXISTS idx_odyssey_models_model_header_id;
DROP INDEX IF EXISTS idx_odyssey_models_geometry_header_id;
DROP INDEX IF EXISTS idx_odyssey_models_file_header_id;
DROP INDEX IF EXISTS idx_odyssey_model_headers_geometry_header_id;
DROP INDEX IF EXISTS idx_odyssey_geometry_headers_file_header_id;

-- Drop tables in reverse order of dependencies
DROP TABLE IF EXISTS erf_resource_entries;
DROP TABLE IF EXISTS erf_key_entries;
DROP TABLE IF EXISTS erf_localized_strings;
DROP TABLE IF EXISTS erf_headers;
DROP TABLE IF EXISTS erf_files;

DROP TABLE IF EXISTS mip_maps;
DROP TABLE IF EXISTS dds_files;

DROP TABLE IF EXISTS odyssey_model_animations;
DROP TABLE IF EXISTS odyssey_model_nodes;
DROP TABLE IF EXISTS odyssey_models;
DROP TABLE IF EXISTS odyssey_model_headers;
DROP TABLE IF EXISTS odyssey_array_definitions;
DROP TABLE IF EXISTS odyssey_geometry_headers;
DROP TABLE IF EXISTS odyssey_file_headers;