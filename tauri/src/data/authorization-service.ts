import { Result } from "@/models/Result";
import {
  Authorization,
  AuthorizationUtils,
  CreateAuthorizationData,
  CreateAuthorizationWithRefreshData,
  UserError,
  UserErrorType
} from "@/models/User";
import { invoke } from "@tauri-apps/api/core";

export class AuthorizationService {
  /**
 * Creates a new authorization for a user
 * @param authData - The authorization creation data
 * @returns Promise containing a Result with either the Authorization data or an error
 */
  async createAuthorization(authData: CreateAuthorizationData): Promise<Result<Authorization, UserError>> {
    try {
      const authorization = await invoke<Authorization>('create_authorization', {
        user_id: authData.user_id,
        token: authData.token,
        token_type: authData.token_type,
        expires_at: authData.expires_at,
        scopes: authData.scopes
      });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to create authorization:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.DatabaseError, 'Failed to create authorization');
      return { ok: false, error: userError };
    }
  }

  /**
 * Creates a new authorization with refresh token
 * @param authData - The authorization creation data with refresh token
 * @returns Promise containing a Result with either the Authorization data or an error
 */
  async createAuthorizationWithRefresh(authData: CreateAuthorizationWithRefreshData): Promise<Result<Authorization, UserError>> {
    try {
      const authorization = await invoke<Authorization>('create_authorization_with_refresh', {
        user_id: authData.user_id,
        token: authData.token,
        token_type: authData.token_type,
        expires_at: authData.expires_at,
        refresh_token: authData.refresh_token,
        refresh_token_expires_at: authData.refresh_token_expires_at,
        scopes: authData.scopes
      });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to create authorization with refresh token:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.DatabaseError, 'Failed to create authorization with refresh token');
      return { ok: false, error: userError };
    }
  }

  /**
   * Gets an authorization by token
   * @param token - The authorization token
   * @returns Promise containing a Result with either the Authorization data or an error
   */
  async getAuthorizationByToken(token: string): Promise<Result<Authorization | null, UserError>> {
    try {
      const authorization = await invoke<Authorization | null>('get_authorization_by_token', { token });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to get authorization by token:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Gets all authorizations for a user
   * @param userId - The user's ID
   * @returns Promise containing a Result with either the Authorization array or an error
   */
  async getAuthorizationsByUserId(userId: string): Promise<Result<Authorization[], UserError>> {
    try {
      const authorizations = await invoke<Authorization[]>('get_authorizations_by_user_id', { userId });
      return { ok: true, value: authorizations };
    } catch (error) {
      console.error('Failed to get authorizations by user ID:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.UserNotFound);
      return { ok: false, error: userError };
    }
  }

  /**
   * Updates the last used timestamp for an authorization
   * @param token - The authorization token
   * @returns Promise containing a Result with either the updated Authorization or an error
   */
  async updateLastUsed(token: string): Promise<Result<Authorization, UserError>> {
    try {
      const authorization = await invoke<Authorization>('update_authorization_last_used', { token });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to update authorization last used:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Revokes an authorization
   * @param token - The authorization token to revoke
   * @returns Promise containing a Result with either the revoked Authorization or an error
   */
  async revokeAuthorization(token: string): Promise<Result<Authorization, UserError>> {
    try {
      const authorization = await invoke<Authorization>('revoke_authorization', { token });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to revoke authorization:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Revokes all authorizations for a user
   * @param userId - The user's ID
   * @returns Promise containing a Result with either success or an error
   */
  async revokeAllUserAuthorizations(userId: string): Promise<Result<void, UserError>> {
    try {
      await invoke('revoke_all_user_authorizations', { userId });
      return { ok: true, value: undefined };
    } catch (error) {
      console.error('Failed to revoke all user authorizations:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.UserNotFound);
      return { ok: false, error: userError };
    }
  }

  /**
   * Validates an authorization token
   * @param token - The authorization token to validate
   * @returns Promise containing a Result with either a boolean indicating validity or an error
   */
  async validateToken(token: string): Promise<Result<boolean, UserError>> {
    try {
      const isValid = await invoke<boolean>('validate_authorization_token', { token });
      return { ok: true, value: isValid };
    } catch (error) {
      console.error('Failed to validate authorization token:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Validates a refresh token
   * @param refreshToken - The refresh token to validate
   * @returns Promise containing a Result with either a boolean indicating validity or an error
   */
  async validateRefreshToken(refreshToken: string): Promise<Result<boolean, UserError>> {
    try {
      const isValid = await invoke<boolean>('validate_refresh_token', { refreshToken });
      return { ok: true, value: isValid };
    } catch (error) {
      console.error('Failed to validate refresh token:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  /**
   * Refreshes an authorization using a refresh token
   * @param refreshToken - The refresh token
   * @returns Promise containing a Result with either the new Authorization or an error
   */
  async refreshAuthorization(refreshToken: string): Promise<Result<Authorization, UserError>> {
    try {
      const authorization = await invoke<Authorization>('refresh_authorization', { refreshToken });
      return { ok: true, value: authorization };
    } catch (error) {
      console.error('Failed to refresh authorization:', error);
      const userError = error instanceof Error
        ? UserError.fromString(error.message)
        : new UserError(UserErrorType.AuthenticationFailed);
      return { ok: false, error: userError };
    }
  }

  // Client-side utility methods using AuthorizationUtils

  /**
   * Checks if an authorization is valid (client-side check)
   * @param authorization - The authorization to check
   * @returns boolean indicating if the authorization is valid
   */
  isAuthorizationValid(authorization: Authorization): boolean {
    return AuthorizationUtils.isValid(authorization);
  }

  /**
   * Checks if a refresh token is valid (client-side check)
   * @param authorization - The authorization containing the refresh token
   * @returns boolean indicating if the refresh token is valid
   */
  isRefreshTokenValidLocal(authorization: Authorization): boolean {
    return AuthorizationUtils.isRefreshTokenValid(authorization);
  }

  /**
   * Updates the last used timestamp locally
   * @param authorization - The authorization to update
   * @returns Updated authorization object
   */
  updateLastUsedLocal(authorization: Authorization): Authorization {
    return AuthorizationUtils.updateLastUsed(authorization);
  }

  /**
   * Revokes an authorization locally
   * @param authorization - The authorization to revoke
   * @returns Revoked authorization object
   */
  revokeAuthorizationLocal(authorization: Authorization): Authorization {
    return AuthorizationUtils.revoke(authorization);
  }
}

// Export a singleton instance for convenience
export const authorizationService = new AuthorizationService();
