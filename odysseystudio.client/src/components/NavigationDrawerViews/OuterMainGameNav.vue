<template>

  <main class="container">

    <aside class="channels">
      <header class="channels-header focusable">

        <h3 role="header" class="channels-header-name">Game Resources</h3>
        <svg role="button" aria-label="Dropdown" class="channels-header-dropdown">
          <use xlink:href="#icon-dropdown"/>
        </svg>
      </header>

      <!-- Chitin Key Section--->
      <section class="channels-list">
        <header class="channels-list-header focusable">
          <h5>Chitin Key Resources</h5>
        </header>


        <ul class="channels-list-text">

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>

            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" v-ripple @click="navigateToResourceView"
                  @click.right="openContextMenu">
                <span class="channel-name">chitin.key</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>

          </v-tooltip>
        </ul>


        <!-- ERF Section--->

        <header class="channels-list-header focusable">
          <h5>ERFResources</h5>
        </header>

        <ul class="channels-list-text">

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>
            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" @click="navigateToResourceView">
                <span class="channel-name">swpc_tex_gui</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>
          </v-tooltip>

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>
            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" @click="navigateToResourceView">
                <span class="channel-name">swpc_tex_tpa</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>
          </v-tooltip>

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>
            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" @click="navigateToResourceView">
                <span class="channel-name">swpc_tex_tpb</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>
          </v-tooltip>

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>
            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" @click="navigateToResourceView">
                <span class="channel-name">swpc_tex_tpc</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>
          </v-tooltip>
        </ul>


        <!-- BIFF Section--->

        <header class="channels-list-header focusable">
          <h5>BIFF Resources</h5>
        </header>


        <ul class="channels-list-text">
          <li class="channel focusable channel-text">
            <span class="channel-name">general</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>

          <li class="channel focusable channel-text">
            <span class="channel-name">help</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>
        </ul>


        <!-- GFF Section--->

        <header class="channels-list-header focusable">
          <h5>GFF Resources</h5>
        </header>


        <ul class="channels-list-text">
          <li class="channel focusable channel-text">
            <span class="channel-name">general</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>

          <li class="channel focusable channel-text">
            <span class="channel-name">help</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>
        </ul>


        <header class="channels-list-header focusable">
          <h5>RIM Resources</h5>
        </header>


        <ul class="channels-list-text">
          <li class="channel focusable channel-text">
            <span class="channel-name">general</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>

          <li class="channel focusable channel-text">
            <span class="channel-name">help</span>
            <button class="button" role="button" aria-label="Invite">
              <svg>
                <use xlink:href="#icon-invite"/>
              </svg>
            </button>
            <button class="button" role="button" aria-label="settings">
              <svg>
                <use xlink:href="#icon-channel-settings"/>
              </svg>
            </button>
          </li>
        </ul>

        <header class="channels-list-header focusable">
          <h5>UTF Resources</h5>
        </header>


        <ul class="channels-list-text">

          <v-tooltip text="Tooltip" location="bottom" open-delay="6" open-on-hover>

            <template v-slot:activator="{ props }">
              <li class="channel focusable channel-text" v-bind="props" @click="navigateToResourceView"
                  @click.right="openContextMenu">
                <span class="channel-name">chitin.key</span>
                <v-spacer></v-spacer>
                <button style="margin-right:9px">
                  <v-icon icon="mdi-export" size="x-small" class="float-right"></v-icon>
                </button>
                <button style="margin-right: 10px">
                  <v-icon icon="mdi-cog" size="x-small" class="float-right"></v-icon>
                </button>
              </li>
            </template>

          </v-tooltip>
        </ul>

      </section>


    </aside>

  </main>

  <ContextMenu :display="showContextMenu" ref="menu" class="glass">


      <v-layout style="border-radius: 3px" class="glass">
        <v-navigation-drawer permanent absolute class="glass" >
          <v-list>
            <v-list-item
              prepend-icon="mdi-cog"
              title="Open this resource"
              subtitle="john@google.com"
            >
              <template v-slot:append>
                <v-btn
                  size="small"
                  variant="text"
                  icon="mdi-menu-down"
                ></v-btn>
              </template>
            </v-list-item>
          </v-list>

          <v-divider></v-divider>

          <v-list
            :lines="false"
            density="compact"
            nav
          >
            <v-list-item
              v-for="(item, i) in items3"
              :key="i"
              :value="item"
              active-color="primary"
            >
              <template v-slot:prepend>
                <v-icon :icon="item.icon" size="x-small"></v-icon>
              </template>


              <v-menu :location="location" :close-on-content-click="false">
                <template v-slot:activator="{ props }">
                  <v-list-item-title v-text="item.text" v-bind="props"></v-list-item-title>
                </template>

                <v-list>
                  <v-list-item
                    v-for="(item, index) in items"
                    :key="index"
                  >
                    <v-list-item-title>{{ item.title }}</v-list-item-title>
                  </v-list-item>
                </v-list>
              </v-menu>
            </v-list-item>
          </v-list>
        </v-navigation-drawer>

        <v-main style="height: 280px;"></v-main>
      </v-layout>

  </ContextMenu>
</template>

<script >



import ContextMenu from "../../components/ContextMenus/ContextMenu.vue";
import router from "../../navigation/base-router.ts";

export default {
  name: "OuterMainGameNav",
  components: {ContextMenu},
  setup() {
    return {
      showContextMenu: false
    }
  },
  methods: {
    navigateToResourceView() {
      router.push({path: '/resource'});
    },
    openContextMenu(e) {
      console.log("This worked partially")
      e.preventDefault()
      this.showContextMenu = true;
      this.$refs.menu.open(e);
    },
  },

  data() {
    return {
      showContextMenu: false,
      items3: [
        { text: 'Open in Explorer', icon: 'mdi-folder' },
        { text: 'View Data', icon: 'mdi-account-multiple' },
        { text: 'Open in Editor', icon: 'mdi-star' },
        { text: 'Export', icon: 'mdi-history' },
        { text: 'Extract', icon: 'mdi-check-circle' },
      ],
      storageOptions: [
        { text: 'Google Drive', icon: 'mdi-clock' },
        { text: 'One Drive', icon: 'mdi-account' },
        { text: 'Local Files', icon: 'mdi-flag' },
      ],
      items: [
        { title: 'Click Me' },
        { title: 'Click Me' },
        { title: 'Click Me' },
        { title: 'Click Me 2' },
      ],
    }
  },
}


</script>

<style scoped lang="scss">
@import url("https://fonts.googleapis.com/css?family=Roboto:300,500,700");
/*@import '../src/renderer/src/assets/css/settings.scss';*/

$material-bg: #212121;
$body-bg: #121416;
$body-color: #FFF;
$servers-bg: #1E2124;
$channels-bg: #2E3136;
$border-accent: darken($channels-bg, 7.7%);
$chat-bg: #36393E;
$menu-bg: $chat-bg;
$server-bg: $channels-bg;
$server-bg-active: #7289DA;
$server-marker-unread: #8A8E94;
$server-marker-active: #FFF;
$button-bg: #2E3136;
$button-bg-active: lighten($button-bg, 5%);

// GLOBAL
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
  -webkit-tap-highlight-color: rgba(0, 0, 0, 0);

  // we override focus on specific elements
  &:focus {
    outline: 0;
  }
}

html, body {
  height: 100%;
  background: $body-bg;
  color: $body-color;
  font-size: 16px;
  font-family: "Roboto";
}

.main {
  width: auto;
}


.container {
  height: 100%;
  display: flex;
}

.vert-container {
  display: flex;
  flex: 1;
  flex-direction: column;
}

// SERVERS
.servers {
  height: 100%;
  background: $servers-bg;
  flex: 0 0 70px;
  display: flex;
  flex-direction: column;
  align-items: center;
  overflow-y: auto;
  padding: 18px 0 18px 0;

  // no scrollbar
  -ms-overflow-style: none;

  &::-webkit-scrollbar {
    display: none;
  }
}

// CHANNELS
.channels {
  background: $material-bg; // was channels-bg
  display: flex;
  flex-direction: column;
  flex: 0 0 100%;
  height: 100%; // needed to fully fill out the nav drawer

  .channels-header {
    cursor: pointer;
    display: flex;
    align-items: center;
    flex: 0 0 56px;
    padding: 28px 24px;
    box-shadow: 0 1px 0 darken($channels-bg, 4.1%), inset 0 -1px 0 rgba(#000, 0.1);
    transition: background 0.15s ease;

    .channels-header-dropdown {
      width: 18px;
      height: 18px;
      margin-left: auto;
      pointer-events: none;

      use {
        stroke-dasharray: 7;
        transform-origin: 50%;
        transition: stroke-dasharray 0.2s ease, transform 0.2s ease;
      }
    }

    &:hover, &:focus {
      background: darken($channels-bg, 2.5%);
    }

    &:focus use {
      stroke-dasharray: 28;
      transform: rotate(-90deg);
    }
  }

  .channels-list-text, .channels-list-voice {
    margin: 0 -20px 0 -20px;
  }

  .channels-header-name {
    font-size: 1rem;
    font-weight: 500;
  }

  .channel {
    cursor: pointer;
    display: flex;
    align-items: center;
    padding: 8px 20px 10px 20px;
    opacity: 0.6;
    width: 100%;

    .button {
      display: none;
      opacity: 0.2;

      &:hover, &:focus {
        opacity: 1;
      }
    }

    &.active, &:hover, &:focus {
      opacity: 1;

      .button {
        display: block;
      }
    }

    .channel-name {
      font-size: 0.8rem;
      font-weight: 370;
    }

    .button:first-of-type {
      margin-left: auto;
      margin-right: 8px;
    }

    .button {
      width: 16px;
      height: 16px;
    }
  }

  .channel-text {
    position: relative;

    &.active, &:hover, &:focus {
      background: linear-gradient(to right, #282b30 85%, #2e3136);
      /* background: linear-gradient(to right, #999999 85%, #000000);*/
      /*the dash on the side of the gradient*/
      &::before {
        content: " ";
        width: 2px;
        height: 100%;
        position: absolute;
        left: 0;
        background: ghostwhite;
        backdrop-filter: blur(20);
      }
    }

    &:not(.active) {
      &:focus::before, &:hover::before {
        opacity: 0.9;
      }
    }

    .channel-name {
      @extend .hash-before;

      &::before {
        font-weight: 400 !important;
      }
    }
  }

  .channels-list {
    flex: 1 1;
    overflow-y: auto;
    padding: 0 20px;

    ul {
      list-style: none;
    }

    .channels-list-header {
      cursor: pointer;
      margin-top: 20px;
      text-transform: uppercase;
      color: rgb(0 255 255);
      font-size: 0.90rem;
      letter-spacing: 0.04rem;
      transition: color 0.2s linear;
      line-height: 30px;
      position: relative;

      &:hover, &:focus {
        color: $body-color;

        &::after {
          opacity: 1;
        }
      }

      &::after {
        position: absolute;
        top: 10px;
        right: 0;
        content: " ";
        width: 10px;
        height: 10px;
        opacity: 0.3;
        transition: opacity 0.2s linear;
        background: url(data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHZpZXdCb3g9IjAgMCAxMCAxMCI+PHBhdGggZmlsbD0iI2ZmZiIgZD0iTTguOTksMy45OUg2LjAxVjEuMDFDNi4wMSwwLjQ1Miw1LjU1OCwwLDUsMFMzLjk5LDAuNDUyLDMuOTksMS4wMVYzLjk5SDEuMDFDMC40NTIsMy45OSwwLDQuNDQyLDAsNWMwLDAuNTU4LDAuNDUyLDEuMDEsMS4wMSwxLjAxSDMuOTlWOC45OUMzLjk5LDkuNTQ4LDQuNDQyLDEwLDUsMTBzMS4wMS0wLjQ1MiwxLjAxLTEuMDFWNi4wMUg4Ljk5QzkuNTQ4LDYuMDEsMTAsNS41NTgsMTAsNUMxMCw0LjQ0Miw5LjU0OCwzLjk5LDguOTksMy45OXoiLz48L3N2Zz4=) no-repeat 50%;
      }
    }
  }

  .channels-footer {
    display: flex;
    align-items: center;
    flex: 0 0 70px;
    margin-top: auto;
    background: darken($channels-bg, 2.35%);
    border-top: 1px solid $border-accent;
    padding: 0 10px;

    .channels-footer-details {
      margin-left: 10px;
    }

    .channels-footer-controls {
      margin-left: auto;
      border: 1px solid $border-accent;
      border-radius: 4px;
      display: flex;

      .button {
        display: block;
        width: 32px;
        height: 32px;

        svg {
          width: 16px;
        }

        &:hover svg, &:focus svg {
          filter: brightness(200%);
        }
      }
    }

    .avatar {
      width: 30px;
      height: 30px;
      border-radius: 50%;
    }

    .username, .tag {
      display: block;
      font-weight: 300;
    }

    .username {
      font-size: 0.9rem;
    }

    .tag {
      color: rgba($body-color, 0.45);
      font-size: 0.7rem;
    }
  }
}

// MENU
.menu {
  flex: 0 0 57px;
  padding: 0 20px 0 20px;
  background: $menu-bg;
  border-bottom: 1px solid darken($menu-bg, 2.5%);
  display: flex;
  align-items: center;

  .menu-name {
    font-weight: bold;
    font-size: 1.3rem;
    letter-spacing: 0.05rem;

    @extend .hash-before;
  }
}

.hash-before::before {
  /*content: "  - ";*/
  margin-right: 2px;
  font-weight: 300;
  color: ghostwhite;
}

// CHAT
.chat {
  background: $chat-bg;
  flex: 1;
}

// SERVER
.server {
  width: 50px;
  height: 50px;
  border-radius: 25px;
  background-color: $server-bg;
  background-repeat: no-repeat;
  margin-bottom: 8px;
  cursor: pointer;
  position: relative;

  &:not(.active) {
    animation: server-hover-out 0.6s ease;

    &:hover, &:focus {
      animation: server-hover-in 0.8s ease forwards;
    }
  }

  .server-icon {
    border-radius: inherit;
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .server-icon > img {
    border-radius: inherit;
    max-width: 100%;
  }

  &.server-friends {
    margin-bottom: 46px;
    text-align: center;

    svg {
      max-width: 60%;
      max-height: 60%;
    }

    &.active::before {
      display: none;
    }

    &::after {
      content: "2 ONLINE";
      color: rgba($body-color, 0.3);
      pointer-events: none;
      font-weight: 300;
      font-size: 0.65rem;
      position: absolute;
      bottom: -35px;
      left: 3px;
      padding-bottom: 10px;
      border-bottom: 2px solid lighten($servers-bg, 5%);
    }
  }

  // unread/active
  &::before {
    position: absolute;
    top: 20px;
    left: -15px;
    content: " ";
    display: block;
    width: 10px;
    height: 10px;
    border-radius: 25px;
  }

  &.active {
    border-radius: 15px;
    background-color: $server-bg-active;
  }

  &.unread::before {
    background: $server-marker-unread;
  }

  &.active::before {
    background: $server-marker-active;
    height: 40px;
    top: 5px;
  }

  &.active.unread::before {
    transition: all 0.2s ease-in-out;
  }
}

// BUTTON
.button {
  background: $button-bg;
  border: 0;
  color: inherit;
  cursor: pointer;
  font: inherit;
  line-height: normal;
  overflow: visible;
  appearance: none;
  user-select: none;

  > svg, > img {
    max-width: 100%;
    max-height: 100%;
  }
}

.button-group {
  .button:focus, .button:active {
    background: $button-bg-active;
  }

  .button:not(:last-of-type) {
    border-right: 1px solid $border-accent;
  }

  .button + .button {
    box-shadow: inset 1px 0 0 #393c41;
  }
}

// ICONS
svg[id] {
  width: 0;
  position: absolute;
}

// ANIMATIONS
@keyframes server-hover-in {
  0% {
    border-radius: 25px;
    background-color: $server-bg;
  }

  40% {
    border-radius: 12px;
  }

  70% {
    border-radius: 16.7px;
  }

  80% {
    background-color: $server-bg-active;
  }

  100% {
    border-radius: 15px;
    background-color: $server-bg-active;
  }
}

@keyframes server-hover-out {
  0% {
    border-radius: 15px;
    background-color: $server-bg-active;
  }

  45% {
    border-radius: 25px;
    background-color: $server-bg;
  }

  65% {
    border-radius: 25px;
  }

  75% {
    border-radius: 23.5px;
  }

  100% {
    border-radius: 25px;
  }
}
</style>
