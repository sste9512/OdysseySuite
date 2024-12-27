<template>
  <v-app-bar color="teal-darken-4" image="https://picsum.photos/1920/1080?random" @click.right="openContextMenu"
    density="compact" style="border-bottom: .8px solid white; height: calc(var(--v-app-bar-height) - 12px);">

    <template v-slot:image>
      <v-img gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"></v-img>
    </template>

    <template v-slot:prepend>
      <v-app-bar-nav-icon @click.stop="toggle"></v-app-bar-nav-icon>
    </template>
    <v-text-field v-model="searchQuery" prepend-inner-icon="mdi-magnify" label="Search" single-line hide-details
      density="compact" class="mx-4" style="max-width: 300px; height: calc(100% - 10px)"
      bg-color="rgba(255, 255, 255, 0.1)" variant="solo"></v-text-field>



    <v-spacer></v-spacer>

    <!-- Tabs component that displays open tabs in a JetBrains-style layout -->
    <v-tabs v-model="currentItem" fixed-tabs class="jetbrains-tabs">

      <!-- Individual tab items -->
      <v-tab v-for="item in items" :key="item" class="text-caption jetbrains-tab" :value="'tab-' + item"
        :ripple="false">

        <!-- Visual divider between tabs -->
        <v-divider color="grey-lighten-1" class="tab-divider"></v-divider>
        <!-- Tab label text -->
        <span class="tab-text">{{ item }}</span>
        <!-- Close button for each tab -->
        <v-btn class="close-tab-btn" icon size="small" prepend-icon="mdi-close">
        </v-btn>

      </v-tab>

      <!-- Overflow menu for additional tabs -->
      <v-menu v-if="length">
        <template v-slot:activator="{ props }">
          <!-- Button to show more tabs -->
          <v-btn variant="plain" rounded="10" class="align-self-center me-4 more-btn" height="100%" v-bind="props">
            more
            <v-icon end>
              mdi-menu-down
            </v-icon>
          </v-btn>
        </template>

        <!-- Dropdown list of additional tabs -->
        <v-list class="bg-grey-lighten-3">
          <v-list-item v-for="item in items" :key="item" class="more-list-item" @click="addItem(item)">
            {{ item }}
          </v-list-item>
        </v-list>
      </v-menu>
    </v-tabs>

    <v-spacer></v-spacer>


    <v-btn icon class="target-light target" @click="navigateHome">
      <v-icon>mdi-home</v-icon>
    </v-btn>
    <v-btn icon>
      <v-icon>mdi-magnify</v-icon>
    </v-btn>

    <v-btn icon>
      <v-icon>mdi-dots-vertical</v-icon>
    </v-btn>

  </v-app-bar>
  <ContextMenu :display="showContextMenu" ref="menu">
    <v-sheet elevation="12" max-width="600" rounded="lg" width="100%" class="pa-4 text-center mx-auto glass">
      <v-icon class="mb-5" color="success" icon="mdi-check-circle" size="112"></v-icon>

      <h2 class="text-h5 mb-6">You reconciled this account</h2>

      <p class="mb-4 text-medium-emphasis text-body-2">
        To see a report on this reconciliation, click <a href="#" class="text-decoration-none text-info">View
          reconciliation report.</a>

        <br>

        Otherwise, you're done!
      </p>

      <v-divider class="mb-4"></v-divider>

      <div class="text-end">
        <v-btn class="text-none" color="success" rounded variant="flat" width="90">
          Done
        </v-btn>
      </div>
    </v-sheet>

  </ContextMenu>


</template>

<script>


import ContextMenu from "../ContextMenus/ContextMenu.vue";

import router from "../../navigation/base-router.ts";
import * as drawerService from "effect/HashSet";
import { useTabViewStore } from "@/state/tab-state.ts";
import { ref } from "vue";

export default {
  name: "AuroraAppBar",
  components: { ContextMenu },
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
  methods: {
    // Bind the tabViewStore to the tab list in the app bar.
    addTab(item) {
      this.tabViewStore.addTab(item);
    },
    toggle() {
      drawerService.toggle();
    },
    openContextMenu(e) {
      console.log("This worked partially")
      e.preventDefault()
      this.showContextMenu = true;
      this.$refs.menu.open(e);
    },
    addItem(item) {
      this.tabViewStore.addTab(item);
      const removed = this.items.splice(0, 1)
      this.items.push(
        ...this.more.splice(this.more.indexOf(item), 1),
      )
      this.more.push(...removed)
      this.$nextTick(() => { this.currentItem = 'tab-' + item })
    },
    logSomething() {
      console.log("I was clicked")
    },
    navigateHome() {
      router.push("/");
    }
  },
  data() {
    return {
      showContextMenu: false,
      items: [
        {
          id: 'tab-home',
          label: 'Home',
          icon: 'home',
          closable: false,
          to: '/'
        }
      ],
      locations:
        [
          'top',
          'bottom',
          'start',
          'end',
          'center',
        ],
      location:
        'end',
    }
  },
}
</script>

<style lang="scss" scoped>
.bottom-border-line {
  border-bottom: white;
  border-bottom-width: 10px;
}
</style>
