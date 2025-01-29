<template>


  <!--  Key Container  -->
  <v-container padding="2px">
    <easy-data-table :headers="headers" :items="items" @click-row="onRowClick" @dblclick-row="onRowDblClick"
      @click-cell="onCellClick" @hover-row="onRowHover" @sort="onSort" @page-change="onPageChange"
      table-class-name="customize-table">

      <template #operation="{ resourceName }">
        <v-btn> {{ resourceName }} </v-btn>
      </template>

      <template #item-indicator-weight="{ item }">
        {{ item.indicator.weight }} (lbs)
      </template>
    </easy-data-table>
  </v-container>

</template>

<script lang="ts">


import type { Header, Item } from "vue3-easy-data-table";
import { defineComponent, ref } from "vue";


export default defineComponent({
  name: "DataTableComponent",
  components: {
 
  },
  setup() {

  },
  data() {
    return {

      rows: [{
        name: "1",
        details: "Item 1",
      }],
      exportOptions: [
        "Excel",
        "Word", "XML",
      ],
      headers: [
        { text: "RESOURCE NAME", value: "resourceName" },
        { text: "RESOURCE TYPE", value: "resourceType" },
        { text: "FILE SIZE", value: "fileSize" },
        { text: "LOCATION", value: "location" },
        { text: "CONTAINER", value: "container" },
        { text: "LAST MODIFIED", value: "lastModified", sortable: true },
        { text: "CHECKSUM", value: "checksum" },
        { text: "Operation", value: "operation" },
      ] as Header[],
      items: [
        { "id": 1, "resourceName": "nwn_base.bif", "resourceType": "BIF", "fileSize": "1.2GB", "location": "/data/bifs/", "container": "chitin.key", "lastModified": "2023-10-15", "checksum": "a1b2c3d4" },
        { "id": 2, "resourceName": "dialog.tlk", "resourceType": "TLK", "fileSize": "45MB", "location": "/data/", "container": "chitin.key", "lastModified": "2023-10-15", "checksum": "e5f6g7h8" },
        { "id": 3, "resourceName": "textures.bif", "resourceType": "BIF", "fileSize": "2.1GB", "location": "/data/bifs/", "container": "chitin.key", "lastModified": "2023-10-15", "checksum": "i9j0k1l2" },
        { "id": 4, "resourceName": "scripts.bif", "resourceType": "BIF", "fileSize": "156MB", "location": "/data/bifs/", "container": "chitin.key", "lastModified": "2023-10-15", "checksum": "m3n4o5p6" },
      ] as Item[],
    };
  },
  methods: {
    onSort(event: { value: string; order: string }) {
      console.log("Sort event:", event);
    },
    onRowClick(row: Item) {
      console.log("Row clicked:", row);
    },
    onRowDblClick(row: Item) {
      console.log("Row double-clicked:", row);
    },
    onCellClick(row: Item, column: Header) {
      console.log("Cell clicked - Row:", row, "Column:", column);
    },
    onRowHover(row: Item) {
      console.log("Row hovered:", row);
    },
    onPageChange(page: number) {
      console.log("Page changed to:", page);
    },
  },
});
</script>


<style scoped lang="scss">
.v-data-table {
  border: 0px solid #ccc !important;
  border-radius: 0px !important;
  overflow: hidden !important;
}


.v-data-table__wrapper {
  background-color: #f9f9f9 !important;
  padding: 2px !important;
}

.v-data-table thead {
  background-color: #e0e0e0 !important;
  font-weight: lighter !important;
}

.v-data-table th {
  color: #333 !important;
  padding: 18px 8px !important;
  text-align: left !important;
  font-weight: lighter !important;
}

.v-data-table td {
  padding: 10px 8px !important;
  color: #555 !important;
  border-top: 3px solid #ddd !important;
}

.v-data-table tbody tr:hover {
  background-color: #f1f1f1 !important;
  cursor: crosshair !important;
}


$easy-table-border: 1px solid #445269;

.customize-table {
  font-family: 'Inter', sans-serif;
  font-weight: lighter !important;
  border-radius: 8px !important;

  --easy-table-border: 1px solid #1a192b;
  --easy-table-row-border: 1px solid #1a192b;

  --easy-table-header-font-size: 14px;
  --easy-table-header-height: 50px;
  --easy-table-header-font-color: rgba(255, 255, 255, 0.9);
  --easy-table-header-background-color: #1a192b;

  --easy-table-header-item-padding: 10px 12px;

  --easy-table-body-even-row-font-color: rgba(255, 255, 255, 0.7);
  --easy-table-body-even-row-background-color: #1a192b;

  --easy-table-body-row-font-color: rgba(255, 255, 255, 0.7);
  --easy-table-body-row-background-color: black;
  --easy-table-body-row-height: 42px;
  --easy-table-body-row-font-size: 12px;

  --easy-table-body-row-hover-font-color: rgba(255, 255, 255, 0.9);
  --easy-table-body-row-hover-background-color: #2a2941;

  --easy-table-body-item-padding: 2px 15px;

  --easy-table-footer-background-color: #1a192b;
  --easy-table-footer-font-color: rgba(255, 255, 255, 0.7);
  --easy-table-footer-font-size: 13px;
  --easy-table-footer-padding: 0px 10px;
  --easy-table-footer-height: 50px;

  --easy-table-rows-per-page-selector-width: 70px;
  --easy-table-rows-per-page-selector-option-padding: 10px;
  --easy-table-rows-per-page-selector-z-index: 1;

  --easy-table-scrollbar-track-color: #1a192b;
  --easy-table-scrollbar-color: black;
  --easy-table-scrollbar-thumb-color: rgba(255, 255, 255, 0.3);
  --easy-table-scrollbar-corner-color: #1a192b;

  --easy-table-loading-mask-background-color: rgba(0, 0, 0, 0.8);
}


.v-toolbar {
  border-radius: 8px !important;
  box-shadow: none !important;
  padding: 4px 8px !important;
  background: linear-gradient(to right, rgba(31, 31, 31, 0.8), rgba(31, 31, 31, 0.4)) !important;
}

.v-toolbar__content {
  min-height: 52px !important;
  padding: 0 8px !important;
  font-weight: lighter !important;
}

.v-toolbar__title {
  font-size: 16px !important;
  font-weight: 300 !important;
  color: inherit !important;
}

.v-toolbar__prepend,
.v-toolbar__append {
  margin: 0 4px !important;
}

.v-toolbar--density-compact {
  height: 50px !important;
  font-weight: lighter !important;
  background: linear-gradient(to right, rgba(31, 31, 31, 0.8), rgba(31, 31, 31, 0.4)) !important;
}

.v-toolbar--border {
  border-bottom: 1px solid rgba(0, 0, 0, 0.12) !important;
}
</style>