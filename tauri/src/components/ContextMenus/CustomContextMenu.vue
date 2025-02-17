<script setup lang="ts">

import {onMounted, ref} from "vue";

const contextVisible = ref(true);

defineProps<{
  caller: string;
}>();

const handleRightClick = (e: MouseEvent) => {
  e.preventDefault();

  const $context = document.querySelector<HTMLElement>(".context:not(.context--sub)");
  const $sub = $context?.querySelector<HTMLElement>(".context--sub");
  const $window = window;

  if ($context && $sub) {
    $sub.classList.remove("oppositeX", "oppositeY");
    const w = $context.offsetWidth;
    const h = $context.offsetHeight;
    const x = e.clientX;
    const y = e.clientY;
    const ww = $window.innerWidth;
    const wh = $window.innerHeight;
    const padx = 30;
    const pady = 20;
    let fx = x;
    let fy = y;
    const hitsRight = x + w >= ww - padx;
    const hitsBottom = y + h >= wh - pady;

    if (hitsRight) {
      fx = ww - w - padx;
    }

    if (hitsBottom) {
      fy = wh - h - pady;
    }

    $context.style.left = `${fx - 1}px`;
    $context.style.top = `${fy - 1}px`;

    const sw = $sub.offsetWidth;
    const sh = $sub.offsetHeight;
    const sx = $sub.getBoundingClientRect().left;
    const sy = $sub.getBoundingClientRect().top;
    const subHitsRight = sx + sw - padx >= ww - padx;
    const subHitsBottom = sy + sh - pady >= wh - pady;

    if (subHitsRight) {
      $sub.classList.add("oppositeX");
    }

    if (subHitsBottom) {
      $sub.classList.add("oppositeY");
    }

    contextVisible.value = true;

    const handleMouseDown = (event: MouseEvent) => {
      const $tar = event.target as HTMLElement;

      if (
          !$tar.isSameNode($context) &&
          !$tar.closest(".context")
      ) {
        contextVisible.value = false;
        document.removeEventListener("mousedown", handleMouseDown);
      }
    };

    document.addEventListener("mousedown", handleMouseDown);
  }
};

const handleContextItemClick = (e: MouseEvent) => {
  const $item = e.currentTarget as HTMLElement;
  if (e.button === 0 && !$item.classList.contains("context__item--nope")) {
    $item.classList.remove("context__item--active");
    setTimeout(() => {
      $item.classList.add("context__item--active");
    }, 10);
  }
};

onMounted(() => {
  //document.addEventListener("contextmenu", handleRightClick);

  // setTimeout(() => {
  //   const $doc = document.querySelector<HTMLElement>(document.body);
  //   const $context = document.querySelector<HTMLElement>(".context");
  //   if ($doc && $context) {
  //     handleRightClick(new MouseEvent("contextmenu", {clientX: 32, clientY: 120}));
  //     $context.style.left = "32px";
  //     $context.style.top = "120px";
  //     contextVisible.value = true;
  //   }
  // }, 1000);
});

</script>

<template>


 
  <ul class="context">
    <li class="context__header">Share</li>

    <li class="context__item context__item--twitter">
      <a href="#"><i class="pre entypo-twitter"></i> Tweet this</a>
    </li>

    <li class="context__item context__item--facebook">
      <a href="#"><i class="pre entypo-facebook-squared"></i> Post to Facebook</a>
    </li>

    <li class="context__item context__item--google context__item--nope">
      <a href="#" title="lol, not likely">Post to Google+</a>
    </li>

    <li class="context__item context__item--pinterest">
      <a href="#"><i class="pre entypo-pinterest"></i> Pin this</a>
    </li>

    <li class="context__divider"></li>

    <li class="context__item context__item--email">
      <a href="#"><i class="post entypo-right-open"></i> Email to a friend</a>
    </li>

    <ul class="context context--sub">
      <li class="context__item">
        <a href="#">Anita</a>
      </li>
      <li class="context__item">
        <a href="#"><i class="pre entypo-check"></i> Jennifer</a>
      </li>
      <li class="context__item">
        <a href="#">Dave</a>
      </li>
      <li class="context__item">
        <a href="#">Hiro</a>
      </li>
      <li class="context__item">
        <a href="#">Yoona</a>
      </li>
    </ul>

    <li class="context__item context__item--email">
      <a href="#">Save for later</a>
    </li>
  </ul></template>

<style scoped lang="scss">
@import url(https://fonts.googleapis.com/css?family=Lato:300,300italic,700,700italic);



h1 {
  margin: 30px 30px 0.2em;
  font-weight: 300;
  color: #7E84B8;

  user-select: none;

  strong {
    font-weight: 700;
    color: #ACB3EA;
  }
}

p {
  margin: 0 32px;
  color: #9aa1d6;
  user-select: none;
}

.context {

  &, & * {
    user-select: none;
    cursor: default;
  }

  font-size: 14px;

  color: #D0C7FF;
  list-style: none;
  margin: 0;
  padding: 0.05em 0.25em;


  border: 1px solid transparent;
  border-right-color: lighten( #3F51B5, 6% );
  border-bottom-color: lighten( #3F51B5, 6% );
  border-radius: 3px;

  position: absolute;
  min-width: 16em;
  z-index: 1;

  background: linear-gradient( 145deg, #673AB7, #3F51B5 );
  box-shadow: 0 4px 14px -5px #141321;

  will-change: transform, opacity;
  opacity: 1;


  &--sub {

    background: #4b4ab6;
    width: auto;
    min-width: 10em;
    left: 100%;
    overflow: hidden;

    .context__item {

      padding-left: 2em;

    }

    i[class*="entypo-"] {

    }

    &.oppositeX {

      right: 100%;
      left: auto;

    }

    &.oppositeY {

      top: auto;
      bottom: -0.4em;

    }

  }

  &__header,
  &__item {

    padding: 0.3em 1.5em 0.35em 2.5em;

  }

  &__header,
  &__divider {

    margin-top: 0.25em;
    margin-bottom: 0.25em;
    border-bottom: 1px solid rgba( #D0C7FF, 0.3 );

  }

  &__header {

    font-weight: 700;
    padding-bottom: 0.5em;

  }

  &__item {

    border-radius: 3px;
    position: relative;

    &:not( &--nope ):hover {

      background-color: rgba( white, 0.09 );
      color: white;

      .context--sub {

        opacity: 1;
        border-radius: 0 3px 3px 3px;
        visibility: visible;

      }

    }

    &:last-child {

      margin-bottom: 0.25em;

    }

    &:first-child {

      margin-top: 0.25em;

    }

    &--nope {

      color: rgba( white, 0.3 );

    }

    &--active {

      animation: flash 0.5s ease 1;

    }

  }

  a {

    cursor: default;
    color: inherit;
    text-decoration: none;
    display: block;

  }

  [class*="entypo-"] {

    font-style: normal;
    position: absolute;
    width: 2em;
    text-align: right;

    &.post {
      right: 0;
      top: 50%;
    }

    &:before {
      font-family: 'entypo', sans-serif;
      margin-right: 0.5em;
    }

  }

}

@keyframes flash {

  0% {
    background: rgba( white, 0 );
  }
  20% {
    background: rgba( white, 0.4 );
  }

}










font-face {
  font-family: 'entypo';
  font-style: normal;
  font-weight: 400;
  src: url( "data:application/font-woff;base64,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" );

}
</style>