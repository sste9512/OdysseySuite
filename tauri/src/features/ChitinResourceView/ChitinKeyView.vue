<template>
  <h1>Chitin Key View</h1>
  <v-container :key="componentKey" style="background: radial-gradient(#1a192b, black); ">
    <v-overlay v-if="loading">
      <v-progress-circular indeterminate />
    </v-overlay>
   
    <div class="components-page-header-demo-content" style="padding: 5%">

      <!-- <v-card class="pa-4">
        <v-card-title class="d-flex align-center">
          <div>
            <div class="text-h5">Title</div>
            <div class="text-subtitle-1">This is a subtitle</div>
          </div>
          <v-avatar class="ml-4" size="40">
            <v-img src="https://avatars1.githubusercontent.com/u/8186664?s=460&v=4"></v-img>
          </v-avatar>
          <v-spacer></v-spacer>
          <v-breadcrumbs style="color: white" :items="items" divider="-"></v-breadcrumbs>
        </v-card-title>

        <v-card-actions>
          <v-btn-group>
            <v-btn prepend-icon="mdi-export">Export</v-btn>
            <v-btn prepend-icon="mdi-book-open-variant">View Documentation</v-btn>
            <v-btn prepend-icon="mdi-content-save">Save</v-btn>
          </v-btn-group>

          <v-menu>
            <template v-slot:activator="{ props }">
              <v-btn icon v-bind="props">
                <v-icon>mdi-dots-vertical</v-icon>
              </v-btn>
            </template>
            <v-list>
              <v-list-item href="http://www.alipay.com/" target="_blank">
                <v-list-item-title>1st menu item</v-list-item-title>
              </v-list-item>
              <v-list-item href="http://www.taobao.com/" target="_blank">
                <v-list-item-title>2nd menu item</v-list-item-title>
              </v-list-item>
              <v-list-item href="http://www.tmall.com/" target="_blank">
                <v-list-item-title>3rd menu item</v-list-item-title>
              </v-list-item>
            </v-list>
          </v-menu>
        </v-card-actions> 

        <v-card-text class="text-white">
          <p>
            Chitin Key is the resource mapping for all other resources embedded and compiled inside the other
            resources i.e bifs, erfs, rim files and so on
          </p>

          <div class="d-flex gap-4">
            <template v-for="item in iconLinks" :key="item.src">
              <a class="text-decoration-none d-flex align-center">
                <v-img :src="item.src" :alt="item.text" width="24" height="24" class="mr-2"></v-img>
                {{ item.text }}
              </a>
            </template>
          </div>

          <v-row class="mt-4">
            <v-col cols="6">
              <v-card-text>
                <div class="text-subtitle-2">Bif Count</div>
                <div class="text-h5">{{ chitinKey?.header?.bif_count }}</div>
              </v-card-text>
            </v-col>
            <v-col cols="6">
              <v-card-text>
                <div class="text-subtitle-2">Key Count</div>
                <div class="text-h5">{{ chitinKey?.header?.key_count }}</div>
              </v-card-text>
            </v-col>
          </v-row>
        </v-card-text>
      </v-card> -->
     
    </div>





    <!-- 
    Key Data Section
    This section displays a searchable data table for viewing and filtering key file contents.
    
    Components:
    - v-container: Wrapper with dark gradient background
    - a-page-header: Header component showing "Key Data" title and avatar
    - a-row: Contains the search filters and content
    - a-select (3x): Multiple-select dropdown filters for resource types
      Available filters: Texture, Scripts, Maps, Lighting, Meshes, Sounds, Dialogue
    - KeyTableCollection: Data table component displaying the key file entries
      Props:
        - key-table-items: Binds to "keys" data source
        
    Styling:
    - Background uses radial gradient from #1a192b to black
    - 5% padding around container
    - White text color
    - Flexbox layout for filter row
    
    Usage:
    This section allows users to:
    1. View the contents of the key file in a tabular format
    2. Filter resources by multiple types using the dropdown selectors
    3. Search and sort through key file entries
    -->
    <v-container fluid style="background: radial-gradient(#1a192b, black); padding: 5%">
   


      <!-- <ErrorBoundary>
        <KeyTableCollection 
          v-if="chitinKey && chitinKey.key_entries" 
          :key-table-items="chitinKey.key_entries"
        />
      </ErrorBoundary> -->
      <!-- <creature-struct-table /> -->

    </v-container>


    <!-- <v-container fluid style="background: radial-gradient(ellipse at bottom, #1a192b, black); padding: 5%">
      <v-row>
        <v-col cols="12">
          <v-container fluid class="border-bottom">
            <BluePrintScaffold class="border-bottom"></BluePrintScaffold>
          </v-container>
        </v-col>
      </v-row>
    </v-container> -->

    <ContextMenu :display="showContextMenu" ref="menu">
      <!-- <CustomContextMenu caller="tab-navigation"></CustomContextMenu> -->
      <!-- <KeyTableCollection :key-table-items="chitinKey.key_entries"></KeyTableCollection> -->
    </ContextMenu>

    <!-- <div v-if="chitinKey"> -->
      <!-- Your existing content -->
      <!-- <KeyTableCollection 
        v-if="chitinKey.key_entries" 
        :key-table-items="chitinKey.key_entries"
      /> -->
    <!-- </div> -->
    <!-- <div v-else-if="!loading">
      <v-alert type="error">
        Failed to load chitin key data
      </v-alert>
    </div> -->
  </v-container>
</template>

<script lang="ts">
import BluePrintScaffold from '../../components/ResourceViews/data/BluePrintScaffold.vue'
import KeyTableCollection from "@/components/ResourceViews/chitin/KeyTableView.vue";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import { ref, watch } from 'vue';
import CreatureStructTable from '@/components/ResourceViews/CreatureStruct.vue'
import { AuroraService } from '@/data/aurora-service';
import { ChitinKey, KeyEntry, Header } from "@/data/chitin-key";
import { EllipsisOutlined } from '@ant-design/icons-vue';
import { defineComponent, onMounted, onUpdated, onUnmounted, onErrorCaptured } from 'vue';

export default defineComponent({
  name: 'ChitinKeyView',
  components: { KeyTableCollection, BluePrintScaffold, ContextMenu, CreatureStructTable, EllipsisOutlined },
  props: {
    path: {
      type: String,
      required: false,
      default: ''
    }
  },
  async setup(props) {
    console.log('ChitinKeyView setup called');
    
    const showContextMenu = ref(false);
    const loading = ref(false);
    const chitinKey = ref<ChitinKey | null>(null);
    const iconLinks = ref([
      {
        src: '/icons/resource.png',
        text: 'Resources'
      },
      {
        src: '/icons/key.png',
        text: 'Keys'
      }
    ]);

    const loadChitinKey = async () => {
      try {
        loading.value = true;
        const auroraService = new AuroraService();
        const path = 'E:/SteamLibrary/steamapps/common/swkotor/chitin.key';
        const result = await auroraService.readChitinKey(path);
        if (!result) {
          throw new Error('Failed to load chitin key data');
        }
      
        chitinKey.value = result;
        console.log('Loaded chitin key:', result);
      } catch (error) {
        console.error('Error loading chitin key:', error);
        // You might want to show an error message to the user
      } finally {
        loading.value = false;
      }
    };

    await loadChitinKey();

    const routes = ref([
      {
        path: 'index',
        breadcrumbName: 'Home',
      },
      {
        path: 'first',
        breadcrumbName: 'Resources',
      },
      {
        path: 'second',
        breadcrumbName: 'Chitin Key',
      },
    ]);

    const onClick = () => {
      console.log('Search clicked');
    };

    const menu = ref<InstanceType<typeof ContextMenu> | null>(null);
    const componentKey = ref(0);

    // Force re-render function if needed
    const forceRerender = () => {
      componentKey.value += 1;
    };

    onMounted(() => {
      console.log('ChitinKeyView mounted');
    });

    onUpdated(() => {
      console.log('ChitinKeyView updated');
    });

    onUnmounted(() => {
      console.log('ChitinKeyView unmounted');
    });

    onErrorCaptured((err, instance, info) => {
      console.error('Render Error:', err);
      console.log('Component:', instance);
      console.log('Error Info:', info);
      return false; // Prevent error from propagating
    });

    watch(chitinKey, (newVal, oldVal) => {
      console.log('ChitinKey changed:', {
        old: oldVal,
        new: newVal
      });
    }, { deep: true });

    return {
      showContextMenu,
      chitinKey,
      loading,
      iconLinks,
      onClick,
      menu,
      routes,
      componentKey,
      forceRerender
    };
  },
  mounted() {
     console.log("mounted ChitinKeyView");
     this.forceRerender();
  },
  methods: {
    openContextMenu(event: { preventDefault: () => void; clientX: number; clientY: number }) {
      event.preventDefault();
     // this.showContextMenu = true;
      if (this.$refs.menu) {
        (this.$refs.menu as any).setPosition(event.clientX, event.clientY);
      }
    },
  },
  data: () => ({
    items: [
      {
        title: 'Dashboard',
        disabled: false,
        href: 'breadcrumbs_dashboard',
      },
      {
        title: 'Link 1',
        disabled: false,
        href: 'breadcrumbs_link_1',
      },
      {
        title: 'Link 2',
        disabled: true,
        href: 'breadcrumbs_link_2',
      },
    ],
  }),
})
</script>

<style scoped lang="scss">
@import "@/assets/css/vuetify.scss";

::v-deep(.ant-statistic) {
  .ant-statistic-title {
    color: rgb(226, 210, 241);
    font-size: 14px;
    margin-bottom: 4px;
  }

  .ant-statistic-content {
    color: rgb(226, 210, 241);

    .ant-statistic-content-value {
      font-size: 24px;
      font-weight: 500;
    }

    .ant-statistic-content-suffix {
      font-size: 16px;
      color: rgba(226, 210, 241, 0.65);
    }
  }
}


::v-deep(.ant-page-header) {
  padding: 16px 24px;
  background-color: rgb(43, 37, 37);
  border-bottom: 1px solid rebeccapurple;
  border-radius: 4px;

  .ant-page-header-heading {
    .ant-page-header-heading-title {
      color: rgb(226, 210, 241);
      font-weight: 500;
    }

    .ant-page-header-heading-sub-title {
      color: rgba(226, 210, 241, 0.65);
    }
  }

  .ant-page-header-content {
    padding-top: 12px;
    color: rgb(226, 210, 241);
  }

  .ant-page-header-back {
    color: rgb(226, 210, 241);

    &:hover {
      color: rebeccapurple;
    }
  }

  .ant-page-header-footer {
    margin-top: 16px;
    padding-top: 16px;
    border-top: 1px solid rebeccapurple;
  }
}


::v-deep(.ant-select) {
  width: 100%;
  background-color: rgb(43, 37, 37) !important;
  border-radius: 9px !important;
  border: 1px solid rebeccapurple !important;
  overflow: hidden !important;
  color: rgb(226, 210, 241) !important;
  margin-right: 10px;

  .ant-select-selector {
    border: 1px solid var(--v-border-color);
    border-radius: 4px;
    background-color: rgb(71, 66, 66) !important;

    &:hover {
      border-color: rebeccapurple;
    }
  }

  .ant-select-selection-placeholder {
    color: rgba(194, 21, 21, 0.45);
  }

  &.ant-select-focused .ant-select-selector {
    border-color: var(--v-primary-base);
    box-shadow: rebeccapurple;
    color: white !important;
    font-weight: 500 !important;
  }

  .ant-select-arrow {
    color: rgba(0, 0, 0, 0.25);
  }
}


#components-page-header-demo-content .image {
  margin: 0 0 0 60px;
  display: flex;
  align-items: center;
}

#components-page-header-demo-content .ant-page-header-rtl .image {
  margin: 0 60px 0 0;
}

#components-page-header-demo-content .example-link {
  line-height: 24px;
  margin-right: 16px;
}

[data-theme='compact'] #components-page-header-demo-content .example-link {
  line-height: 20px;
}

#components-page-header-demo-content .example-link-icon {
  margin-right: 8px;
}

[data-theme='compact'] #components-page-header-demo-content .example-link-icon {
  width: 20px;
  height: 20px;
}

#components-page-header-demo-content .ant-page-header-rtl .example-link {
  float: right;
  margin-right: 0;
  margin-left: 16px;
}

#components-page-header-demo-content .ant-page-header-rtl .example-link-icon {
  margin-right: 0;
  margin-left: 8px;
}

#components-page-header-demo-content .content p {
  margin-bottom: 1em;
  color: rgba(0, 0, 0, 0.85);
  overflow-wrap: break-word;
}

@media (max-width: 768px) {
  #components-page-header-demo-content .image {
    flex: 100%;
    margin: 24px 0 0;
  }
}

::v-deep(.ant-descriptions) {
  border: 3px solid purple !important;
  border-radius: 4px !important;
  padding: 16px !important;
  background-color: black !important;

  .ant-descriptions-title {
    font-size: 22px !important;
    font-weight: lighter !important;
    color: whitesmoke !important;
    margin-bottom: 12px !important;
  }

  .ant-descriptions-item {
    font-size: 6px !important;
    color: whitesmoke !important;
    border-bottom: 1px solid rgba(0, 0, 0, 0.1) !important;
    padding: 2px 3px !important;

    &:last-child {
      border-bottom: none !important;
    }
  }

  .ant-descriptions-item-label {
    font-weight: lighter !important;
    color: white !important;
  }

  .ant-descriptions-item-content {
    color: white !important;

  }
}

::v-deep(.key-action-tabs) {
  height: 35px !important;
  outline: 0.3px solid rgb(103, 58, 183) !important;
  border-radius: 3px !important;
  padding: 0 10px !important;

  .v-tab {
    text-transform: none !important;
    letter-spacing: 0 !important;
    font-weight: 400 !important;
    font-size: 13px !important;
    min-width: 90px !important;
    padding: 0 17px !important;
    opacity: 0.9 !important;
    color: rgb(0, 149, 255) !important;

    &--selected {
      opacity: 1 !important;
      font-weight: 500 !important;
    }

    &:hover {
      opacity: 0.9 !important;
      border-bottom: 4px solid rgb(var(--v-theme-primary)) !important;
      transition: border-bottom 0.2s ease-in-out !important;
    }
  }

  .v-tabs {
    height: 100% !important;

    .v-slide-group__wrapper {
      border-bottom: thin solid rgba(255, 255, 255, 0.12) !important;
    }
  }

  .v-tab-bar {
    height: 2px !important;
    background-color: rgb(var(--v-theme-primary)) !important;
    border-radius: 2px !important;
  }
}

::v-deep(.v-select) {
  font-size: 4px !important;
  background-color: transparent !important;
  border: transparent !important;
  border-radius: 4px !important;
  padding: 1px !important;
}

::v-deep(.v-select__control) {
  font-size: 4px !important;
  padding: 8px 5px !important;
  border: none !important;
  background-color: transparent !important;
}

::v-deep(.v-select:hover) {
  border-color: #888 !important;
}

::v-deep(.v-select__selections) {
  font-size: 8px !important;
  color: whitesmoke !important;
}

::v-deep(.v-select__dropdown) {
  background-color: #fc1313 !important;
  border: 1px solid #ccc !important;
  border-radius: 8px !important;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1) !important;
  font-size: 3px !important;
}

::v-deep(.v-select__list-item) {
  color: white !important;
  font-size: 3px !important;
  padding: 1px 4px !important;
}

::v-deep(.v-select__list-item:hover) {
  background-color: #f1f1f1 !important;
  font-size: 3px !important;
  color: #000 !important;
}



::v-deep(.v-combobox) {
  font-size: 10px !important;
  background-color: black !important;
  border-radius: 8px !important;
  border: 1px solid purple !important;
  font-weight: lighter !important;

  .v-input__control {
    color: #fff !important;
    border: 1px solid #555 !important;
    font-weight: lighter !important;

    &:hover {
      border-color: #777 !important;
    }
  }

  .v-input__append-inner,
  .v-input__prepend-inner {
    color: #aaa !important;
  }

  .v-combobox__selection {
    background: #444 !important;
    border-radius: 4px !important;
    color: #fff !important;
    padding: 4px 8px !important;

    .v-chip {
      background-color: mediumaquamarine !important;
      color: mediumaquamarine !important;

      &:hover {
        background-color: purple !important;
      }
    }
  }

  .v-combobox__selections {
    font-size: 10px !important;
    font-weight: lighter !important;
  }

  .v-menu {
    .v-list {
      background-color: #222 !important;
      border: 1px solid purple !important;
      border-radius: 4px !important;
      font-weight: lighter !important;

      .v-list-item {
        color: #fff !important;
        font-size: 10px !important;

        &:hover {
          background: #555 !important;
          color: #fff !important;
        }
      }
    }
  }
}
</style>
