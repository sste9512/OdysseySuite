import {defineStore} from "pinia";
import {resolve} from "@/injection/injection-context";
import type {IProjectManagementClient} from "@/clients/web-api-client";
import type {DirectoryInfo} from "@/web-api-client";
import {ref, computed} from 'vue';

export const useProjectStore = defineStore('project', () => {




    const projectClient = resolve<IProjectManagementClient>('IProjectManagementClient'); // Resolving dependency

    const projects = ref<DirectoryInfo[]>([]); // Stores the list of projects
    const selectedProject = ref<DirectoryInfo | null>(null); // Currently selected project

    // const loadProjects = async () => {
    //     projects.value = await projectClient; // Fetch projects from the API
    // };

    const selectProject = (project: DirectoryInfo) => {
        selectedProject.value = project; // Update selected project
    };

    const clearSelectedProject = () => {
        selectedProject.value = null; // Clears the selected project
    };

    const totalProjects = computed(() => projects.value.length); // Computes total projects

    return {
        projects,
        selectedProject,
        selectProject,
        clearSelectedProject,
        totalProjects,
    };
})