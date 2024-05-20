<template>
  <v-card flat height="100%" rounded="0">
    <v-toolbar density="compact">
      <v-toolbar-title>Toolbox</v-toolbar-title>

      <v-spacer></v-spacer>

      <v-btn icon size="small">
        <v-icon>mdi-magnify</v-icon>
      </v-btn>

      <v-btn icon size="small">
        <v-icon>mdi-filter-menu-outline</v-icon>
      </v-btn>

      <v-btn icon size="small">
        <v-icon>mdi-close</v-icon>
      </v-btn>
    </v-toolbar>

    <v-layout>
      <v-navigation-drawer permanent expand-on-hover rail style="height: 100%">
        <v-list>
          <v-list-item
            prepend-avatar="https://randomuser.me/api/portraits/women/85.jpg"
            title="Sandra Adams"
            subtitle="sandra_a88@gmailcom"
          ></v-list-item>
        </v-list>

        <v-divider></v-divider>

        <v-list density="compact" nav>
          <v-list-item prepend-icon="mdi-folder" title="Files" value="myfiles"></v-list-item>
          <v-list-item
            prepend-icon="mdi-account-multiple"
            title="Shared"
            value="shared"
          ></v-list-item>
          <v-list-item prepend-icon="mdi-star" title="Favorites" value="starred"></v-list-item>
        </v-list>
      </v-navigation-drawer>

      <v-main style="min-height: 700px">
        <v-container>
          <v-row no-gutters>
            <v-col v-for="n in 9" :key="n" cols="12" sm="2">
              <v-hover>
                <template v-slot:default="{ isHovering, props }">
                  <v-sheet
                    class="ma-2 pa-2"
                    elevation="9"
                    v-bind="props"
                    :color="isHovering ? 'primary' : undefined"
                  >
                    <h4 class="align-content-center">item</h4>
                    <h4 class="text-caption">item desc</h4>
                  </v-sheet>
                </template>
              </v-hover>
            </v-col>
          </v-row>
        </v-container>
      </v-main>
    </v-layout>
  </v-card>
</template>

<script>


export default {
  name: 'ToolboxView',
  data() {
    return {
      entries: [],
      resources: []
    }
  },
  setup() {
    // The same rules apply when you want to only find one document
    /*resourceDataStore.findOne({ _id: 'id1' }, function (err, doc) {
          this.resources = doc;
    });*/


  }
}
</script>

<style scoped lang="scss"></style>
