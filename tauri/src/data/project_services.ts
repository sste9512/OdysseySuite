import { invoke } from "@tauri-apps/api/core";
import { Result } from '../models/Result';

export interface Project {
  id: string;
  user_id: string;
  name: string;
  description?: string;
  created_at: string;
  staging_path: string;
  original_directory_path: string;
}




export const projectService = {
  /**
   * Lists all projects for a user
   */
  async listProjects(userId: string): Promise<Result<Project[]>> {
    try {
      const projects = await invoke<Project[]>('list_projects', { userId });
      return { ok: true, value: projects };
    } catch (error) {
      console.error('Failed to list projects:', error);
      return { ok: false, error: error as Error };
    }
  },

  /**
   * Creates a new project
   */
  async createProject(
    name: string,
    description: string | null,
    stagingPath: string,
    originalDirectoryPath: string
  ): Promise<Result<Project>> {
    try {
      const project = await invoke<Project>('create_project', {
        name,
        description,
        stagingPath,
        originalDirectoryPath
      });
      return { ok: true, value: project };
    } catch (error) {
      console.error('Failed to create project:', error);
      return { ok: false, error: error as Error };
    }
  },

  /**
   * Updates an existing project
   */
  async updateProject(
    id: string,
    data: { name: string; description?: string | null; stagingPath: string }
  ): Promise<Result<Project>> {
    try {
      const project = await invoke<Project>('update_project', {
        id,
        name: data.name,
        description: data.description,
        stagingPath: data.stagingPath
      });
      return { ok: true, value: project };
    } catch (error) {
      console.error('Failed to update project:', error);
      return { ok: false, error: error as Error };
    }
  },

  /**
   * Deletes a project
   */
  async deleteProject(id: string): Promise<Result<void>> {
    try {
      await invoke<void>('delete_project', { id });
      return { ok: true, value: undefined };
    } catch (error) {
      console.error('Failed to delete project:', error);
      return { ok: false, error: error as Error };
    }
  },

  /**
   * Lists all projects for a user (synchronous version)
   */
  listProjectsSync(userId: string): Promise<Result<Project[]>> {
    return this.listProjects(userId);
  },

  /**
   * Creates a new project (synchronous version)
   */
  createProjectSync(
    name: string,
    description: string | null,
    stagingPath: string,
    originalDirectoryPath: string
  ): Promise<Result<Project>> {
    return this.createProject(name, description, stagingPath, originalDirectoryPath);
  },

  /**
   * Updates an existing project (synchronous version)
   */
  updateProjectSync(
    id: string,
    data: { name: string; description?: string | null; stagingPath: string }
  ): Promise<Result<Project>> {
    return this.updateProject(id, data);
  },

  /**
   * Deletes a project (synchronous version)
   */
  deleteProjectSync(id: string): Promise<Result<void>> {
    return this.deleteProject(id);
  }
};
