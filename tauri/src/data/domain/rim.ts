export interface RimKeyEntry {
    resource_name: string;
    resource_type: number;  // i16 in Rust -> number in TS
    resource_id: number;    // i16 in Rust -> number in TS
    offset: number;        // i32 in Rust -> number in TS
    length: number;        // i32 in Rust -> number in TS
    index: number;         // i32 in Rust -> number in TS
  }
  
  export interface Rim {
    entry_count: number;    // i32 in Rust -> number in TS
    off_key_list: number;    // i32 in Rust -> number in TS
    key_entry_list: RimKeyEntry[];
    data: Uint8Array;      // Vec<u8> in Rust -> Uint8Array in TS
  }