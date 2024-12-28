<template>
  <v-app-bar color="teal-darken-4" image="https://picsum.photos/1920/1080?random" @click.right="openContextMenu"
    density="compact" style="border-bottom: .8px solid white;">

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

    <CustomContextMenu caller="appnavbar"></CustomContextMenu>

  </ContextMenu>


</template>

<script>


import ContextMenu from "../ContextMenus/ContextMenu.vue";

import router from "../../navigation/base-router.ts";
import * as drawerService from "effect/HashSet";
import { useTabViewStore } from "@/state/tab-state.ts";
import { ref } from "vue";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";

export default {
  name: "AuroraAppBar",
  components: { CustomContextMenu, ContextMenu },
  setup() {


  },
  methods: {

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
// Override Vuetify app bar styles
:deep(.v-app-bar) {
  border: none;
  box-shadow: none;
  background: transparent;
  height: 10px !important;
}

:deep(.v-toolbar) {
  box-shadow: none !important;
}

:deep(.v-app-bar-title) {
  font-size: 1.1rem;
  font-weight: 500;
}

:deep(.v-app-bar-nav-icon) {
  color: whitesmoke;

  &:hover {
    background-color: rgba(255, 255, 255, 0.1) !important;
  }
}

:deep(.v-btn) {
  text-transform: none;
  letter-spacing: normal;
}

:deep(.v-toolbar__content) {
  padding: 0 10px;
  min-height: var(--v-app-bar-height) !important;
}

:deep(.v-toolbar__prepend),
:deep(.v-toolbar__append) {
  margin-inline: 0;
}

.bottom-border-line {
  border-bottom: white;
  border-bottom-width: 10px;
}
</style>
