// src/data/user-service-updated.ts
import { Result } from "@/models/Result";
import {
  CreateUserData,
  LoginCredentials,
  UserError,
  UserErrorType,
  UserSafe
} from "@/models/User";
import { invoke } from "@tauri-apps/api/core";

export class UserService {
  /**
   * Signs in a user with username and password
   * Calls the Tauri user_sign_in command
   * @param credentials - The user's login credentials
   * @returns Promise containing a Result with either the User data or an error
   */
  async signIn(credentials: LoginCredentials): Promise<Result<UserSafe, UserError>> {
    try {
      const user = await invoke<UserSafe>('user_sign_in', {
        username: credentials.username,
        password: credentials.password
      });
      return { ok: true, value: user };
    } catch (error) {
      console.error('Failed to sign in user:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Signs out a user by their ID
   * Calls the Tauri user_log_out command
   * @param userId - The user's ID
   * @returns Promise containing a Result with either success or an error
   */
  async signOut(userId: string): Promise<Result<void, UserError>> {
    try {
      // Fix: Use user_id (snake_case) to match Rust parameter name
      await invoke('user_log_out', { user_id: userId });
      return { ok: true, value: undefined };
    } catch (error) {
      console.error('Failed to sign out user:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.DatabaseError, 'Failed to sign out user');
      return { ok: false, error: userError };
    }
  }

  /**
   * Signs in a user with username and password (convenience method)
   * @param username - The user's username
   * @param password - The user's password
   * @returns Promise containing a Result with either the User data or an error
   */
  async signInWithCredentials(username: string, password: string): Promise<Result<UserSafe, UserError>> {
    return this.signIn({ username, password });
  }

  /**
   * Verifies user credentials without signing in
   * @param credentials - The user's login credentials
   * @returns Promise containing a Result with either a boolean indicating success or an error
   */
  async verifyCredentials(credentials: LoginCredentials): Promise<Result<boolean, UserError>> {
    try {
      const isValid = await invoke<boolean>('verify_user_credentials', {
        username: credentials.username,
        password: credentials.password
      });
      return { ok: true, value: isValid };
    } catch (error) {
      console.error('Failed to verify user credentials:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }
}

// Export a singleton instance for convenience
export const userService = new UserService();