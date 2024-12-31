<template>
  <v-container padding="8px">

    <v-breadcrumbs :items="items" divider="-"></v-breadcrumbs>
    <v-form>


      <v-container>
        <v-row>
          <v-col cols="12" sm="4" v-for="{ key, value } in entries" :key="n" :value="n">
            <v-card height="auto" width="100%" elevation="30"
              :class="['d-flex justify-center align-center shadow-bottom']" style="border-right: 5px white !important">
              <div class="pa-0 bg-secondary rounded-e-lg w-0" style="height: 50px; width: 10px !important"></div>
              <div>
                <div class="d-block pa-2 align-content-center">
                  <h6>{{ key }}</h6>
                </div>
                <div class="d-block pa-2 align-content-start">
                  <h4>{{ value }}</h4>
                </div>
              </div>
              <v-spacer></v-spacer>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-form>


    <h2>Key Data</h2>
    <!-- Tab navigation for key actions -->
    <!-- Uses v-tabs component with deep purple accent color and right-aligned tabs -->
    <!-- Fixed height of 35px for consistent sizing -->
    <v-tabs v-model="tab" align-tabs="end" class="key-action-tabs">
      <!-- Export tab for exporting key data -->
      <v-tab :value="1" class="text-caption" @click.right="openContextMenu($event)">Export</v-tab>
      <!-- Documentation tab for viewing key documentation -->
      <v-tab :value="2" class="text-caption" @click.right="openContextMenu($event)">View Documentation</v-tab>
      <!-- Toolbox tab for adding keys to toolbox -->
      <v-tab :value="3" class="text-caption" @click.right="openContextMenu($event)">Add to Toolbox</v-tab>
      <!-- Reserved tab for future functionality -->
      <v-tab :value="4" class="text-caption" @click.right="openContextMenu($event)">View Relationships</v-tab>
    </v-tabs>

    <v-container fluid>
      <v-row class="d-flex flex-wrap">
        <v-col cols="12" sm="6" md="6" lg="6" class="d-flex">
          <v-combobox clearable chips multiple label="Search Filters"
            :items="['Texture', 'Scripts', 'Maps', 'Lighting', 'Meshes', 'Sounds', 'Dialogue']" variant="solo"
            class="flex-grow-1"></v-combobox>
        </v-col>
        <v-col cols="12" sm="6" md="6" lg="6" class="d-flex">
          <v-combobox clearable chips multiple label="Search Filters"
            :items="['Texture', 'Scripts', 'Maps', 'Lighting', 'Meshes', 'Sounds', 'Dialogue']" variant="solo"
            class="flex-grow-1"></v-combobox>
        </v-col>
      </v-row>
    </v-container>
  </v-container>

  <KeyTableCollection key-table-items="keys"></KeyTableCollection>


  <v-container fluid class="border-bottom">
    <BluePrintScaffold class="border-bottom"></BluePrintScaffold>
  </v-container>

  <ContextMenu :display="showContextMenu" ref="menu">
    <!-- <CustomContextMenu caller="tab-navigation"></CustomContextMenu> -->
    <KeyTableCollection key-table-items="keys"></KeyTableCollection>
  </ContextMenu>
</template>

<script>
import BluePrintScaffold from '../../components/ResourceViews/BluePrintScaffold.vue'
import KeyTableCollection from "@/components/ResourceViews/chitin/KeyTableView.vue";
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";
import { ref } from 'vue';


export default {
  name: 'ChitinKeyView',
  components: { KeyTableCollection, BluePrintScaffold, ContextMenu, CustomContextMenu },
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
/* Key Action Tabs 
  - Fixed height of 35px for consistent sizing
  - Right-aligned tabs with deep purple accent color
  - Text-caption class for consistent styling
  - Custom styling for tabs and tab bar
  - Hover effect for tabs
  - Selected tab styling
  - Note: We want to override the default tab styling for these tabs, so we encapsulate it in a class.
*/
.key-action-tabs {
  height: 35px;

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


.v-select {
  font-size: 4px !important;
  //color: #444 !important;
  background-color: transparent !important;
  border: transparent !important;
  border-radius: 4px !important;
  padding: 1px !important;
}

.v-select__control {
  font-size: 4px !important;
  padding: 8px 5px !important;
  border: none !important;
  background-color: transparent !important;
}

.v-select:hover {
  border-color: #888 !important;
}

.v-select__selections {
  font-size: 8px !important;
  color: whitesmoke !important;
}

.v-select__dropdown {
  background-color: #fc1313 !important;
  border: 1px solid #ccc !important;
  border-radius: 8px !important;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1) !important;
  font-size: 3px !important;
}

.v-select__list-item {
  color: white !important;
  font-size: 3px !important;
  padding: 1px 4px !important;
}

.v-select__list-item:hover {
  background-color: #f1f1f1 !important;
  font-size: 3px !important;
  color: #000 !important;
}


.v-breadcrumbs {
  padding: 8px 12px !important;
  background: transparent !important;
}

.v-breadcrumbs__item {
  color: rgba(255, 255, 255, 0.7) !important;
  font-size: 14px !important;
  font-weight: 400 !important;
}

.v-breadcrumbs__item--disabled {
  color: rgba(255, 255, 255, 0.5) !important;
}

.v-breadcrumbs__divider {
  color: rgba(255, 255, 255, 0.5) !important;
  padding: 0 8px !important;
}

.v-breadcrumbs__item:hover {
  color: rgba(255, 255, 255, 0.9) !important;
  text-decoration: none !important;
}

.v-breadcrumbs__item--link {
  cursor: pointer !important;
  text-decoration: none !important;
}
</style>
