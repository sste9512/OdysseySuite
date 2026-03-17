// src/features/TwodaViewer/TwodaViewer.vue
<template>
  <div class="twoda-viewer">
    <v-card>
      <v-card-title>
        <span>{{ fileName }}</span>
        <v-spacer></v-spacer>
        <v-btn icon @click="refreshData">
          <v-icon>mdi-refresh</v-icon>
        </v-btn>
      </v-card-title>
      <v-card-text>
        <v-data-table
          :headers="tableHeaders"
          :items="tableRows"
          :items-per-page="25"
          class="elevation-1"
          dense
        >
          <template v-slot:item="{ item, index }">
            <tr>
              <td v-for="(value, key) in item" :key="key">{{ value }}</td>
            </tr>
          </template>
        </v-data-table>
      </v-card-text>
    </v-card>
  </div>
</template>

<script setup lang="ts">
import { ref, computed, onMounted, watch } from 'vue';
import { useTwodaStore } from '@/state/twoda-store';
import type { TwodaRow, TwodaCellValue } from '@/data/Twoda';

const props = defineProps({
  path: {
    type: String,
    required: true
  }
});

const twodaStore = useTwodaStore();

const fileName = computed(() => props.path.split('\\').pop() || props.path.split('/').pop() || 'Unknown');

const tableHeaders = computed(() => {
  if (!twodaStore.currentTwoda) return [];
  return twodaStore.currentTwoda.columns.map((col: string) => ({
    title: col,
    key: col,
    sortable: true
  }));
});

const tableRows = computed(() => {
  if (!twodaStore.currentTwoda) return [];
  return twodaStore.currentTwoda.rows.map(row => {
    const rowData: Record<string, any> = { RowIndex: row.index };
    row.values.forEach((value, key) => {
      rowData[key] = value ?? twodaStore.currentTwoda?.header.defaultValue ?? '';
    });
    return rowData;
  });
});

const refreshData = async () => {
  await twodaStore.loadTwoda(props.path);
};

onMounted(async () => {
  console.log('Twoda-Viewer component mounted to DOM with path:', props.path);
  await twodaStore.loadTwoda(props.path);
});

watch(() => props.path, async (newPath) => {
  console.log('Twoda-Viewer component watching path change:', newPath);
  await twodaStore.loadTwoda(newPath);
});
</script>

<style scoped>
.twoda-viewer {
  padding: 16px;
  height: 100%;
  overflow: auto;
}
</style>
