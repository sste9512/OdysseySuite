import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";
import { TpcData } from "./tpc-data";
import { TPC } from "@/components/Aurora-Rendering/types/TPC";


export class ImageApi {
 
 

 
    /**
     * Converts a byte array to TPC format
     * @param resourceData - The raw byte data to convert
     * @returns Promise resolving to TPC object
     */
    async convertBytesToTPC(resourceData: Uint8Array): Promise<Result<TPC>> {
        try {
            const tpc = await invoke<TPC>('convert_bytes_to_tpc', {
                resourceData: Array.from(resourceData)
            });
            return { ok: true, value: tpc };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }

    /**
     * Converts a file at the given path to TPC format
     * @param path - Path to the file to convert
     * @returns Promise resolving to TPC object
     */
    async convertFileToTPC(path: string): Promise<Result<TPC>> {
        try {
            const tpc = await invoke<TPC>('convert_file_to_tpc', { path });
            return { ok: true, value: tpc };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }

    /**
     * Writes TPC data to a file
     * @param path - Path where to write the file
     * @param tpcData - The TPC data to write
     * @returns Promise resolving to void on success
     */
    async writeTPCToFile(path: string, tpcData: TPC): Promise<Result<void>> {
        try {
            await invoke<void>('write_tpc_to_file', { 
                path, 
                tpcData 
            });
            return { ok: true, value: undefined };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }

      /**
     * Converts a TPC texture to DDS format
     * @param tpcData - The TPC texture data to convert
     * @returns Promise resolving to Uint8Array containing DDS data
     */
      async convertTPCtoDDS(tpcData: TPC): Promise<Result<Uint8Array>> {
        try {
            const ddsData = await invoke<number[]>('convert_tpc_to_dds', { 
                tpcData 
            });
            return { 
                ok: true, 
                value: new Uint8Array(ddsData) 
            };
        } catch (error) {
            return { 
                ok: false, 
                error: error as Error 
            };
        }
    }

    /**
     * Gets TPC data from a file at specified offset and size
     * @param path - Path to the file containing TPC data
     * @param offset - Offset in the file where TPC data starts
     * @param size - Size of the TPC data in bytes
     * @returns Promise resolving to TPC data
     */
    async getTPCFromFile(path: string, offset: number, size: number): Promise<Result<TPC>> {
        try {
            const tpc = await invoke<TPC>('get_tpc_from_file', {
                path,
                offset,
                size
            });
            return { ok: true, value: tpc };
        } catch (error) {
            return { ok: false, error: error as Error };
        }
    }
}

 
