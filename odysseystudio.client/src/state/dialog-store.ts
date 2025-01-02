import { defineStore } from "pinia";
import { ref } from "vue";

export const useDialogStore = defineStore("dialog", () => {
  // Dialog visibility states
  const gameSetupDialog = ref(false);
  const globalCommandsDialog = ref(false);
  const profileDialog = ref(false);
  const settingsDialog = ref(false);

  // Toggle functions
  function toggleGameSetupDialog() {
    gameSetupDialog.value = !gameSetupDialog.value;
  }

  function toggleGlobalCommandsDialog() {
    globalCommandsDialog.value = !globalCommandsDialog.value;
  }

  function toggleProfileDialog() {
    profileDialog.value = !profileDialog.value;
  }

  function toggleSettingsDialog() {
    settingsDialog.value = !settingsDialog.value;
  }

  // Direct state setters
  function setGameSetupDialog(value: boolean) {
    gameSetupDialog.value = value;
  }

  function setGlobalCommandsDialog(value: boolean) {
    globalCommandsDialog.value = value;
  }

  function setProfileDialog(value: boolean) {
    profileDialog.value = value;
  }

  function setSettingsDialog(value: boolean) {
    settingsDialog.value = value;
  }

  function closeAllDialogs() {
    gameSetupDialog.value = false;
    globalCommandsDialog.value = false;
    profileDialog.value = false;
    settingsDialog.value = false;
  }

  return {
    // States
    gameSetupDialog,
    globalCommandsDialog,
    profileDialog,
    settingsDialog,

    // Toggle methods
    toggleGameSetupDialog,
    toggleGlobalCommandsDialog,
    toggleProfileDialog,
    toggleSettingsDialog,

    // Setter methods
    setGameSetupDialog,
    setGlobalCommandsDialog,
    setProfileDialog,
    setSettingsDialog,
    closeAllDialogs,
  };
});
