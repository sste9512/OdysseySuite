<script lang="ts">
import { DirectoryService, DriveStatistics } from "@/data/directory-service.ts";
import { useDialogStore } from "@/state/dialog-store";

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
    }
  },
  setup(props) {
    const dialogStore = useDialogStore();
    return { dialogStore }
  },
  data() {
    return {
      directories: [] as string[],
      drives: [] as DriveStatistics[],
      selectedDirectory: '',
      selectedDrive: '',
      viewButtons: null as NodeListOf<Element> | null,
      filesList: null as Element | null,
      currentDirectory: null as string | null,
      previousDirectory: null as string | null,
      backBtn: null as HTMLElement | null,
      forwardBtn: null as HTMLElement | null,
      visitedDirectories: [] as string[],
      currentDirectoryIndex: -1
    }
  },
  async mounted() {
    const directoryService = new DirectoryService();
    this.directories = await directoryService.listDirectoryFromRoot();
    console.log(this.directories);

    this.drives = await directoryService.getDriveStatistics();
    console.log(this.drives);

    this.viewButtons = document.querySelectorAll('.view-btn');
    this.filesList = document.querySelector('#files-list');
    this.backBtn = document.getElementById('back-btn');
    this.forwardBtn = document.getElementById('forward-btn');

    // Add click event listeners to view buttons
    if (this.viewButtons) {
      this.viewButtons.forEach(button => {
        button.addEventListener('click', (e: Event) => {
          const target = e.currentTarget as HTMLElement;
          const view = target.dataset.view;
          if (view) {
            this.toggleView(view);
            this.setActiveViewButton(view);
          }
        });
      });
    }
  },
  methods: {
    toggleView(view: string) {
      if (!this.filesList) return;

      switch (view) {
        case 'icons':
          this.filesList.classList.add('mega-icons');
          this.filesList.classList.remove('big-icons', 'normal-icons', 'details');
          break;
        case 'big-icons':
          this.filesList.classList.add('big-icons');
          this.filesList.classList.remove('mega-icons', 'normal-icons', 'details');
          break;
        case 'normal-icons':
          this.filesList.classList.add('normal-icons');
          this.filesList.classList.remove('mega-icons', 'big-icons', 'details');
          break;
        case 'table':
          this.filesList.classList.add('details');
          this.filesList.classList.remove('mega-icons', 'big-icons', 'normal-icons');
          break;
      }
    },
    setActiveViewButton(view: string) {
      if (!this.viewButtons) return;

      this.viewButtons.forEach(button => {
        /*if (button.dataset.view === view) {
          button.classList.add('active');
        } else {
          button.classList.remove('active');
        }*/
      });
    },
    goBack() {
      if (this.previousDirectory) {
        this.navigateToDirectory(this.previousDirectory);

        const temp = this.currentDirectory;
        this.currentDirectory = this.previousDirectory;
        this.previousDirectory = temp;

        if (!this.previousDirectory && this.backBtn) {
          // this.backBtn.disabled = true;
        }

        if (this.hasNextDirectory() && this.forwardBtn) {
          // this.forwardBtn.disabled = false;
        }
      }
    },
    goForward() {
      if (this.hasNextDirectory()) {
        const nextDir = this.getNextDirectory();
        if (nextDir) {
          this.navigateToDirectory(nextDir);

          const temp = this.currentDirectory;
          this.currentDirectory = nextDir;
          this.previousDirectory = temp;

          if (!this.hasNextDirectory() && this.forwardBtn) {
            // this.forwardBtn.disabled = true;
          }

          if (this.previousDirectory && this.backBtn) {
            // this.backBtn.disabled = false;
          }
        }
      }
    },
    hasNextDirectory(): boolean {
      return this.currentDirectoryIndex < this.visitedDirectories.length - 1;
    },
    getNextDirectory(): string | null {
      if (this.hasNextDirectory()) {
        this.currentDirectoryIndex++;
        return this.visitedDirectories[this.currentDirectoryIndex];
      }
      return null;
    },
    async navigateToDirectory(directory: string) {
      console.log(directory);
      const directoryService = new DirectoryService();
      this.directories = await directoryService.listDirectory(directory);
    },
    openModal(element: string) {
      const modal = document.querySelector(element);
      if (modal) {
        modal.classList.add("modal-show");
      }
    },
    closeModal() {
      this.$emit('update:isOpen', false);
    }
  }
}
</script>

<template>
  <v-layout>


    <v-navigation-drawer location="left" width="300" elevation="4" expand-on-hover rail>
      <v-list nav dense>
        <v-list-subheader>Drives</v-list-subheader>

        <v-list-item v-for="drive in drives" :key="drive.path" :value="drive.path" :title="drive.path"
          @click="selectDrive(drive.path)">
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
          <v-btn icon>
            <v-icon>mdi-close</v-icon>
          </v-btn>

        </v-list-item>
      </v-list>
    </v-navigation-drawer>


    <v-main>


      <v-row>
        <v-btn-group>

          <!-- Back button -->
          <v-btn icon variant="text">
            <v-icon>mdi-arrow-left</v-icon>
          </v-btn>

          <!-- Forward button -->
          <v-btn icon variant="text">
            <v-icon>mdi-arrow-right</v-icon>
          </v-btn>



        </v-btn-group>

        <v-divider vertical style="margin-left: 15px; margin-right: 15px;color: rebeccapurple; width: 3px;"></v-divider>
        <!-- View mode controls for displaying directory contents -->
        <v-btn-group>
          <!-- List view button - displays items in a detailed table format -->
          <v-btn icon variant="text" @click="toggleView('table')">
            <v-icon>mdi-view-list</v-icon>
          </v-btn>

          <!-- Grid view button - displays items as medium-sized icons -->
          <v-btn icon variant="text" @click="toggleView('normal-icons')">
            <v-icon>mdi-view-grid</v-icon>
          </v-btn>

          <!-- Large grid view button - displays items as large icons -->
          <v-btn icon variant="text" @click="toggleView('big-icons')">
            <v-icon>mdi-view-grid-plus</v-icon>
          </v-btn>

        </v-btn-group>
        <v-spacer></v-spacer>

        <!-- Close button -->
        <v-btn icon variant="text" @click="toggleView('big-icons')" style="margin-top: 10px; margin-right: 13px;">
          <v-icon>mdi-close</v-icon>
        </v-btn>
      </v-row>





      <!-- another version - flat style with animated hover effect -->
      <div class="breadcrumb flat">
        <a aria-disabled="true">Browse</a>
        <a aria-disabled="true">Compare</a>
        <a aria-disabled="true">Order Confirmation</a>
        <a aria-disabled="true">Checkout</a>
      </div>



      <v-row style="padding: 0px 25px 25px 25px; min-height: 20vh;">
        <v-col v-for="item in directories" :key="item.name" cols="12" md="4" lg="4">
          <v-card @click="navigateToDirectory(item)" elevation="9">
            <v-card-title>
              <v-row>
                <v-icon color="gold" style="margin-left: 10px;">mdi-folder</v-icon>
                <v-spacer></v-spacer>
                <span style="margin-left: 10px;">{{ item.valueOf() }}</span>

                <v-spacer></v-spacer>
              </v-row>
            </v-card-title>


            <v-card-subtitle>
              <v-row>
                <v-spacer></v-spacer>
                <v-chip size="small">8 files</v-chip>
              </v-row>

            </v-card-subtitle>
          </v-card>
        </v-col>
      </v-row>
      <v-spacer style="rotate: 90deg;"></v-spacer>



    </v-main>
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
.v-main {
  padding: 0px 0px 0px 52px;
  display: flex;
  flex-direction: column;
  margin-left: 0px;
  min-height: var(--viewport-height);
  min-width: var(--viewport-width);
}

.v-main .v-container {
  flex: 1;
}

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

  border-left: 3px solid gold;
  /* Add a thin border to the left */
  padding: 10px;
}

.v-card-title {
  font-size: 16px;
  /* Set a larger font size for the title */
  font-weight: lighter;
  /* Make the title bold */
  color: lightgray;
  /* Set a dark text color for better readability */
  padding: 10px;
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