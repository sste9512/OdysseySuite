import { Result } from "@/models/Result";
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

export interface DirectoryItem {
  name: string;
  path: string;
  size: number;
  created: number;
  modified: number;
  is_hidden: boolean;
  type: "directory" | "file" | "other";
  readonly: boolean;
}

export interface DirectoryContents {
  path: string;
  contents: DirectoryItem[];
  total_items: number;
}

export class DirectoryService {
  async listDirectoryFromRoot(): Promise<Result<string[]>> {
    try {
      const files = await invoke<string[]>("list_directory_from_root");
      return { ok: true, value: files };
    } catch (error) {
      console.error("Failed to list directory:", error);
      return { ok: false, error: error as Error };
    }
  }

  /**
   * Lists all files in the specified directory
   * @param path The directory path to list
   * @returns Promise containing Result with array of file names or error
   */
  async listDirectory(path: string): Promise<Result<string[]>> {
    try {
      const files = await invoke<string[]>("list_directory", { path });
      return { ok: true, value: files };
    } catch (error) {
      console.error("Failed to list directory:", error);
      return { ok: false, error: error as Error };
    }
  }

  /**
   * Gets information about available drives on the system
   * @returns Promise containing array of drive paths (e.g., ["C:", "D:", ...])
   * @throws Error if unable to get drive information
   */
  async getDriveInfo(): Promise<Result<string[]>> {
    try {
      const drives = await invoke<string[]>("get_drive_info");
      return { ok: true, value: drives };
    } catch (error) {
      console.error("Failed to get drive information:", error);
      return { ok: false, error: error as Error };
    }
  }
  /**
   * Gets detailed statistics about all available drives on the system
   * @returns Promise containing array of DriveStatistics objects with information like total/free space
   * @throws Error if unable to retrieve drive statistics
   */
  async getDriveStatistics(): Promise<Result<DriveStatistics[]>> {
    try {
      const stats = await invoke<DriveStatistics[]>("get_drive_statistics");
      return { ok: true, value: stats };
    } catch (error) {
      console.error("Failed to get drive statistics:", error);
      return { ok: false, error: error as Error };
    }
  }

  /**
   * Gets the contents of a directory at the specified path
   * @param path The directory path to get contents for
   * @returns Promise containing DirectoryContents with path, contents array, and total item count
   * @throws Error if unable to retrieve directory contents
   */
  async getDirectoryContents(path: string): Promise<Result<DirectoryContents>> {
    try {
      const contents = await invoke<DirectoryContents>(
        "get_directory_contents",
        {
          path,
        }
      );
      return { ok: true, value: contents };
    } catch (error) {
      console.error("Failed to get directory contents:", error);
      return { ok: false, error: error as Error };
    }
  }

  /**
   * Gets the contents of the parent directory for a given path
   * @param path The path to get the parent directory contents for
   * @returns Promise containing Result with DirectoryContents or error
   */
  async getParentDirectoryContents(
    path: string
  ): Promise<Result<DirectoryContents>> {
    try {
      const contents = await invoke<DirectoryContents>(
        "get_parent_directory_contents",
        { path }
      );
      return { ok: true, value: contents };
    } catch (error) {
      console.error("Failed to get parent directory contents:", error);
      return { ok: false, error: error as Error };
    }
  }

  /**
 * Invokes the `search_files_by_extension` command from Tauri.
 * 
 * @param path - The path where the search should be performed.
 * @param extension - The file extension to search for.
 * @returns A promise resolving to a list of matching file paths or an error message.
 */
  async searchFilesByExtension(path: string, extension: string): Promise<Result<string[]>> {
    try {
      const matchingFiles = await invoke<string[]>('search_files_by_extension', {
        path,
        extension
      });
      console.log('Matching files:', matchingFiles);
      return { ok: true, value: matchingFiles };
    } catch (error) {
      console.error('Error searching files:', error);
      return { ok: false, error: error as Error };
    }
  }

  // Example usage:
  // const path = 'C:\\Users\\Example\\Documents'; // Replace with the desired path
  // const extension = 'txt'; // Replace with the desired file extension

  // searchFilesByExtension(path, extension)
  //   .then((files) => {
  //     console.log('Found files:', files);
  //   })
  //   .catch((err) => {
  //     console.error('Failed to search for files:', err);
  //   });



}
