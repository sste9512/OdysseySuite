import {defineStore} from "pinia";
import {computed, ref} from "vue";
import {resolve} from "@/injection/injection-context";
import type {IUserManagementClient} from "@/clients/web-api-client";

export interface IUser {
    userName: string;
    id: string;
}

export const useAuthStore = defineStore('auth', () => {
    // Value containers
    const count = ref(0)
    const name = ref('Eduardo')
    const bearerToken = ref('');

    // Getters
    const doubleCount = computed(() => count.value * 2)


    function increment() {
        count.value++
    }

    function setBearer(bearer: string) {
        bearerToken.value = bearer;
    }

    async function signin(username: string, password: string): Promise<boolean> {
        const authClient = resolve<IUserManagementClient>("");
        const result = await authClient.authorize(username, password);
        if (result) {
            return result
        } else {
            return result
        }
    }

    return {count, name, doubleCount, signin}
})