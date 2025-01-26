<template>
  <a-tabs v-model:activeKey="current" type="editable-card" class="ant-custom-tabs">
    <a-tab-pane v-for="item in tabViewStore.tabs" :key="item.value" :tab="item.text" :closable="true"
      @contextmenu.prevent="openContextMenu" @mouseenter="onTabHover(item.text)" @mouseleave="onTabLeave(item)"
      @dragstart="onTabDragStart(item, $event)" @dragend="onTabDragEnd(item, $event)"
      @dragover="onTabDragOver(item, $event)" @drop="onTabDrop(item, $event)" draggable="true">

      <template #tab>
        <span class="tab-text">{{ item.text }}</span>
        <a-button type="text" size="small" class="ms-2">
          <template #icon>
            <PushpinOutlined />
          </template>
        </a-button>
      </template>
 

   
      <ChitinView v-if="item.text === 'chitin'" :path="item.value" />
      <ErfResourceView v-if="item.text === 'erf'" :filePath="item.value" />
      <BiffResourceView v-if="item.text === 'biff'" :filePath="item.value" />
      <AdminDashboard v-if="item.text === 'admin'" />



    </a-tab-pane>

  </a-tabs>

</template>

<script lang="ts">
import { ref, defineComponent, watch } from "vue";
import { useTabViewStore } from "@/state/tab-store.ts";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";
import ChitinView from "@/features/ChitinResourceView/ChitinView.vue";
import ErfResourceView from "@/features/ErfResourceView/ErfResourceView.vue";
import BiffResourceView from "@/features/BiffResourceView/BiffResourceView.vue";


import DirectoryViewer from "@/features/DirectoryViewer/DirectoryViewer.vue";
import AdminDashboard from "./AdminDashboard.vue";

export default defineComponent({
  name: 'TabNavigation',
  components: {
    ChitinView,
    CustomContextMenu,
    ContextMenu,
    DirectoryViewer,
    ErfResourceView,
    AdminDashboard,
    BiffResourceView,
  },
  setup() {
    const tabViewStore = useTabViewStore();
    const items = ref(tabViewStore.tabs);
    const current = ref(tabViewStore.currentTab);
    const length = ref(tabViewStore.tabs.length);

    watch(() => tabViewStore.tabs, (newTabs) => {
      console.log('Tabs changed:', newTabs);
      items.value = newTabs;
      current.value = newTabs[newTabs.length - 1]?.value ?? null;
    }, { deep: true });


    return {
      tabViewStore,
      length,
      items,
      current,
    }
  },
  mounted() {
    console.log("TabNavigation mounted");
  },
  methods: {
    /**
     * @param {UnwrapRefSimple<UnwrapRefSimple<TabViewState>>|string} e
     */
    onTabSelected(e) {
      console.log("Tab selected:", e);
      this.$forceUpdate();
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

    onTabClick(item: { id: string }) {
      console.log("Tab clicked:", item);
      const foundTab = this.items.find(tab => tab.id === item.id);
      this.current = foundTab?.id ?? this.current; // Keep existing value if not found
    },
    onTabHover(item: { id: string }) {
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
})
</script>

<style scoped lang="scss">
@import "@/assets/css/ant-overrides/ant-tabs.scss";
</style>
