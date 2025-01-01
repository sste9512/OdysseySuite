<template>
  <v-sheet class="flex-wrap mx-auto" elevation="4" height="90%" rounded max-width="90%" width="90%">
    <v-card>
      <v-toolbar color="primary">
        <v-toolbar-title>User Profile</v-toolbar-title>
      </v-toolbar>
      <div class="d-flex flex-row">

        <v-tabs v-model="tab" direction="vertical" color="primary" height="40px">
          <v-tab value="option-1">
            <v-icon start> mdi-account </v-icon>
            Account
          </v-tab>
          <v-tab value="option-2">
            <v-icon start> mdi-lock </v-icon>
            Profile Settings
          </v-tab>
          <v-tab value="option-3">
            <v-icon start> mdi-access-point </v-icon>
            Editor Settings
          </v-tab>
          <v-tab value="option-4">
            <v-icon start> mdi-access-point </v-icon>
            Integrations
          </v-tab>
          <v-tab value="option-5">
            <v-icon start> mdi-access-point </v-icon>
            Settings
          </v-tab>
        </v-tabs>
        <v-window v-model="tab">
          <v-window-item value="option-1">
            <v-card flat>
              <AccountView></AccountView>
            </v-card>
          </v-window-item>
          <v-window-item value="option-2">
            <v-card flat>
              <ProfileInfoView></ProfileInfoView>
            </v-card>
          </v-window-item>
          <v-window-item value="option-3">
            <v-card flat>
              <EditorSettingsView></EditorSettingsView>
            </v-card>
          </v-window-item>
          <v-window-item value="option-4">
            <v-card flat>
              <IntegrationsGridView></IntegrationsGridView>
            </v-card>
          </v-window-item>
          <v-window-item value="option-5">
            <v-card flat>
              <Settings></Settings>
            </v-card>
          </v-window-item>
        </v-window>
      </div>
    </v-card>
  </v-sheet>
</template>

<script lang="ts">
import ProfileInfoView from '../../components/ProfileViews/ProfileInfoView.vue'
import EditorSettingsView from '../../components/ProfileViews/EditorSettingsView.vue'
import AccountView from '../../components/ProfileViews/AccountView.vue'
import IntegrationsGridView from "../../components/ProfileViews/IntegrationsGridView.vue";
import Settings from "@/components/ProfileViews/Settings.vue";



export default {
  name: 'ProfilePage',
  components: { Settings, IntegrationsGridView, AccountView, EditorSettingsView, ProfileInfoView },
  // eslint-disable-next-line @typescript-eslint/explicit-function-return-type
  data: () => ({
    tab: 'option-1'
  })
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Nunito:ital,wght@0,200;0,300;0,400;0,600;0,700;0,800;0,900;1,200;1,300;1,400;1,600;1,700;1,800;1,900&display=swap');


body {
  font-family: 'Nunito', sans-serif;
  color: #676767;
  background-color: #1e1e1e;
}






.bg-card {
  background-color: #171717;
}

.bg-sidebar-card-top {
  background-color: #353535;
}

.sidebar-separator-top {
  border-bottom: 1px solid #2e2e2e;
}

.sidebar-separator-bottom {
  border-top: 1px solid #2e2e2e;
}

.text-premium-yellow {
  color: #f7b91c;
}

.icon-background {
  background: #2d2d2d;
}

.tooltip-head {
  background: #1d1d1d;
}

.tooltip-body {
  background: #252525;
}

.search-icon {
  top: 50%;
  transform: translate(0, -50%);
}

.card-stack-border {
  border-bottom: 2px solid #696969;
}

.bg-details {
  background-color: #1e1e1e;
}

.add-component-head {
  background-color: #181818;
  background-image: url('https://www.transparenttextures.com/patterns/carbon-fibre.png');
}

.sidebar-item-selected {
  color: white;
  border-right: 2px solid white;
}

.sidebar-item {
  border-right: 2px solid transparent;
}

.sidebar-item:hover {
  color: #a1a0a0;
}
</style>
