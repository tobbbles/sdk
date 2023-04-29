/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.13.1
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// IdentityState : The state can either be `active` or `inactive`.

/// The state can either be `active` or `inactive`.
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum IdentityState {
    #[serde(rename = "active")]
    Active,
    #[serde(rename = "inactive")]
    Inactive,

}

impl ToString for IdentityState {
    fn to_string(&self) -> String {
        match self {
            Self::Active => String::from("active"),
            Self::Inactive => String::from("inactive"),
        }
    }
}




