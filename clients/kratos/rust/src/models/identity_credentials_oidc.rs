/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v1.1.0
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct IdentityCredentialsOidc {
    #[serde(rename = "providers", skip_serializing_if = "Option::is_none")]
    pub providers: Option<Vec<crate::models::IdentityCredentialsOidcProvider>>,
}

impl Default for IdentityCredentialsOidc {
    fn default() -> Self {
        Self::new()
    }
}

impl IdentityCredentialsOidc {
    pub fn new() -> IdentityCredentialsOidc {
        IdentityCredentialsOidc {
                providers: None,
        }
    }
}


