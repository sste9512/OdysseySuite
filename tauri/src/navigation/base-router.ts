import {createRouter, createWebHistory} from "vue-router";

const routes = [

    {
        name: 'Login',
        path: '/',
        component: async function () {
            return import('../features/Login-Auth/LoginScreen.vue')
        }
    },
    {
        name: "MainDashboard",
        path: '/project/maindashboard',
        component: async function () {
            return import('../features/MainDashboard.vue')
        },
        children: [
            {
                path: '',
                name: 'Home',
                component: () => import( '../features/Administration/AdminDashboard.vue')
            },
            {
                path: '/resource/:id',
                component: () => import('../features/ResourceViewPortalPage.vue')
            },
            {
                path: '/profile',
                component: () => import('../features/Login-Auth/ProfilePage.vue')
            }
        ]
    }
]


const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router