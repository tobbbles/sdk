/*
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.5-alpha.4
 * 
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct RevokeSession {
    /// The Session Token  Invalidate this session token.
    #[serde(rename = "session_token")]
    pub session_token: String,
}

impl RevokeSession {
    pub fn new(session_token: String) -> RevokeSession {
        RevokeSession {
            session_token,
        }
    }
}

