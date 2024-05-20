<template xmlns="http://www.w3.org/1999/html">

  <v-app-bar
    color="teal-darken-4"
    image="https://picsum.photos/1920/1080?random"
    @click.right="openContextMenu"
    density="compact"
  >
    <template v-slot:image>
      <v-img
        gradient="to top right, rgba(19,84,122,.8), rgba(128,208,199,.8)"
      ></v-img>
    </template>

    <template v-slot:prepend>
      <v-app-bar-nav-icon @click.stop="toggle"></v-app-bar-nav-icon>
    </template>

    <v-app-bar-title>Aurora Studio</v-app-bar-title>

    <v-spacer></v-spacer>

    <v-tabs
      v-model="currentItem"
      fixed-tabs
    >
      <v-tab
        v-for="item in items2"
        :key="item"
        class="text-caption"
        :value="'tab-' + item"
        :ripple="false">
        <v-divider color="white"></v-divider>
        {{ item }}
       <v-btn prepend-icon="mdi-close" size="x-small">

       </v-btn>
      </v-tab>

      <v-menu
        v-if="more.length"
      >
        <template v-slot:activator="{ props }">
          <v-btn
            variant="plain"
            rounded="10"
            class="align-self-center me-4"
            height="100%"
            v-bind="props"
          >
            more
            <v-icon end>
              mdi-menu-down
            </v-icon>
          </v-btn>
        </template>

        <v-list class="bg-grey-lighten-3">
          <v-list-item
            v-for="item in more"
            :key="item"
            @click="addItem(item)"
          >
            {{ item }}
          </v-list-item>
        </v-list>
      </v-menu>
    </v-tabs>

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
    <v-sheet
      elevation="12"
      max-width="600"
      rounded="lg"
      width="100%"
      class="pa-4 text-center mx-auto glass"
    >
      <v-icon
        class="mb-5"
        color="success"
        icon="mdi-check-circle"
        size="112"
      ></v-icon>

      <h2 class="text-h5 mb-6">You reconciled this account</h2>

      <p class="mb-4 text-medium-emphasis text-body-2">
        To see a report on this reconciliation, click <a href="#" class="text-decoration-none text-info">View
        reconciliation report.</a>

        <br>

        Otherwise, you're done!
      </p>

      <v-divider class="mb-4"></v-divider>

      <div class="text-end">
        <v-btn
          class="text-none"
          color="success"
          rounded
          variant="flat"
          width="90"
        >
          Done
        </v-btn>
      </div>
    </v-sheet>

  </ContextMenu>


</template>

<script>


import ContextMenu from "../ContextMenus/ContextMenu.vue";
import GlowingAuraSpinner from "../LoadingSpinners/GlowingAuraSpinner.vue";

import router from "../../navigation/base-router.ts";

export default {
  name: "AuroraAppBar",
  components: {ContextMenu},
  setup() {

    return {
      showContextMenu: false
    }
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
    addItem (item) {
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
        {title: 'Click Me'},
        {title: 'Click Me'},
        {title: 'Click Me'},
        {title: 'Click Me 2'},
      ],
      currentItem: 'tab-chitin.key',
      items2: [
        'chitin.key', 'swpc_tex_gui', 'swpc_tex_gui', 'swpc_tex_gui',
      ],
      more: [
        'swpc_tex_gui', 'swpc_tex_gui', 'swpc_tex_gui', 'swpc_tex_gui', 'swpc_tex_gui',
      ],
      text: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.',
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

.bottom-border-line {
  border-bottom: white;
  border-bottom-width: 10px;
}

</style>
