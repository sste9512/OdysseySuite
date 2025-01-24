import {defineStore} from "pinia";
import {resolve} from "@/injection/injection-context";
import type {IProjectManagementClient} from "@/clients/web-api-client";
import {ref, computed} from 'vue';

export const useProjectStore = defineStore('project', () => {



    const projects = ref<Project[]>([]);
    const selectedProject = ref<Project | null>(null);
    const totalProjects = computed(() => projects.value.length);

    const projectClient = resolve<IProjectManagementClient>('project-client');

    async function loadProjects() {
        try {
            const response = await projectClient.getProjects();
            projects.value = response.map(p => ({
                id: p.id,
                name: p.name,
                path: p.path,
                description: p.description || '',
                createdAt: new Date(p.createdAt),
                lastModified: new Date(p.lastModified),
                gameType: p.gameType,
                settings: p.settings || {}
            }));
        } catch (error) {
            console.error('Failed to load projects:', error);
            return { ok: false, error: error as Error };
        }
    }

    async function createProject(project: Partial<Project>) {
        try {
            const newProject = {
                ...defaultProject,
                ...project,
                id: crypto.randomUUID(),
                createdAt: new Date(),
                lastModified: new Date()
            };
            
            const response = await projectClient.createProject({
                id: newProject.id,
                name: newProject.name,
                path: newProject.path,
                description: newProject.description,
                createdAt: newProject.createdAt.toISOString(),
                lastModified: newProject.lastModified.toISOString(),
                gameType: newProject.gameType,
                settings: newProject.settings
            });

            projects.value.push(newProject);
            return { ok: true, value: newProject };
        } catch (error) {
            console.error('Failed to create project:', error);
            return { ok: false, error: error as Error };
        }
    }

    async function updateProject(project: Project) {
        try {
            const response = await projectClient.updateProject(project.id, {
                name: project.name,
                path: project.path,
                description: project.description,
                gameType: project.gameType,
                settings: project.settings
            });

            const index = projects.value.findIndex(p => p.id === project.id);
            if (index !== -1) {
                projects.value[index] = {
                    ...project,
                    lastModified: new Date()
                };
            }
            return { ok: true, value: project };
        } catch (error) {
            console.error('Failed to update project:', error);
            return { ok: false, error: error as Error };
        }
    }

    async function deleteProject(projectId: string) {
        try {
            await projectClient.deleteProject(projectId);
            projects.value = projects.value.filter(p => p.id !== projectId);
            if (selectedProject.value?.id === projectId) {
                selectedProject.value = null;
            }
            return { ok: true, value: undefined };
        } catch (error) {
            console.error('Failed to delete project:', error);
            return { ok: false, error: error as Error };
        }
    }

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
    id: string;
    name: string;
    path: string;
    description?: string;
    createdAt: Date;
    lastModified: Date;
    gameType?: string;
    settings?: {
        [key: string]: any;
    };
}

export const defaultProject: Project = {
    id: crypto.randomUUID(),
    name: '',
    path: '',
    description: '',
    createdAt: new Date(),
    lastModified: new Date(),
    gameType: '',
    settings: {}
};

