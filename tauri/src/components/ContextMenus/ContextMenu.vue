<template>

  <div
    class="context-menu mx-auto"
    v-show="show"
    :style="style"
    ref="context"
    tabindex="0"
    @blur="close"
  >
    <slot></slot>
  </div>


</template>

<script lang="js">

import {nextTick} from "vue";

export default {
  name: 'ContextMenu',
  setup() {

  },
  props: {
    display: Boolean,
    background: String// prop detect if we should show context menu
  },
  data() {
    return {
      left: 0, // left position
      top: 0, // top position
      show: false, // affect display of context menu
    };
  },
  computed: {
    // get position of context menu
    style() {
      return {
        top: this.top + 'px',
        left: this.left + 'px',
      };
    },
  },
  methods: {
    // closes context menu
    close() {
      this.show = false;
      this.left = 0;
      this.top = 0;
    },
    open(evt) {
      // updates position of context menu
      this.left = evt.pageX || evt.clientX;
      this.top = evt.pageY || evt.clientY;
      // make element focused
      // @ts-ignore
      nextTick(() => this.$el.focus());
      this.show = true;
    },
  },
};
</script>

<style scoped>

.context-menu {
  position: fixed;
  z-index: 99999999;
  cursor: pointer;
  border-radius: 3px;
}
</style>
