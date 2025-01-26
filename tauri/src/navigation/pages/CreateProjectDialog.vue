<template>


  <v-card width="75%" class="pa-6">
    <v-card-title>
      <span class="text-h6">Create New Project</span>
    </v-card-title>
    <v-card-text>
      <!-- Form for creating a new project -->
      <v-form ref="form" v-model="valid" lazy-validation>
        <v-text-field v-model="projectName" label="Project Name" required :rules="[rules.required]" class="mb-4"
          clearable variant="solo"></v-text-field>

        <v-textarea v-model="projectDescription" label="Project Description" rows="4" variant="outlined"
          class="mb-4"></v-textarea>

        <v-text-field v-model="gameDirectory" label="Game Directory" required :rules="[rules.required]" variant="solo"
          class="mb-4" append-inner-icon="mdi-folder" @click:append-inner="openGameDirectoryDialog"></v-text-field>

        <v-text-field v-model="stagingDirectory" label="Staging Directory" required :rules="[rules.required]"
          variant="solo" class="mb-4" append-inner-icon="mdi-folder"
          @click:append-inner="openStagingDirectoryDialog"></v-text-field>
      </v-form>
    </v-card-text>

    <v-overlay :model-value="isLoading" class="align-center justify-center" persistent>
      <v-card color="primary" width="300">
        <v-card-text class="text-center pa-6">
          <v-progress-circular indeterminate size="64" color="white" class="mb-4"></v-progress-circular>
          <div class="text-h6 text-white">Creating Project...</div>
          <div class="text-subtitle-1 text-white">Please wait while we set up your project</div>
        </v-card-text>
      </v-card>
    </v-overlay>


    <v-card-actions>
      <v-btn text @click="closeDialog">
        Cancel
      </v-btn>
      <v-spacer></v-spacer>
      <v-btn :disabled="!formIsValid" @click="closeDialog" text color="primary" type="submit">
        Register
      </v-btn>
    </v-card-actions>


  </v-card>
  <!-- Dialog for creating a new project -->
  <!-- <v-overlay v-model="showDirectoryViewer" class="align-center justify-center" width="75%" height="75%">
    <directory-viewer :show="showDirectoryViewer"></directory-viewer>
  </v-overlay> -->

  <v-overlay v-model="showDirectoryViewer" :scrim="true" :teleport="'body'" class=" align-center justify-center">
    <v-container
      style="overflow: hidden; margin: 15px 15px 15px 15px; max-width: 100%; min-width: 90vw; min-height: 90vh;">
      <!-- Directory content can be dynamically loaded here -->
      <DirectoryViewer :isOpen="showDirectoryViewer" 
        selectedDirectory="selectedDirectory"  @update:selectedDirectory="handleDirectoryUpdate"
        @close="handleClose"></DirectoryViewer>
    </v-container>
  </v-overlay>
</template>

<script setup lang="ts">
import { computed, ref } from "vue";
import { useProjectStore } from "@/state/project-store";
import { useDialogStore } from "@/state/dialog-store";
import DirectoryViewer from "@/features/DirectoryViewer/DirectoryViewer.vue";

const props = defineProps({
  showDialog: {
    type: Boolean,
    required: true,
  },
});

const emit = defineEmits(['update:showDialog', 'update:selectedDirectory']);


const projectName = ref("");
const projectDescription = ref("");
const showDirectoryViewer = ref(false);
const gameDirectory = ref("");
const stagingDirectory = ref("");
const valid = ref(false);
const form = ref(null);

const projectStore = useProjectStore();
const dialogStore = useDialogStore();
const selectedDirectory = ref("");
const isOpen = ref(false);
let isRequestingStagingDirectory = false;

const rules = {
  required: (value: string) =>
    !!value || "This field is required",
};

const isLoading = ref(false);

const openGameDirectoryDialog = async () => {
  console.log("Open Game Directory Dialog");
  showDirectoryViewer.value = true;
  isRequestingStagingDirectory = false;
};

const openStagingDirectoryDialog = () => {
  console.log("Open Staging Directory Dialog");
  showDirectoryViewer.value = true;
  isRequestingStagingDirectory = true;
};

const resetForm = () => {
  if (form.value) {
    form.value.reset();
  }
};
const handleDirectoryUpdate = (path: string) => {
  console.log('Selected directory:', path);
  selectedDirectory.value = path;
  if(isRequestingStagingDirectory) {
    stagingDirectory.value = path;
  } else {
    gameDirectory.value = path;
  }
  showDirectoryViewer.value = false;
};

const handleClose = () => {
  console.log('Directory viewer closed');
  showDirectoryViewer.value = false;
  gameDirectory.value = selectedDirectory.value;
};

const formIsValid = computed(() => {
  return !!projectName.value && !!gameDirectory.value && !!stagingDirectory.value;
});

const closeDialog = () => {
  projectName.value = "";
  projectDescription.value = "";
  gameDirectory.value = "";
  stagingDirectory.value = "";
  selectedDirectory.value = "";
  isOpen.value = false;
  console.log(selectedDirectory.value);
  emit('update:showDialog', false);
};

const createProject = () => {
  if (form.value?.validate()) {
    isLoading.value = true;
    projectStore.createProject({
      name: projectName.value,
      description: projectDescription.value,
      original_directory_path: gameDirectory.value,
      staging_path: stagingDirectory.value,
    });
    closeDialog();
  }
};

defineExpose({

  projectName,
  projectDescription,
  valid,
  form,
  rules,
  closeDialog,
  createProject,
  gameDirectory,
  stagingDirectory,
  openGameDirectoryDialog,
  openStagingDirectoryDialog,
  isLoading,
  handleDirectoryUpdate,
  handleClose,
});
</script>

<style scoped>
/* Change label styling for input fields */
.v-label {
  font-weight: bold;
  /* Make label bold */
  color: #1e88e5;
  /* Custom label color */
}

/* Override button styling */
.v-btn {
  border: none;
  /* Remove default button border */
  border-radius: 12px;
  /* Rounded button corners */
  text-transform: none;
  /* Remove uppercase text */
  font-weight: 600;
  /* Make text slightly bold */
  padding: 8px 16px;
  /* Adjust padding */
  transition: background-color 0.3s ease;
  /* Smooth hover transition */
}

/* Customize specific button colors based on their type */
.v-btn[color='blue darken-1'] {
  background-color: #1e88e5;
  /* Primary blue */
  color: #fff;
  /* White text */
}

.v-btn[color='blue darken-1']:hover {
  background-color: #1565c0;
  /* Darker blue on hover */
}

.v-btn[color='red'] {
  background-color: #e53935;
  /* Custom red color */
  color: #fff;
  /* White text */
}

.v-btn[color='red']:hover {
  background-color: #b71c1c;
  /* Darker red on hover */
}
</style>