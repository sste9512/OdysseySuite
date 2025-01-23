<template>
  <v-container fluid style="background: radial-gradient(#1a192b, black);">
    <!-- Header Section -->
    <div class="components-page-header-demo-content" style="padding: 5%">
      <a-page-header 
        title="ERF Resource View" 
        class="site-page-header" 
        sub-title="View and manage ERF resource files"
      >
        <template #tags>
          <v-breadcrumbs style="color: white" :items="breadcrumbItems" divider="-"></v-breadcrumbs>
        </template>
        
        <template #extra>
          <v-btn-group>
            <v-btn prepend-icon="mdi-export">Export</v-btn>
            <v-btn prepend-icon="mdi-book-open-variant">Documentation</v-btn>
            <v-btn prepend-icon="mdi-content-save">Save</v-btn>
          </v-btn-group>
        </template>

        <a-row class="content" style="color: white">
          <div style="flex: 1">
            <p>
              ERF files are resource containers used to package game assets like textures, 
              models, scripts and other resources.
            </p>
          </div>
          <div>
            <a-row style="color: white">
              <a-col :span="12">
                <a-statistic title="Resource Count" :value="0" style="margin-right: 60px"/>
              </a-col>
              <a-col :span="12">
                <a-statistic title="File Size" :value="0" :suffix="'bytes'"/>
              </a-col>
            </a-row>
          </div>
        </a-row>
      </a-page-header>
    </div>

    <!-- Resource List Section -->
    <v-container fluid style="background: radial-gradient(#1a192b, black); padding: 5%">
      <a-page-header title="Resources" class="site-page-header">
        <template #extra>
          <v-text-field
            :loading="loading"
            append-inner-icon="mdi-magnify"
            density="compact"
            label="Search resources"
            variant="solo"
            hide-details
            single-line
            style="width: 500px;"
          ></v-text-field>
        </template>

        <a-row class="content" style="color: white">
          <div style="flex: 1">
            <div class="d-flex flex-row gap-4">
              <a-select mode="multiple" allow-clear class="flex-grow-1" placeholder="Resource Types">
                <a-select-option value="Texture">Texture</a-select-option>
                <a-select-option value="Scripts">Scripts</a-select-option>
                <a-select-option value="Models">Models</a-select-option>
                <a-select-option value="Audio">Audio</a-select-option>
              </a-select>
            </div>
          </div>
        </a-row>
      </a-page-header>

      <!-- Resource Table Component Placeholder -->
      <v-data-table
        :headers="headers"
        :items="resources"
        :loading="loading"
        class="mt-4"
      ></v-data-table>
    </v-container>

    <ContextMenu :display="showContextMenu" ref="menu">
    </ContextMenu>
  </v-container>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import ContextMenu from "@/components/ContextMenus/ContextMenu.vue";

export default defineComponent({
  name: 'ErfResourceView',
  components: { ContextMenu },
  data() {
    return {
      loading: false,
      showContextMenu: false,
      resources: [],
      headers: [
        { title: 'Name', key: 'name' },
        { title: 'Type', key: 'type' },
        { title: 'Size', key: 'size' },
        { title: 'Modified', key: 'modified' }
      ],
      breadcrumbItems: [
        { title: 'Resources', disabled: false },
        { title: 'ERF View', disabled: true }
      ]
    }
  },
  methods: {
    openContextMenu(event: { preventDefault: () => void; clientX: number; clientY: number }) {
      event.preventDefault();
      if (this.$refs.menu) {
        (this.$refs.menu as any).setPosition(event.clientX, event.clientY);
      }
    }
  }
});
</script>

<style scoped lang="scss">
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
}
</style>
