<template>
    <div class="tpc-viewer">
        <div v-if="loading" class="loading">
            Loading texture...
        </div>
        <div v-else-if="error" class="error">
            {{ error }}
        </div>
        <canvas v-else ref="canvas" :width="width" :height="height"></canvas>
    </div>
</template>

<script lang="ts">
import { defineComponent, ref, onMounted, watch } from 'vue'
import { ImageApi } from '../../data/image-api';



export default defineComponent({
    name: 'TpcViewer',
    props: {
        filePath: {
            type: String,
            required: false
        },
        bytes: {
            type: ArrayBuffer,
            required: false
        }
    },
    setup(props) {
        const canvas = ref<HTMLCanvasElement | null>(null)
        const loading = ref(true)
        const error = ref<string | null>(null)
        const width = ref(0)
        const height = ref(0)

        async function loadTpcTexture() {
            try {
                loading.value = true
                error.value = null
                const imageApi = new ImageApi();
                // Invoke Rust function to read and decode TPC file
                if (!props.bytes) {
                    throw new Error("No bytes provided");
                }
                const tpcData = await imageApi.readTpcFromBytes(new Uint8Array(props.bytes));

                // Set canvas dimensions
                if (tpcData.ok) {
                    width.value = tpcData.value.width;
                    height.value = tpcData.value.height;
                } else {
                    throw new Error("Failed to decode TPC data");
                }
                // Draw to canvas
                const ctx = canvas.value?.getContext('2d')
                if (!ctx) {
                    throw new Error("Could not get canvas context")
                }
                const imageData = new ImageData(
                    new Uint8ClampedArray(tpcData.value.pixels),
                    tpcData.value.width,
                    tpcData.value.height
                )
                ctx.putImageData(imageData, 0, 0)
            } catch (err) {
                error.value = `Failed to load TPC file: ${err.message}`
            } finally {
                loading.value = false
            }
        }

        onMounted(async () => {
            console.log("onMounted");
            await loadTpcTexture();
        });

        // Load texture when component mounts or filePath changes
        watch(() => props.filePath, loadTpcTexture, { immediate: true })

        return {
            canvas,
            loading,
            error,
            width,
            height,
            loadTpcTexture
        }
    }
})
</script>

<style scoped>
.tpc-viewer {
    position: relative;
    width: 100%;
    height: 100%;
    min-height: 200px;
    display: flex;
    justify-content: center;
    align-items: center;
    background: #333;
}

canvas {
    max-width: 100%;
    max-height: 100%;
    object-fit: contain;
}

.loading,
.error {
    color: white;
    text-align: center;
    padding: 1rem;
}

.error {
    color: #ff6b6b;
}
</style>