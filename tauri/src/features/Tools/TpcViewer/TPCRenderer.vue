<template>
  <div ref="container" class="tpc-renderer">
    <canvas ref="canvas"></canvas>
  </div>
</template>

<script lang="ts">
import { defineComponent, onMounted, ref, PropType } from 'vue';
import * as THREE from 'three';
import { TPCLoader } from './KotorJsAdapted/TPCLoader';
import { OdysseyCompressedTexture } from '@/components/Aurora-Rendering/types/TPC';
import { TPCTexture } from '@/features/Tools/TpcViewer/TPCTexture';

export default defineComponent({
  name: 'TPCRenderer',
  props: {
    tpcData: {
      type: Uint8Array as PropType<Uint8Array>,
      required: true
    },
    fileName: {
      type: String,
      required: true
    }
  },
  setup(props) {
    const container = ref<HTMLDivElement | null>(null);
    const canvas = ref<HTMLCanvasElement | null>(null);
    
    let scene: THREE.Scene;
    let camera: THREE.OrthographicCamera;
    let renderer: THREE.WebGLRenderer;
    let texture: OdysseyCompressedTexture | null = null;
    let mesh: THREE.Mesh;

    const init = async () => {
      if (!container.value || !canvas.value) return;

      // Create scene
      scene = new THREE.Scene();
      
      // Create camera
      const aspect = container.value.clientWidth / container.value.clientHeight;
      camera = new THREE.OrthographicCamera(-aspect, aspect, 1, -1, 0.1, 1000);
      camera.position.z = 1;

      // Create renderer
    renderer = new THREE.WebGLRenderer({
        canvas: canvas.value,
        antialias: true
      });
      renderer.setSize(container.value.clientWidth, container.value.clientHeight);

      try {
        // Load texture
        //const loader = new TPCLoader();
        texture = new TPCTexture(props.tpcData);
        
        if (texture) {
          // Create mesh with texture
          const geometry = new THREE.PlaneGeometry(2 * aspect, 2);
          const material = new THREE.MeshBasicMaterial({ 
            map: texture,
            side: THREE.DoubleSide
          });
          mesh = new THREE.Mesh(geometry, material);
          scene.add(mesh);
        }
      } catch (error) {
        console.error('Error loading TPC texture:', error);
      }

      animate();
    };

    const animate = () => {
      requestAnimationFrame(animate);
      renderer.render(scene, camera);
    };

    onMounted(() => {
      init();

      // Handle window resize
      const handleResize = () => {
        if (!container.value || !canvas.value) return;
        
        const aspect = container.value.clientWidth / container.value.clientHeight;
        
        camera.left = -aspect;
        camera.right = aspect;
        camera.updateProjectionMatrix();
        
        renderer.setSize(container.value.clientWidth, container.value.clientHeight);
        
        if (mesh) {
          mesh.geometry = new THREE.PlaneGeometry(2 * aspect, 2);
        }
      };

      window.addEventListener('resize', handleResize);
    });

    return {
      container,
      canvas
    };
  }
});
</script>

<style scoped>
.tpc-renderer {
  width: 100%;
  height: 100%;
}

canvas {
  width: 100%;
  height: 100%;
}
</style>
