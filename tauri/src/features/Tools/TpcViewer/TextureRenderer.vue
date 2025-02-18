<template>
  <div ref="threeContainer" style="width: 100%; height: 400px; background: black; border-radius: 4px;"></div>
</template>

<script setup lang="ts">
import { onMounted, ref } from 'vue';
import * as THREE from 'three';

const threeContainer = ref<HTMLDivElement | null>(null);

onMounted(() => {
  if (!threeContainer.value) {
    console.error('Three container not found');
    return;
  }

  // Setup renderer
  const renderer = new THREE.WebGLRenderer({
    antialias: true,
    alpha: true
  });
  renderer.setPixelRatio(window.devicePixelRatio);
  renderer.setSize(threeContainer.value.clientWidth, threeContainer.value.clientHeight);
  threeContainer.value.appendChild(renderer.domElement);

  // Setup scene
  const scene = new THREE.Scene();
  const camera = new THREE.PerspectiveCamera(
    75,
    threeContainer.value.clientWidth / threeContainer.value.clientHeight,
    0.1,
    1000
  );
  camera.position.z = 5;

  // Create triangle geometry
  const geometry = new THREE.BufferGeometry();
  const vertices = new Float32Array([
    -1.0, -1.0, 0.0,  // bottom left
     1.0, -1.0, 0.0,  // bottom right
     0.0,  1.0, 0.0   // top center
  ]);
  geometry.setAttribute('position', new THREE.BufferAttribute(vertices, 3));

  // Create material
  const material = new THREE.MeshBasicMaterial({
    color: 0x00ff00,
    side: THREE.DoubleSide
  });

  // Create mesh and add to scene
  const triangle = new THREE.Mesh(geometry, material);
  scene.add(triangle);

  // Animation loop
  function animate() {
    requestAnimationFrame(animate);
    triangle.rotation.y += 0.01;
    renderer.render(scene, camera);
  }

  animate();

  // Handle window resize
  window.addEventListener('resize', () => {
    if (!threeContainer.value) return;
    
    const width = threeContainer.value.clientWidth;
    const height = threeContainer.value.clientHeight;

    camera.aspect = width / height;
    camera.updateProjectionMatrix();
    renderer.setSize(width, height);
  });
});
</script>

<style scoped>
.three-container {
  width: 100%;
  height: 400px;
  background: black;
  border-radius: 4px;
}
</style>
