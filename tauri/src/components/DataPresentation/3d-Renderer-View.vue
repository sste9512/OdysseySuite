<template>
  <div class="UI3DRendererView-container" style="containerStyle">
    <canvas ref="canvasRef" class="UI3DRendererView-canvas" tabindex="1" />
    <slot></slot>
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, onUnmounted, ref, watch } from 'vue';
import {UI3DRenderer} from "@/components/ThreeRendering/UI3DRenderer";

export default defineComponent({
  name: 'UI3DRendererView',
  props: {
    context: {
      type: UI3DRenderer,
      required: true
    },
    onMouseWheel: {
      type: Function,
      required: false
    },
  },
  setup(props) {
   
    const canvasRef = ref<HTMLCanvasElement | null>();
    const containerStyle = {
      position: 'absolute',
      top: 0,
      left: 0,
      right: 0,
      bottom: 0
    };

    const onMouseWheelHandler = (e: WheelEvent) => {
      if (typeof props.onMouseWheel === 'function') {
        props.onMouseWheel(e);
      }
    };

    onMounted(() => {
      // if (!(props.context instanceof UI3DRenderer)) {
      //   props.context = new UI3DRenderer(canvasRef.value as HTMLCanvasElement);
      // }
     
      if (canvasRef.value) {
        console.log('Setting canvas on UI3DRenderer context');
        props.context.setCanvas(canvasRef.value);
        
        console.log('Generating and setting UUID for canvas');
        canvasRef.value.dataset.uuid = crypto.randomUUID();
        
        console.log('Adding wheel event listener to canvas'); 
        canvasRef.value.addEventListener('wheel', onMouseWheelHandler);
      }
    });

    onUnmounted(() => {
      console.log('Cleaning up UI3DRenderer');
      if (props.context) {
        console.log('Disposing of controls');
        // Access controls through public method since it's private
        props.context.disposeControls();
      }
      
      if (canvasRef.value) {
        console.log('Removing wheel event listener');
        canvasRef.value.removeEventListener('wheel', onMouseWheelHandler);
      }
    });

    watch(() => canvasRef.value, (newCanvas) => {
      if (newCanvas) {
        console.log('Canvas ref changed, updating UI3DRenderer canvas');
        props.context.setCanvas(newCanvas);
      }
    });

    return {
      canvasRef,
      containerStyle
    };
  }
});
</script>
