use crate::domain::entities::user::User;
use crate::infrastructure::authorization::authorization_service::AuthorizationService;

#[tauri::command]
pub async fn user_sign_in(username: &str, password: &str) -> Result<User, String> {
    println!("Starting user sign-in process");

    // Create and initialize authorization service
    let mut auth_service = AuthorizationService::new();

    match auth_service.initialize().await {
        Ok(_) => {
            println!("Authorization service initialized successfully");
        }
        Err(e) => {
            println!("Failed to initialize authorization service: {}", e);
            return Err(format!("Failed to initialize authorization service: {}", e));
        }
    }

    // Use the authorization service to handle sign-in
    match auth_service.sign_in(username, password).await {
        Ok(user) => {
            println!("User sign-in completed successfully");
            Ok(user)
        }
        Err(e) => {
            println!("User sign-in failed: {}", e);
            Err(format!("Sign-in failed: {}", e))
        }
    }
}

#[tauri::command]
pub async fn user_register(username: &str, email: &str, password: &str) -> Result<User, String> {
    println!("Starting user registration process");

    // Create and initialize authorization service
    let mut auth_service = AuthorizationService::new();

    match auth_service.initialize().await {
        Ok(_) => {
            println!("Authorization service initialized successfully");
        }
        Err(e) => {
            println!("Failed to initialize authorization service: {}", e);
            return Err(format!("Failed to initialize authorization service: {}", e));
        }
    }

    // Use the authorization service to handle registration
    match auth_service.register(username, email, password).await {
        Ok(user) => {
            println!("User registration completed successfully");
            Ok(user)
        }
        Err(e) => {
            println!("User registration failed: {}", e);
            Err(format!("Registration failed: {}", e))
        }
    }
}

#[tauri::command]
pub async fn user_log_out(user_id: &str) -> Result<(), String> {
    println!("Starting user log-out process");

    // Create and initialize authorization service
    let mut auth_service = AuthorizationService::new();

    match auth_service.initialize().await {
        Ok(_) => {
            println!("Authorization service initialized successfully");
        }
        Err(e) => {
            println!("Failed to initialize authorization service: {}", e);
            return Err(format!("Failed to initialize authorization service: {}", e));
        }
    }

    // Use the authorization service to handle sign-out
    match auth_service.sign_out(user_id).await {
        Ok(_) => {
            println!("User log-out completed successfully");
            Ok(())
        }
        Err(e) => {
            println!("User log-out failed: {}", e);
            Err(format!("Log-out failed: {}", e))
        }
    }
}
