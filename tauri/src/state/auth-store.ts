import {defineStore} from "pinia";
import {computed, ref} from "vue";
import { userService } from "@/data/services/user-service";
import { Result } from "@/models/Result";
import { UserError, UserSafe } from "@/models/User";

export interface IUser {
    userName: string;
    id: string;
}

export const useAuthStore = defineStore('auth', () => {
    // User state
    const currentUser = ref<UserSafe | null>(null);
    const isAuthenticated = computed(() => currentUser.value !== null);
    const bearerToken = ref('');
    const isLoading = ref(false);

    // Set the current user
    function setUser(user: UserSafe | null) {
        currentUser.value = user;
    }

    // Set bearer token
    function setBearer(bearer: string) {
        bearerToken.value = bearer;
    }

    // Sign in a user
    async function login(username: string, password: string): Promise<Result<UserSafe, UserError>> {
        try {
            isLoading.value = true;
            const result = await userService.signInWithCredentials(username, password);
            
            if (result.ok) {
                setUser(result.value);
            }
            
            return result;
        } catch (error) {
            console.error('Login error:', error);
            const userError = error instanceof Error
                ? new UserError(0, error.message)
                : new UserError(0, 'Unknown error during login');
            return { ok: false, error: userError };
        } finally {
            isLoading.value = false;
        }
    }

    // Sign out the current user
    async function logout(): Promise<Result<void, UserError>> {
        try {
            isLoading.value = true;
            
            if (!currentUser.value) {
                return { ok: true, value: undefined };
            }
            
            const result = await userService.signOut(currentUser.value.id);
            
            if (result.ok) {
                setUser(null);
                bearerToken.value = '';
            }
            
            return result;
        } catch (error) {
            console.error('Logout error:', error);
            const userError = error instanceof Error
                ? new UserError(0, error.message)
                : new UserError(0, 'Unknown error during logout');
            return { ok: false, error: userError };
        } finally {
            isLoading.value = false;
        }
    }

    // Verify user credentials without signing in
    async function verifyCredentials(username: string, password: string): Promise<Result<boolean, UserError>> {
        try {
            isLoading.value = true;
            return await userService.verifyCredentials({ username, password });
        } catch (error) {
            console.error('Verification error:', error);
            const userError = error instanceof Error
                ? new UserError(0, error.message)
                : new UserError(0, 'Unknown error during verification');
            return { ok: false, error: userError };
        } finally {
            isLoading.value = false;
        }
    }

    return {
        currentUser,
        isAuthenticated,
        bearerToken,
        isLoading,
        login,
        logout,
        verifyCredentials,
        setBearer,
        setUser
    }
})