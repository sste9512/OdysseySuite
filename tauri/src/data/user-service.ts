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
   * Signs in a user with username and password (legacy method)
   * @param username - The user's username
   * @param password - The user's password
   * @returns Promise containing a Result with either the User data or an error
   */
  async signInLegacy(username: string, password: string): Promise<Result<UserSafe, UserError>> {
    return this.signIn({ username, password });
  }

  /**
   * Signs out a user by their ID
   * @param userId - The user's ID
   * @returns Promise containing a Result with either success or an error
   */
  async signOut(userId: string): Promise<Result<void, UserError>> {
    try {
      await invoke('user_log_out', { userId });
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
   * Gets a user by their ID
   * @param userId - The user's ID
   * @returns Promise containing a Result with either the User data or an error
   */
  async getUserById(userId: string): Promise<Result<UserSafe | null, UserError>> {
    try {
      const user = await invoke<UserSafe | null>('get_user_by_id', { userId });
      return { ok: true, value: user };
    } catch (error) {
      console.error('Failed to get user by ID:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.UserNotFound);
      return { ok: false, error: userError };
    }
  }

  /**
   * Verifies user credentials
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

  /**
   * Verifies user credentials (legacy method)
   * @param username - The user's username
   * @param password - The user's password
   * @returns Promise containing a Result with either a boolean indicating success or an error
   */
  async verifyCredentialsLegacy(username: string, password: string): Promise<Result<boolean, UserError>> {
    return this.verifyCredentials({ username, password });
  }

  /**
 * Creates a new user
 * @param userData - The user creation data
 * @returns Promise containing a Result with either the created User data or an error
 */
  async createUser(userData: CreateUserData): Promise<Result<UserSafe, UserError>> {
    try {
      const user = await invoke<UserSafe>('create_user', {
        username: userData.username,
        password: userData.password,
        email: userData.email
      });
      return { ok: true, value: user };
    } catch (error) {
      console.error('Failed to create user:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.DatabaseError, 'Failed to create user');
      return { ok: false, error: userError };
    }
  }
}

// Export a singleton instance for convenience
export const userService = new UserService();