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

const pinia = createPinia();
const context = new InjectionContext();
const app = createApp(App);
app.component("EasyDataTable", Vue3EasyDataTable);
const customTheme = {
  dark: false,
  colors: {
    primary: "#1E88E5", // Blue
    secondary: "#43A047", // Green
    accent: "#FF5722", // Orange
    error: "#E53935", // Red
    info: "#1E88E5", // Blue
    success: "#4CAF50", // Green
    warning: "#FB8C00", // Amber
    background: "#F5F5F5", // Light grey
    surface: "#FFFFFF", // White
  },
};

const vuetify = createVuetify({
  theme: {
    defaultTheme: "customTheme",
    themes: {
      customTheme,
    },
  },
  icons: {
    defaultSet: "mdi",
    aliases,
    sets: {
      mdi,
    },
  },
  components,
  directives,
});

app.use(Antd);
app.use(pinia);
app.use(router);
app.use(vuetify);

if (process.env.NODE_ENV === "development") {
  await devtools.connect();
}

app.mount("#app");
