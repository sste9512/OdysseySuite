<template>
  <v-tabs v-model="currentItem" fixed-tabs >

    <!-- Individual tab items -->
    <v-tab v-for="item in items" :key="item"  :value="'tab-' + item"
           :ripple="false" @click.right="openContextMenu" >

      <!-- Visual divider between tabs -->
      <v-divider color="grey-lighten-1" class="tab-divider"></v-divider>

      <!-- Tab label text -->
      <span class="tab-text">{{ item.id }}</span><!-- Close button for each tab -->

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
  <ContextMenu :display="showContextMenu" ref="menu">
    <CustomContextMenu caller="tab-navigation"></CustomContextMenu>
  </ContextMenu>
</template>

<script>

import {ref} from "vue";
import {useTabViewStore} from "@/state/tab-state.ts";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";

export default {
  name: 'TabNavigation',
  components: {CustomContextMenu, ContextMenu},
  setup() {
    const tabViewStore = useTabViewStore();
    const items = ref(tabViewStore.tabs);
    const currentItem = ref(tabViewStore.currentItem);
    const length = ref(tabViewStore.tabs.length);
    return {
      length,
      items,
      currentItem,
      addItem: tabViewStore.addTab
    }
  },
  methods: {
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