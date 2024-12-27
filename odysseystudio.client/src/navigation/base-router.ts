import {createRouter, createWebHistory} from "vue-router";

const routes = [

    {
        name: 'Login',
        path: '/',
        component: async function () {
            return import('./pages/LoginScreen.vue')
        }
    },
    {
        name: "MainDashboard",
        path: '/project/maindashboard',
        component: async function () {
            return import('./pages/MainDashboard.vue')
        },
        children: [
            {
                path: '',
                name: 'Home',
                component: () => import( '../navigation/pages/AdminDashboard.vue')
            },
            {
                path: '/resource/:id',
                component: () => import('../navigation/pages/ResourceViewPortalPage.vue')
            },
            {
                path: '/resource',
                component: () => import('../components/ResourceViews/ChitinView.vue')
            },
            {
                path: '/profile',
                component: () => import('../navigation/pages/ProfilePage.vue')
            }
        ]
    }
]


const router = createRouter({
    history: createWebHistory(),
    routes
})

export default router