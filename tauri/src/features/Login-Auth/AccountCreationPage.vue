<template>
  <h1>Aurora</h1>
  <div></div>
  <div></div>
  <div></div>
</template>

<script>
export default {
  name: "AccountCreationPage"
};
</script>

<style scoped lang="less">
@diameter: 45vmax;

body {
  background: #000;
}

h1 {
  position: absolute;
  width: 100%;
  text-align: center;
  top: 48vh;
  color: #fff;
  font-family: 'Trebuchet MS', Helvetica, sans-serif;
  letter-spacing: .7em;
  font-size: 20pt;
  font-weight: normal;
  opacity: .2;
  text-transform: uppercase;
}

div {
  position: absolute;
  width: .001vmin;
  height: .001vmin;
  border-radius: 50%;
  opacity: .25;
}

div:nth-child(2) {
  box-shadow: 0 0 @diameter @diameter magenta;
  animation:
    hue 10s 0s linear infinite,
    move1 19s 0s linear infinite;
}

div:nth-child(3) {
  box-shadow: 0 0 @diameter @diameter white;
  animation:
    hue 15s 0s linear infinite,
    move2 25s 0s linear infinite;
}

div:nth-child(4) {
  box-shadow: 0 0 @diameter @diameter cyan;
  animation:
    hue 20s 0s linear infinite,
    move3 15s 0s linear infinite;
  opacity: .2;
}

@keyframes hue {
  0% {
    filter: hue-rotate(0deg);
  }

  100% {
    filter: hue-rotate(360deg);
  }
}

@keyframes move1 {
  0% {
    top: 0vh;
    left: 50vw;
  }

  25% {
    left: 0vw;
  }

  50% {
    top: 100vh;
  }

  75% {
    left: 100vw;
  }

  100% {
    top: 0vh;
    left: 50vw;
  }
}

@keyframes move2 {
  0% {
    top: 50vh;
    left: 100vw;
  }

  25% {
    top: 100vh;
  }

  50% {
    left: 0vw;
  }

  75% {
    top: 0vh;
  }

  100% {
    top: 50vh;
    left: 100vw;
  }
}

@keyframes move3 {
  0% {
    top: 100vh;
    left: 50vw;
  }

  25% {
    left: 100vw;
  }

  50% {
    top: 0vh;
  }

  75% {
    left: 0vw;
  }

  100% {
    top: 100vh;
    left: 50vw;
  }
}
</style>
