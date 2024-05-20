
import "reflect-metadata";
import { createApp } from 'vue'
import App from './App.vue'
import {createPinia} from "pinia";
import router from "@/navigation/base-router";
import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
import { aliases, mdi } from 'vuetify/iconsets/mdi'
import {InjectionContext} from "@/injection/injection-context";
import {ResourceEndpointsClient} from "@/clients/web-api-client";




const pinia = createPinia()
const context = new InjectionContext();
const app = createApp(App)
const vuetify = createVuetify({
    icons: {
        defaultSet: 'mdi',
        aliases,
        sets: {
            mdi,
        },
    },
    components,
    directives,
})


app.use(pinia)
app.use(router)
app.use(vuetify)



app.mount('#app')

