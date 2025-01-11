import { defineStore, acceptHMRUpdate } from "pinia";
import { DirectoryService } from "@/data/directory-service";
import { DriveStatistics } from "@/data/directory-service";
import { DirectoryContents } from "@/data/directory-service";

// TODO: Add logging Store to track actions and errors
export const useFileSystemStore = defineStore("fileSystem", {
  state: () => ({
    currentDirectory: {} as DirectoryContents,
    previousDirectory: null as DirectoryContents | null,
    visitedDirectories: [] as string[],
    currentDirectoryIndex: -1,
    drives: [] as DriveStatistics[],
    selectedDrive: "",
    isLoading: false,
    error: null as string | null,
  }),

  actions: {
    async loadDrives() {
      this.isLoading = true;
      this.error = null;

      const directoryService = new DirectoryService();
      const result = await directoryService.getDriveStatistics();

      if (result.ok) {
        this.drives = result.value;
      } else {
        this.error = result.error;
      }

      this.isLoading = false;
    },

    async navigateToDirectory(path: string) {
      this.isLoading = true;
      this.error = null;

      const directoryService = new DirectoryService();
      const result = await directoryService.getDirectoryContents(path);

      if (result.ok) {
        this.previousDirectory = this.currentDirectory;
        this.currentDirectory = result.value;

        // Add to navigation history
        this.visitedDirectories = this.visitedDirectories.slice(
          0,
          this.currentDirectoryIndex + 1
        );
        this.visitedDirectories.push(path);
        this.currentDirectoryIndex++;
      } else {
        this.error = result.error;
      }

      this.isLoading = false;
    },

    async navigateToParent() {
      if (!this.currentDirectory?.path) {
        return;
      }

      this.isLoading = true;
      this.error = null;

      const directoryService = new DirectoryService();
      const result = await directoryService.getParentDirectoryContents(
        this.currentDirectory.path
      );

      if (result.ok) {
        this.previousDirectory = this.currentDirectory;
        this.currentDirectory = result.value;

        // Add to navigation history
        this.visitedDirectories = this.visitedDirectories.slice(
          0,
          this.currentDirectoryIndex + 1
        );
        this.visitedDirectories.push(this.currentDirectory.path);
        this.currentDirectoryIndex++;
      } else {
        this.error = result.error;
      }

      this.isLoading = false;
    },

    canGoBack(): boolean {
      return this.currentDirectoryIndex > 0;
    },

    canGoForward(): boolean {
      return this.currentDirectoryIndex < this.visitedDirectories.length - 1;
    },

    async goBack() {
      if (!this.canGoBack()) {
        return;
      }

      this.currentDirectoryIndex--;
      await this.navigateToDirectory(
        this.visitedDirectories[this.currentDirectoryIndex]
      );
    },

    async goForward() {
      if (!this.canGoForward()) {
        return;
      }

      this.currentDirectoryIndex++;
      await this.navigateToDirectory(
        this.visitedDirectories[this.currentDirectoryIndex]
      );
    },

    selectDrive(drivePath: string) {
      this.selectedDrive = drivePath;
      this.navigateToDirectory(drivePath);
    },

    reset() {
      this.currentDirectory = {} as DirectoryContents;
      this.previousDirectory = null;
      this.visitedDirectories = [];
      this.currentDirectoryIndex = -1;
    },
  },
});

// @ts-ignore
if (import.meta.hot) {
  // @ts-ignore
  import.meta.hot.accept(acceptHMRUpdate(useFileSystemStore, import.meta.hot));
}
