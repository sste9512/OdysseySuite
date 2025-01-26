import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";
import { ChitinKey } from "@/data/chitin-key";
import { Biff } from "./biff";


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
