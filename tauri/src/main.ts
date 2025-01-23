import "reflect-metadata";
import { devtools } from "@vue/devtools";
import { createApp } from "vue";
import App from "./App.vue";
import { createPinia } from "pinia";
import router from "@/navigation/base-router";
import "vuetify/styles";
import { createVuetify } from "vuetify";
import * as components from "vuetify/components";
import * as directives from "vuetify/directives";
import { aliases, mdi } from "vuetify/iconsets/mdi";
import { InjectionContext } from "@/injection/injection-context";
import Vue3EasyDataTable from "vue3-easy-data-table";
import "vue3-easy-data-table/dist/style.css";
import Antd from "ant-design-vue";
import "@mdi/font/css/materialdesignicons.css";

const pinia = createPinia();
const context = new InjectionContext();
const app = createApp(App);
app.component("EasyDataTable", Vue3EasyDataTable);

const vuetify = createVuetify({
  components,
  directives,
  theme: {
    defaultTheme: "dark",
    themes: {
      dark: {
        dark: true,
        colors: {
          primary: "#673AB7",
          secondary: "#424242",
          accent: "#82B1FF",
          error: "#FF5252",
          info: "#2196F3",
          success: "#4CAF50",
          warning: "#FFC107",
        },
      },
    },
  },
  icons: {
    defaultSet: "mdi",
    aliases,
    sets: {
      mdi,
    },
  },
});

app.use(Antd);
app.use(pinia);
app.use(router);
app.use(vuetify);

if (process.env.NODE_ENV === "development") {
  devtools.connect();
}

app.mount("#app");
