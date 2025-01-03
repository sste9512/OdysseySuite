<template>
  <v-container fluid style="background: radial-gradient(#1a192b, black); ">

    <div class="components-page-header-demo-content" style="padding: 5%">

      <a-page-header title="Title" class="site-page-header" sub-title="This is a subtitle"
        :avatar="{ src: 'https://avatars1.githubusercontent.com/u/8186664?s=460&v=4' }" :breadcrumb="{ routes }">
        <template #tags>
          <v-breadcrumbs style="color: white" :items="items" divider="-"></v-breadcrumbs>
        </template>
        <template #extra>

          <v-btn-group>
            <v-btn prepend-icon="mdi-export"> Export</v-btn>
            <v-btn prepend-icon="mdi-book-open-variant"> View Documentation</v-btn>
            <v-btn prepend-icon="mdi-content-save"> Save</v-btn>
          </v-btn-group>


          <a-dropdown key="more">
            <a-button :style="{ border: 'none', padding: 0 }">
              <EllipsisOutlined :style="{ fontSize: '20px', verticalAlign: 'top' }" />

            </a-button>
            <template #overlay>
              <a-menu>
                <a-menu-item>
                  <a target="_blank" rel="noopener noreferrer" href="http://www.alipay.com/">
                    1st menu item
                  </a>
                </a-menu-item>
                <a-menu-item>
                  <a target="_blank" rel="noopener noreferrer" href="http://www.taobao.com/">
                    2nd menu item
                  </a>
                </a-menu-item>
                <a-menu-item>
                  <a target="_blank" rel="noopener noreferrer" href="http://www.tmall.com/">
                    3rd menu item
                  </a>
                </a-menu-item>
              </a-menu>
            </template>
          </a-dropdown>
        </template>


        <a-row class="content" style="color: white">
          <div style="flex: 1">
            <p>
              Chitin Key is the resource mapping for all other resources embedded and compiled inside the other
              resources i.e bifs, erfs, rim files and so on
            </p>

            <div>
              <template v-for="item in iconLinks" :key="item.src">
                <a class="example-link">
                  <img class="example-link-icon" :src="item.src" :alt="item.text" />
                  {{ item.text }}
                </a>
              </template>
            </div>
          </div>
          <div>
            <a-row style="color: white">
              <a-col :span="12">
                <a-statistic title="File Size" :value="112893" style="margin-right: 60px; color: white" />
              </a-col>
              <a-col :span="12">
                <a-statistic title="Asc Files" :precision="2" :value="112893" />
              </a-col>
            </a-row>
          </div>
        </a-row>
      </a-page-header>
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
      <a-page-header title="Key Data" class="site-page-header" sub-title="Search for ids of resources in other files"
        :avatar="{ src: 'https://avatars1.githubusercontent.com/u/8186664?s=460&v=4' }" :breadcrumb="{ routes }">
        <template #tags>

        </template>
        <template #extra>
          <!-- Search Bar -->
          <v-text-field :loading="loading" append-inner-icon="mdi-magnify" density="compact" label="Search templates"
            variant="solo" hide-details single-line @click:append-inner="onClick" style="width: 500px;"></v-text-field>
        </template>


        <a-row class="content" style="color: white">
          <div style="flex: 1">
            <div class="d-flex flex-row gap-4">
              <a-select mode="multiple" allow-clear class="flex-grow-1" placeholder="Search Filters">
                <a-select-option value="Texture">Texture</a-select-option>
                <a-select-option value="Scripts">Scripts</a-select-option>
                <a-select-option value="Maps">Maps</a-select-option>
                <a-select-option value="Lighting">Lighting</a-select-option>
                <a-select-option value="Meshes">Meshes</a-select-option>
                <a-select-option value="Sounds">Sounds</a-select-option>
                <a-select-option value="Dialogue">Dialogue</a-select-option>
              </a-select>
              <a-select mode="multiple" allow-clear class="flex-grow-1" placeholder="Search Filters">
                <a-select-option value="Texture">Texture</a-select-option>
                <a-select-option value="Scripts">Scripts</a-select-option>
                <a-select-option value="Maps">Maps</a-select-option>
                <a-select-option value="Lighting">Lighting</a-select-option>
                <a-select-option value="Meshes">Meshes</a-select-option>
                <a-select-option value="Sounds">Sounds</a-select-option>
                <a-select-option value="Dialogue">Dialogue</a-select-option>
              </a-select>
              <a-select mode="multiple" allow-clear class="flex-grow-1" placeholder="Search Filters">
                <a-select-option value="Texture">Texture</a-select-option>
                <a-select-option value="Scripts">Scripts</a-select-option>
                <a-select-option value="Maps">Maps</a-select-option>
                <a-select-option value="Lighting">Lighting</a-select-option>
                <a-select-option value="Meshes">Meshes</a-select-option>
                <a-select-option value="Sounds">Sounds</a-select-option>
                <a-select-option value="Dialogue">Dialogue</a-select-option>
              </a-select>
            </div>
            <div>
              <template v-for="item in iconLinks" :key="item.src">
                <a class="example-link">
                  <img class="example-link-icon" :src="item.src" :alt="item.text" /> {{ item.text }}
                </a>
              </template>
            </div>
          </div>
          <div>

          </div>
        </a-row>
      </a-page-header>


      <KeyTableCollection key-table-items="keys"></KeyTableCollection>
      <creature-struct-table />

    </v-container>


    <v-container fluid style="background: radial-gradient(ellipse at bottom, #1a192b, black); padding: 5%">
      <v-row>
        <v-col cols="12">
          <v-container fluid class="border-bottom">
            <BluePrintScaffold class="border-bottom"></BluePrintScaffold>
          </v-container>
        </v-col>
      </v-row>
    </v-container>

    <ContextMenu :display="showContextMenu" ref="menu">
      <!-- <CustomContextMenu caller="tab-navigation"></CustomContextMenu> -->
      <KeyTableCollection key-table-items="keys"></KeyTableCollection>
    </ContextMenu>
  </v-container>
</template>

<script>
import BluePrintScaffold from '../../components/ResourceViews/data/BluePrintScaffold.vue'
import KeyTableCollection from "@/components/ResourceViews/chitin/KeyTableView.vue";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import { ref } from 'vue';
import CreatureStructTable from '@/components/ResourceViews/CreatureStruct.vue';

export default {
  name: 'ChitinKeyView',
  components: { KeyTableCollection, BluePrintScaffold, ContextMenu, CreatureStructTable },
  setup() {
    const showContextMenu = ref(false);
    return {
      showContextMenu,
    };
  },
  methods: {
    openContextMenu(event) {
      event.preventDefault();
      this.showContextMenu = true;
      console.log(event);
      this.$refs.menu.setPosition(event.clientX, event.clientY);
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
}
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
