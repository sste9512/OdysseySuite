import { invoke } from "@tauri-apps/api/core";

export interface DriveStatistics {
  path: string;
  total_gb: number;
  used_gb: number;
  available_gb: number;
  usage_percent: number;
  name: string;
  file_system: string;
}
export class DirectoryService {
  // Uses tauri commands
  async listDirectoryFromRoot(): Promise<string[]> {
    try {
      const files = await invoke<string[]>("list_directory_from_root");
      return files;
    } catch (error) {
      console.error("Failed to list directory:", error);
      throw error;
    }
  }

  /**
   * Lists all files in the specified directory
   * @param path The directory path to list
   * @returns Promise containing array of file names
   */
  async listDirectory(path: string): Promise<string[]> {
    try {
      const files = await invoke<string[]>("list_directory", { path });
      return files;
    } catch (error) {
      console.error("Failed to list directory:", error);
      throw error;
    }
  }

  /**
   * Gets information about available drives on the system
   * @returns Promise containing array of drive paths (e.g., ["C:", "D:", ...])
   */
  async getDriveInfo(): Promise<string[]> {
    try {
      const drives = await invoke<string[]>("get_drive_info");
      return drives;
    } catch (error) {
      console.error("Failed to get drive information:", error);
      throw error;
    }
  }

  async getDriveStatistics(): Promise<DriveStatistics[]> {
    try {
      const stats = await invoke<DriveStatistics[]>("get_drive_statistics");
      return stats;
    } catch (error) {
      console.error("Failed to get drive statistics:", error);
      throw error;
    }
  }

  // Example usage:
  //     async function example() {
  //         try {
  //             const drives = await getDriveInfo();
  //             console.log('Available drives:', drives);
  //         } catch (error) {
  //             console.error('Error:', error);
  //         }
  //     }

  // Example usage:
  //     async function example() {
  //         try {
  //             const files = await listDirectory('C:/some/path');
  //             console.log('Files in directory:', files);
  //         } catch (error) {
  //             console.error('Error:', error);
  //         }
  //     }
  // }
}
