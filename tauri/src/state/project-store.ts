import {defineStore} from "pinia";
import {resolve} from "@/injection/injection-context";
import type {IProjectManagementClient} from "@/clients/web-api-client";
import {ref, computed} from 'vue';
import {ProjectApi} from "@/data/project-api";

export const useProjectStore = defineStore('project', () => {


    const projects = ref<Project[]>([]);
    const selectedProject = ref<Project | null>(null);
    const totalProjects = computed(() => projects.value.length);

    const projectApi = new ProjectApi();

    async function loadProjects() {
        try {
            const response = await projectApi.listProjects();
            if (response.ok) {
                projects.value = response.value;
                return {ok: true, value: response.value};
            }
        } catch (error) {
            console.error('Failed to load projects:', error);
            return {ok: false, error: error as Error};
        }
    }

    async function createProject(project: Partial<Project>) {
        try {
            const newProject = {
                ...defaultProject,
                ...project,
                id: crypto.randomUUID(),
                created_at: new Date().toISOString(),
                lastModified: new Date()
            };

            const response = await projectApi.createProject(
                newProject.name,
                newProject.description || null,
                newProject.staging_path,
                newProject.original_directory_path
            );

            if (response.ok) {
                projects.value.push(newProject);
                return {ok: true, value: newProject};
            } else {
                throw new Error('Failed to create project on the server');
            }
        } catch (error) {
            console.error('Failed to create project:', error);
            return {ok: false, error: error as Error};
        }
    }

    // async function updateProject(project: Project) {
    //     try {
    //         const response = await projectApi.updateProject(project.id, {
    //             name: project.name,
    //             staging_path: project.staging_path,
    //             description: project.description
    //         });
    //
    //         if (response.ok) {
    //             const index = projects.value.findIndex(p => p.id === project.id);
    //             if (index !== -1) {
    //                 projects.value[index] = {
    //                     ...projects.value[index],
    //                     ...project,
    //                     lastModified: new Date()
    //                 };
    //             }
    //             return {ok: true, value: project};
    //         } else {
    //             throw new Error('Failed to update project on the server');
    //         }
    //     } catch (error) {
    //         console.error('Failed to update project:', error);
    //         return {ok: false, error: error as Error};
    //     }
    // }

    // async function deleteProject(projectId: string) {
    //     try {
    //             await projectApi.deleteProject(projectId);
    //         projects.value = projects.value.filter(p => p.id !== projectId);
    //         if (selectedProject.value?.id === projectId) {
    //             selectedProject.value = null;
    //         }
    //         return { ok: true, value: undefined };
    //     } catch (error) {
    //         console.error('Failed to delete project:', error);
    //         return { ok: false, error: error as Error };
    //     }
    // }

    function selectProject(project: Project) {
        selectedProject.value = project;
    }

    function clearSelectedProject() {
        selectedProject.value = null;
    }

    return {
        projects,
        selectedProject,
        selectProject,
        clearSelectedProject,
        totalProjects,
    };
})

export interface Project {
    id: string; // Unique project ID
    name: string; // Project name
    description?: string; // Optional project description
    created_at: string; // Timestamp when the project was created
    staging_path: string; // Path where the project is staged
    original_directory_path: string; // Path to the original project directory
}


export const defaultProject: Project = {
    id: '', // Placeholder, can be set dynamically (e.g., crypto.randomUUID())
    name: '',
    description: '',
    created_at: new Date().toISOString(),
    staging_path: '',
    original_directory_path: ''
};

