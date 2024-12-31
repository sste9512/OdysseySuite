<template>
  <!--  Key Container  -->
  <v-container padding="2px">




    <EasyDataTable table-class-name="customize-table" :headers="headers" :items="items" header-text-direction="center"
      body-text-direction="center" :rows-per-page="5" @click-row="onRowClick" @sort="onSort" @row-click="onRowClick"
      @row-dblclick="onRowDblClick" @cell-click="onCellClick" @row-hover="onRowHover" @page-change="onPageChange"
      border-cell />
  </v-container>

</template>

<script lang="ts">


import type { Header, Item } from "vue3-easy-data-table";
import { defineComponent } from "vue";
import TableHeaderWithActions from "./TableHeaderWithActions.vue";

export default defineComponent({
  name: "DataTableComponent",
  components: { TableHeaderWithActions },
  data() {
    return {
      exportOptions: [
        "Excel",
        "Word", "XML",
      ],
      headers: [
        { text: "PLAYER", value: "player" },
        { text: "TEAM", value: "team" },
        { text: "NUMBER", value: "number" },
        { text: "POSITION", value: "position" },
        { text: "HEIGHT", value: "indicator.height" },
        { text: "WEIGHT (lbs)", value: "indicator.weight", sortable: true },
        { text: "LAST ATTENDED", value: "lastAttended", width: 200 },
        { text: "COUNTRY", value: "country" },
      ] as Header[],
      items: [
        {
          player: "Stephen Curry",
          team: "GSW",
          number: 30,
          position: "G",
          indicator: { height: "6-2", weight: 185 },
          lastAttended: "Davidson",
          country: "USA",
        },
        {
          player: "Lebron James",
          team: "LAL",
          number: 6,
          position: "F",
          indicator: { height: "6-9", weight: 250 },
          lastAttended: "St. Vincent-St. Mary HS (OH)",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Kevin Durant",
          team: "BKN",
          number: 7,
          position: "F",
          indicator: { height: "6-10", weight: 240 },
          lastAttended: "Texas-Austin",
          country: "USA",
        },
        {
          player: "Giannis Antetokounmpo",
          team: "MIL",
          number: 34,
          position: "F",
          indicator: { height: "6-11", weight: 242 },
          lastAttended: "Filathlitikos",
          country: "Greece",
        },
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

  --easy-table-border: 1px solid #3d3d3d;
  --easy-table-row-border: 1px solid #3d3d3d;

  --easy-table-header-font-size: 14px;
  --easy-table-header-height: 50px;
  --easy-table-header-font-color: #00ff87;
  --easy-table-header-background-color: #1a1a1a;

  --easy-table-header-item-padding: 10px 15px;

  --easy-table-body-even-row-font-color: #00ffe1;
  --easy-table-body-even-row-background-color: #242424;

  --easy-table-body-row-font-color: #00aaff;
  --easy-table-body-row-background-color: #121212;
  --easy-table-body-row-height: 42px;
  --easy-table-body-row-font-size: 12px;

  --easy-table-body-row-hover-font-color: #ff00e1;
  --easy-table-body-row-hover-background-color: #292929;

  --easy-table-body-item-padding: 2px 15px;

  --easy-table-footer-background-color: #1a1a1a;
  --easy-table-footer-font-color: #00afff;
  --easy-table-footer-font-size: 13px;
  --easy-table-footer-padding: 0px 10px;
  --easy-table-footer-height: 50px;

  --easy-table-rows-per-page-selector-width: 70px;
  --easy-table-rows-per-page-selector-option-padding: 10px;
  --easy-table-rows-per-page-selector-z-index: 1;

  --easy-table-scrollbar-track-color: #242424;
  --easy-table-scrollbar-color: #121212;
  --easy-table-scrollbar-thumb-color: #00ff87;
  --easy-table-scrollbar-corner-color: #242424;

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