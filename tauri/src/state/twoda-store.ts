import { defineStore } from "pinia";
import { ref } from "vue";
import { Twoda, TwodaRow, TwodaCellValue } from "@/data/Twoda";
import { twodaApi } from "@/data/Twoda";
import { Result } from "@/models/Result";

export const useTwodaStore = defineStore("twoda", () => {
  // State
  const currentTwoda = ref<Twoda | null>(null);
  const filePath = ref<string | null>(null);
  const isLoading = ref(false);
  const error = ref<Error | null>(null);

  // Actions
  async function loadTwoda(path: string): Promise<Result<Twoda>> {
    isLoading.value = true;
    error.value = null;

    try {
      const result = await twodaApi.readTwoda(path);
      if (result.ok) {
        currentTwoda.value = result.value;
        filePath.value = path;
      } else {
        error.value = result.error;
      }
      return result;
    } finally {
      isLoading.value = false;
    }
  }

  function getCell(rowIndex: number, columnName: string): TwodaCellValue | undefined {
    return currentTwoda.value?.getCell(rowIndex, columnName);
  }

  function getRow(rowIndex: number): TwodaRow | undefined {
    return currentTwoda.value?.getRow(rowIndex);
  }

  function clearTwoda() {
    currentTwoda.value = null;
    filePath.value = null;
    error.value = null;
  }

  async function refreshData(): Promise<Result<Twoda> | null> {
    if (filePath.value) {
      return loadTwoda(filePath.value);
    }
    return null;
  }

  return {
    // State
    currentTwoda,
    filePath,
    isLoading,
    error,
    // Actions
    loadTwoda,
    getCell,
    getRow,
    clearTwoda,
    refreshData,
  };
});
