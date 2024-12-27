<script setup lang="ts">
import { ref } from 'vue';

const categories = ref(['General', 'Appearance', 'Keymap']);
const selectedCategory = ref('General');

const selectCategory = (category: string) => {
  selectedCategory.value = category;
};
</script>

<template>
  <div class="settings-container" style="display: flex; height: 100%; font-family: Arial, sans-serif;">
    <!-- Sidebar -->
    <div class="settings-sidebar"
         style="width: 20%; background-color: #2b2b2b; color: #ccc; padding: 10px; box-shadow: 2px 0 5px rgba(0, 0, 0, 0.2);">
      <ul style="list-style: none; padding: 0; margin: 0;">
        <li
            v-for="item in categories"
            :key="item"
            :class="{ active: item === selectedCategory }"
            @click="selectCategory(item)"
            style="padding: 10px 15px; margin: 5px 0; cursor: pointer; border-radius: 3px; background-color: #3c3f41;"
            :style="{ backgroundColor: item === selectedCategory ? '#4e5254' : '', color: item === selectedCategory? '#fff' : '#ccc', transition: 'background-color 0.3s' }"
        >
          {{ item }}
        </li>
      </ul>
    </div>

    <!-- Main Content Area -->
    <div class="settings-main-content" style="flex: 1; background-color: #3c3f41; color: #fff; padding: 20px;">
      <div v-if="selectedCategory === 'General'" style="padding-bottom: 20px;">
        <h2 style="margin-bottom: 10px; color: #a9b7c6;">General Settings</h2>
        <p>Configure global application properties here.</p>
        <!-- Add General Settings controls here -->
      </div>
      <div v-else-if="selectedCategory === 'Appearance'" style="padding-bottom: 20px;">
        <h2 style="margin-bottom: 10px; color: #a9b7c6;">Appearance</h2>
        <p>Change UI themes and fonts.</p>
        <!-- Add Appearance controls here -->
      </div>
      <div v-else-if="selectedCategory === 'Keymap'" style="padding-bottom: 20px;">
        <h2 style="margin-bottom: 10px; color: #a9b7c6;">Keymap</h2>
        <p>Modify keyboard shortcuts and bindings.</p>
        <!-- Add Keymap controls here -->
      </div>
      <div v-else style="padding-bottom: 20px;">
        <h2 style="margin-bottom: 10px; color: #a9b7c6;">{{ selectedCategory }}</h2>
        <p>No content available for this section.</p>
      </div>
    </div>
  </div>
</template>

<style scoped>

</style>