import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";
import { TpcData } from "./tpc-data";


export class ImageApi {


/**
* Reads TPC texture data from a byte array
* @param data Byte array containing TPC data
* @returns Promise containing a Result with either the TPC data or an error
*/
    async readTpcFromBytes(data: Uint8Array): Promise<Result<TpcData>> {
        try {
            const tpcData = await invoke<TpcData>('read_tpc_from_bytes', { data: Array.from(data) });
            return { ok: true, value: tpcData };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }
}
