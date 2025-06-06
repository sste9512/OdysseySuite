// @generated automatically by Diesel CLI.

diesel::table! {
    dds_files (id) {
        id -> Integer,
        format -> Integer,
        filepath -> Text,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    erf_files (id) {
        id -> Integer,
        file_path -> Text,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    erf_headers (id) {
        id -> Integer,
        erf_id -> Integer,
        file_type -> Binary,
        version -> Binary,
        language_count -> Integer,
        localized_string_size -> Integer,
        entry_count -> Integer,
        offset_to_localized_string -> Integer,
        offset_to_key_list -> Integer,
        offset_to_resource_list -> Integer,
        build_year -> Integer,
        build_day -> Integer,
        description_strref -> Integer,
        reserved -> Nullable<Binary>,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    erf_key_entries (id) {
        id -> Integer,
        erf_id -> Integer,
        filename -> Binary,
        resource_id -> Integer,
        resource_type -> Integer,
        unused -> Integer,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    erf_localized_strings (id) {
        id -> Integer,
        erf_id -> Integer,
        language_id -> Integer,
        string_size -> Integer,
        string -> Text,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    erf_resource_entries (id) {
        id -> Integer,
        erf_id -> Integer,
        offset_to_resource -> Integer,
        resource_size -> Integer,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    mip_maps (id) {
        id -> Integer,
        dds_id -> Integer,
        width -> Integer,
        height -> Integer,
        size -> Integer,
        data -> Nullable<Binary>,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_array_definitions (id) {
        id -> Integer,
        parent_type -> Text,
        parent_id -> Integer,
        array_type -> Text,
        offset -> Integer,
        count -> Integer,
        count2 -> Integer,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_file_headers (id) {
        id -> Integer,
        flag_binary -> Integer,
        mdl_data_size -> Integer,
        mdx_data_size -> Integer,
        model_data_offset -> Integer,
        raw_data_offset -> Integer,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_geometry_headers (id) {
        id -> Integer,
        file_header_id -> Integer,
        mdx_offset -> Integer,
        mdx_length -> Integer,
        padding -> Integer,
        root_node_offset2 -> Integer,
        function_pointer0 -> Integer,
        function_pointer1 -> Integer,
        model_name -> Text,
        root_node_offset -> Integer,
        node_count -> Integer,
        ref_count -> Integer,
        geometry_type -> Integer,
        unknown4 -> Nullable<Binary>,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_model_animations (id) {
        id -> Integer,
        model_id -> Integer,
        name -> Text,
        length -> Float,
        transition_time -> Float,
        animation_root -> Text,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_model_headers (id) {
        id -> Integer,
        geometry_header_id -> Integer,
        classification -> Integer,
        sub_classification -> Integer,
        smoothing -> Bool,
        fogged -> Bool,
        child_model_count -> Integer,
        parent_model_pointer -> Integer,
        bounding_min_x -> Float,
        bounding_min_y -> Float,
        bounding_min_z -> Float,
        bounding_max_x -> Float,
        bounding_max_y -> Float,
        bounding_max_z -> Float,
        radius -> Float,
        scale -> Float,
        super_model_name -> Text,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_model_nodes (id) {
        id -> Integer,
        model_id -> Integer,
        parent_id -> Nullable<Integer>,
        name -> Text,
        node_type -> Integer,
        position_x -> Float,
        position_y -> Float,
        position_z -> Float,
        rotation_x -> Float,
        rotation_y -> Float,
        rotation_z -> Float,
        rotation_w -> Float,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::table! {
    odyssey_models (id) {
        id -> Integer,
        file_header_id -> Integer,
        geometry_header_id -> Integer,
        model_header_id -> Integer,
        engine -> Integer,
        mdl_data -> Nullable<Binary>,
        mdx_data -> Nullable<Binary>,
        created_at -> Timestamp,
        updated_at -> Timestamp,
    }
}

diesel::joinable!(erf_headers -> erf_files (erf_id));
diesel::joinable!(erf_key_entries -> erf_files (erf_id));
diesel::joinable!(erf_localized_strings -> erf_files (erf_id));
diesel::joinable!(erf_resource_entries -> erf_files (erf_id));
diesel::joinable!(mip_maps -> dds_files (dds_id));
diesel::joinable!(odyssey_geometry_headers -> odyssey_file_headers (file_header_id));
diesel::joinable!(odyssey_model_animations -> odyssey_models (model_id));
diesel::joinable!(odyssey_model_headers -> odyssey_geometry_headers (geometry_header_id));
diesel::joinable!(odyssey_model_nodes -> odyssey_models (model_id));
diesel::joinable!(odyssey_models -> odyssey_file_headers (file_header_id));
diesel::joinable!(odyssey_models -> odyssey_geometry_headers (geometry_header_id));
diesel::joinable!(odyssey_models -> odyssey_model_headers (model_header_id));

diesel::allow_tables_to_appear_in_same_query!(
    dds_files,
    erf_files,
    erf_headers,
    erf_key_entries,
    erf_localized_strings,
    erf_resource_entries,
    mip_maps,
    odyssey_array_definitions,
    odyssey_file_headers,
    odyssey_geometry_headers,
    odyssey_model_animations,
    odyssey_model_headers,
    odyssey_model_nodes,
    odyssey_models,
);