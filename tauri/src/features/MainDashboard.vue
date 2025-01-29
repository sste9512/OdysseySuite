<script>


import AuroraAppBar from "@/components/AppBarViews/AuroraAppBar.vue";
import ToolboxView from "@/features/Toolbox/ToolboxView.vue";
import OuterMainGameNav from "@/components/NavigationDrawerViews/GameResourcesNavView.vue";
import { useTabViewStore } from "@/state/tab-store.ts";
import { ref } from "vue";
import TabNavigation from "@/features/TabNavigation.vue";
import { useDialogStore } from "@/state/dialog-store.ts";
import ProfilePage from "@/features/Login-Auth/ProfilePage.vue";
import LogViewer from "@/features/LogViewer/LogViewer.vue";
import CreateProjectDialog from "@/features/ProjectManagement/CreateProjectDialog.vue";



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
    const items = ref(tabViewStore.tabs);
    const currentItem = ref(tabViewStore.currentItem);
    const length = ref(tabViewStore.tabs.length);
    const globalCommandsDialogSwitch = ref(dialogStore.globalCommandsDialog);
    const settingsDialogSwitch = ref(dialogStore.settingsDialog);


    window.addEventListener('keydown', (e) => {
      if (e.altKey && e.key === 'g') {
        globalCommandsDialogSwitch.value = true;
      }
    });
    return {
      length,
      tabViewStore,
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
      icons: ['mdi-facebook', 'mdi-twitter', 'mdi-linkedin', 'mdi-instagram']
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
          <v-list-item prepend-icon="mdi-view-dashboard" value="dashboard"></v-list-item>
          <v-list-item prepend-icon="mdi-view-dashboard" value="messages">
            <v-avatar image="./assets/game_icons/kotor-1-icon.png"></v-avatar>
          </v-list-item>
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
      <CreateProjectDialog :showDialog="dialogGameSetup" @update:showDialog="dialogGameSetup = false"> </CreateProjectDialog>
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
</style>