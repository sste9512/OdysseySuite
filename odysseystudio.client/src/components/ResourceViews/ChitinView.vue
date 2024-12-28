<template>


     <BluePrintScaffold></BluePrintScaffold>


</template>

<script>

import BluePrintScaffold from "@/components/ResourceViews/BluePrintScaffold.vue";

export default {
   name: "ChitinView",
  components: {BluePrintScaffold},
   async setup() {

   },
   mounted() {

  }
};
</script>

<style scoped>
.games-carousel .game .game-cover {
  transition: transform 0.1s ease;
}

.games-carousel .game .game-cover:hover {
  transform: translate(5px, -5px);
  cursor: pointer;
}
.games-carousel .game .game-cover img {
  height: 100%;
  width: 100%;
}

.games-carousel .game .game-cover:hover img {
  box-shadow: -5px 5px #a970ff;
}

</style>
