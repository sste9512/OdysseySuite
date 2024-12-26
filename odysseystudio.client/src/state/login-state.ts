import {defineStore} from 'pinia';

export const useLoginStore = defineStore('login', {
    state: () => ({
        token: localStorage.getItem('token') || '',
        username: localStorage.getItem('username') || ''
    }),

    actions: {
        // Login action to store token and username in state and localStorage
        login(username: string, token: string) {
            this.username = username;
            this.token = token;

            localStorage.setItem('username', username);
            localStorage.setItem('token', token);
        },

        // Logout action to clear state and localStorage
        logout() {
            this.username = '';
            this.token = '';

            localStorage.removeItem('username');
            localStorage.removeItem('token');
        }
    },

    getters: {
        // Check if the user is logged in
        isLoggedIn: (state) => !!state.token
    }
});