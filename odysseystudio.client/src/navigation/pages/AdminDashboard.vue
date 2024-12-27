<template>
  <v-container>

    <v-row no-gutters>
      <v-col cols="12" sm="4">
        <resource-grid-views class="ma-2 pa-2" title="View Odyssey Suite Documentation"
          subtitle="View Documentation on features of Odyssey Suite"
          imageSrc="https://cdn.vuetifyjs.com/images/cards/sunset.jpg" resourceId="1" resourceType="documentation"
          resourcePath="https://aurora-docs.com" lastModified="2024-01-01" size="100"></resource-grid-views>
      </v-col>
      <v-col v-for="n in 2" :key="n" cols="12" sm="4">
        <resource-grid-views class="ma-2 pa-2" title="View Aurora Documentation"
          subtitle="View Original Documentation to get started"
          imageSrc="https://cdn.vuetifyjs.com/images/cards/sunset.jpg" resourceId="1" resourceType="documentation"
          resourcePath="https://aurora-docs.com" lastModified="2024-01-01" size="100"></resource-grid-views>
      </v-col>
    </v-row>

    <v-row class="mb-6" no-gutters>
      <v-col :cols="cols[0]">
        <v-card theme="dark" class="ma-2 pa-2 glass">
          <template #title> Activity </template>

          <v-timeline side="end" align="start">
            <v-timeline-item dot-color="pink" size="small">
              <div class="d-flex">
                <strong class="me-4">5pm</strong>
                <div>
                  <strong>New Icon</strong>
                  <div class="text-caption">Mobile App</div>
                </div>
              </div>
            </v-timeline-item>

            <v-timeline-item dot-color="teal-lighten-3" size="small">
              <div class="d-flex">
                <strong class="me-4">3-4pm</strong>
                <div>
                  <strong>Design Stand Up</strong>
                  <div class="text-caption mb-2">Hangouts</div>
                </div>
              </div>
            </v-timeline-item>

            <v-timeline-item dot-color="pink" size="small">
              <div class="d-flex">
                <strong class="me-4">12pm</strong>
                <div>
                  <strong>Lunch break</strong>
                </div>
              </div>
            </v-timeline-item>

            <v-timeline-item dot-color="teal-lighten-3" size="small">
              <div class="d-flex">
                <strong class="me-4">9-11am</strong>
                <div>
                  <strong>Finish Home Screen</strong>
                  <div class="text-caption">Web App</div>
                </div>
              </div>
            </v-timeline-item>
          </v-timeline>
          <v-card-actions>
            <v-btn @click="expand = !expand">
              {{ !expand ? 'Full Report' : 'Hide Report' }}
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>

      <v-col :cols="cols[1]">
        <v-card theme="dark" class="ma-2 pa-2">
          <template #title> Storage Accounts </template>

          <v-banner lines="one" icon="mdi-file-cabinet" color="warning">
            <template #text> Local File Storage </template>

            <template #actions>
              <v-btn> Dismiss </v-btn>

              <v-btn> Retry </v-btn>
            </template>
          </v-banner>
          <v-banner lines="one" icon="mdi-google-drive" color="warning">
            <template #text> Google Drive </template>

            <template #actions>
              <v-btn> Dismiss </v-btn>

              <v-btn> Retry </v-btn>
            </template>
          </v-banner>
          <v-banner lines="one" icon="mdi-microsoft-onedrive" color="warning">
            <template #text> One Drive </template>

            <template #actions>
              <v-btn> View </v-btn>

              <v-btn> </v-btn>
            </template>
          </v-banner>
          <v-card-actions>
            <v-btn @click="expand = !expand">
              {{ !expand ? 'View Accounts' : 'Hide Report' }}
            </v-btn>
          </v-card-actions>
          <v-card-actions>
            <v-btn @click="expand = !expand">
              {{ !expand ? 'Add Account' : 'Hide Report' }}
            </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script setup>
import { onMounted } from 'vue'
import ResourceGridViews from "@/components/ResourceViews/ResourceGridView.vue";


function setup() {
  const keys = [
    {
      color: 'cyan',
      year: '1960'
    },
    {
      color: 'green',
      year: '1970'
    },
    {
      color: 'pink',
      year: '1980'
    },
    {
      color: 'amber',
      year: '1990'
    },
    {
      color: 'orange',
      year: '2000'
    }
  ]
  return {
    keys
  }
}

function cols() {
  const { lg, sm } = this.$vuetify.display
  return lg ? [3, 9] : sm ? [9, 3] : [6, 6]
}

onMounted(() => {
  console.log('onMounted event triggered')
})
</script>

<style scoped></style>
