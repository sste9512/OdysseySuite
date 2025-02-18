<script lang="ts">
import { DirectoryItem, DriveStatistics } from "@/data/directory-service";
import { useDialogStore } from "@/state/dialog-store";
import { useFileSystemStore } from "@/state/file-system-store";
import { storeToRefs } from "pinia";
import { ref } from "vue";

export default {
  name: 'DirectoryViewer',
  props: {
    isOpen: {
      type: Boolean,
      required: false
    },
    close: {
      type: Function,
      required: false
    },
    selectedDirectory: {
      type: String,
      required: false
    },
    canSelectFile: {
      type: Boolean,
      required: false
    }
  },
  emits: ['update:selectedDirectory', 'update:isOpen'],

  setup() {
    const fileSystemStore = useFileSystemStore();
    const selectedDrive = ref<DriveStatistics | null>(null);
    const selectedFile = ref<string>("");
    selectedDrive.value = fileSystemStore.drives[1];
    const { drives, currentDirectory, previousDirectory, visitedDirectories, currentDirectoryIndex } = storeToRefs(fileSystemStore);
    return { fileSystemStore, drives, currentDirectory, previousDirectory, visitedDirectories, currentDirectoryIndex, selectedDrive, selectedFile }
  },
  unmounted() {
    //this.fileSystemStore.reset();
    this.$emit('update:isOpen', false);
  },
  async mounted() {
    await this.fileSystemStore.loadDrives();
    // Only navigate if selectedDrive exists
    if (this.selectedDrive) {
      await this.fileSystemStore.navigateToDirectory(this.selectedDrive.path);
    }
  },
  methods: {
    async goBack() {
      await this.fileSystemStore.navigateToParent();
      this.$emit('update:selectedDirectory', this.currentDirectory.path);
    },
    async goForward() {
      await this.fileSystemStore.goForward();
      this.$emit('update:selectedDirectory', this.currentDirectory.path);
    },
    hasNextDirectory(): boolean {
      return this.currentDirectoryIndex < this.visitedDirectories.length - 1;
    },
    async navigateToDirectory(directory: DirectoryItem | string) {

      if (this.canSelectFile && typeof directory === "object" && directory.type === "file") {
        this.selectedFile = directory.path;
        console.log('Selected file:', this.selectedFile);
        this.selectFile();
      }

      else if (typeof directory === "string") {
        await this.fileSystemStore.navigateToDirectory(directory);
      } else {
        await this.fileSystemStore.navigateToDirectory(directory.path);
      }


    },
    closeModal() {
      this.$emit('update:isOpen', false);
    },
    selectFile() {
      this.$emit('update:selectedDirectory', this.selectedFile);
      this.closeModal();
    },
    selectDirectory() {
      if (this.canSelectFile) {
        this.$emit('update:selectedDirectory', this.selectedFile);
      } else {
        this.$emit('update:selectedDirectory', this.currentDirectory.path);
      }
      this.closeModal();
    },




    selectDrive(drive: DriveStatistics) {
      this.selectedDrive = drive;
      this.fileSystemStore.navigateToDirectory(drive.path);
    }
  }
}
</script>

<template>
  <v-layout width="90vw" height="90vh">


    <v-navigation-drawer location="left" width="300" elevation="4" expand-on-hover rail>
      <v-list nav dense>
        <v-list-subheader>Drives</v-list-subheader>

        <v-list-item v-for="drive in drives" :key="drive.path" :value="drive.path" :title="drive.path"
          @click="selectDrive(drive)">
          <template v-slot:prepend>
            <v-icon>mdi-harddisk</v-icon>
          </template>

          <template v-slot:append>
            <v-chip size="small" variant="flat" :text="`${drive.available_gb}GB free`" />
          </template>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-navigation-drawer location="right" width="300" elevation="4" rail>
      <v-list nav dense>
        <v-list-item @click="closeModal()">
          <template v-slot:prepend>
            <v-icon style="background-color: transparent;">mdi-close</v-icon>
          </template>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>
    <v-app-bar flat>
      <v-btn-group>
        <!-- Back button -->
        <v-btn icon variant="text" @click="goBack()">
          <v-icon>mdi-arrow-left</v-icon>
        </v-btn>

        <!-- Forward button -->
        <v-btn icon variant="text" @click="goForward()">
          <v-icon>mdi-arrow-right</v-icon>
        </v-btn>
      </v-btn-group>

      <v-divider vertical style="margin-left: 15px; margin-right: 15px;color: rebeccapurple; width: 3px;"></v-divider>

      <!-- View mode controls for displaying directory contents -->
      <v-btn-group>
        <!-- List view button - displays items in a detailed table format -->
        <v-btn icon variant="text">
          <v-icon>mdi-view-list</v-icon>
        </v-btn>

        <!-- Grid view button - displays items as medium-sized icons -->
        <v-btn icon variant="text">
          <v-icon>mdi-view-grid</v-icon>
        </v-btn>

        <!-- Large grid view button - displays items as large icons -->
        <v-btn icon variant="text">
          <v-icon>mdi-view-grid-plus</v-icon>
        </v-btn>
      </v-btn-group>

      <v-spacer></v-spacer>
      <div class="breadcrumb flat">
        <a aria-disabled="true">{{ currentDirectory.path }}</a>
      </div>
    </v-app-bar>


    <v-main>

      <v-row style="min-height: 20vh; max-height: 70vh; overflow-y: auto;">
        <v-col v-for="item in currentDirectory.contents" :key="item.path" cols="12" md="4" lg="4">
          <v-card @click="navigateToDirectory(item)" elevation="9">
            <v-card-title>
              <v-row>
                <v-icon color="gold" style="margin-left: 10px;" v-if="item.type === 'directory'">mdi-folder</v-icon>
                <v-icon style="margin-left: 10px;" v-else>mdi-file</v-icon>
                <v-spacer></v-spacer>
                <span style="margin-left: 10px;">{{ item.name }}</span>
                <v-spacer></v-spacer>
              </v-row>
            </v-card-title>

            <v-card-subtitle>
              <v-row style="margin-top: 5px;">
                <v-spacer></v-spacer>
                <v-chip size="small" v-if="item.type === 'directory'">{{ item.size }} items</v-chip>
                <v-chip size="small" v-else color="light-blue">{{ item.size }} bytes</v-chip>
              </v-row>
            </v-card-subtitle>
          </v-card>
        </v-col>
      </v-row>




    </v-main>
    <v-bottom-navigation>
      <v-row class="d-flex flex-row align-center" elevation="4">
        <v-icon size="small" color="grey" class="mr-2" style="margin-left: 20px;">mdi-folder-open</v-icon>
        
        <span class="text-caption text-grey" v-if="canSelectFile">{{ selectedFile }}</span>
        <span class="text-caption text-grey" v-else>{{ currentDirectory.path }}</span>
        <v-spacer></v-spacer>


        <v-btn color="success" variant="tonal" style="margin-right: 15px;" @click="selectDirectory">
          <v-icon left>
            mdi-pencil
          </v-icon>
          Select
        </v-btn>
      </v-row>
    </v-bottom-navigation>

  </v-layout>


</template>

<style scoped>
/* Viewport size variable */
:root {
  --viewport-width: 100vw;
  --viewport-height: 100vh;
}

/* Media queries to update viewport variables */
@media screen and (max-width: 960px) {
  :root {
    --viewport-width: 100vw;
    --viewport-height: 100vh;
  }
}

@media screen and (max-width: 600px) {
  :root {
    --viewport-width: 100vw;
    --viewport-height: 100vh;
  }
}

/** CSS *************************
 * Reset
 ************************************/




.v-layout {
  background-color: rgb(var(--v-theme-surface));
  /* Set a light gray background color */
  border-radius: 3px 3px 3px 3px;
  min-height: var(--viewport-height);
  /* Prevent resizing by setting minimum height */
  min-width: var(--viewport-width);
  /* Prevent horizontal resizing */
  overflow: auto;
  /* Add scrollbars if content overflows */
}

.v-overlay {
  background-color: rgba(0, 0, 0, 0.8);
}

/* Row styling overrides */
::v-deep(.v-row) {
  align-items: center;
  width: 100%;
}

.v-col {
  align-items: center;
  min-width: var(--viewport-width);
  min-height: 100vh;
  height: 100%;
  width: 100%;
}


/* Ensure proper spacing on mobile */
@media (max-width: 600px) {
  .v-row {
    padding: 4px 8px;
  }
}





/* Adjust container spacing on smaller screens */
@media (max-width: 960px) {
  .v-container {
    padding: 12px;
    margin: 0 8px;
  }
}



/* Button group styling */
::v-deep(.v-btn-group) {
  background-color: rgb(var(--v-theme-surface));
  border-radius: 4px;
  box-shadow: 0 1px 3px rgba(0, 0, 0, 0.1);
  margin-left: 10px;
  height: 55px;
}

::v-deep(.v-btn-group .v-btn) {
  height: 25px;
  min-width: 16px;
  padding: 0 8px;
  font-size: 12px;
  font-weight: 200;
  color: rgb(var(--v-theme-on-surface));
  background-color: transparent;
}

::v-deep(.v-btn-group .v-btn:hover) {
  background-color: rgba(var(--v-theme-on-surface), 0.04);
}

::v-deep(.v-btn-group .v-btn.v-btn--active) {
  background-color: rgba(var(--v-theme-primary), 0.12);
  color: rgb(var(--v-theme-primary));
}

::v-deep(.v-btn-group .v-btn:not(:last-child)) {
  border-right: 1px solid rgba(var(--v-border-color), 0.12);
}




.v-card {
  background-color: rgb(var(--v-theme-surface));
  /* Set a light gray background color for cards */
  border-radius: 3px;
  /* Slightly round the corners */
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  /* Add a light shadow for depth */

  border-left: 2px solid gold;
  /* Add a thin border to the left */
  padding: 10px;
}

.v-card-title {
  font-size: 12px;
  /* Set a larger font size for the title */
  font-weight: lighter;
  /* Make the title bold */
  color: lightgray;
  /* Set a dark text color for better readability */
  padding: 10px;
  margin-bottom: 10px;
}

.v-card-subtitle {
  font-size: 14px;
  /* Slightly increase the subtitle font size */
  font-weight: normal;
  /* Use normal font weight for subtitles */
  color: lightgray;

  height: 30px;
  padding: 0px;
}

.v-card:hover {

  transform: translateY(-2px);
  /* Add a slight hover effect */
  box-shadow: 0 8px 16px rgba(0, 0, 0, 0.15);
  /* Deepen the shadow on hover */
  transition: all 0.1s ease;
  /* Smooth hover transition */
}






.breadcrumb {
  /*centering*/
  display: inline-block;
  box-shadow: 0 0 1px 1px rgba(0, 0, 0, 0.35);
  overflow: hidden;
  border-radius: 0px 0px 0px 0px;
  /*Lets add the numbers for each link using CSS counters. flag is the name of the counter. to be defined using counter-reset in the parent element of the links*/
  counter-reset: flag;
  margin-bottom: 9px;
  background-color: rgb(var(--v-theme-surface));
  z-index: 2;
}

.breadcrumb a {
  text-decoration: none;
  outline: none;
  display: block;
  float: left;
  font-size: 12px;
  line-height: 28px;
  color: white;
  /*need more margin on the left of links to accomodate the numbers*/
  padding: 0 10px 0 20px;
  background-color: rgb(var(--v-theme-surface));
  position: relative;
  border-bottom: 1px solid rgb(var(--v-theme-surface-variant));
}

/*since the first link does not have a triangle before it we can reduce the left padding to make it look consistent with other links*/
.breadcrumb a:first-child {
  padding-left: 24px;
  border-radius: 0px 0px 0px 0px;
  color: white;
  background-color: rgb(var(--v-theme-surface));
}

.breadcrumb a:first-child:before {
  left: 14px;
}

.breadcrumb a:last-child {
  border-radius: 0 0px 0px 0;
  /*this was to prevent glitches on hover*/
  padding-right: 12px;
  color: lightgray;
  background-color: teal;
}

/*hover/active styles*/
.breadcrumb a.active,
.breadcrumb a:hover {
  background-color: rgb(var(--v-theme-surface-variant));
}

.breadcrumb a.active:after,
.breadcrumb a:hover:after {
  background-color: rgb(var(--v-theme-surface-variant));
}

/*adding the arrows for the breadcrumbs using rotated pseudo elements*/
.breadcrumb a:after {
  content: '';
  position: absolute;
  top: 0;
  right: -12px;

  /*half of square's length*/
  /*same dimension as the line-height of .breadcrumb a */
  width: 28px;
  height: 28px;
  /*as you see the rotated square takes a larger height. which makes it tough to position it properly. So we are going to scale it down so that the diagonals become equal to the line-height of the link. We scale it to 70.7% because if square's:
  length = 1; diagonal = (1^2 + 1^2)^0.5 = 1.414 (pythagoras theorem)
  if diagonal required = 1; length = 1/1.414 = 0.707*/
  transform: scale(0.707) rotate(45deg);
  /*we need to prevent the arrows from getting buried under the next link*/
  z-index: 1;
  /*background same as links but the gradient will be rotated to compensate with the transform applied*/
  background-color: rgb(var(--v-theme-surface));
  /*stylish arrow design using box shadow*/
  box-shadow:
    2px -2px 0 2px rgba(0, 0, 0, 0.4),
    3px -3px 0 2px rgba(255, 255, 255, 0.1);
  /*
    5px - for rounded arrows and
    50px - to prevent hover glitches on the border created using shadows*/
  border-radius: 0 5px 0 50px;
}

/*we dont need an arrow after the last link*/
.breadcrumb a:last-child:after {
  content: none;
}

/*we will use the :before element to show numbers*/


.flat a,
.flat a:after {
  background: rgb(var(--v-theme-surface));
  color: white;
  transition: all 0.5s;
}

.flat a:before {
  background: rgb(var(--v-theme-surface));
  box-shadow: 0 0 0 1px #ccc;
}

.flat a:hover,
.flat a.active,
.flat a:hover:after,
.flat a.active:after {
  background: rgb(var(--v-theme-surface-variant));
}
</style>