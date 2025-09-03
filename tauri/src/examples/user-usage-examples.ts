/**
 * Usage examples for User and Authorization TypeScript objects
 * This file demonstrates how to use the TypeScript equivalents of the Rust structs
 */

import { authorizationService } from '@/data/authorization-service';
import { userService } from '@/data/user-service';
import {
  Authorization,
  AuthorizationUtils,
  CreateUserData,
  LoginCredentials,
  User,
  UserError,
  UserErrorType,
  UserSafe,
  UserUtils
} from '@/models/User';

// Example 1: Creating a new user using utility functions
export function createUserExample() {
  const userData: CreateUserData = {
    username: 'john_doe',
    password: 'secure_password_123',
    email: 'john.doe@example.com'
  };

  // Create user object locally (client-side)
  const newUser: User = UserUtils.createUser(userData);
  console.log('Created user:', newUser);

  // Convert to safe version (without password)
  const safeUser: UserSafe = UserUtils.toSafe(newUser);
  console.log('Safe user data:', safeUser);
}

// Example 2: User validation
export function validateUserExample() {
  const userData: Partial<User> = {
    username: 'test_user',
    password: 'test123',
    email: 'test@example.com'
  };

  const validationResult = UserUtils.validate(userData);

  if (validationResult.ok) {
    console.log('User data is valid');
  } else {
    console.error('Validation error:', validationResult.error.message);
    console.error('Error type:', validationResult.error.type);
  }
}

// Example 3: User authentication with service
export async function authenticateUserExample() {
  const credentials: LoginCredentials = {
    username: 'john_doe',
    password: 'secure_password_123'
  };

  const loginResult = await userService.signIn(credentials);

  if (loginResult.ok) {
    console.log('Login successful:', loginResult.value);
    return loginResult.value;
  } else {
    console.error('Login failed:', loginResult.error.message);
    console.error('Error type:', loginResult.error.type);
    return null;
  }
}

// Example 4: Creating and managing authorizations
export function createAuthorizationExample() {
  const authData = {
    user_id: 'user-123',
    token: 'bearer_token_xyz',
    token_type: 'Bearer',
    expires_at: new Date(Date.now() + 3600000).toISOString(), // 1 hour from now
    scopes: ['read', 'write', 'admin']
  };

  // Create authorization locally
  const authorization: Authorization = AuthorizationUtils.createAuthorization(authData);
  console.log('Created authorization:', authorization);

  // Check if valid
  const isValid = AuthorizationUtils.isValid(authorization);
  console.log('Authorization is valid:', isValid);

  // Update last used
  const updatedAuth = AuthorizationUtils.updateLastUsed(authorization);
  console.log('Updated last used:', updatedAuth.last_used_at);
}

// Example 5: Creating authorization with refresh token
export function createAuthorizationWithRefreshExample() {
  const authData = {
    user_id: 'user-123',
    token: 'bearer_token_xyz',
    token_type: 'Bearer',
    expires_at: new Date(Date.now() + 3600000).toISOString(), // 1 hour from now
    refresh_token: 'refresh_token_abc',
    refresh_token_expires_at: new Date(Date.now() + 86400000).toISOString(), // 24 hours from now
    scopes: ['read', 'write']
  };

  const authorization = AuthorizationUtils.createAuthorizationWithRefresh(authData);
  console.log('Authorization with refresh token:', authorization);

  // Check refresh token validity
  const isRefreshValid = AuthorizationUtils.isRefreshTokenValid(authorization);
  console.log('Refresh token is valid:', isRefreshValid);
}

// Example 6: Complete user workflow with error handling
export async function completeUserWorkflowExample() {
  try {
    // 1. Create a new user
    const userData: CreateUserData = {
      username: 'alice_smith',
      password: 'strong_password_456',
      email: 'alice.smith@example.com'
    };

    const createResult = await userService.createUser(userData);
    if (!createResult.ok) {
      throw createResult.error;
    }

    console.log('User created successfully:', createResult.value);
    const user = createResult.value;

    // 2. Sign in the user
    const loginResult = await userService.signIn({
      username: userData.username,
      password: userData.password
    });

    if (!loginResult.ok) {
      throw loginResult.error;
    }

    console.log('User signed in:', loginResult.value);

    // 3. Create authorization
    const authResult = await authorizationService.createAuthorization({
      user_id: user.id,
      token: `token_${Date.now()}`,
      token_type: 'Bearer',
      expires_at: new Date(Date.now() + 3600000).toISOString(),
      scopes: ['read', 'write']
    });

    if (!authResult.ok) {
      throw authResult.error;
    }

    console.log('Authorization created:', authResult.value);

    // 4. Validate the token
    const validateResult = await authorizationService.validateToken(authResult.value.token);
    if (validateResult.ok) {
      console.log('Token is valid:', validateResult.value);
    }

  } catch (error) {
    if (error instanceof UserError) {
      console.error(`User error [${error.type}]:`, error.message);
    } else {
      console.error('Unexpected error:', error);
    }
  }
}

// Example 7: Working with authorization service
export async function authorizationServiceExample() {
  const userId = 'user-456';
  const token = 'sample_token_123';

  try {
    // Get all authorizations for a user
    const authsResult = await authorizationService.getAuthorizationsByUserId(userId);
    if (authsResult.ok) {
      console.log('User authorizations:', authsResult.value);

      // Check each authorization
      authsResult.value.forEach((auth, index) => {
        console.log(`Authorization ${index + 1}:`);
        console.log('  Valid:', authorizationService.isAuthorizationValid(auth));
        console.log('  Refresh token valid:', authorizationService.isRefreshTokenValidLocal(auth));
      });
    }

    // Validate a specific token
    const validationResult = await authorizationService.validateToken(token);
    if (validationResult.ok) {
      console.log('Token validation result:', validationResult.value);
    }

    // Update last used timestamp
    const updateResult = await authorizationService.updateLastUsed(token);
    if (updateResult.ok) {
      console.log('Updated authorization:', updateResult.value);
    }

  } catch (error) {
    console.error('Authorization service error:', error);
  }
}

// Example 8: Error handling patterns
export function errorHandlingExample() {
  // Creating errors manually
  const usernameError = new UserError(UserErrorType.EmptyUsername);
  console.log('Username error:', usernameError.message);

  const dbError = new UserError(UserErrorType.DatabaseError, 'Connection timeout');
  console.log('Database error:', dbError.message);

  // Parsing error from string (useful for Tauri responses)
  const parsedError = UserError.fromString('Authentication failed');
  console.log('Parsed error type:', parsedError.type);
  console.log('Parsed error message:', parsedError.message);
}

// Example 9: Type-safe result handling
export async function resultHandlingExample() {
  const credentials: LoginCredentials = {
    username: 'test_user',
    password: 'test_pass'
  };

  const result = await userService.signIn(credentials);

  // Type-safe result handling
  if (result.ok) {
    // TypeScript knows result.value is UserSafe
    const user: UserSafe = result.value;
    console.log(`Welcome ${user.username}!`);
    console.log(`Account created: ${user.created_at}`);
  } else {
    // TypeScript knows result.error is UserError
    const error: UserError = result.error;

    switch (error.type) {
      case UserErrorType.AuthenticationFailed:
        console.log('Invalid credentials');
        break;
      case UserErrorType.UserNotFound:
        console.log('User does not exist');
        break;
      case UserErrorType.DatabaseError:
        console.log('System error, please try again later');
        break;
      default:
        console.log('Unknown error occurred');
    }
  }
}

// Export all examples for easy testing
export const examples = {
  createUserExample,
  validateUserExample,
  authenticateUserExample,
  createAuthorizationExample,
  createAuthorizationWithRefreshExample,
  completeUserWorkflowExample,
  authorizationServiceExample,
  errorHandlingExample,
  resultHandlingExample
};
