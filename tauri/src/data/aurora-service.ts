import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";
import { ChitinKey } from "@/data/chitin-key";
import { Biff } from "./biff";
import { ErfFile } from "./erf";
import { Rim } from "./rim";
import { TpcData } from "./tpc-data";


export class AuroraService {
  /**
   * Reads and parses a Chitin.key file from the given path.
   * The Chitin.key file contains metadata about game resources and their locations.
   * 
   * @param path - The file system path to the Chitin.key file
   * @returns Promise resolving to the parsed ChitinKey data structure
   * @throws Error if reading or parsing the file fails
   */
  async readChitinKey(path: string): Promise<ChitinKey> {
    try {
      return await invoke("read_chitin_key", { path });
    } catch (error) {
      console.error("Failed to read chitin key:", error);
      throw error;
    }
  }

  /**
   * Reads and parses a BIFF (Binary Infinity File Format) file from the given path.
   * BIFF files contain game resources like graphics, sounds, and other data.
   * 
   * @param path - The file system path to the BIFF file
   * @returns Promise resolving to a Result containing either the parsed Biff data or an error
   */
  async readBiffFile(path: string): Promise<Result<Biff>> {
    try {
      const biff = await invoke<Biff>('read_biff', { path });
      return { ok: true, value: biff };
    } catch (error) {
      return { ok: false, error: error as Error };
    }
  }

  /**
 * Reads an ERF file from the specified path
 * @param path Path to the ERF file
 * @returns Promise containing a Result with either the ERF file data or an error
 */
  async readErfFile(path: string): Promise<Result<ErfFile>> {
    try {
      const erf = await invoke<ErfFile>('read_erf', { path });
      return { ok: true, value: erf };
    } catch (error) {
      return { ok: false, error: error as Error };
    }
  }

  /**
   * Reads a RIM file from the specified path
   * @param path Path to the RIM file
   * @returns Promise containing a Result with either the RIM file data or an error
   */
  async readRimFile(path: string): Promise<Result<Rim>> {
    try {
      const rim = await invoke<Rim>('read_rim', { path });
      return { ok: true, value: rim };
    } catch (error) {
      return { ok: false, error: error as Error };
    }
  }




  /**
   * Gets resource data from an ERF file for a specific resource ID
   * @param filepath Path to the ERF file
   * @param resourceId ID of the resource to extract
   * @returns Promise containing a Result with either the resource data or an error
   */
  async getErfResourceData(filepath: string, resourceId: number): Promise<Result<Uint8Array>> {
    try {
      const data = await invoke<number[]>('get_erf_resource_data', { filepath, resourceId });
      return { ok: true, value: new Uint8Array(data) };
    } catch (error) {
      return { ok: false, error: error as Error };
    }
  }



}




// Usage example:
// async function loadBiffFile(filePath: string) {
//     const result = await readBiffFile(filePath);
//     if (result.ok) {
//         const biff = result.value;
//         console.log('BIFF Header:', biff.header);
//         console.log('Variable Resources:', biff.variableResources.length);
//         console.log('Fixed Resources:', biff.fixedResources.length);
//     } else {
//           console.error('Failed to read BIFF file:', result.error);
//     }
// }
