<template>
  <v-card color="#1F7087" theme="dark">
    <div class="d-flex flex-no-wrap justify-space-between">
      <div>
        <v-card-title class="text-h5">
          {{ props.title }}
        </v-card-title>

        <v-card-subtitle>{{ props.subtitle }} </v-card-subtitle>

        <v-card-actions>
          <v-btn class="ms-2" variant="outlined" size="small">
            Open
          </v-btn>
        </v-card-actions>
      </div>

      <v-avatar class="ma-3" size="125" rounded="0">
        <v-img src="https://cdn.vuetifyjs.com/images/cards/foster.jpg"></v-img>
      </v-avatar>
    </div>
  </v-card>
</template>

<script setup lang="ts">

interface Props {
  title?: string;
  subtitle?: string;
  imageSrc?: string;
  resourceId?: string;
  resourceType?: string;
  resourcePath?: string;
  lastModified?: Date;
  size?: number;
}

const props = defineProps<Props>();



</script>

<style scoped></style>
