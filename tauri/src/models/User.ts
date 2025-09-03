import { Result } from './Result';

/**
 * Represents a user in the system
 * Corresponds to the Rust User struct
 */
export interface User {
  id: string;
  username: string;
  /** Password field - excluded from serialization on the Rust side */
  password: string;
  email: string;
  created_at: string; // ISO 8601 date string
  updated_at: string; // ISO 8601 date string
  is_active: boolean;
  is_admin: boolean;
  profile_picture: string | null;
}

/**
 * User data without sensitive information (password excluded)
 * Safe for client-side usage and API responses
 */
export interface UserSafe {
  id: string;
  username: string;
  email: string;
  created_at: string;
  updated_at: string;
  is_active: boolean;
  is_admin: boolean;
  profile_picture: string | null;
}

/**
 * Represents user authorization data
 * Corresponds to the Rust Authorization struct
 */
export interface Authorization {
  user_id: string;
  token: string;
  token_type: string;
  expires_at: string; // ISO 8601 date string
  refresh_token: string | null;
  refresh_token_expires_at: string | null; // ISO 8601 date string
  scopes: string[];
  created_at: string; // ISO 8601 date string
  last_used_at: string; // ISO 8601 date string
  is_revoked: boolean;
}

/**
 * Data required to create a new user
 */
export interface CreateUserData {
  username: string;
  password: string;
  email: string;
}

/**
 * Data required to create a new user with a specific ID
 */
export interface CreateUserWithIdData extends CreateUserData {
  id: string;
}

/**
 * User login credentials
 */
export interface LoginCredentials {
  username: string;
  password: string;
}

/**
 * Authorization creation data
 */
export interface CreateAuthorizationData {
  user_id: string;
  token: string;
  token_type: string;
  expires_at: string;
  scopes: string[];
}

/**
 * Authorization creation data with refresh token
 */
export interface CreateAuthorizationWithRefreshData extends CreateAuthorizationData {
  refresh_token: string;
  refresh_token_expires_at: string;
}

/**
 * Errors that can occur when working with users
 * Corresponds to the Rust UserError enum
 */
export enum UserErrorType {
  EmptyUsername = 'EmptyUsername',
  EmptyPassword = 'EmptyPassword',
  AuthenticationFailed = 'AuthenticationFailed',
  UserNotFound = 'UserNotFound',
  DatabaseError = 'DatabaseError',
}

/**
 * User error class with type and message
 */
export class UserError extends Error {
  public readonly type: UserErrorType;

  constructor(type: UserErrorType, message?: string) {
    const defaultMessages = {
      [UserErrorType.EmptyUsername]: 'Username cannot be empty',
      [UserErrorType.EmptyPassword]: 'Password cannot be empty',
      [UserErrorType.AuthenticationFailed]: 'Authentication failed',
      [UserErrorType.UserNotFound]: 'User not found',
      [UserErrorType.DatabaseError]: message || 'Database error occurred',
    };

    super(message || defaultMessages[type]);
    this.type = type;
    this.name = 'UserError';
  }

  static fromString(error: string): UserError {
    if (error.includes('Username cannot be empty')) {
      return new UserError(UserErrorType.EmptyUsername);
    }
    if (error.includes('Password cannot be empty')) {
      return new UserError(UserErrorType.EmptyPassword);
    }
    if (error.includes('Authentication failed')) {
      return new UserError(UserErrorType.AuthenticationFailed);
    }
    if (error.includes('User not found')) {
      return new UserError(UserErrorType.UserNotFound);
    }
    if (error.includes('Database error')) {
      return new UserError(UserErrorType.DatabaseError, error);
    }

    // Default to database error for unknown errors
    return new UserError(UserErrorType.DatabaseError, error);
  }
}

/**
 * Utility class for working with User objects
 */
export class UserUtils {
  /**
   * Creates a new user object with generated UUID
   */
  static createUser(data: CreateUserData): User {
    const now = new Date().toISOString();
    return {
      id: crypto.randomUUID(),
      username: data.username,
      password: data.password,
      email: data.email,
      created_at: now,
      updated_at: now,
      is_active: true,
      is_admin: false,
      profile_picture: null,
    };
  }

  /**
   * Creates a user with a specific ID
   */
  static createUserWithId(data: CreateUserWithIdData): User {
    const now = new Date().toISOString();
    return {
      id: data.id,
      username: data.username,
      password: data.password,
      email: data.email,
      created_at: now,
      updated_at: now,
      is_active: true,
      is_admin: false,
      profile_picture: null,
    };
  }

  /**
   * Converts a User object to UserSafe by removing sensitive information
   */
  static toSafe(user: User): UserSafe {
    const { password, ...safeUser } = user;
    return safeUser;
  }

  /**
   * Validates user data
   */
  static validate(user: Partial<User>): Result<void, UserError> {
    try {
      if (!user.username || user.username.trim() === '') {
        return { ok: false, error: new UserError(UserErrorType.EmptyUsername) };
      }
      if (!user.password || user.password.trim() === '') {
        return { ok: false, error: new UserError(UserErrorType.EmptyPassword) };
      }
      return { ok: true, value: undefined };
    } catch (error) {
      return {
        ok: false,
        error: new UserError(UserErrorType.DatabaseError, error instanceof Error ? error.message : 'Unknown error')
      };
    }
  }
}

/**
 * Utility class for working with Authorization objects
 */
export class AuthorizationUtils {
  /**
   * Creates a new authorization for a user
   */
  static createAuthorization(data: CreateAuthorizationData): Authorization {
    const now = new Date().toISOString();
    return {
      user_id: data.user_id,
      token: data.token,
      token_type: data.token_type,
      expires_at: data.expires_at,
      refresh_token: null,
      refresh_token_expires_at: null,
      scopes: data.scopes,
      created_at: now,
      last_used_at: now,
      is_revoked: false,
    };
  }

  /**
   * Creates a new authorization with refresh token
   */
  static createAuthorizationWithRefresh(data: CreateAuthorizationWithRefreshData): Authorization {
    const now = new Date().toISOString();
    return {
      user_id: data.user_id,
      token: data.token,
      token_type: data.token_type,
      expires_at: data.expires_at,
      refresh_token: data.refresh_token,
      refresh_token_expires_at: data.refresh_token_expires_at,
      scopes: data.scopes,
      created_at: now,
      last_used_at: now,
      is_revoked: false,
    };
  }

  /**
   * Checks if the authorization is valid (not expired and not revoked)
   */
  static isValid(auth: Authorization): boolean {
    if (auth.is_revoked) return false;

    const expiresAt = new Date(auth.expires_at);
    const now = new Date();

    return expiresAt > now;
  }

  /**
   * Updates the last used timestamp
   */
  static updateLastUsed(auth: Authorization): Authorization {
    return {
      ...auth,
      last_used_at: new Date().toISOString(),
    };
  }

  /**
   * Revokes the authorization
   */
  static revoke(auth: Authorization): Authorization {
    return {
      ...auth,
      is_revoked: true,
    };
  }

  /**
   * Checks if the refresh token is valid
   */
  static isRefreshTokenValid(auth: Authorization): boolean {
    if (!auth.refresh_token || !auth.refresh_token_expires_at) {
      return false;
    }

    if (auth.is_revoked) return false;

    const expiresAt = new Date(auth.refresh_token_expires_at);
    const now = new Date();

    return expiresAt > now;
  }
}
