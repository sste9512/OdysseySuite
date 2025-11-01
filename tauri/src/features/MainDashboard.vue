<script>


import AuroraAppBar from "@/components/AppBarViews/AuroraAppBar.vue";
import OuterMainGameNav from "@/components/NavigationDrawerViews/GameResourcesNavView.vue";
import ProfilePage from "@/features/Login-Auth/ProfilePage.vue";
import LogViewer from "@/features/LogViewer/LogViewer.vue";
import CreateProjectDialog from "@/features/ProjectManagement/CreateProjectDialog.vue";
import TabNavigation from "@/features/TabNavigation.vue";
import ToolboxView from "@/features/Toolbox/ToolboxView.vue";
import { useDialogStore } from "@/state/dialog-store.ts";
import { useProjectStore } from "@/state/project-store.ts";
import { useTabViewStore } from "@/state/tab-store.ts";
import { ref } from "vue";



export default {
  components: {
    CreateProjectDialog,
    LogViewer,
    ProfilePage,
    TabNavigation,
    ToolboxView,
    AuroraAppBar,
    OuterMainGameNav,
  },
  setup() {
    const tabViewStore = useTabViewStore();
    const dialogStore = useDialogStore();
    const projectStore = useProjectStore();
    const items = ref(tabViewStore.tabs);
    const currentItem = ref(tabViewStore.currentItem);
    const length = ref(tabViewStore.tabs.length);
    const globalCommandsDialogSwitch = ref(dialogStore.globalCommandsDialog);
    const settingsDialogSwitch = ref(dialogStore.settingsDialog);
  

    // Watch for changes in the selected project
    const selectedProject = ref(projectStore.selectedProject);
    
    // Create a watcher for the selected project
    const watchSelectedProject = () => {
      try {
        // Update the local ref whenever the store's selected project changes
        selectedProject.value = projectStore.selectedProject;
        
        // Additional actions when project changes can be added here
        if (selectedProject.value) {
          console.log('Project selected:', selectedProject.value.name);
        }
      } catch (error) {
        console.error('Error handling project change:', error);
      }
    };
    
    // Set up the watcher
    projectStore.$subscribe((mutation, state) => {
      console.log('Project store mutation:', mutation);
      console.log('Project store state:', state);
      if (mutation.type.includes('selectProject')) {
        watchSelectedProject();
      }
    });

    // Load user projects
    const loadUserProjects = async () => {
      try {
        const result = await projectStore.loadProjects();
        if (!result.ok) {
          console.error('Failed to load projects:', result.error);
        }
      } catch (error) {
        console.error('Error loading projects:', error);
      }
    };

    // Load projects on component setup
    loadUserProjects();

    window.addEventListener('keydown', (e) => {
      if (e.altKey && e.key === 'g') {
        globalCommandsDialogSwitch.value = true;
      }
    });

    return {
      length,
      tabViewStore,
      projectStore,
      items,
      currentItem,
      showContextMenu: false,
      globalCommandsDialogSwitch,
      settingsDialogSwitch
    }
  },
  data() {
    return {
      drawer: null,
      dialogGameSetup: null,
      drawerBottom: null,
      entries: [],
      icons: ['mdi-facebook', 'mdi-twitter', 'mdi-linkedin', 'mdi-instagram'],
      projectInfoDialog: false,
      selectedProjectInfo: null,
      snackbar: false,
      snackbarText: ''
    }
  },
  mounted() {
    this.tabViewStore.addTab('tab-home', "home", true, 'ProfilePage');
  },
  methods: {
    addTab(item) {
      this.tabViewStore.addTab(item);
    },
    toggleBottomDrawer() {
      console.log('I am being clicked')
      this.drawerBottom = !this.drawerBottom
    },

    navigateToProfile() {
      this.settingsDialogSwitch = true;
    },

    selectProject(project) {
      try {
        console.log('Selecting project:', project);
        this.projectStore.selectProject(project);
        // TODO: Switch the resource view to the currently selected project
        //this.tabViewStore.addTab(`project-${project.id}`, project.name, true, 'ProjectView');
      } catch (error) {
        console.error('Error selecting project:', error); 
      }
    },

    openContextMenu(event, project, menuProps) {
      try {
        // Close all other menus first
        this.projectStore.projects.forEach(p => {
          if (p.id !== project.id && p.menuOpen) {
            p.menuOpen = false;
          }
        });
        
        // Toggle this menu
        project.menuOpen = !project.menuOpen;
        
        // Trigger the menu activator
        if (menuProps && menuProps.onClick) {
          menuProps.onClick(event);
        }
      } catch (error) {
        console.error('Error opening context menu:', error);
      }
    },

    showProjectInfo(project) {
      try {
        this.selectedProjectInfo = project;
        this.projectInfoDialog = true;
      } catch (error) {
        console.error('Error showing project info:', error);
        this.showSnackbar('Failed to show project information');
      }
    },

    async openInFileExplorer(project) {
      try {
        const { open } = await import('@tauri-apps/plugin-opener');
        // Try to open the staging path first, fallback to original directory
        const pathToOpen = project.staging_path || project.original_directory_path;
        
        if (pathToOpen) {
          await open(pathToOpen);
          this.showSnackbar('Opening in file explorer...');
        } else {
          this.showSnackbar('No valid path found for this project');
        }
      } catch (error) {
        console.error('Error opening file explorer:', error);
        this.showSnackbar('Failed to open file explorer');
      }
    },

    copyToJson(project) {
      try {
        const projectJson = JSON.stringify(project, null, 2);
        
        // Use modern clipboard API
        if (navigator.clipboard && window.isSecureContext) {
          navigator.clipboard.writeText(projectJson).then(() => {
            this.showSnackbar('Project JSON copied to clipboard!');
          }).catch((error) => {
            console.error('Failed to copy to clipboard:', error);
            this.showSnackbar('Failed to copy to clipboard');
          });
        } else {
          // Fallback for older browsers or non-secure contexts
          const textArea = document.createElement('textarea');
          textArea.value = projectJson;
          textArea.style.position = 'fixed';
          textArea.style.left = '-999999px';
          document.body.appendChild(textArea);
          textArea.select();
          
          try {
            document.execCommand('copy');
            this.showSnackbar('Project JSON copied to clipboard!');
          } catch (error) {
            console.error('Fallback copy failed:', error);
            this.showSnackbar('Failed to copy to clipboard');
          }
          
          document.body.removeChild(textArea);
        }
      } catch (error) {
        console.error('Error copying to JSON:', error);
        this.showSnackbar('Failed to copy project data');
      }
    },

    showSnackbar(text) {
      this.snackbarText = text;
      this.snackbar = true;
    }
  }
}
</script>

<template>
  <v-card theme="dark">
    <v-layout>
      <!--   TODO: Move this to its own component, replace with router view    -->
      <!--      Inner Navigation Drawer    -->
      <v-navigation-drawer theme="dark" rail permanent>
        <v-list-item nav prepend-avatar="https://randomuser.me/api/portraits/women/75.jpg" @click="navigateToProfile">
        </v-list-item>

        <v-divider></v-divider>

        <v-list density="default" nav>
          <v-list-item prepend-icon="mdi-plus" @click="dialogGameSetup = true" value="plus"></v-list-item>
          <v-divider></v-divider>
          <v-list-item prepend-icon="mdi-gamepad-square-outline" value="dashboard"
            @click="toggleBottomDrawer"></v-list-item>
          <v-list-item prepend-icon="mdi-gamepad-square-outline" value="messages"></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <v-navigation-drawer theme="dark" rail permanent>
        <v-list density="default" nav>
          <v-menu
            v-for="project in projectStore.projects"
            :key="project.id"
            v-model="project.menuOpen"
            location="end"
            transition="slide-x-transition"
            :close-on-content-click="true"
          >
            <template v-slot:activator="{ props: menuProps }">
              <v-list-item
                :prepend-icon="project.icon || 'mdi-view-dashboard'"
                :value="project.id"
                @click="selectProject(project)"
                @contextmenu.prevent="(e) => openContextMenu(e, project, menuProps)"
                :title="project.name"
              >
                <v-avatar v-if="project.image" :image="project.image"></v-avatar>
                <h6>{{ project.name }}</h6>
                <template v-slot:title>{{ project.name }}</template>
              </v-list-item>
            </template>

            <v-card min-width="250">
              <v-list density="compact">
                <v-list-item prepend-icon="mdi-information-outline" @click="showProjectInfo(project)">
                  <v-list-item-title>View Project Information</v-list-item-title>
                </v-list-item>
                
                <v-list-item prepend-icon="mdi-folder-open-outline" @click="openInFileExplorer(project)">
                  <v-list-item-title>Open in File Explorer</v-list-item-title>
                </v-list-item>
                
                <v-list-item prepend-icon="mdi-code-json" @click="copyToJson(project)">
                  <v-list-item-title>Copy to JSON</v-list-item-title>
                </v-list-item>
              </v-list>
            </v-card>
          </v-menu>
        </v-list>
        <!--        <DiscordInnerNavView></DiscordInnerNavView>-->
      </v-navigation-drawer>

      <!--      Outer Navigation Drawer     -->
      <v-navigation-drawer permanent v-model="drawer">
        <v-list style="padding: 0px">
          <OuterMainGameNav></OuterMainGameNav>
        </v-list>
      </v-navigation-drawer>

      <!--      <v-navigation-drawer v-model="drawerBottom" location="bottom" style="height: 45%" temporary>-->
      <!--        <toolbox-view></toolbox-view>-->
      <!--      </v-navigation-drawer>-->
      <v-navigation-drawer v-model="drawerBottom" location="bottom" style="height: 45%" temporary>
        <log-viewer></log-viewer>
      </v-navigation-drawer>

      <!--      Main App Bar     -->
      <AuroraAppBar></AuroraAppBar>


      <!--      Main Content     -->
      <v-main style="min-height: 300px">


        <TabNavigation></TabNavigation>


      </v-main>
    </v-layout>
  </v-card>

  <div class="text-center">


    <!-- Dialog for creating a new project -->
    <!-- Uses dark theme, takes up 75% of screen width, and appears above other content -->
    <v-overlay v-model="dialogGameSetup" :scrim="true" :teleport="'body'" class=" align-center justify-center">
      <v-container
        style="overflow: hidden; margin: 15px 15px 15px 15px; max-width: 100%; min-width: 90vw; min-height: 90vh;">
        <CreateProjectDialog :showDialog="dialogGameSetup" @update:showDialog="dialogGameSetup = false">
        </CreateProjectDialog>
      </v-container>
    </v-overlay>


    <!--- Global Commands Dialog --->
    <v-overlay v-model="globalCommandsDialogSwitch" class="align-center justify-center">
      <v-card class="mx-auto dark-glass" width="75%">
        <v-toolbar flat height="20px" color="teal-darken-4" image="https://picsum.photos/1920/1080?random">
          <template v-slot:image>
            <v-img gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"></v-img>
          </template>
          <v-btn icon="mdi-account"></v-btn>

          <v-toolbar-title> Create a project from Game Directory</v-toolbar-title>

          <v-spacer></v-spacer>

          <v-btn icon>
            <v-fade-transition leave-absolute>
              <v-icon v-if="isEditing" size="x-small">mdi-close</v-icon>
            </v-fade-transition>
          </v-btn>
        </v-toolbar>

        <v-card-text>
          <v-tabs v-model="activeTab" bg-color="transparent" grow>
            <v-tab value="actions">
              <v-icon start>mdi-play-circle</v-icon>
              Actions
            </v-tab>
            <v-tab value="settings">
              <v-icon start>mdi-cog</v-icon>
              Settings
            </v-tab>
            <v-tab value="resources">
              <v-icon start>mdi-folder</v-icon>
              Resources
            </v-tab>
            <v-tab value="tools">
              <v-icon start>mdi-tools</v-icon>
              Tools
            </v-tab>
          </v-tabs>

          <v-window v-model="activeTab">
            <v-window-item value="actions">
              <v-card flat>
                <v-card-text>
                  <v-list>
                    <v-list-item prepend-icon="mdi-folder-open" title="Open Game Directory"></v-list-item>
                    <v-list-item prepend-icon="mdi-refresh" title="Scan Resources"></v-list-item>
                    <v-list-item prepend-icon="mdi-export" title="Export Project"></v-list-item>
                  </v-list>
                </v-card-text>
              </v-card>
            </v-window-item>

            <v-window-item value="settings">
              <v-card flat>
                <v-card-text>
                  <v-list>
                    <v-list-item prepend-icon="mdi-folder-cog" title="Project Settings"></v-list-item>
                    <v-list-item prepend-icon="mdi-application-cog" title="Application Settings"></v-list-item>
                    <v-list-item prepend-icon="mdi-backup-restore" title="Backup Settings"></v-list-item>
                  </v-list>
                </v-card-text>
              </v-card>
            </v-window-item>

            <v-window-item value="resources">
              <v-card flat>
                <v-card-text>
                  <v-list>
                    <v-list-item prepend-icon="mdi-file-key" title="Chitin Resources"></v-list-item>
                    <v-list-item prepend-icon="mdi-archive" title="ERF Resources"></v-list-item>
                    <v-list-item prepend-icon="mdi-texture-box" title="Texture Resources"></v-list-item>
                  </v-list>
                </v-card-text>
              </v-card>
            </v-window-item>

            <v-window-item value="tools">
              <v-card flat>
                <v-card-text>
                  <v-list>
                    <v-list-item prepend-icon="mdi-wrench" title="Resource Editor"></v-list-item>
                    <v-list-item prepend-icon="mdi-magnify" title="Resource Explorer"></v-list-item>
                    <v-list-item prepend-icon="mdi-database" title="Data Viewer"></v-list-item>
                  </v-list>
                </v-card-text>
              </v-card>
            </v-window-item>
          </v-window>
        </v-card-text>

        <v-divider></v-divider>

        <v-snackbar v-model="hasSaved" :timeout="2000" attach position="absolute" location="bottom left">
          Your profile has been updated
        </v-snackbar>


        <v-card-actions>
          <v-btn color="primary" block @click="globalCommandsDialogSwitch = false">Finished</v-btn>
        </v-card-actions>
        <v-card-actions>
          <v-btn color="primary" block @click="globalCommandsDialogSwitch = false">Close Dialog</v-btn>
        </v-card-actions>
      </v-card>
    </v-overlay>


    <!--- Settings Dialog --->
    <v-overlay v-model="settingsDialogSwitch" class="align-center justify-center">
      <v-card class="mx-auto dark-glass" width="75%">
        <v-toolbar flat height="20px" color="teal-darken-4">
          <template v-slot:image>
            <v-img gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"></v-img>
          </template>
          <v-btn icon="mdi-account"></v-btn>

          <v-toolbar-title> Create a project from Game Directory</v-toolbar-title>

          <v-spacer></v-spacer>

          <v-btn icon>
            <v-fade-transition leave-absolute>
              <v-icon v-if="isEditing" size="x-small">mdi-close</v-icon>
            </v-fade-transition>
          </v-btn>
        </v-toolbar>

        <v-card-text>
          <ProfilePage></ProfilePage>
        </v-card-text>

        <v-divider></v-divider>

        <v-snackbar v-model="hasSaved" :timeout="2000" attach position="absolute" location="bottom left">
          Your profile has been updated
        </v-snackbar>


        <v-card-actions>
          <v-btn color="primary" block @click="settingsDialogSwitch = false">Finished</v-btn>
        </v-card-actions>
        <v-card-actions>
          <v-btn color="primary" block @click="settingsDialogSwitch = false">Close Dialog</v-btn>
        </v-card-actions>
      </v-card>
    </v-overlay>

    <!--- Project Information Dialog --->
    <v-dialog v-model="projectInfoDialog" max-width="600">
      <v-card class="dark-glass">
        <v-card-title class="d-flex align-center">
          <v-icon class="mr-2">mdi-information-outline</v-icon>
          Project Information
          <v-spacer></v-spacer>
          <v-btn icon="mdi-close" variant="text" @click="projectInfoDialog = false"></v-btn>
        </v-card-title>
        
        <v-divider></v-divider>
        
        <v-card-text v-if="selectedProjectInfo">
          <v-list density="comfortable">
            <v-list-item>
              <v-list-item-title class="text-caption text-grey">Project Name</v-list-item-title>
              <v-list-item-subtitle class="text-body-1">{{ selectedProjectInfo.name }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item v-if="selectedProjectInfo.description">
              <v-list-item-title class="text-caption text-grey">Description</v-list-item-title>
              <v-list-item-subtitle class="text-body-1">{{ selectedProjectInfo.description }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item>
              <v-list-item-title class="text-caption text-grey">Project ID</v-list-item-title>
              <v-list-item-subtitle class="text-body-2 font-mono">{{ selectedProjectInfo.id }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item>
              <v-list-item-title class="text-caption text-grey">User ID</v-list-item-title>
              <v-list-item-subtitle class="text-body-2 font-mono">{{ selectedProjectInfo.user_id }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item v-if="selectedProjectInfo.staging_path">
              <v-list-item-title class="text-caption text-grey">Staging Path</v-list-item-title>
              <v-list-item-subtitle class="text-body-2">{{ selectedProjectInfo.staging_path }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item v-if="selectedProjectInfo.original_directory_path">
              <v-list-item-title class="text-caption text-grey">Original Directory</v-list-item-title>
              <v-list-item-subtitle class="text-body-2">{{ selectedProjectInfo.original_directory_path }}</v-list-item-subtitle>
            </v-list-item>
            
            <v-list-item v-if="selectedProjectInfo.created_at">
              <v-list-item-title class="text-caption text-grey">Created At</v-list-item-title>
              <v-list-item-subtitle class="text-body-2">{{ selectedProjectInfo.created_at }}</v-list-item-subtitle>
            </v-list-item>
          </v-list>
        </v-card-text>
        
        <v-divider></v-divider>
        
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="primary" @click="projectInfoDialog = false">Close</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>

    <!--- Snackbar for notifications --->
    <v-snackbar v-model="snackbar" :timeout="3000" location="bottom right">
      {{ snackbarText }}
      <template v-slot:actions>
        <v-btn color="primary" variant="text" @click="snackbar = false">Close</v-btn>
      </template>
    </v-snackbar>
  </div>
</template>

<style lang="scss">
.v-dialog {
  background: rgba(0, 0, 0, 0);
}


.dark-glass {
  background: rgba(0, 0, 0, 0.8);
  backdrop-filter: blur(28px) !important;
}

.font-mono {
  font-family: 'Courier New', Courier, monospace;
}
</style>