<template>
  <v-layout style="border-radius: 3px" class="glass">
    <v-navigation-drawer permanent absolute class="glass">
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
            >
            </v-btn>
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

          <v-list-item-title v-text="item.text"></v-list-item-title>
        </v-list-item>
      </v-list>
    </v-navigation-drawer>

    <v-main style="height: 280px;"></v-main>
  </v-layout>
</template>
<script>
export default {
  name: 'ResourceItemContextMenu',
  props: {
    items3: {}
  }
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


// SERVERS

// CHANNELS

// MENU

// CHAT

// SERVER

// BUTTON

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
