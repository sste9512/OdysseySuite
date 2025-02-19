<template>
    <div ref="containerRef"
        style="position: absolute; top: 0; left: 0; right: 0; bottom: 0; overflow: scroll; display: flex; align-items: center; justify-content: center">
        <canvas ref="canvasRef" class="checkerboard"
            :style="{ width: `${canvasWidth}px`, height: `${canvasHeight}px`, transform: `scale(${canvasScale})` }" />
    </div>
</template>

<script lang="ts">
import { defineComponent, ref, watch } from 'vue';
import { TGAObject } from '@/components/ThreeRendering/resource/TGAObject';
import { TgaLoader } from 'tga-js';

export default defineComponent({
    name: 'TgaImageViewer',
    props: {
        filename: {
            type: String,
            required: false,
            default: 'test.tga'
        },
        bytes: {
            type: Uint8Array,
            required: true
        },
        height: {
            type: Number,
            required: false,
            default: 512
        },
        width: {
            type: Number,
            required: false,
            default: 512
        }
    },
    setup(props) {
        const tga = new TgaLoader();

        const buffer = new Uint8Array(props.bytes);

        tga.load(new Uint8Array(buffer));
        document.body.appendChild(tga.getCanvas());
    }
});
</script>

<style scoped>
.checkerboard {
    background-image: linear-gradient(45deg, #808080 25%, transparent 25%),
        linear-gradient(-45deg, #808080 25%, transparent 25%),
        linear-gradient(45deg, transparent 75%, #808080 75%),
        linear-gradient(-45deg, transparent 75%, #808080 75%);
    background-size: 20px 20px;
    background-position: 0 0, 0 10px, 10px -10px, -10px 0px;
}
</style>
