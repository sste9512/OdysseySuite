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




  </v-tabs>

  <v-tabs-window v-model="current" height="100%" class="pa-0" style="margin: 0px 0px 0px 0px !important;">
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
/* Deep selector to override Vuetify tab styles */
::v-deep(.v-tab) {
  background-color: #181818;
  /* Custom background for tabs */
  color: #4b367c;
  /* Text color for tabs */
  font-weight: lighter;
  /* Light text for tabs */
  font-size: 10px;
  transition: all 0.1s ease;
  /* Smooth transition for hover effects */
  height: 35px !important;
  min-width: 50px !important;
  margin-bottom: 0 !important;
  padding-bottom: 0 !important;
  border-bottom: none !important;
}

::v-deep(.v-slide-group__content) {
  background-color: #181818;
  padding: 0px 0px 0px 0px !important;
}


::v-deep(.v-tab:hover) {
  background-color: #1e1e1e;
  /* Slightly lighter background on hover */
  color: white;
  /* Text color on hover */
}

::v-deep(.v-tab--selected) {
  background-color: #353535;
  /* Background color for selected tabs */
  color: #ffffff;
  /* Text color for selected tabs */
}

::v-deep(.v-tab__icon) {
  color: #4b367c;
  /* Icon color for tabs */
  margin-right: 8px;
  /* Spacing between icon and text */
}

::v-deep(.v-tabs) {
  background-color: #121212;
  /* Background for the tabs container */
  border-bottom: 1px solid #2e2e2e;
  /* Optional border for separation */
  padding: 2px 2px 2px 2px !important;
  /* Padding around tabs */
}
</style>