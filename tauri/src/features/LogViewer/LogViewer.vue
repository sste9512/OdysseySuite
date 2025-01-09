<template>
  <div>
    <table class="user-action-grid">
      <thead>
      <tr>
        <th>Id</th>
        <th>Action</th>
        <th>TimeStamp</th>
      </tr>
      </thead>
      <tbody>
      <tr v-for="(action, index) in userActions.slice(0, 10)" :key="action.id">
        <td>{{ action.id }}</td>
        <td>{{ action.description }}</td>
        <td>{{ action.timestamp }}</td>
      </tr>
      </tbody>
    </table>
  </div>
</template>

<script setup lang="ts">
import {ref} from 'vue';

import {useLoggingStore, UserAction} from "@/state/logging-store";


const loggingStore = useLoggingStore();

const userActions = ref<UserAction[]>(loggingStore.getActionsByCategory("tabs"));


</script>

<style scoped>
.user-action-grid {
  width: 100%;
  border-collapse: collapse;
  font-weight: lighter;
  font-size: 9px;
}

.user-action-grid {
  width: 100%;
  border-collapse: collapse;

}

.user-action-grid th,
.user-action-grid td {
  padding: 8px;
  text-align: left;

 
}

.user-action-grid th {
  background-color: rebeccapurple;
  height: 10px;
}
</style>


<style scoped>

</style>