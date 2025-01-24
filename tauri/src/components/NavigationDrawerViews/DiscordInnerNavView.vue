<template>
  <aside class="servers">
    <div class="servers-collection">
      <div class="server focusable server-friends unread" role="button" aria-label="Friends unread">
        <div class="server-icon">
          <svg>
            <use xlink:href="#icon-friends"/>
          </svg>
        </div>
      </div>
    </div>

    <div class="servers-collection">
      <div class="server focusable unread" role="button" aria-label="Discord Developers unread">
        <div class="server-icon"><img
          src="/aurora-studio-vue/src/assets/game_icons/kotor-1-icon.png" alt=""/></div>
      </div>
    </div>

    <div class="servers-collection">
      <div class="server focusable active" role="button" aria-label="My Server" aria-selected="true">
        <div class="server-icon"><img src="https://discordapp.com/assets/0e291f67c9274a1abdddeb3fd919cbaa.png"/></div>
      </div>
    </div>
  </aside>
</template>

<script lang="ts">
import { DirectoryService } from '@/data/directory-service';
import { onMounted } from 'vue';

export default {
  name: "DiscordInnerNavView"
}



const $ = document.querySelectorAll.bind(document);

$(".focusable, .button").forEach(el => {
  // blur only on mouse click
  // for accessibility, keep focus when keyboard focused

  el.addEventListener("mousedown", e => e.preventDefault());
  el.setAttribute("tabindex", "0");
});

$(".server").forEach(el => {
  el.addEventListener("click", () => {
    const activeServer = $(".server.active")[0];
    activeServer.classList.remove("active");
    activeServer.removeAttribute("aria-selected");

    el.classList.add("active");
    el.setAttribute("aria-selected", true);
  });
})

$(".channel-text").forEach(el => {
  el.addEventListener("click", () => {
    $(".channel-text.active")[0].classList.remove("active");
    el.classList.add("active");
  });
})

// focus/blur on channel header click
/*
$(".channels-header")[0].addEventListener("click", e => {
  e.preventDefault();

  const focused = document.activeElement === e.target;
  //focused ? e.target.blur() : e.target.focus();
});
*/

</script>

<style scoped lang="scss">
@import url("https://fonts.googleapis.com/css?family=Roboto:300,500,700");


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


// SERVER
.server {
  width: 35px;
  height: 35px;
  border-radius: 15px;
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
