import { Project, projectService } from "@/data/services/project_services";
import { defineStore } from "pinia";
import { computed, ref } from 'vue';
import { Result } from '../models/Result';

export const useProjectStore = defineStore('project', () => {
  const projects = ref<Project[]>([]);
  const selectedProject = ref<Project | null>(null);
  const totalProjects = computed(() => projects.value.length);

  async function loadProjects(): Promise<Result<Project[]>> {
    try {
      const response = await projectService.listProjects('current-user-id'); // TODO: Get actual user ID
      if (response.ok) {
        projects.value = response.value;
        return { ok: true, value: response.value };
      } else {
        throw response.error;
      }
    } catch (error) {
      console.error('Failed to load projects:', error);
      return { ok: false, error: error as Error };
    }
  }

  function loadProjectsSync(): Promise<Result<Project[]>> {
    return loadProjects();
  }

  async function createProject(project: Partial<Project>): Promise<Result<Project>> {
    try {
      const newProject = {
        ...defaultProject,
        ...project,
        id: crypto.randomUUID(),
        created_at: new Date().toISOString(),
        lastModified: new Date()
      };

      const response = await projectService.createProject(
        newProject.name,
        newProject.description || null,
        newProject.staging_path,
        newProject.original_directory_path
      );

      if (response.ok) {
        projects.value.push(response.value);
        return { ok: true, value: response.value };
      } else {
        throw response.error;
      }
    } catch (error) {
      console.error('Failed to create project:', error);
      return { ok: false, error: error as Error };
    }
  }

  function createProjectSync(project: Partial<Project>): Promise<Result<Project>> {
    return createProject(project);
  }

  async function updateProject(project: Project): Promise<Result<Project>> {
    try {
      const response = await projectService.updateProject(project.id, {
        name: project.name,
        description: project.description,
        stagingPath: project.staging_path
      });

      if (response.ok) {
        const index = projects.value.findIndex(p => p.id === project.id);
        if (index !== -1) {
          projects.value[index] = {
            ...projects.value[index],
            ...response.value,
            lastModified: new Date()
          };
        }
        return { ok: true, value: response.value };
      } else {
        throw response.error;
      }
    } catch (error) {
      console.error('Failed to update project:', error);
      return { ok: false, error: error as Error };
    }
  }

  function updateProjectSync(project: Project): Promise<Result<Project>> {
    return updateProject(project);
  }

  async function deleteProject(projectId: string): Promise<Result<void>> {
    try {
      const response = await projectService.deleteProject(projectId);
      if (response.ok) {
        projects.value = projects.value.filter(p => p.id !== projectId);
        if (selectedProject.value?.id === projectId) {
          selectedProject.value = null;
        }
        return { ok: true, value: undefined };
      } else {
        throw response.error;
      }
    } catch (error) {
      console.error('Failed to delete project:', error);
      return { ok: false, error: error as Error };
    }
  }

  function deleteProjectSync(projectId: string): Promise<Result<void>> {
    return deleteProject(projectId);
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
    loadProjects,
    loadProjectsSync,
    createProject,
    createProjectSync,
    updateProject,
    updateProjectSync,
    deleteProject,
    deleteProjectSync
  };
})



export const defaultProject: Project = {
  user_id: '',
  id: '', // Placeholder, can be set dynamically (e.g., crypto.randomUUID())
  name: '',
  description: '',
  created_at: new Date().toISOString(),
  staging_path: '',
  original_directory_path: ''
};
