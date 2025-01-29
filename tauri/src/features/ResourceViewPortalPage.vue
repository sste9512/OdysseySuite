<template>
  <v-app-bar flat>
    <v-app-bar-title>
      <v-icon icon="mdi-circle-slice-6"/>
      Resource Name
    </v-app-bar-title>
  </v-app-bar>

  <v-app-bar flat>
    <v-breadcrumbs :items="items">
      <template v-slot:prepend>
        <v-icon icon="mdi-vuetify"></v-icon>
      </template>
    </v-breadcrumbs>
    <v-app-bar-title></v-app-bar-title>

    <!--- Export Actions --->
    <div class="text-center">
      <v-menu
          v-model="menu2"
          :close-on-content-click="false"
          location="end"
          transition="slide-x-transition"
      >
        <template v-slot:activator="{ props }">
          <v-btn color="indigo" v-bind="props" prepend-icon="mdi-cog"> Edit Actions</v-btn>
        </template>

        <v-card class="mx-auto" width="256">
          <v-layout>
            <v-navigation-drawer permanent absolute>
              <v-list>
                <v-list-item
                    prepend-icon="mdi-cog"
                    title="Open this resource"
                    subtitle="john@google.com"
                >
                  <template v-slot:append>
                    <v-btn size="small" variant="text" icon="mdi-menu-down"></v-btn>
                  </template>
                </v-list-item>
              </v-list>

              <v-divider></v-divider>

              <v-list :lines="false" density="compact" nav>
                <v-list-item
                    v-for="(item, i) in items3"
                    :key="i"
                    :value="item"
                    active-color="primary"
                >
                  <template v-slot:prepend>
                    <v-icon :icon="item.icon"></v-icon>
                  </template>

                  <v-list-item-title v-text="item.text"></v-list-item-title>
                </v-list-item>
              </v-list>
            </v-navigation-drawer>

            <v-main style="height: 354px"></v-main>
          </v-layout>
        </v-card>
      </v-menu>
    </div>

    <div class="text-center">
      <v-menu
          v-model="menu2"
          :close-on-content-click="false"
          location="end"
          transition="slide-x-transition"
      >
        <template v-slot:activator="{ props }">
          <v-btn color="indigo" v-bind="props" prepend-icon="mdi-cog"> Edit Actions</v-btn>
        </template>

        <v-card class="mx-auto" width="256">
          <v-layout>
            <v-navigation-drawer permanent absolute>
              <v-list>
                <v-list-item
                    prepend-icon="mdi-cog"
                    title="Open this resource"
                    subtitle="john@google.com"
                >
                  <template v-slot:append>
                    <v-btn size="small" variant="text" icon="mdi-menu-down"></v-btn>
                  </template>
                </v-list-item>
              </v-list>

              <v-divider></v-divider>

              <v-list :lines="false" density="compact" nav>
                <v-list-item
                    v-for="(item, i) in items3"
                    :key="i"
                    :value="item"
                    active-color="primary"
                >
                  <template v-slot:prepend>
                    <v-icon :icon="item.icon"></v-icon>
                  </template>

                  <v-list-item-title v-text="item.text"></v-list-item-title>
                </v-list-item>
              </v-list>
            </v-navigation-drawer>

            <v-main style="height: 354px"></v-main>
          </v-layout>
        </v-card>
      </v-menu>
    </div>
  </v-app-bar>


  <v-lazy :min-height="200" :options="{ threshold: 0.5 }" transition="fade-transition">
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
                  :class="['d-flex justify-center align-center shadow-bottom game game-cover']"
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
  </v-lazy>

  <v-lazy :min-height="200" :options="{ threshold: 0.5 }" transition="fade-transition">
    <!--   Bif Container  -->
    <v-container padding="2px">
      <h1>Bifs</h1>
      <v-table
          v-model:page="page"
          :headers="headers"
          :items="bifs"
          :items-per-page="itemsPerPage"
          hide-default-footer
          class="elevation-1 game game-cover"
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
  </v-lazy>

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
            <v-col v-for="i in entries" :key="i" cols="12" md="4"></v-col>
          </v-row>
        </v-container>
      </v-window-item>
    </v-window>
  </v-card>
</template>

<script>
import ChitinView from '../components/ResourceViews/ChitinView.vue'
import ProfilePage from './Login-Auth/ProfilePage.vue'
import GlassContainer from '../layouts/default/GlassContainer.vue'
import GlassCardView from '../components/ResourceViews/GlassCardView.vue'
import App from '../App.vue'
import BluePrintScaffold from '../components/ResourceViews/BluePrintScaffold.vue'
import DataEntryCards from '../components/ResourceViews/DataEntryCards.vue'
import ResourceGridViews from '../components/ResourceViews/ResourceGridView.vue'
import EntryContainerView from '../components/ResourceViews/EntryContainerView.vue'

export default {
  name: 'ResourceViewPortal',
  components: {
    EntryContainerView,
    ResourceGridViews,
    DataEntryCards,
    ChitinView,
    ProfilePage,
    GlassContainer,
    GlassCardView,
    BluePrintScaffold
  },
  setup() {
  },
  data: () => ({
    items: [
      {
        title: 'Dashboard',
        disabled: false,
        href: 'breadcrumbs_dashboard'
      },
      {
        title: 'Link 1',
        disabled: false,
        href: 'breadcrumbs_link_1'
      },
      {
        title: 'Link 2',
        disabled: true,
        href: 'breadcrumbs_link_2'
      }
    ],
    items3: [
      {text: 'My Files', icon: 'mdi-folder'},
      {text: 'Shared with me', icon: 'mdi-account-multiple'},
      {text: 'Starred', icon: 'mdi-star'},
      {text: 'Recent', icon: 'mdi-history'},
      {text: 'Offline', icon: 'mdi-check-circle'},
      {text: 'Uploads', icon: 'mdi-upload'},
      {text: 'Backups', icon: 'mdi-cloud-upload'}
    ],
    tab: null,
    fav: true,
    menu: false,
    menu2: false,
    message: false,
    hints: true,
    selectedItem: 1,
    selectedItem2: 1,
    formatOptions: [
      {text: 'Json', icon: 'mdi-clock'},
      {text: 'Yaml', icon: 'mdi-account'},
      {text: 'Xml', icon: 'mdi-flag'}
    ],
    storageOptions: [
      {text: 'Google Drive', icon: 'mdi-clock'},
      {text: 'One Drive', icon: 'mdi-account'},
      {text: 'Local Files', icon: 'mdi-flag'}
    ],
    entries: [],
    bifs: [],
    keys: []
  }),
  mounted() {
    window.aurora.loadChitinKey('blenderFile')

    window.aurora.loadErf('blenderFile')

    window.aurora.loadRim('loading')

    window.aurora.loadBif('asdfaf')

    window.electron.ipcRenderer.on('loadKeyReply', (event, arg) => {
      //console.log(arg)
      const entries = Object.entries(arg)
      this.bifs = arg.bifs
      /*this.keys = arg.keys.first(30)*/
      for (const [key, value] of entries) {
        //console.log(`${key}: ${value}`)
        if (key.includes('keys')) {
          continue
        }
        if (key.includes('reader')) {
          continue
        }
        if (key.includes('Reserved')) {
          continue
        }
        if (key.includes('bifs')) {
          continue
        }
        // this.entries.push(`${key}: ${value}`)
        this.entries.push({
          key: key,
          value: value
        })
      }
    })

    /*
     *   Await Call to IPC
     * */
    window.electron.ipcRenderer.on('loadErfReply', (event, arg) => {
      //console.log(arg)
    })

    window.electron.ipcRenderer.on('loadRimReply', (event, arg) => {
      //console.log(arg)
    })

    window.electron.ipcRenderer.on('loadBifReply', (event, arg) => {
      //console.log(arg)
    })
  }
}
</script>

<style scoped>
.btn-shadow {
  margin: 0 auto;
  position: relative;
  top: -15px;
  width: 80%;
  height: 30px;
  z-index: 20;
  box-shadow: 0 10px 21px rgba(248, 63, 126, 0.3);
}

.shadow-bottom {
  /*box-shadow: 0px 7px 7px -2px rgba(0, 0, 255, 0.5) !important;*/
  -webkit-box-shadow: 0 10px 6px -6px rgba(0, 0, 255, 0.4);
  -moz-box-shadow: 0 10px 6px -6px rgba(0, 0, 255, 0.4);
  box-shadow: 0 10px 6px -6px rgba(0, 0, 255, 0.4);
}

.inset-shadow {
  box-shadow: 2px 0px rgb(15, 197, 134) inset;
}

h4 {
  width: 150px;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

/*.inset-shadow {
  box-shadow:  4px 0px rgba(0, 0, 255, 0.5) inset, 0px 15px #7eb4e2 inset;
}*/

.games-carousel .game .game-cover {
  transition: transform 0.1s ease;
}

.games-carousel .game .game-cover:hover {
  transform: translate(5px, -5px);
  cursor: pointer;
}

.games-carousel .game .game-cover img {
  height: 100%;
  width: 100%;
}

.games-carousel .game .game-cover:hover img {
  box-shadow: -5px 5px #a970ff;
}
</style>
