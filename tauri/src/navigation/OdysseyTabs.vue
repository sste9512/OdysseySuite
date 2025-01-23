<template>
  <div>
    <!-- Tabs Header -->
    <div class="tabs-header">
      <button
          v-for="(tab, index) in tabs"
          :key="index"
          :class="['tab-button', { active: activeTab === index }]"
          @click="setActiveTab(index)"
      >
        {{ tab.label }}
      </button>
    </div>

    <!-- Tabs Content -->
    <div class="tabs-content">
      <div v-for="(tab, index) in tabs" :key="index" v-show="activeTab === index">
        <slot :name="tab.slot"></slot>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      activeTab: 0, // Initial active tab index
      tabs: [
        {label: 'Tab 1', slot: 'tab1'},
        {label: 'Tab 2', slot: 'tab2'},
        {label: 'Tab 3', slot: 'tab3'}
      ]
    };
  },
  methods: {
    setActiveTab(index) {
      this.activeTab = index;
    }
  }
};
</script>

<style scoped>
.tabs-header {
  display: flex;
  border-bottom: 1px solid #ccc;
  margin-bottom: 10px;
}

.tab-button {
  padding: 10px 20px;
  cursor: pointer;
  border: none;
  background: none;
  outline: none;
  transition: 0.3s all;
}

.tab-button.active {
  color: white;
  background-color: #007bff;
}

.tab-button:hover {
  background-color: #f1f1f1;
}

.tabs-content {
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 5px;
  min-height: 100px;
}
</style>