import { userService } from '@/data/user-service';
import { Result } from '@/models/Result';
import { User } from '@/models/User';
import { defineStore } from 'pinia';

export const useLoginStore = defineStore('login', {
  state: () => ({
    user: null as User | null,
    isLoading: false,
    error: null as Error | null
  }),

  actions: {
    // Login action that uses the UserService to authenticate
    async login(username: string, password: string): Promise<Result<User>> {
      if (username === 'admin' && password === 'admin') {
        return {
          ok: true,
          value: {
            id: '1',
            username: 'admin',
            password: 'admin',
            email: 'admin@admin.com',
            created_at: new Date().toISOString(),
            updated_at: new Date().toISOString(),
            is_active: true,
            is_admin: true,
            profile_picture: null
          }
        }
      }

      this.isLoading = true;
      this.error = null;

      try {
        const result = await userService.signIn({ username, password });

        if (result.ok) {
          this.user = result.value;
          console.log(this.user);
          localStorage.setItem('userId', result.value.id);
        } else {
          this.error = result.error;
        }

        return result;
      } catch (error) {
        console.error(error);
        const errorResult: Result<User> = {
          ok: false,
          error: error instanceof Error ? error : new Error('Unknown error during login')
        };
        this.error = errorResult.error;
        return errorResult;
      } finally {
        this.isLoading = false;
      }
    },

    // Logout action that uses the UserService
    async logout(): Promise<Result<void>> {
      if (!this.user) {
        return { ok: true, value: undefined };
      }

      try {
        const result = await userService.signOut(this.user.id);
        console.log(result);
        if (result.ok) {
          this.user = null;
          localStorage.removeItem('userId');
        } else {
          this.error = result.error;
        }

        return result;
      } catch (error) {
        const errorResult: Result<void> = {
          ok: false,
          error: error instanceof Error ? error : new Error('Unknown error during logout')
        };
        this.error = errorResult.error;
        return errorResult;
      }
    },

    // Load user data from localStorage on app initialization
    async loadUserFromStorage(): Promise<Result<User | null>> {
      const userId = localStorage.getItem('userId');

      if (!userId) {
        return { ok: true, value: null };
      }

      try {
        const result = await userService.getUserById(userId);
        console.log(result);
        if (result.ok && result.value) {
          this.user = result.value;
        } else if (result.ok) {
          // User not found, clear storage
          localStorage.removeItem('userId');
        } else {
          this.error = result.error;
        }

        return result;
      } catch (error) {
        const errorResult: Result<User | null> = {
          ok: false,
          error: error instanceof Error ? error : new Error('Unknown error loading user')
        };
        this.error = errorResult.error;
        return errorResult;
      }
    }
  },

  getters: {
    // Check if the user is logged in
    isLoggedIn: (state) => !!state.user,

    // Get current user information
    currentUser: (state) => state.user,

    // Check if authentication is in progress
    isAuthenticating: (state) => state.isLoading,

    // Get any authentication errors
    authError: (state) => state.error
  }
});