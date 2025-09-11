export interface ErfFile {
  header: ErfHeader;
  localized_strings: ErfLocalizedStringTable;
  key_list: ErfKeyTable;
  resource_list: ErfResourceTable;
  resource_data: ErfResourceData;
  file_path: string;
}

export interface ErfHeader {
  file_type: number[];  // 4 bytes
  version: number[];    // 4 bytes
  language_count: number;
  localized_string_size: number;
  entry_count: number;
  offset_to_localized_string: number;
  offset_to_key_list: number;
  offset_to_resource_list: number;
  build_year: number;
  build_day: number;
  description_strref: number;
  reserved: number[];
}

export enum LanguageId {
  English = 0,
  French = 1,
  German = 2,
  Italian = 3,
  Spanish = 4,
  Polish = 5,
  Korean = 128,
  ChineseTraditional = 129,
  ChineseSimplified = 130,
  Japanese = 131,
}

export interface ErfLocalizedString {
  language_id: number;
  string_size: number;
  string: string;
}

export interface ErfLocalizedStringTable {
  table_size: number;
  strings: ErfLocalizedString[];
}

export interface ErfKeyEntry {
  filename: number[];  // 16 bytes
  resource_id: number;
  resource_type: number;
  unused: number;
}

export interface ErfKeyTable {
  entries: ErfKeyEntry[];
}

export interface ErfResourceEntry {
  offset_to_resource: number;
  resource_size: number;
}

export interface ErfResourceTable {
  entries: ErfResourceEntry[];
}

export interface ErfResourceData {
  data: number[];
}