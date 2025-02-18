<template>
 
  <v-container fluid class="container">
    <v-toolbar density="compact" class="toolbar">
      <v-menu>
        <template v-slot:activator="{ props }">
          <v-btn icon v-bind="props" class="menu-button">
            <v-icon>mdi-menu</v-icon>
          </v-btn>
        </template>

        <v-list class="menu-list">
          <v-list-item @click="openFile" class="menu-item">
            <v-list-item-title>
              <v-icon start>mdi-file-outline</v-icon>
              Open
            </v-list-item-title>
            <v-list-item-subtitle class="shortcut">Ctrl+O</v-list-item-subtitle>
          </v-list-item>

          <v-divider></v-divider>

          <v-list-item class="menu-item">
            <v-list-item-title>
              <v-icon start>mdi-help</v-icon>
              Help
            </v-list-item-title>
            <v-list-item-subtitle class="shortcut">F1</v-list-item-subtitle>
          </v-list-item>
        </v-list>
      </v-menu>

      <v-divider vertical class="mx-2"></v-divider>





    </v-toolbar>

    <v-tabs v-model="activeTab" background-color="grey-darken-4" align-tabs="start" class="editor-tabs">
      <v-tab v-for="tpcData in tpcs" :key="tpcData.filename" :value="tpcData" class="editor-tab"
        :class="{ 'active-tab': activeTab === tpcData }">
        <v-icon start size="small" color="amber">mdi-file-image</v-icon>
        {{ tpcData.filename }}

        <v-btn size="x-small" icon variant="text" density="compact" class="close-button ml-2"
          @click.stop="closeTab(tpcData)">
          <v-icon size="small">mdi-close</v-icon>
        </v-btn>
      </v-tab>

      <v-btn icon size="small" variant="text" class="new-tab-button ml-2" @click="addNewTab" title="New Tab (Ctrl+T)">
        <v-icon>mdi-plus</v-icon>
      </v-btn>
    </v-tabs>

    <v-window v-model="activeTab" class="editor-content">
      <v-window-item v-for="tpcData in tpcs" :key="tpcData.filename" :value="tpcData">
        <v-row no-gutters>
          <v-col cols="8" class="preview-panel">
            <v-card flat class="pa-4 preview-card">
              <TgaRenderer v-if="tpcData" :src="currentImage" :tpc="tpcData" :bytes="tpcData.file"></TgaRenderer>

              <v-sheet v-else height="400" color="grey-darken-3" class="empty-state">
                <span class="text-h6">No TPC image loaded</span>
              </v-sheet>
            </v-card>
          </v-col>

          <v-divider vertical></v-divider>

          <v-col cols="4" class="properties-panel">
            <v-card flat class="pa-4 properties-card">
              <v-banner class="text-h6 mb-4 properties-header" color="pink-darken-1" icon="mdi-account-box" lines="two">
                <template v-slot:prepend>
                  <v-avatar></v-avatar>
                </template>

                <v-banner-text>
                  Header Properties
                </v-banner-text>

                <v-banner-actions>
                  <v-btn>Action Button</v-btn>
                </v-banner-actions>
              </v-banner>
           

              <v-table density="compact" class="properties-table">
                <tbody>
                  <tr v-for="(value, key) in tpcData.header" :key="key">
                    <td class="property-name">{{ key }}</td>
                    <td class="property-value">
                      <v-chip size="small" :color="getPropertyColor(key)">{{ value }}</v-chip>
                    </td>
                    <td class="property-info">
                      <v-btn icon="mdi-information-outline" variant="text" density="compact" size="x-small"></v-btn>
                    </td>
                  </tr>
                </tbody>
              </v-table>

              <v-divider class="my-4"></v-divider>

              <v-btn-group block>
                <v-btn color="primary" prepend-icon="mdi-export" @click="exportTpc">
                  Export
                </v-btn>
                <v-btn color="primary" icon>
                  <v-icon>mdi-dots-vertical</v-icon>
                </v-btn>
              </v-btn-group>
            </v-card>
          </v-col>
        </v-row>
      </v-window-item>
    </v-window>
  </v-container>

 

  <v-dialog v-model="showDirectoryViewer" max-width="800px">
    <DirectoryViewer 
      :isOpen="showDirectoryViewer"
      :canSelectFile="true"
      @update:isOpen="showDirectoryViewer = $event"
      @update:selected-directory="selectedFile = $event" />
  </v-dialog>

  <div class="tpc-viewer">
    <div class="controls">
      <v-btn @click="exportAsDDS">Export as DDS</v-btn>
    </div>
    
    <DDSRenderer 
      v-if="showDDSView" 
      :tpc="currentTpc" 
      :onAppeared="showDDSView" 
      @update:showTpcOverlay="showDDSView = $event"
      class="dds-renderer" 
    />
    <TPCRenderer 
      v-if="showDDSView" 
      :tpcData="currentBytes" 
      class="tpc-renderer" 
    />
  </div>
</template>

<script setup lang="ts">
import { onMounted, ref, watch } from 'vue';
import { TPC } from '@/components/Aurora-Rendering/types/TPC';
import DirectoryViewer from '@/features/DirectoryViewer/DirectoryViewer.vue';
import { ImageApi } from '@/data/image-api';
import * as THREE from 'three';
import TextureRenderer from './TextureRenderer.vue';
import TgaRenderer from './TgaRenderer.vue';
import { AuroraService } from '@/data/aurora-service';
import DDSRenderer from './DDSRenderer.vue';
import TPCRenderer from './TPCRenderer.vue';

const currentImage = ref(null);
const tpcData = ref(null);
const isLoading = ref(false);
const activeTab = ref<TPC | null>(null);
const tpcs = ref<TPC[]>([]);
const showDirectoryViewer = ref(false);
const selectedFile = ref<string | null>(null);
const showFormatInfo = ref(false);
const showDDSView = ref(false);
const currentTpc = ref<TPC>();
const currentBytes = ref<Uint8Array>();

defineProps({
  isOpen: {
    type: Boolean,
    required: true
  }
});

const openFile = async () => {
  showDirectoryViewer.value = true;
}

const addNewTab = () => {
  showDirectoryViewer.value = true;
}

const closeTab = (tpcData: TPC) => {
  tpcs.value = tpcs.value.filter((tpc: TPC) => tpc !== tpcData);
}

const exportTpc = () => {
  console.log('Exporting TPC');
}

const getPropertyColor = (key: string) => {
  return 'primary';
}

watch(selectedFile, async (newVal) => {
  console.log('Selected file:', newVal);
  const imageApi = new ImageApi();
  if (newVal) {
    const tpc = await imageApi.readTPCFromDetachedFile(newVal);
    const bytes = await imageApi.getBytesFromFile(newVal);
    if (bytes.ok) {
      currentBytes.value = bytes.value;
    }
    if (tpc.ok) {
      console.log('TPC data:', tpc.value);
      tpcs.value.push(tpc.value);
      showDDSView.value = true;
    } else {
      console.error('Error reading TPC file:', tpc.error);
    }
  }
});

onMounted(async () => {

});

async function openTpcFile() {

}

const exportAsDDS = () => {
    if (tpcs.value.length > 0) {
        currentTpc.value = tpcs.value[0];
        showDDSView.value = true;
    }
};
</script>

<style scoped>
.v-tabs {
  .v-tab {
    min-height: 20px !important;
    height: 35px !important;
    font-size: 11px !important;
    font-weight: 200 !important;


    .v-icon {
      font-size: 12px !important;
      font-weight: 300 !important;
    }

  }

  .v-tab--selected {
    background: var(--v-secondary-base) !important;
  }

  .v-tab:hover {
    background: rgba(255, 255, 255, 0.05);
  }

  .v-tab:active {
    background: rgba(255, 255, 255, 0.1);
  }

}

.v-window {
  .v-window-item {
    min-height: 400px !important;
    padding: 0px !important;
  }
}

.h3 {
  font-size: 12px;
  font-weight: 200;
}


.v-card {

  border: 1px solid rgba(255, 255, 255, 0.1);

  border-radius: 8px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);

  .v-card-text {
    color: #ffffff;
    font-size: 12px;
    font-weight: 100;
  }
}


.v-menu {
  .v-list-item {

    min-height: 35px;
    padding: 0 16px;
    font-size: 12px;
    font-weight: 200 !important;

    .v-icon {
      font-size: 12px;
      font-weight: 300;
    }

    &:hover {
      background: rgba(255, 255, 255, 0.05);
    }

    &:active {
      background: rgba(255, 255, 255, 0.1);
    }
  }
}

.v-list {

  .v-list-item {
    border-bottom: 1px solid rgba(255, 255, 255, 0.1);
    font-size: 8px;
    font-weight: 100;
  }

  .v-list-item-title {
    font-size: 12px;
    font-weight: 200;
  }

}


.v-toolbar {

  .v-icon {
    font-size: 20px;
    font-weight: 300;
  }

  border-bottom: 1px solid rgba(255, 255, 255, 0.1);
  border-radius: 8px 8px 0px 0px;
}

.container {
  width: 100%;
  height: 100%;
  border-radius: 8px;

  background: #000000e7;
  --gap: 3em;
  --line: 1px;
  --color: rgba(255, 255, 255, 0.2);

  background-image: linear-gradient(-90deg,
      transparent calc(var(--gap) - var(--line)),
      var(--color) calc(var(--gap) - var(--line) + 1px),
      var(--color) var(--gap)),
    linear-gradient(0deg,
      transparent calc(var(--gap) - var(--line)),
      var(--color) calc(var(--gap) - var(--line) + 1px),
      var(--color) var(--gap));
  background-size: var(--gap) var(--gap);
}

.tpc-viewer {
  position: relative;
  width: 100%;
  height: 100%;
}

.dds-renderer {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.8);
}

.controls {
  position: absolute;
  top: 10px;
  right: 10px;
  z-index: 1;
}
</style>
