<template>
  <v-card class="project-selection-container"
          style="background: linear-gradient(135deg, #212121, #424242); padding: 30px;">
   
   
    <v-app-bar class="header hero" app style="background: linear-gradient(135deg, #ff0099, #0000ff);" dark>
      <v-toolbar-title class="title">Select a Project</v-toolbar-title>
    </v-app-bar>

    <v-card-text class="project-list" style="flex-grow: 1; overflow-y: auto; margin-bottom: 20px;">
      <ul>
        <li
            v-for="project in projects"
            :key="project.id"
            class="project-item"
            @click="selectProject(project)"
            @contextmenu.prevent="openContextMenu($event, project)"
        >
          <v-card class="project-card" outlined
                  style="background: linear-gradient(135deg, #0f0f0f, #303030); border-color: #00ffcc; position: relative;"
                  @click="selectProject(project)">
            <v-card-text class="d-flex align-center">
              <v-icon class="mr-4" style="font-size: 19px; color: #00ffcc;">mdi-folder</v-icon>
              <div class="project-details">
                <h2 class="project-name" style="font-size: 12px; color: #ff00ff;">{{ project.name }}</h2>
                <p class="project-path" style="font-size: 10px; color: #00ffcc;">{{ project.path }}</p>
              </div>
            </v-card-text>
            <v-btn outlined small color="primary" class="hover-open-btn"
                   style="position: absolute; top: 10px; right: 10px; opacity: 0; transition: opacity 0.3s;">
              Open
            </v-btn>
          </v-card>
        </li>
      </ul>
    </v-card-text>
  </v-card>
</template>

<script setup lang="ts">
import {ref} from "vue";

interface Project {
  id: string;
  name: string;
  path: string;
}

// Sample data for demo purposes
const projects = ref<Project[]>([
  {id: "1", name: "Project Alpha", path: "C:/Projects/Alpha"},
  {id: "2", name: "Project Beta", path: "/Users/example/Projects/Beta"},
  {id: "3", name: "Project Gamma", path: "~/Documents/Gamma"}
]);

function selectProject(project: Project) {
  console.log(`Selected Project: ${project.name}`);
  // Add navigation or state management logic here
}

function createNewProject() {
  console.log("Creating a new project...");
  // Add your logic for creating a new project
}

function openExistingProject() {
  console.log("Opening an existing project...");
  // Add your logic for opening an existing project
}
</script>

<style scoped>
.project-selection-container {
  display: flex;
  flex-direction: column;
  height: 100vh;
  justify-content: space-between;
  padding: 20px;
  background-color: #f5f5f5;
  font-family: Arial, sans-serif;
}


 .project-card:hover .hover-open-btn {
   opacity: 1;
 }


.header {
  text-align: center;
}

.title {
  font-size: 24px;
  font-weight: bold;
}

.project-list {
  flex-grow: 1;
  margin-top: 20px;
  overflow-y: auto;
}

ul {
  list-style: none;
  padding: 0;
}

.project-item:hover {
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}

.project-icon {
  font-size: 32px;
  margin-right: 15px;
}

.project-details {
  display: flex;
  flex-direction: column;
}

.project-name {
  font-size: 18px;
  font-weight: bold;
  margin: 0;
}

.project-path {
  font-size: 14px;
  color: #666;
  margin: 0;
}

.footer {
  display: flex;
  justify-content: space-between;
}

.create-button, .open-button {
  padding: 10px 20px;
  font-size: 16px;
  border: none;
  border-radius: 6px;
  cursor: pointer;
  transition: background-color 0.3s;
}

.create-button {
  background-color: #4caf50;
  color: white;
}

.create-button:hover {
  background-color: #45a049;
}

.open-button {
  background-color: #2196f3;
  color: white;
}

.open-button:hover {
  background-color: #1e88e5;
}
</style>


