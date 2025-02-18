<template>
    <div ref="container" class="renderer-container"></div>
  </template>
  
  <script setup lang="ts">
  import { ref, onMounted, onBeforeUnmount, watch, nextTick } from 'vue';
  import * as THREE from 'three';
  import { DDSLoader } from 'three/examples/jsm/loaders/DDSLoader.js';
  import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls.js';
  import { ImageApi } from '@/data/image-api';
  import { TPC } from '@/components/Aurora-Rendering/types/TPC';
  
  const props = defineProps<{
    tpc?: TPC,
    onAppeared?: boolean 
  }>();

  const emits = defineEmits<{
    (e: 'update:showTpcOverlay', showTpcOverlay: boolean): void
  }>();
  
  const container = ref<HTMLElement>();
  let scene: THREE.Scene | null = null;
  let camera: THREE.PerspectiveCamera | null = null;
  let renderer: THREE.WebGLRenderer | null = null;
  let controls: OrbitControls | null = null;
  let texture: THREE.CompressedTexture | null = null;
  let material: THREE.MeshBasicMaterial | null = null;
  let mesh: THREE.Mesh | null = null;
  const imageApi = new ImageApi();
  let animationFrameId: number | null = null;
  
  // Initialize the 3D scene
  const init = () => {
    console.log('Initializing scene, container exists:', !!container.value);
    if (!container.value) {
        console.error('Container element not found');
        return;
    }
    if (scene) {
        console.log('Scene already initialized');
        return;
    }
  
    console.log('Creating Three.js scene...');
    scene = new THREE.Scene();
    
    console.log('Setting up camera...');
    camera = new THREE.PerspectiveCamera(75, container.value.clientWidth / container.value.clientHeight, 0.1, 1000);
    
    console.log('Initializing WebGL renderer...');
    renderer = new THREE.WebGLRenderer({ antialias: true, alpha: true });
    renderer.setClearColor(0x000000, 0);
    renderer.setSize(container.value.clientWidth, container.value.clientHeight);
    container.value.appendChild(renderer.domElement);
  
    console.log('Creating geometry and materials...');
    const geometry = new THREE.PlaneGeometry(1, 1);
    material = new THREE.MeshBasicMaterial({ 
        side: THREE.DoubleSide,
        transparent: true
    });
    
    console.log('Creating mesh and adding to scene...');
    mesh = new THREE.Mesh(geometry, material);
    scene.add(mesh);
  
    console.log('Positioning camera...');
    camera.position.z = 1.5;
  
    console.log('Setting up orbit controls...');
    controls = new OrbitControls(camera, renderer.domElement);
    controls.enableDamping = true;
  
    console.log('Starting animation loop...');
    animate();
  };
  
  // Animation loop
  const animate = () => {
    if (!scene || !camera || !renderer) return;
    
    animationFrameId = requestAnimationFrame(animate);
    controls?.update();
    renderer.render(scene, camera);
  };
  
  // Clean up resources
  const cleanup = () => {
    if (animationFrameId) {
        cancelAnimationFrame(animationFrameId);
        animationFrameId = null;
    }
    
    if (renderer) {
        renderer.dispose();
        container.value?.removeChild(renderer.domElement);
        renderer = null;
    }
    
    if (mesh) {
        mesh.geometry.dispose();
        if (mesh.material instanceof THREE.Material) {
            mesh.material.dispose();
        }
        mesh = null;
    }
    
    if (texture) {
        texture.dispose();
        texture = null;
    }
    
    scene = null;
    camera = null;
    controls = null;
    material = null;
  };
  
  // Watch for visibility changes
  watch(() => props.onAppeared, async (newOnAppeared, oldOnAppeared) => {
    console.log('Visibility changed:', newOnAppeared, 'Previous:', oldOnAppeared);
    if (newOnAppeared) {
        await nextTick();  // Wait for DOM update
        cleanup(); // Clean up existing scene if any
        init();
    } else {
        cleanup();
    }
  }, { immediate: true });
  
  // Watch for TPC data changes
  watch(() => props.tpc, async (newTpc) => {
    console.log('TPC data changed:', !!newTpc, 'Material exists:', !!material);
    if (!newTpc || !material) {
        return;
    }
  
    try {
        console.log('Converting TPC to DDS format...');
        const ddsResult = await imageApi.convertTPCtoDDS(newTpc);
        if (!ddsResult.ok) {
            console.error('Failed to convert TPC to DDS:', ddsResult.error);
            return;
        }
  
        console.log('Creating DDS loader and blob...');
        const loader = new DDSLoader();
        const ddsBlob = new Blob([ddsResult.value], { type: 'application/octet-stream' });
        const ddsUrl = URL.createObjectURL(ddsBlob);
        
        try {
            console.log('Loading DDS texture...');
            if (texture) {
                texture.dispose();
            }
            texture = await loader.loadAsync(ddsUrl);
            console.log('DDS texture loaded:', texture.image.width, 'x', texture.image.height);
  
            console.log('Updating material with new texture...');
            if (material) {
                material.map = texture;
                material.needsUpdate = true;
            }
  
            console.log('Adjusting plane geometry to match texture aspect ratio...');
            if (mesh && texture) {
                const aspectRatio = texture.image.width / texture.image.height;
                mesh.scale.set(aspectRatio, 1, 1);
                console.log(`Set mesh scale to match aspect ratio: ${aspectRatio}`);
            }
        } finally {
            URL.revokeObjectURL(ddsUrl);
        }
    } catch (error) {
        console.error('Error loading texture:', error);
    }
  }, { immediate: true });
  
  // Handle window resize
  const handleResize = () => {
    if (!container.value || !camera || !renderer) return;
    
    camera.aspect = container.value.clientWidth / container.value.clientHeight;
    camera.updateProjectionMatrix();
    renderer.setSize(container.value.clientWidth, container.value.clientHeight);
  };
  
  onMounted(() => {
    console.log('Component mounted');
    window.addEventListener('resize', handleResize);
  });
  
  onBeforeUnmount(() => {
    console.log('Component unmounting');
    window.removeEventListener('resize', handleResize);
    cleanup();
  });
  </script>
  
  <style scoped>
  .renderer-container {
    width: 100%;
    height: 100%;
  }
  </style>