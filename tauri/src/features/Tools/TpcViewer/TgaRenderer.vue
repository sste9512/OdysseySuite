<template>
    <div ref="container" style="width: 100%; height: 400px; background: black; border-radius: 4px;"></div>
    <div class="toolbar"
        style="position: absolute; bottom: 16px; left: 50%; transform: translateX(-50%); background: rgba(0,0,0,0.7); padding: 8px; border-radius: 8px; display: flex; gap: 8px;">
        <v-btn-group>
            <v-btn icon size="small" variant="text" color="white">
                <v-icon>mdi-rotate-3d</v-icon>
                <v-tooltip activator="parent" location="top" @update:modelValue="resetCamera">Reset Camera</v-tooltip>
            </v-btn>

            <v-btn icon size="small" variant="text" color="white">
                <v-icon>mdi-grid</v-icon>
                <v-tooltip activator="parent" location="top" @update:modelValue="toggleGrid">Toggle Grid</v-tooltip>
            </v-btn>

            <v-btn icon size="small" variant="text" color="white">
                <v-icon>mdi-cube-outline</v-icon>
                <v-tooltip activator="parent" location="top" @update:modelValue="toggleWireframe">Toggle
                    Wireframe</v-tooltip>
            </v-btn>

            <v-btn icon size="small" variant="text" color="white">
                <v-icon>mdi-brightness-6</v-icon>
                <v-tooltip activator="parent" location="top" @update:modelValue="toggleLighting">Toggle
                    Lighting</v-tooltip>
            </v-btn>
        </v-btn-group>
    </div>
</template>

<script setup lang="ts">
import { onMounted, onUnmounted, ref, watch } from 'vue';
import * as THREE from 'three';
import { OrbitControls } from 'three/addons/controls/OrbitControls.js';
import { TGALoader } from 'three/addons/loaders/TGALoader.js';
import { DDSLoader } from 'three/addons/loaders/DDSLoader.js';

import { OdysseyCompressedTexture, TPC } from '@/components/Aurora-Rendering/types/TPC';
import { TPCLoader } from '@/features/Tools/TpcViewer/KotorJsAdapted/TPCLoader';
import { Result } from '@/models/Result';
import { AuroraService } from '@/data/aurora-service';


const props = defineProps<{
    tpc: TPC | null,
    bytes: Uint8Array | null
}>();

const container = ref<HTMLDivElement | null>(null);
const scene = new THREE.Scene();
const material = new THREE.MeshStandardMaterial();

const gridHelper = ref<THREE.GridHelper | null>(null);
const wireframe = ref(false);
const lighting = ref(false);
const controls = ref<OrbitControls | null>(null);



const resetCamera = () => {
    if (!controls.value) return;
    controls.value.reset();
};

const toggleGrid = () => {
    if (!gridHelper.value) return;
    gridHelper.value.visible = !gridHelper.value.visible;
};

const toggleWireframe = () => {
    if (!material) return;
    material.wireframe = !material.wireframe;
};

const toggleLighting = () => {
    if (!lighting.value) return;
    lighting.value = !lighting.value;
};


onMounted(async () => {
    if (!container.value) {
        console.error('Container not found');
        return;
    }

    // Setup camera
    const camera = new THREE.PerspectiveCamera(
        45,
        container.value.clientWidth / container.value.clientHeight,
        0.1,
        100
    );
    camera.position.set(0, 1, 5);

    // Setup scene



    // Setup renderer
    const renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setPixelRatio(window.devicePixelRatio);
    renderer.setSize(container.value.clientWidth, container.value.clientHeight);
    container.value.appendChild(renderer.domElement);



    // Add grid helper
    const size = 10;
    const divisions = 10;
    const gridHelper = new THREE.GridHelper(size, divisions);
    gridHelper.position.y = -1; // Position grid below the plane
    scene.add(gridHelper);

    // Add lighting
    const ambientLight = new THREE.AmbientLight(0xffffff, 1.5);
    scene.add(ambientLight);


    const light = new THREE.DirectionalLight(0xffffff, 2.5);
    light.position.set(1, 1, 1);
    scene.add(light);

    // const ddsLoader = new DDSLoader();
    // ddsLoader.parse(props.tpc, (texture) => {
    //     console.log(texture);
    // });


    // Create texture from TPC data
    const tpcLoader = new TPCLoader();
    if (!props.tpc) {
        throw new Error('TPC data is required');
    }



    const tpc = TPC.loadFromBytes(props.bytes as Uint8Array, { filename: 'icon_inventory.tpc' });
    if (tpc.ok) {
        
        console.log('TPC loaded successfully, mapping to texture...');
        const textureResult = await tpcLoader.mapToTexture(tpc.value);
        if (!textureResult.ok) {
            console.error(textureResult.error);
            return;
        }
        console.log('Texture mapped successfully');
        const texture = textureResult.value;

        console.log('Configuring texture properties...');
        // here we skip the step that the texture loader does
        texture.anisotropy = 8;
        texture.wrapS = THREE.RepeatWrapping;
        texture.wrapT = THREE.RepeatWrapping;
        texture.needsUpdate = true;

        console.log('Creating material...');
        // Create material with texture
        const material = new THREE.MeshStandardMaterial({
            map: texture,
            side: THREE.DoubleSide,
            transparent: texture.format === THREE.RGBA_S3TC_DXT5_Format,
            alphaTest: texture.header?.alphaTest ?? 0
        });

        console.log('Creating and adding plane geometry...');
        // Create plane geometry for texture
        const geometry = new THREE.PlaneGeometry(2, 2);
        const plane = new THREE.Mesh(geometry, material);
        scene.add(plane);

        console.log('Setting up controls...');
        // Setup controls
        controls.value = new OrbitControls(camera, renderer.domElement);
        controls.value.enableZoom = false;

        console.log('Texture rendering setup complete');
    }
    else {
        console.error('Failed to load TPC data');
    }




    // Animation loop
    function animate() {
        requestAnimationFrame(animate);
        renderer.render(scene, camera);
    }


    animate();

    // Handle window resize
    window.addEventListener('resize', () => {
        if (!container.value) return;

        const width = container.value.clientWidth;
        const height = container.value.clientHeight;

        camera.aspect = width / height;
        camera.updateProjectionMatrix();
        renderer.setSize(width, height);
    });
});

onUnmounted(() => {
    if (!container.value) return;
    container.value.innerHTML = '';

    // Dispose of Three.js objects
    if (scene) {
        scene.traverse((object) => {
            if (object instanceof THREE.Mesh) {
                if (object.geometry) {
                    object.geometry.dispose();
                }
                if (object.material) {
                    if (object.material.map) {
                        object.material.map.dispose();
                    }
                    object.material.dispose();
                }
            }
        });
        scene.clear();
    }

    if (renderer.value) {
        renderer.value.dispose();
    }

    if (controls.value) {
        controls.value.dispose();
    }

});

// Watch for src changes to load new textures

watch(() => props.bytes, async (newBytes) => {
    if (!newBytes || !scene || !material) return;


    const tpcLoader = new TPCLoader();
    if (!props.tpc) {
        throw new Error('TPC data is required');
    }
    const textureResult = await tpcLoader.mapToTexture(props.tpc);
    if (!textureResult.ok) {
        console.error(textureResult.error);
        return;
    }
    const texture = textureResult.value;

    // here we skip the step that the texture loader does
    texture.anisotropy = 8;
    texture.wrapS = THREE.RepeatWrapping;
    texture.wrapT = THREE.RepeatWrapping;
    texture.needsUpdate = true;

    material.map = texture;
    material.needsUpdate = true;

    

}, { immediate: true });
</script>

<style scoped>
.toolbar {
    position: absolute;
    bottom: 16px;
    left: 50%;
    transform: translateX(-50%);
    background: rgba(0, 0, 0, 0.7);
    padding: 8px;
    border-radius: 8px;
    display: flex;
    gap: 8px;
}

.toolbar-button {
    background: rgba(0, 0, 0, 0.7);
    color: white;
    border: none;
    padding: 8px;
    border-radius: 4px;
    cursor: pointer;
}

.toolbar-button:hover {
    background: rgba(0, 0, 0, 0.9);
}
</style>
