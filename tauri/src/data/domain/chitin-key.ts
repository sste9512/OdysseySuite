import { Char } from "effect/Schema";

// Interface definitions
interface KeyHeader {
    file_type: string; // [char; 4]
    file_version: string; // [char; 4]
    bif_count: number; // u32
    key_count: number; // u32
    offset_to_file_table: number; // u32
    offset_to_key_table: number; // u32
    build_year: number; // u32
    build_day: number; // u32
    reserved: number[]; // [u8; 32]
}

interface FileEntry {
    file_size: number; // u32
    filename_offset: number; // u32
    filename_size: number; // u16
    drives: number; // u16
}

interface FilenameEntry {
    filename: string;
}

interface KeyEntry {
    resref:  string[]; // [char; 16]
    resource_type: number; // u16
    res_id: number; // u32
}

// Main ChitinKey interface that we export
export interface ChitinKey {
    header: KeyHeader;
    file_entries: FileEntry[];
    filenames: FilenameEntry[];
    key_entries: KeyEntry[];
}

// Also export the other interfaces if needed elsewhere
export type {
    KeyHeader,
    FileEntry,
    FilenameEntry,
    KeyEntry
};

export function getBifIndex(resId: number): number {
    return resId >> 20;
}

export function getResourceIndex(resId: number): number {
    return resId & 0xFFFFF; // Bottom 20 bits
}
