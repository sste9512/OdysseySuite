<template>
  <h1>SANDBOX</h1>
  <div class="desk">
    <div class="box">
      <div class="pad">
        <div class="titles pink">
          <img class="icon" src="http://vladgohn.com/park/i-run.png" />
          <div class="title">Construction Script</div>
        </div>
        <div class="cols">
          <div class="col">
            <div class="port in">
              <div class="dot aqua act"></div>
              <div class="name">input1</div>
            </div>
          </div>
          <div class="col"></div>
          <div class="col">
            <div class="port out">
              <div class="name">output1</div>
              <div class="dot"></div>
            </div>
            <div class="port out">
              <div class="name">output2</div>
              <div class="dot"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="box">
      <div class="pad">
        <div class="titles blue">
          <img class="icon" src="http://vladgohn.com/park/i-func.png" />
          <div class="title">
            My Title
            <div class="subtitle">Targe is inside component</div>
          </div>
        </div>
        <div class="cols">
          <div class="col">
            <div class="port in">
              <div class="dot aqua"></div>
              <div class="name">
                Target
                <input class="input" type="text" value="self" />
              </div>
            </div>
            <div class="port in">
              <div class="dot aqua"></div>
              <div class="name">input2</div>
            </div>
          </div>
          <div class="col"></div>
          <div class="col">
            <div class="port out">
              <div class="name">output1</div>
              <div class="dot"></div>
            </div>
            <div class="port out">
              <div class="name">output2</div>
              <div class="dot"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="box">
      <div class="topper">call</div>
      <div class="pad">
        <div class="cols">
          <div class="col">
            <div class="port in">
              <div class="dot"></div>
              <div class="name">input1</div>
            </div>
            <div class="port in">
              <div class="dot"></div>
              <div class="name">input2</div>
            </div>
            <div class="port in">
              <div class="dot"></div>
              <div class="name">input2</div>
            </div>
          </div>
          <div class="col core"><span>BUNK</span></div>
          <div class="col">
            <div class="port out">
              <div class="name">output1</div>
              <div class="dot"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="box select">
      <div class="pad">
        <div class="cols">
          <div class="col">
            <div class="port out">
              <div class="name">output1</div>
              <div class="dot aqua"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: 'BluePrintScaffold'
}
</script>

<style scoped lang="scss">
$port-line-height: 1em;
$grid-bg: #2a2a2a;
$aside-dark: #272727;
$aside-pan: #404040;
$aside-text: #dcdcdc;
$pan-head-bg: #333333;
$color-bool: #8b0101;
$color-byte: #01665d;
$color-int: #21d7a4;
$color-int64: #a0d5a3;
$color-float: #98f343;
$color-name: #be78ed;
$color-string: #ea01c2;
$color-text: #d16f98;
$color-vect: #f1be25;
$color-trans: #e06401;
$color-rotat: #94a6ed;
$box-radius: 14px;
@import url('https://fonts.googleapis.com/css2?family=Bebas+Neue&display=swap');

* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html,
body {
  height: 100%;
  width: 100%;
}

body {
  font-family: 'SF Pro Text', -apple-system, BlinkMacSystemFont, Roboto, 'Segoe UI', Helvetica,
    Arial, sans-serif, 'Apple Color Emoji', 'Segoe UI Emoji', 'Segoe UI Symbol';
  font-size: 14px;
  background-color: $grid-bg;
  background-image: url('http://vladgohn.com/park/grid.png');
  background-size: 128px;
}

.desk {
  margin: 2em;
}

.box {
  cursor: pointer;
  display: inline-block;
  position: relative;

  .pad {
    overflow: hidden;
    border-radius: $box-radius;
    border: 1px solid rgba(#000, 0.6);
    box-shadow: 0 2px 1px rgba(#000, 0.3), 0 4px 3px rgba(#000, 0.2), 0 7px 8px rgba(#000, 0.1);
    color: #ededed;
    background-image: linear-gradient(0deg, rgba(#141414, 0.77) 0%, rgba(#2c2c2c, 0.42) 100%);

    &::after {
      z-index: 0;
      content: '';
      position: absolute;
      height: 100%;
      width: 100%;
      left: 0;
      top: 0;
      border-radius: $box-radius;
      box-shadow: inset 0 2px 1px rgba(#fff, 0.3), inset 0 8px 6px rgba(#fff, 0.15);
      pointer-events: none;
    }
  }

  .topper {
    background-color: aqua;
    border-radius: 8px;
    position: absolute;
    font-size: 12px;
    font-weight: 600;
    padding: 0 4px 0 3px;
    right: 20px;
    top: -0.7em;
    z-index: 1;
  }

  .titles {
    padding: 5px 10px 3px 5px;
    position: relative;
    text-shadow: 0 1px 1px #000;

    &.blue {
      background: linear-gradient(127deg, rgba(#04388f, 1) 50%, rgba(#0d00e7, 0.2) 100%);
    }

    &.pink {
      background: linear-gradient(127deg, rgba(#8f045b, 1) 50%, rgba(#e70048, 0.2) 100%);
    }

    .icon {
      display: inline-block;
      position: absolute;
      height: 16px;
      width: 16px;
      top: 5px;
    }

    .title {
      display: inline-block;
      font-size: 1em;
      font-weight: 700;
      line-height: 1em;
      margin-left: 20px;
    }

    .subtitle {
      color: rgba(#fff, 0.6);
      font-size: 0.8em;
      font-weight: 400;
      font-style: italic;
    }
  }

  .cols {
    display: table;
    width: 100%;
    font-size: 0.8em;
    // margin-bottom: .1em;
    // border: 1px solid aqua;

    .col {
      display: table-cell;
      vertical-align: top;
      // text-align: center;
      cursor: default;
      position: relative;
      // border: 1px solid green;
      padding: 3px 10px;

      &.core {
        vertical-align: middle;
        // border: 1px solid red;
        padding: 0.3em;

        span {
          font-size: 40px;
          font-family: 'Bebas Neue';
          color: rgba(#fff, 0.4);
          filter: blur(0.5px);
          // border: 1px solid red;
        }

        &:before {
          content: '';
          display: block;
          position: absolute;
          left: 0;
          top: 0;
          width: 100%;
          height: 100%;
          background-image: url('http://vladgohn.com/park/i-grid.png');
          background-repeat: no-repeat;
          background-position: center;
          background-size: contain;
          opacity: 0.3;
          // z-index: -1;
          filter: blur(3.5px);
        }
      }
    }
  }

  .port {
    // border: 1px solid red;
    line-height: 2em;
    padding: 2px 0;
    overflow: hidden;

    &.in {
      text-align: left;
    }

    &.out {
      text-align: right;
    }

    .input {
      background-color: transparent;
      color: rgba(#fff, 0.8);
      width: 2.5em;
      margin-left: 2px;
      font-size: 1em;
      padding: 0 2px;
      position: relative;
      border: 1px solid rgba(#fff, 0.3);
      border-radius: 3px;
      cursor: default;
    }

    .dot {
      display: inline-block;
      position: relative;
      line-height: inherit;
      border-radius: 50%;
      height: 11px;
      width: 11px;
      top: 1px;
      background-color: rgba(#000, 0.8);
      box-shadow: inset 0 0 0 1.5px rgba(#fff, 1);
      cursor: pointer;
      pointer-events: auto;

      &.aqua {
        background-color: rgba(#000, 0.5);
        box-shadow: inset 0 0 0 1.5px rgba(#23e3ad, 1);

        &.act {
          background-color: rgba(#23e3ad, 1);
        }
      }
    }

    .name {
      display: inline-block;
    }
  }

  &.select {
    margin: 0;
    border-radius: $box-radius + 1px;
    border: 2px solid orange;
  }
}
</style>
