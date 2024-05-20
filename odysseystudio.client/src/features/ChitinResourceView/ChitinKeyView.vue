<template>
  <v-container padding="2px">
    <h1>Header</h1>
    <v-form>
      <v-container>
        <v-row>
          <v-col cols="12" sm="4" v-for="{ key, value } in entries" :key="n" :value="n">
            <!--          <v-text-field  :model-value="value" :label="key" variant="solo" readonly></v-text-field>-->
            <v-card
              height="auto"
              width="100%"
              elevation="30"
              :class="['d-flex justify-center align-center shadow-bottom']"
              style="border-right: 5px white !important"
            >
              <div
                class="pa-0 bg-secondary rounded-e-lg w-0"
                style="height: 50px; width: 10px !important"
              ></div>
              <div>
                <div class="d-block pa-2 align-content-center">
                  <h6>{{ key }}</h6>
                </div>
                <div class="d-block pa-2 align-content-start">
                  <h4>{{ value }}</h4>
                </div>
              </div>
              <v-spacer></v-spacer>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-form>
  </v-container>

  <!--   Bif Container  -->
  <v-container padding="2px">
    <h1>Bifs</h1>
    <v-table
      v-model:page="page"
      :headers="headers"
      :items="bifs"
      :items-per-page="itemsPerPage"
      hide-default-footer
      class="elevation-1"
      @update:options="options = $event"
    >
      <thead>
        <!--    FileSize: 431840,
  FilenameOffset: 376,
  FilenameSize: 13,
  Drives: 1,
  filename: 'data\\2da.bif'-->
        <tr>
          <th class="text-left">FileSize</th>
          <th class="text-left">FileNameOffset</th>
          <th class="text-left">FileNameSize</th>
          <th class="text-left">Drives</th>
          <th class="text-left">File Name</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in bifs" :key="item">
          <td>{{ item.FileSize }}</td>
          <td>{{ item.FilenameOffset }}</td>
          <td>{{ item.FilenameSize }}</td>
          <td>{{ item.Drives }}</td>
          <td>{{ item.filename }}</td>
        </tr>
      </tbody>
    </v-table>
  </v-container>

  <!--  Key Container  -->
  <v-container padding="2px">
    <h1>Keys</h1>
    <v-table>
      <thead>
        <tr>
          <th class="text-left">Resource Reference</th>
          <th class="text-left">Resource Type</th>
          <th class="text-left">Resource Id</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in keys" :key="item">
          <td>{{ item.ResRef }}</td>
          <td>{{ item.ResType }}</td>
          <td>{{ item.ResID }}</td>
        </tr>
      </tbody>
    </v-table>
  </v-container>
  <v-container fluid class="border-bottom">
    <BluePrintScaffold class="border-bottom"></BluePrintScaffold>
  </v-container>

  <v-container fluid class="border-bottom">
    <ChitinView></ChitinView>
  </v-container>

  <v-card>
    <v-tabs v-model="tab" color="deep-purple-accent-4" align-tabs="end" style="height: 35px">
      <v-tab :value="1" class="text-caption" style="height: 35px">Data</v-tab>
      <v-tab :value="2" class="text-caption" style="height: 35px">Keys</v-tab>
      <v-tab :value="3" class="text-caption" style="height: 35px">Bifs</v-tab>
      <v-tab :value="4" class="text-caption" style="height: 35px">Reserved</v-tab>
    </v-tabs>

    <v-window v-model="tab">
      <v-window-item v-for="n in 4" :key="n" :value="n">
        <v-container fluid>
          <v-row>
            <v-col v-for="i in entries" :key="i" cols="12" md="4"> </v-col>
          </v-row>
        </v-container>
      </v-window-item>
    </v-window>
  </v-card>
</template>

<script>
import BluePrintScaffold from '../../components/ResourceViews/BluePrintScaffold.vue'
import ChitinView from '../../components/ResourceViews/ChitinView.vue'

export default {
  name: 'ChitinKeyView',
  components: { ChitinView, BluePrintScaffold }
}
</script>

<style scoped></style>
