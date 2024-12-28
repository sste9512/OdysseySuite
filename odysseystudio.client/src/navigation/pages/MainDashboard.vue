<script>


import AuroraAppBar from "@/components/AppBarViews/AuroraAppBar.vue";
import ToolboxView from "@/features/Toolbox/ToolboxView.vue";
import OuterMainGameNav from "@/components/NavigationDrawerViews/OuterMainGameNav.vue";
import router from "@/navigation/base-router.ts";
import * as drawerService from "effect/HashSet";
import {useTabViewStore} from "@/state/tab-state.ts";
import {ref} from "vue";
import TabNavigation from "@/navigation/pages/TabNavigation.vue";
import Tabs from 'primevue/tabs';
import TabList from 'primevue/tablist';
import Tab from 'primevue/tab';
import TabPanels from 'primevue/tabpanels';
import TabPanel from 'primevue/tabpanel';


export default {
  components: {
    TabNavigation,
    ToolboxView,
    AuroraAppBar,
    OuterMainGameNav
  },
  setup() {
    const tabViewStore = useTabViewStore();
    const items = ref(tabViewStore.tabs);
    const currentItem = ref(tabViewStore.currentItem);
    const length = ref(tabViewStore.tabs.length);
    return {
      length,
      tabViewStore,
      items,
      currentItem,
      showContextMenu: false
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
       this.tabViewStore.addTab('tab-home');
       this.tabViewStore.setCurrentTab('tab-home');

  },
  methods: {
    // Bind the tabViewStore to the tab list in the app bar.
    addTab(item) {
      this.tabViewStore.addTab(item);
    },
    toggleDrawer() {
      console.log('I am being clicked')
      drawerService.toggle()
    },
    toggleBottomDrawer() {
      console.log('I am being clicked')
      //drawerService.toggle();
      this.drawerBottom = !this.drawerBottom
    },

    navigateToProfile() {
      router.push({path: '/profile'})
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

      <v-navigation-drawer v-model="drawerBottom" location="bottom" style="height: 45%" temporary>
        <toolbox-view></toolbox-view>
      </v-navigation-drawer>

      <!--      Main App Bar     -->
      <AuroraAppBar></AuroraAppBar>


      <!--      Main Content     -->
      <v-main style="min-height: 300px">


        <TabNavigation></TabNavigation>


        <!-- ROUTER -->
        <router-view/>
      </v-main>
    </v-layout>
  </v-card>

  <div class="text-center">
    <v-dialog theme="dark" v-model="dialogGameSetup" min-width="75%" width="auto" style="z-index: 9999999">
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
          <v-text-field color="white" label="Name" variant="solo"></v-text-field>

          <v-autocomplete :disabled="!isEditing" :items="states" :custom-filter="customFilter" color="white"
                          item-title="name" item-value="abbr" label="State" variant="solo"></v-autocomplete>
        </v-card-text>

        <v-divider></v-divider>

        <v-snackbar v-model="hasSaved" :timeout="2000" attach position="absolute" location="bottom left">
          Your profile has been updated
        </v-snackbar>


        <v-card-actions>
          <v-btn color="primary" block @click="dialogGameSetup = false">Finished</v-btn>
        </v-card-actions>
        <v-card-actions>
          <v-btn color="primary" block @click="dialogGameSetup = false">Close Dialog</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </div>
</template>

<style lang="scss">
@import "@/assets/css/global.scss";
@import "@/assets/css/settings.scss";



.v-dialog {
  background: rgba(0, 0, 0, 0);
}


//.v-main {
//  padding: 0 !important;
//  display: block;
//  align-items: center;
//  justify-content: end;
//  margin-left: 30%;
//}

.dark-glass {
  background: rgba(0, 0, 0, 0.8);
  backdrop-filter: blur(28px) !important;
}


</style>