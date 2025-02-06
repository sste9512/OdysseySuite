<template>
  <div ref="container" class="renderer-container"></div>
</template>

<script lang="ts">
import { defineComponent, onMounted, onBeforeUnmount } from 'vue';
import * as THREE from 'three';
import { DDSTexture } from '../Aurora-Rendering/types/DDSTexture';
import { DDS_HEADER } from '../Aurora-Rendering/types/DDS';
import { PropType } from 'vue';

export default defineComponent({
  name: 'ThreeRender',
  props: {
    ddsHeader: {
      type: Object as PropType<Uint8Array>,
      required: true
    }
  },
  data() {
    return {
      scene: null as THREE.Scene | null,
      camera: null as THREE.PerspectiveCamera | null,
      renderer: null as THREE.WebGLRenderer | null,
      texture: null as DDSTexture | null,
      mesh: null as THREE.Mesh | null
    };
  },
  async mounted() {
    console.log('Mounted');
    await this.initScene();
    this.animate();
  },
  methods: {
    async initScene() {
      const container = this.$refs.container as HTMLElement;
      if (!container) return;

      // Create scene
      this.scene = new THREE.Scene();
      
      // Create camera with container aspect ratio
      const aspect = container.clientWidth / container.clientHeight;
      this.camera = new THREE.PerspectiveCamera(75, aspect, 0.1, 1000);
      this.camera.position.z = 2;

      // Create renderer matching container size
      this.renderer = new THREE.WebGLRenderer({ antialias: true });
      this.renderer.setSize(container.clientWidth, container.clientHeight);
      this.renderer.setPixelRatio(window.devicePixelRatio);
      container.appendChild(this.renderer.domElement);

      try {
        // Convert Uint8Array to ArrayBuffer
        const buffer = this.ddsHeader.buffer;
        console.log('Loading texture from buffer:', buffer);
        
        // Load DDS texture
        this.texture = DDSTexture.fromDDSData(buffer);
        if (!this.texture) {
          throw new Error('Failed to create texture from DDS data');
        }

        // Create material with texture
        const material = new THREE.MeshBasicMaterial({ 
          map: this.texture,
          side: THREE.DoubleSide // Make the plane visible from both sides
        });

        // Create plane geometry that matches texture aspect ratio
        const textureAspect = this.texture.image.width / this.texture.image.height;
        const width = 2;
        const height = width / textureAspect;
        const geometry = new THREE.PlaneGeometry(width, height);
        
        // Create mesh
        this.mesh = new THREE.Mesh(geometry, material);
        this.scene.add(this.mesh);

      } catch (error) {
        console.error('Error loading texture:', error);
      }

      // Handle container resize
      const resizeObserver = new ResizeObserver(() => this.onResize());
      resizeObserver.observe(container);
    },

    animate() {
      if (!this.renderer || !this.scene || !this.camera) return;
      
      requestAnimationFrame(this.animate);
      this.renderer.render(this.scene, this.camera);
    },

    onResize() {
      const container = this.$refs.container as HTMLElement;
      if (!container || !this.camera || !this.renderer) return;

      const width = container.clientWidth;
      const height = container.clientHeight;

      this.camera.aspect = width / height;
      this.camera.updateProjectionMatrix();
      this.renderer.setSize(width, height);
    }
  },
  beforeUnmount() {
    // Clean up resources
    if (this.renderer) {
      this.renderer.dispose();
      const container = this.$refs.container as HTMLElement;
      if (container && this.renderer.domElement) {
        container.removeChild(this.renderer.domElement);
      }
    }
    if (this.mesh) {
      this.mesh.geometry.dispose();
      if (this.mesh.material instanceof THREE.Material) {
        this.mesh.material.dispose();
      }
    }
    if (this.texture) {
      this.texture.dispose();
    }
  }
});
</script>

<style scoped>
.renderer-container {
  width: 400px;
  height: 400px; /* Fixed height instead of 100vh */
  background: rebeccapurple;
  border-radius: 4px;
  overflow: hidden;
}
</style>
