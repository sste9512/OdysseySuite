<template>
  <div class="rim-view">
    <div class="desk">
   
          <a-page-header title="RIM Resource" sub-title="Resource Index Manager" :ghost="false"  style="background-color: transparent; padding: 10px;">
            <template #breadcrumb>
              <v-breadcrumbs :items="breadcrumbItems"></v-breadcrumbs>
            </template>

            <template #extra>
              <v-btn-group>
                <v-btn prepend-icon="mdi-export" variant="outlined">Export</v-btn>
                <v-btn prepend-icon="mdi-book-open-variant" variant="outlined">Documentation</v-btn>
                <v-btn prepend-icon="mdi-content-save" variant="outlined">Save</v-btn>
              </v-btn-group>
            </template>

            <div style="display: flex; flex-direction: row; gap: 16px;">
              <a-statistic title="Total Resources" :value="rim?.entry_count || 0" />
              <a-statistic title="Total Size" :value="rim?.data?.length || 0" suffix="bytes" />
            </div>

            <div class="mt-4">
              <v-text-field v-model="search" 
                :loading="loading" 
                prepend-inner-icon="mdi-magnify" 
                label="Search resources"
                variant="outlined" 
                hide-details 
                density="comfortable"
                class="search-field">
              </v-text-field>
            </div>
          </a-page-header>
  

          <v-row class="mt-4">
            <v-col cols="12">
              <v-select v-model="selectedTypes" 
                multiple 
                chips 
                label="Resource Types" 
                :items="resourceTypes"
                variant="outlined" 
                class="resource-select">
              </v-select>
            </v-col>
          </v-row>

          <v-data-table :headers="headers" 
            :items="filteredResources" 
            :loading="loading" 
            class="mt-4"
            hover>
            <template v-slot:item.resource_type="{ item }">
              {{ getResourceTypeName(item.resource_type) }}
            </template>
            <template v-slot:item.resource_size="{ item }">
              {{ formatBytes(item.length) }}
            </template>
          </v-data-table>


    <ContextMenu :display="showContextMenu" ref="menu">
    </ContextMenu>
  </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref, watch, computed, onMounted } from 'vue';
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import { Rim } from '@/data/rim';
import { AuroraService } from '@/data/aurora-service';
import { ResourceType, resourceTypeFromNumber } from '@/data/resource_identification';

export default defineComponent({
  name: 'RimResourceView',
  components: { ContextMenu },
  props: {
    path: {
      type: String,
      required: true
    }
  },
  setup(props) {
    const rim = ref<Rim | null>(null);
    const loading = ref(false);
    const showContextMenu = ref(false);
    const search = ref('');
    const selectedTypes = ref<number[]>([]);
    const resourceTypes = ref<number[]>([]);
    const headers = ref([
      { title: 'Name', key: 'resource_name', align: 'start' },
      { title: 'Type', key: 'resource_type' },
      { title: 'Size', key: 'resource_size' },
      { title: 'Actions', key: 'actions' }
    ]);

    const breadcrumbItems = ref([
      { title: 'Resources', disabled: false, path: '/resources' },
      { title: props.path.split('/').pop() || 'RIM View', disabled: true, path: props.path }
    ]);

    const loadRim = async () => {
      try {
        loading.value = true;
        const auroraService = new AuroraService();
        console.log('Loading RIM from path:', props.path);
        const rimData = await auroraService.readRimFile(props.path);
        if (rimData.ok) {
          console.log('RIM data loaded:', rimData.value);
          rim.value = rimData.value;
          
          // Extract unique resource types
          const types = new Set(rimData.value.key_entry_list.map(entry => resourceTypeFromNumber(entry.resource_type)));
          resourceTypes.value = Array.from(types) as number[];
        } else {
          console.error('Failed to load RIM:', rimData.error);
        }
      } catch (error) {
        console.error('Failed to load RIM:', error);
      } finally {
        loading.value = false;
      }
    };

    const filteredResources = computed(() => {
      if (!rim.value) return [];
      
      let resources = rim.value.key_entry_list;

      if (search.value) {
        const searchLower = search.value.toLowerCase();
        resources = resources.filter(resource => 
          resource.resource_name.toLowerCase().includes(searchLower)
        );
      }

      if (selectedTypes.value.length > 0) {
        resources = resources.filter(resource => 
          selectedTypes.value.includes(resource.resource_type)
        );
      }

      return resources;
    });

    const getResourceTypeName = (type: number) => {
      const resourceType = resourceTypeFromNumber(type);
      return resourceType ? ResourceType[resourceType] : `Type ${type}`;
    };

    const formatBytes = (bytes: number) => {
      if (bytes === 0) return '0 Bytes';
      const k = 1024;
      const sizes = ['Bytes', 'KB', 'MB', 'GB'];
      const i = Math.floor(Math.log(bytes) / Math.log(k));
      return parseFloat((bytes / Math.pow(k, i)).toFixed(2)) + ' ' + sizes[i];
    };

    onMounted(async () => {
      await loadRim();
    });

    watch(() => props.path, async () => {
      await loadRim();
    });

    return {
      rim,
      loading,
      showContextMenu,
      headers,
      breadcrumbItems,
      loadRim,
      getResourceTypeName,
      formatBytes,
      search,
      selectedTypes,
      resourceTypes,
      filteredResources
    };
  }
});
</script>

<style scoped lang="scss">

.rim-view {
  padding: 15px 15px 15px 15px;

  .desk {
    background: rgba(0, 0, 0, 0.3);
    border-radius: 8px;
    padding: 25px 25px 30px 30px;
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

  .v-data-table {
    background: rgba(0, 0, 0, 0.3);
    border-radius: 8px;

    :deep(.v-data-table-header) {
      background: rgba(0, 0, 0, 0.2);

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
