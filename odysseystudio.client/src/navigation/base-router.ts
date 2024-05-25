import {createRouter, createWebHistory} from "vue-router";

const routes = [
    
    {
        path: '/',
        component: async function() {
            return import('../features/project-selection.vue')
        }}, 
    {
        path: '/project',
        component: async function () {
            return import('../components/default/Default.vue')
        } ,
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