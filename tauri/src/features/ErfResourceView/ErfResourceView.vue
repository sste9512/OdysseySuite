<template>
  <div class="erf-view">
    <div class="desk">

      <v-row>
        <v-col cols="12">
          <div class="name">
            <v-breadcrumbs :items="path.split(/[/\\]/).map(item => ({
              title: item || 'Root',
              disabled: false
            }))"></v-breadcrumbs>
          </div>

          <a-page-header :title="path.split(/[/\\]/).pop() || 'ERF Resource'" sub-title="Resource Archive File"
            :ghost="false" style="background-color: transparent; padding: 10px;">
            <template #extra>
              <v-btn key="3">Export As</v-btn>
              <v-btn key="2">View Relationships</v-btn>

              <v-btn key="1" color="primary">Save</v-btn>
            </template>

            <div style="display: flex; flex-direction: row; gap: 16px;">
              <a-statistic title="Total Resources" :value="erf?.key_list.entries.length || 0" />
              <a-statistic title="Total Size" :value="erf?.resource_data.data.length || 0" suffix="bytes" />
              <a-statistic title="Version" :value="erf?.header.version.join('.') || '0.0.0.0'" />
              <a-statistic title="Language Count" :value="erf?.header.language_count || 0" />
              <a-statistic title="Entry Count" :value="erf?.header.entry_count || 0" />
              <a-statistic title="Description Str Ref" :value="erf?.header.description_strref || 0" />
              <a-statistic title="Localized String Size" :value="erf?.header.localized_string_size || 0"
                suffix="bytes" />
              <a-statistic title="Entry Count" :value="erf?.header.entry_count || 0" />
              <a-statistic title="Offset to Localized String" :value="erf?.header.offset_to_localized_string || 0"
                suffix="bytes" />
              <a-statistic title="Offset to Key List" :value="erf?.header.offset_to_key_list || 0" suffix="bytes" />
              <a-statistic title="Offset to Resource List" :value="erf?.header.offset_to_resource_list || 0"
                suffix="bytes" />
              <a-statistic title="Build Year" :value="erf?.header.build_year || 0" />
              <a-statistic title="Build Day" :value="erf?.header.build_day || 0" />
            </div>
          </a-page-header>



          <v-row class="mt-4">
            <v-col cols="12">
              <v-select v-model="selectedTypes" multiple chips label="Resource Types" :items="resourceTypes"
                variant="outlined" class="resource-select">
              </v-select>
            </v-col>
          </v-row>

          <v-data-table :headers="headers" :items="filteredResources" :loading="loading" class="mt-4" hover>
            <template v-slot:item.filename="{ item }">
              {{ String.fromCharCode(...item.filename).trim() }}
            </template>
            <template v-slot:item.resource_type="{ item }">
              <v-chip class="resource-type-chip">{{ getResourceTypeName(item.resource_type) }}</v-chip>
            </template>
            <template v-slot:item.resource_id="{ item }">
              {{ getResourceOffset(item.resource_id) }}
            </template>
            <template v-slot:item.resource_size="{ item }">
              {{ getResourceSize(item.resource_id) }}
            </template>
            <template v-slot:item.actions="{ item }">
              <v-btn @click="exportResource(item.resource_id)">Export</v-btn>
              <v-btn @click="handleViewClick(item.resource_id)">View</v-btn>
              <v-btn>Save</v-btn>
            </template>

          </v-data-table>


          <v-data-table :headers="[
            { title: 'Language', key: 'language_id', align: 'start' },
            { title: 'String Size', key: 'string_size' },
            { title: 'Content', key: 'string' }
          ]" :items="localizedStrings" :loading="loading" class="mt-8" hover>
            <template v-slot:item.language_id="{ item }">
              {{ getLanguageName(item.language_id) }}
            </template>
            <template v-slot:item.string_size="{ item }">
              {{ formatBytes(item.string_size) }}
            </template>
          </v-data-table>

        </v-col>

        <v-snackbar v-model="snackbar" :timeout="timeout" :close-on-back="false" vertical>

          {{ text }}
          <v-banner
      class="my-4"
      color="deep-purple-accent-4"
      icon="mdi-lock"
      lines="one"
    >
      <v-banner-text>
        Banner with one line of text.
      </v-banner-text>

      <template v-slot:actions>
        <v-btn>Action</v-btn>
      </template>
    </v-banner>

    <v-banner
      class="my-4"
      color="error"
      icon="mdi-weather-hurricane"
      lines="two"
    ></v-banner>
          <v-progress-linear indeterminate></v-progress-linear>


          <template v-slot:actions>
            <v-btn color="blue" variant="text" @click="snackbar = false">
              Close
            </v-btn>
          </template>
        </v-snackbar>
      </v-row>

      <ContextMenu :display="showContextMenu" ref="menu">
      </ContextMenu>




      <v-overlay v-model="showTpcOverlay" class="align-center justify-center">
        <v-card min-width="400" min-height="400">
          <v-card-title class="d-flex justify-space-between">
            <span>Texture Preview</span>
            <v-btn icon="mdi-close" variant="text" @click="showTpcOverlay = false"></v-btn>
          </v-card-title>
          <v-card-text>
            <ThreeRender :ddsHeader="ddsHeader" />
          </v-card-text>
        </v-card>
      </v-overlay>

    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, watch, computed, onMounted } from 'vue';
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import { ErfFile, ErfKeyEntry, ErfLocalizedString, ErfResourceTable, LanguageId } from '@/data/erf';
import { AuroraService } from '@/data/aurora-service';
import { ResourceType } from '@/data/resource_identification';
import TpcViewer from '@/components/DataPresentation/TpcViewer.vue';
import { DDS_HEADER } from '@/components/Aurora-Rendering/types/DDS';
import ThreeRender from '@/components/ThreeRendering/ThreeRender.vue';
import { TPC } from '@/components/Aurora-Rendering/types/TPC';
import { ImageApi } from '@/data/image-api';
import { NotificationPlacement, notification } from 'ant-design-vue';

export default {
  name: 'ErfResourceView',
  components: { ContextMenu },
  props: {
    path: {
      type: String,
      required: true
    }
  },
  setup(props) {
    console.log('ERF Resource View', props.path);
    const erf = ref<ErfFile | null>(null);
    const loading = ref(false);
    const showContextMenu = ref(false);
    const search = ref('');
    const selectedTypes = ref<number[]>([]);
    const resourceTypes = ref<string[]>([]);
    const menu = ref();
    const showTpcOverlay = ref(false);
    const selectedResourceData = ref<Uint8Array | null>(null);
    const ddsHeader = ref<Uint8Array | null>(null);
    const snackbar = ref(false);
    const text = ref('My timeout is set to 2000.');
    const timeout = ref(2000);




    const headers = ref([
      { title: 'Name', key: 'filename', align: 'start' as const },
      { title: 'Type', key: 'resource_type' },
      { title: 'Offset', key: 'resource_id' },
      { title: 'Size', key: 'resource_size' },
      { title: 'Actions', key: 'actions' }
    ]);

    const breadcrumbItems = ref([
      { title: 'Resources', disabled: false },
      { title: 'ERF View', disabled: true }
    ]);

    const localizedStrings = ref<ErfLocalizedString[]>([]);
    const resourceList = ref<ErfResourceTable>();
    const getLanguageName = (languageId: number) => {
      return LanguageId[languageId] || languageId;
    };


    const exportResource = async (resourceId: number) => {
      // const [api, contextHolder] = notification.useNotification();
      // const open = (placement: NotificationPlacement) => openNotification(placement);
      // const openNotification = (placement: NotificationPlacement) => {
      //   api.info({
      //     message: `Notification ${placement}`,
      //     description:
      //       'This is the content of the notification. This is the content of the notification. This is the content of the notification.',
      //     placement,
      //   });
      // };
      snackbar.value = true;
    }

    // Handle view click
    // This function is used to handle the view click event for a resource
    // It retrieves the resource data from the AuroraService
    // It then creates a new TPC object with the resource data
    // It then sets the selectedResourceData to the resource data

    // It then sets the showTpcOverlay to true
    // It then logs the selectedResourceData
    const handleViewClick = async (resourceId: number) => {

      showTpcOverlay.value = true;
      const auroraService = new AuroraService();
      const resourceData = await auroraService.getErfResourceData(props.path, resourceId);

      if (resourceData.ok) {
        // console.log("resourceData", resourceData.value);
        selectedResourceData.value = resourceData.value;
        // const tpc = new TPC({
        //   filename: resourceId.toString(), // the name of the texture file
        //   file:  resourceData.value, // actual binary data
        //   pack: 0, // this is the texture pack reference, meaning the different packages of erf files that contain the textures
        // });

        const imageApi = new ImageApi();
        const tpcData = await imageApi.convertBytesToTPC(resourceData.value);



        if (tpcData.ok) {
          // get the offset of the resource
          const resourceOffset = getResourceOffset(resourceId);
          if (resourceOffset === undefined) {
            console.error("Could not get resource offset");
            return;
          }
          // get the size of the resource
          const resourceSize = getResourceSize(resourceId);
          if (resourceSize === undefined) {
            console.error("Could not get resource size");
            return;
          }
          // get the tpc from the file
          const tpc = await imageApi.getTPCFromFile(props.path, resourceOffset, resourceSize);
          if (tpc.ok) {
            console.log("tpc", tpc.value);
          } else {
            console.error("Could not get TPC from file");
            return;
          }


          // Move this to export function
          const desktopPath = "C:\\Users\\steve\\OneDrive\\Windows\\Backgrounds\\Desktop\\tpc_dump";
          const tpcPath = desktopPath + "\\" + String.fromCharCode(...filteredResources.value[resourceId].filename).trim().replace(/[^a-zA-Z0-9]/g, "_") + ".tpc";


          const writeTpcToFile = await imageApi.writeTPCToFile(tpcPath, tpc.value);
          if (writeTpcToFile.ok) {

            const tpcXoreos = await imageApi.getTPCFromFileXoreos(props.path, resourceOffset, resourceSize);
            if (tpcXoreos.ok) {
              console.log("tpcXoreos", tpcXoreos.value);
            } else {
              console.error("Could not get TPC from file");
              return;
            }

            const ddsData = await imageApi.convertTPCtoDDS(tpc.value);
            if (ddsData.ok) {
              ddsHeader.value = ddsData.value;
              console.log("ddsHeader", ddsHeader.value);
            } else {
              console.log("error", ddsData.error);
            }

          }
          else {
            console.log("error", tpcData.error);
          }

        }


        console.log("selectedResourceData", selectedResourceData.value);
      };
    }





    const loadErf = async () => {
      try {
        loading.value = true;
        const auroraService = new AuroraService();
        console.log('Loading ERF from path:', props.path);
        const erfData = await auroraService.readErfFile(props.path);
        if (erfData.ok) {
          console.log('ERF data loaded:', erfData.value);
          erf.value = erfData.value;

          // Extract unique resource types from key list entries
          const types = new Set<number>(erfData.value.key_list.entries.map(entry => entry.resource_type));
          resourceTypes.value = Array.from(types).map(type => getResourceTypeName(type));
          localizedStrings.value = erfData.value.localized_strings.strings;
          resourceList.value = erfData.value.resource_list;
        } else {
          console.error('Failed to load ERF:', erfData.error);
        }
      } catch (error) {
        console.error('Failed to load ERF:', error);
      } finally {
        loading.value = false;
      }
    };

    const getResourceData = async (resourceId: number) => {
      const auroraService = new AuroraService();
      const resourceData = await auroraService.getErfResourceData(props.path, resourceId);
      if (resourceData.ok) {
        return resourceData.value;
      } else {
        throw new Error("Failed to get resource data");
      }
    };

    const getResourceSize = (size: number) => {
      return resourceList.value?.entries[size].resource_size;
    };

    const getResourceOffset = (offset: number) => {
      return resourceList.value?.entries[offset].offset_to_resource;
    };

    const getResourceTypeName = (type: number) => {
      return ResourceType[type] || type;
    };

    const filteredResources = computed(() => {
      if (!erf.value) return [];


      let resources = erf.value.key_list.entries;

      // // Apply search filter
      // if (search.value) {
      //   const searchLower = search.value.toLowerCase();
      //   resources = resources.filter(resource =>
      //     resource.filename.toLowerCase().includes(searchLower)
      //   );
      // }

      // Apply type filter
      if (selectedTypes.value.length > 0) {
        resources = resources.filter(resource =>
          selectedTypes.value.includes(resource.resource_type)
        );
      }

      return resources;
    });



    const formatBytes = (bytes: number) => {
      if (bytes === 0) return '0 Bytes';
      const k = 1024;
      const sizes = ['Bytes', 'KB', 'MB', 'GB'];
      const i = Math.floor(Math.log(bytes) / Math.log(k));
      return parseFloat((bytes / Math.pow(k, i)).toFixed(2)) + ' ' + sizes[i];
    };

    const openContextMenu = (event: { preventDefault: () => void; clientX: number; clientY: number }) => {
      event.preventDefault();
      if (menu.value) {
        menu.value.setPosition(event.clientX, event.clientY);
      }
    };

    // Load ERF when component mounts
    onMounted(async () => {
      console.log('ERF Resource View mounted');
      await loadErf();
    });

    // Watch for path changes
    watch(() => props.path, async () => {
      console.log('ERF Resource View path changed:', props.path);
      await loadErf();
    });

    return {
      erf,
      loading,
      showContextMenu,
      headers,
      breadcrumbItems,
      loadErf,
      getResourceTypeName,
      formatBytes,
      search,
      selectedTypes,
      resourceTypes,
      filteredResources,
      openContextMenu,
      menu,
      localizedStrings,
      getLanguageName,
      getResourceSize,
      getResourceOffset,
      getResourceData,
      showTpcOverlay,
      selectedResourceData,
      handleViewClick,
      exportResource,
      snackbar,
      text,
      timeout
    };
  }
}

</script>

<style scoped lang="scss">
.erf-view {
  :deep(.v-breadcrumbs) {
    padding: 0;

    .v-breadcrumbs-item {
      color: rgba(255, 255, 255, 0.65);
      font-size: 14px;

      &--disabled {
        opacity: 0.5;
      }

      &:hover:not(.v-breadcrumbs-item--disabled) {
        color: rgba(255, 255, 255, 0.85);
      }
    }

    .v-breadcrumbs-divider {
      color: rgba(255, 255, 255, 0.45);
      padding: 0 8px;
    }
  }

  padding: 15px 15px 15px 15px;

  .resource-type-chip {
    background: rgba(74, 158, 255, 0.15);
    color: #4a9eff;
    font-size: 12px;
    height: 24px;
  }

  .desk {
    background: rgba(0, 0, 0, 0.3);
    border-radius: 8px;
    padding: 25px 25px 30px 30px;
    border: 0.4px solid rebeccapurple;
    box-shadow: 0 0 5px 0 rgba(0, 0, 0, 0.5);
  }

  .titles {
    display: flex;
    align-items: center;
    margin-bottom: 15px;

    &.blue {
      color: #4a9eff;
    }

    .icon {
      width: 24px;
      height: 24px;
      margin-right: 10px;
    }

    .title {
      font-size: 18px;
      font-weight: 500;

      .subtitle {
        font-size: 12px;
        opacity: 0.7;
      }
    }
  }

  :deep(.ant-page-header) {
    .ant-page-header-heading-title {
      color: rgba(255, 255, 255, 0.85);
      font-size: 20px;
      font-weight: 500;
    }

    .ant-page-header-heading-sub-title {
      color: rgba(255, 255, 255, 0.65);
      font-size: 14px;
    }
  }

  :deep(.ant-breadcrumb) {
    .ant-breadcrumb-link {
      color: rgba(255, 255, 255, 0.85);
      font-size: 14px;

      &:hover {
        color: #4a9eff;
      }
    }

    .ant-breadcrumb-separator {
      color: rgba(255, 255, 255, 0.45);
    }
  }

  :deep(.ant-statistic) {
    .ant-statistic-title {
      color: rgba(255, 255, 255, 0.85);
      font-size: 14px;
      margin-bottom: 4px;
    }

    .ant-statistic-content {
      color: rgba(255, 255, 255, 0.65);
      font-size: 24px;

      .ant-statistic-content-value {
        display: inline-block;
      }

      .ant-statistic-content-suffix {
        margin-left: 4px;
      }
    }
  }

  :deep(.v-select) {
    .v-field {
      background: rgba(30, 30, 40, 0.7) !important;
      border: 1px solid rgba(255, 255, 255, 0.1);
      border-radius: 4px;

      &:hover {
        border-color: rgba(74, 158, 255, 0.5);
      }

      &.v-field--focused {
        border-color: #4a9eff;
        box-shadow: 0 0 0 2px rgba(74, 158, 255, 0.2);
      }

      .v-field__input {
        color: rgba(255, 255, 255, 0.85) !important;
        font-size: 14px;
      }

      .v-field__append-inner {
        color: rgba(255, 255, 255, 0.45);
      }
    }

    .v-select__selection {
      color: rgba(255, 255, 255, 0.85) !important;
    }

    .v-label {
      color: rgba(255, 255, 255, 0.65) !important;
      font-size: 14px;
    }

    .v-chip {
      background: rgba(74, 158, 255, 0.15);
      color: #4a9eff;
      font-size: 12px;
      height: 24px;

      &:hover {
        background: rgba(74, 158, 255, 0.25);
      }

      .v-chip__close {
        color: #4a9eff;
        opacity: 0.7;

        &:hover {
          opacity: 1;
        }
      }
    }

    .v-list {
      background: rgba(30, 30, 40, 0.95);
      border: 1px solid rgba(255, 255, 255, 0.1);

      .v-list-item {
        color: rgba(255, 255, 255, 0.85);

        &:hover {
          background: rgba(74, 158, 255, 0.1);
        }

        &.v-list-item--active {
          background: rgba(74, 158, 255, 0.2);
          color: #4a9eff;
        }
      }
    }
  }

  .v-data-table {

    border-radius: 8px;

    :deep(.v-data-table-header) {



      th {
        color: rgba(255, 255, 255, 0.85) !important;
        font-weight: 500;
        font-size: 14px;
      }
    }

    :deep(.v-data-table__wrapper) {
      td {
        color: rgba(255, 255, 255, 0.65);
      }
    }
  }

  .v-select {
    .v-field {
      background: rgba(0, 0, 0, 0.3) !important;
      border-radius: 8px;
    }

    .v-field__input,
    .v-field__field,
    .v-select__selection {
      color: rgba(255, 255, 255, 0.85) !important;
    }

    .v-label {
      color: rgba(255, 255, 255, 0.65) !important;
    }

    .v-chip {
      background: rgba(74, 158, 255, 0.2);
      color: #4a9eff;
    }
  }
}
</style>
