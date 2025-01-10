<script>


import {onMounted} from 'vue';
import {DirectoryService} from "@/data/directory-service.ts";

export default {
  setup() {
    onMounted(async () => {
      const directoryService = new DirectoryService();
      const files = await directoryService.listDirectoryFromRoot();
      console.log(files);
    });
  }
};

</script>

<template>
  <router-view/>
</template>

<style lang="scss">

body {
  background-color: #121212; /* Dark background color */
  color: #ffffff; /* Ensure text is readable on dark background */
}

/* Deep selector to override Vuetify tab styles */
::v-deep(.v-tab) {
  background-color: #181818; /* Custom background for tabs */
  color: #f7b91c; /* Text color for tabs */
  border-radius: 12px; /* Add rounded corners */
  font-weight: lighter; /* Bold text for tabs */
  font-size: 10px;
  transition: all 0.1s ease; /* Smooth transition for hover effects */
  height: 30px;
}

::v-deep(.v-tab:hover) {
  background-color: #1e1e1e; /* Slightly lighter background on hover */
  color: white; /* Text color on hover */
}

::v-deep(.v-tab--selected) {
  background-color: #353535; /* Background color for selected tabs */
  color: #ffffff; /* Text color for selected tabs */
}

::v-deep(.v-tab__icon) {
  color: #f7b91c; /* Icon color for tabs */
  margin-right: 8px; /* Spacing between icon and text */
}

::v-deep(.v-tabs) {
  background-color: #121212; /* Background for the tabs container */
  border-bottom: 1px solid #2e2e2e; /* Optional border for separation */
  padding: 8px; /* Padding around tabs */
}

</style>