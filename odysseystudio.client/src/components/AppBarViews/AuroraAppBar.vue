<template>
  <v-app-bar color="teal-darken-4" @click.right="openContextMenu" density="compact"
    style="border-bottom: .8px solid white;">

    <template v-slot:image>
      <v-img gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"></v-img>
    </template>

    <template v-slot:prepend>
      <v-app-bar-nav-icon @click.stop="toggle"></v-app-bar-nav-icon>
    </template>

    <v-text-field v-model="searchQuery" prepend-inner-icon="mdi-magnify" label="Search" single-line hide-details
      density="compact" class="mx-4" style="max-width: 300px; height: calc(100% - 10px)"
      bg-color="rgba(255, 255, 255, 0.1)" variant="solo"></v-text-field>

    <v-spacer></v-spacer>

    <v-btn icon class="target-light target" @click="navigateHome">
      <v-icon>mdi-home</v-icon>
    </v-btn>

    <v-btn icon>
      <v-icon>mdi-magnify</v-icon>
    </v-btn>

    <v-btn icon>
      <v-icon>mdi-dots-vertical</v-icon>
    </v-btn>

  </v-app-bar>
  <ContextMenu :display="showContextMenu" ref="menu">

    <CustomContextMenu caller="appnavbar"></CustomContextMenu>

  </ContextMenu>


</template>

<script>


import ContextMenu from "../ContextMenus/ContextMenu.vue";

import router from "../../navigation/base-router.ts";
import * as drawerService from "effect/HashSet";
import CustomContextMenu from "@/components/ContextMenus/CustomContextMenu.vue";

export default {
  name: "AuroraAppBar",
  components: { CustomContextMenu, ContextMenu },
  setup() {


  },
  methods: {

    toggle() {
      drawerService.toggle();
    },
    openContextMenu(e) {
      console.log("This worked partially")
      e.preventDefault()
      this.showContextMenu = true;
      this.$refs.menu.open(e);
    },
    addItem(item) {
      this.tabViewStore.addTab(item);
      const removed = this.items.splice(0, 1)
      this.items.push(
        ...this.more.splice(this.more.indexOf(item), 1),
      )
      this.more.push(...removed)
      this.$nextTick(() => { this.currentItem = 'tab-' + item })
    },
    logSomething() {
      console.log("I was clicked")
    },
    navigateHome() {
      router.push("/");
    }
  },
  data() {
    return {
      showContextMenu: false,
      items: [
        {
          id: 'tab-home',
          label: 'Home',
          icon: 'home',
          closable: false,
          to: '/'
        }
      ],
      locations:
        [
          'top',
          'bottom',
          'start',
          'end',
          'center',
        ],
      location:
        'end',
    }
  },
}
</script>

<style lang="scss" scoped>
@import "@/assets/css/animations.scss";



// Override Vuetify text field styles
::v-deep(.v-text-field) {
  .v-field {
    border-radius: 3px !important;
    background: rgba(44, 39, 39, 0.911) !important;
    font-weight: lighter !important;
    width: 400px;

    &--focused {

      animation: glow 1.5s ease-in-out infinite alternate;
    }

    &__input {
      color: #fff;
      font-size: 0.9rem;
      font-weight: lighter !important;


      &::placeholder {
        color: rgba(255, 255, 255, 0.5) !important;
      }
    }

    &__outline {
      border-color: rgba(255, 255, 255, 0.1) !important;

      &--focused {
        border-color: var(--v-primary-base) !important;
      }
    }
  }

  .v-input__details {
    color: rgba(255, 255, 255, 0.6) !important;
    font-size: 0.75rem;
    margin-top: 2px;
  }

  .v-input__append,
  .v-input__prepend {
    color: rgba(255, 255, 255, 0.7) !important;
  }
}


// Override Vuetify app bar styles
::v-deep(.v-app-bar) {
  border: none;
  box-shadow: none;
  background: transparent;
  height: 15px !important;
}

::v-deep(.v-toolbar) {
  box-shadow: none !important;
}

::v-deep(.v-app-bar-title) {
  font-size: 1.1rem;
  font-weight: 500;
}

::v-deep(.v-app-bar-nav-icon) {
  color: whitesmoke;

  &:hover {
    background-color: rgba(255, 255, 255, 0.1) !important;
  }
}

::v-deep(.v-btn) {
  text-transform: none;
  letter-spacing: normal;
}

::v-deep(.v-toolbar__content) {
  padding: 0 10px;
  min-height: var(--v-app-bar-height) !important;
}

::v-deep(.v-toolbar__prepend),
::v-deep(.v-toolbar__append) {
  margin-inline: 0;
}

.bottom-border-line {
  border-bottom: white;
  border-bottom-width: 10px;
}
</style>
