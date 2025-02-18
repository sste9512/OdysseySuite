<template>

    <div ref="containerRef"
        style="position: absolute; top: 0; left: 0; right: 0; bottom: 0; overflow: scroll; display: flex; align-items: center; justify-content: center">
        <canvas ref="canvasRef" class="checkerboard"
            :style="{ width: `${canvasWidth}px`, height: `${canvasHeight}px`, transform: `scale(${canvasScale})` }" />
    </div>

</template>

<script lang="ts">
import { defineComponent, ref, onMounted, onUnmounted, computed, watch } from 'vue';

import { TPCObject } from '@/components/ThreeRendering/resource/TPCObject';
import { TGAObject } from '@/components/ThreeRendering/resource/TGAObject';
import { PixelManager } from '@/components/ThreeRendering/utility/PixelManager';

export default defineComponent({
    name: 'TpcImageViewer',
    props: {
        // data: {
        //     type: TPCObject,
        //     required: true
        // },
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
        const render = ref(false);
        const canvasScale = ref(1);
        const canvasWidth = ref(props.width);
        const canvasHeight = ref(props.height);
        const txiObject = ref<object>();
        const canvasRef = ref<HTMLCanvasElement | null>(null);
        const containerRef = ref<HTMLDivElement | null>(null);
        const tpc = ref<TPCObject>();

        const renderToCanvas = async (pixelData: Uint8Array) => {
            if (!canvasRef.value) return;
            
            const canvas = canvasRef.value;
            const ctx = canvas.getContext('2d');
            if (!ctx) return;

            const result = TPCObject.fromBytes({ filename: 'test.tpc' }, props.bytes);
            if (!result.ok) return;

            const tpcObj = result.value;
            const width = tpcObj.header.width;
            const height = tpcObj.header.height;

            // Update canvas dimensions
            canvas.width = width;
            canvas.height = height;
            canvasWidth.value = width;
            canvasHeight.value = height;

            // Create ImageData from pixel data
            const imageData = new ImageData(
                new Uint8ClampedArray(pixelData.buffer),
                width,
                height
            );

            // Clear canvas and draw new image
            ctx.clearRect(0, 0, width, height);
            ctx.putImageData(imageData, 0, 0);
        };

        const getPixelData = async (): Promise<Uint8Array> => {
            return new Promise<Uint8Array>((resolve, reject) => {

                console.log('Step 1: Starting getPixelData');
                // if (tpc.value instanceof TPCObject) {

                console.log('Step 2: Processing TPC image');
                let tpc: TPCObject;
                let dds: any;
                let imagePixels = new Uint8Array(0);
                try {
                    const result = TPCObject.fromBytes({ filename: 'test.tpc' }, props.bytes);
                    if (result.ok) {
                        tpc = result.value;
                        dds = tpc.getDDS(false);
                        const width = tpc.header.width;
                        const height = tpc.header.height;
                        const mipmapCount = 1;
                        console.log('Step 3: Got dimensions', { width, height });

                        if (!tpc.txi.procedureType) {
                            console.log('Step 4: Processing non-procedural texture');
                            if (tpc.header.faces > 1) {


                                console.log('Step 4a: Processing multi-face texture');
                                for (let face = 0; face < tpc.header.faces; face++) {
                                    console.log('Step 4b: Processing face', face);
                                    for (let i = 0; i < 1; i++) {
                                        const mipmap = dds.mipmaps[face + (i * dds.mipmapCount)];
                                        if (tpc.header.faces == 6) {
                                            console.log('Step 4c: Processing cubemap face rotations');
                                            switch (face) {
                                                case 3:
                                                    mipmap.data = PixelManager.Rotate90deg(PixelManager.Rotate90deg(mipmap.data, 4, width, height), 4, width, height);
                                                    break;
                                                case 1:
                                                    mipmap.data = PixelManager.Rotate90deg(mipmap.data, 4, width, height);
                                                    break;
                                                case 0:
                                                    mipmap.data = PixelManager.Rotate90deg(PixelManager.Rotate90deg(PixelManager.Rotate90deg(mipmap.data, 4, width, height), 4, width, height), 4, width, height);
                                                    break;
                                            }
                                        }
                                        imagePixels = concatenate(Uint8Array, imagePixels, mipmap.data);
                                    }
                                }
                            } else {
                                console.log('Step 4d: Processing single face texture');
                                imagePixels = concatenate(Uint8Array, imagePixels, dds.mipmaps[0].data);
                            }
                        } else {
                            console.log('Step 5: Processing procedural texture');
                            imagePixels = concatenate(Uint8Array, imagePixels, dds.mipmaps[0].data);
                        }
                        console.log('Step 6: Resolving TPC pixel data');
                        resolve(imagePixels);
                    } else {
                        console.error('getPixelData', result.error);
                    }
                } catch (e) {
                    console.error('getPixelData', e);
                }

                // } else {
                // console.log('Step 7: Processing non-TPC image');
                // props.data.getPixelData((buffer: Uint8Array) => {
                //     console.log('Step 8: Resolving non-TPC pixel data');
                //     resolve(new Uint8Array(buffer));
                // })
                //}
            });
        }

        watch(() => props.bytes, async () => {
            try {
                const pixelData = await getPixelData();
                await renderToCanvas(pixelData);
            } catch (e) {
                console.error('Failed to render TPC:', e);
            }
        }, { immediate: true });

        const concatenate = (resultConstructor: any, ...arrays: any) => {
            let totalLength = 0;
            for (let arr of arrays) {
                totalLength += arr.length;
            }
            let result = new resultConstructor(totalLength);
            let offset = 0;
            for (let arr of arrays) {
                result.set(arr, offset);
                offset += arr.length;
            }
            return result;
        }

        const onMouseWheel = (e: WheelEvent) => {
            let tmpCanvasScale = canvasScale.value;
            if (e.ctrlKey) {
                if (e.deltaY < 0) {
                    tmpCanvasScale -= 0.25;
                } else {
                    tmpCanvasScale += 0.25;
                }
            }
            tmpCanvasScale = Math.max(0.25, Math.min(10, tmpCanvasScale));
            canvasScale.value = tmpCanvasScale;
        };

        // const onEditorFileLoad = () => {
        //     getPixelData(props.data);
        // };

        const FlipY = (pixelData: Uint8Array, width = 1, height = 1) => {
            let offset = 0;
            let stride = width * 4;

            let unFlipped = Uint8Array.from(pixelData);

            for (let pos = unFlipped.length - stride; pos >= 0; pos -= stride) {
                pixelData.set(unFlipped.slice(pos, pos + stride), offset);
                offset += stride;
            }
        }

        const FlipX = (pixelData: Uint8Array, width = 1, height = 1) => {
            let unFlipped = Uint8Array.from(pixelData);

            for (let i = 0; i < pixelData.length; i++) {
                pixelData[i] = (unFlipped[i - 2 * (i % width) + width - 1]);
            }
        }

        const PixelDataToRGBA = (pixelData: Uint8Array, width = 1, height = 1) => {
            let data = new Uint8Array(pixelData.length);
            let n = 4 * width * height;
            let s = 0, d = 0;
            while (d < n) {
                data[d++] = pixelData[s++];
                data[d++] = pixelData[s++];
                data[d++] = pixelData[s++];
                data[d++] = pixelData[s++];
            }
            return data;
        }

        const RGBToRGBA = (pixelData: Uint8Array, width = 1, height = 1) => {
            let data = new Uint8Array(4 * width * height);
            let n = 4 * width * height;
            let s = 0, d = 0;
            while (d < n) {
                data[d++] = pixelData[s++];
                data[d++] = pixelData[s++];
                data[d++] = pixelData[s++];
                data[d++] = 255;
            }
            return data;
        }

        const BGRAtoRGBA = (pixelData: Uint8Array) => {
            for (let i = 0; i < pixelData.length; i += 4) {
                pixelData[i] = pixelData[i + 2]; // red
                pixelData[i + 1] = pixelData[i + 1]; // green
                pixelData[i + 2] = pixelData[i]; // blue
                pixelData[i + 3] = pixelData[i + 3]; // alpha
            }
        }

        const TGAGrayFix = (pixelData: Uint8Array) => {
            let fixed = new Uint8Array(pixelData.length * 4);
            for (let i = 0; i < pixelData.length; i++) {

                let color = pixelData[i];
                let offset = i * 4;

                fixed[offset] = color; // red
                fixed[offset + 1] = color; // green
                fixed[offset + 2] = color; // blue
                fixed[offset + 3] = 255; // alpha
            }
            return fixed;
        }

        const TGAColorFix = (pixelData: Uint8Array) => {
            let fixed = Uint8Array.from(pixelData);
            for (let i = 0; i < pixelData.length; i += 4) {
                fixed[i + 2] = pixelData[i]; // red
                fixed[i + 1] = pixelData[i + 1]; // green
                fixed[i] = pixelData[i + 2]; // blue
                fixed[i + 3] = pixelData[i + 3]; // alpha
            }
            return fixed;
        }

        const PreviewAlphaFix = (pixelData: Uint8Array) => {
            for (let i = 0; i < pixelData.length; i += 4) {
                pixelData[i + 3] = 255;
            }
        }

        onMounted(async () => {
            //props.tab.addEventListener('onEditorFileLoad', onEditorFileLoad);
            console.log('onMounted');
            await getPixelData();
            containerRef.value?.addEventListener('wheel', onMouseWheel);
        });

        onUnmounted(() => {
            // props.tab.removeEventListener('onEditorFileLoad', onEditorFileLoad);
            containerRef.value?.removeEventListener('wheel', onMouseWheel);
        });

        return {
            canvasRef,
            containerRef,
            canvasWidth,
            canvasHeight,
            canvasScale,
            getPixelData
        };
    }
});
</script>