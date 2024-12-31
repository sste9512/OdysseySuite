<template>
  <v-tabs v-model="current" fixed-tabs>

    <!-- Individual tab items -->
    <v-tab v-for="item in items" :key="item" :value="item.id" :ripple="false" @click.right="openContextMenu"
      @click="onTabSelected(item)" @mouseenter="onTabHover(item)" @mouseleave="onTabLeave(item)"
      @dragstart="onTabDragStart(item, $event)" @dragend="onTabDragEnd(item, $event)"
      @dragover="onTabDragOver(item, $event)" @drop="onTabDrop(item, $event)" draggable="true" direction="vertical">


      <!-- Visual divider between tabs -->
      <v-divider color="grey-lighten-1" class="tab-divider"></v-divider>

      <!-- Tab label text -->
      <span class="tab-text">{{ item.title }}</span><!-- Close button for each tab -->

      <v-btn v-if="item.pinned" class="ms-2" size="small" prepend-icon="mdi-pin" variant="text"></v-btn>
      <v-btn class="ms-auto" size="small" prepend-icon="mdi-close" variant="text" onclick="closeTabClick(e)"></v-btn>


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

  <v-tabs-window v-model="current" height="100%">
    <v-tabs-window-item :value="item.id" v-for="item in items" :key="item">

      <component :is="item.innerComponent" />

    </v-tabs-window-item>
  </v-tabs-window>



  <ContextMenu :display="showContextMenu" ref="menu">
    <CustomContextMenu caller="tab-navigation"></CustomContextMenu>
  </ContextMenu>
</template>


<script>

import { ref } from "vue";
import { useTabViewStore } from "@/state/tab-store.ts";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";
import ChitinKeyView from "@/features/ChitinResourceView/ChitinKeyView.vue";

export default {
  name: 'TabNavigation',
  components: { ChitinKeyView, CustomContextMenu, ContextMenu },
  setup() {
    const tabViewStore = useTabViewStore();
    const items = ref(tabViewStore.tabs);
    const current = ref(null);
    const length = ref(tabViewStore.tabs.length);
    return {
      tabViewStore,
      length,
      items,
      current,
    }
  },
  methods: {
    /**
     * @param {UnwrapRefSimple<UnwrapRefSimple<TabViewState>>|string} e
     */
    onTabSelected(e) {

    },
    closeTabClick(e) {
      console.log("I was clicked")
      console.log(e)
    },
    openContextMenu(e) {
      console.log("This worked partially")
      e.preventDefault()
      this.showContextMenu = true;
      this.$refs.menu.open(e);
    },

    onTabClick(item) {
      console.log("Tab clicked:", item);
    },
    onTabHover(item) {
      console.log("Tab hovered:", item);
    },
    onTabLeave(item) {
      console.log("Tab left:", item);
    },
    onTabDragStart(item, event) {
      console.log("Drag start on tab:", item);
      event.dataTransfer.setData("text/plain", JSON.stringify(item));
    },
    onTabDragEnd(item, event) {
      console.log("Drag end on tab:", item);
      event.preventDefault();
    },
    onTabDragOver(item, event) {
      console.log("Drag over on tab:", item);
      event.preventDefault(); // Necessary for allowing drop
    },
    onTabDrop(item, event) {
      event.preventDefault();
      const droppedData = event.dataTransfer.getData("text/plain");
      const droppedItem = JSON.parse(droppedData);
      console.log("Item dropped on tab:", item, "Dropped item:", droppedItem);
    }
  },
  data() {
    return {
      showContextMenu: false
    }
  }
}
</script>

<style scoped lang="scss">
@import "@/assets/css/global.scss";
</style>