

import { Result } from '@/models/Result';
import { Project } from '@/state/project-store';
import { invoke } from "@tauri-apps/api/core";

export class ProjectApi {
    // Create a new project
    async createProject(
        name: string,
        description: string | null,
        stagingPath: string,
        originalDirectoryPath: string
    ): Promise<Result<Project, Error>> {
        try {
            const project = await invoke('create_project', {
                name,
                description,
                stagingPath,
                originalDirectoryPath
            });
            return { ok: true, value: project as Project };
        } catch (error) {
            console.error('Failed to create project:', error);
            return { ok: false, error: error as Error };
        }
    }

    // List all projects
    async listProjects(): Promise<Result<Project[]>> {
        try {
            const projects = await invoke('list_projects');
            return { ok: true, value: projects as Project[] };
        } catch (error) {
            console.error('Failed to list projects:', error);
            return { ok: false, error: error as Error };
        }
    }

}