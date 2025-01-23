import { Result } from "@/models/Result";
import { invoke } from "@tauri-apps/api/core";
import {ChitinKey} from "@/data/chitin-key";


export class AuroraService {
  async readChitinKey(path: string): Promise<ChitinKey> {
    try {
      return await invoke("read_chitin_key", { path });
    } catch (error) {
      console.error("Failed to read chitin key:", error);
      throw error;
    }
  }
}
