/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.50
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct RedirectionConfig {
    #[serde(rename = "global", skip_serializing_if = "Option::is_none")]
    pub global: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "login", skip_serializing_if = "Option::is_none")]
    pub login: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "logout", skip_serializing_if = "Option::is_none")]
    pub logout: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "recovery", skip_serializing_if = "Option::is_none")]
    pub recovery: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "registration", skip_serializing_if = "Option::is_none")]
    pub registration: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "settings", skip_serializing_if = "Option::is_none")]
    pub settings: Option<Box<crate::models::RedirectionField>>,
    #[serde(rename = "url_allowlist", skip_serializing_if = "Option::is_none")]
    pub url_allowlist: Option<Vec<String>>,
    #[serde(rename = "verification", skip_serializing_if = "Option::is_none")]
    pub verification: Option<Box<crate::models::RedirectionField>>,
}

impl RedirectionConfig {
    pub fn new() -> RedirectionConfig {
        RedirectionConfig {
            global: None,
            login: None,
            logout: None,
            recovery: None,
            registration: None,
            settings: None,
            url_allowlist: None,
            verification: None,
        }
    }
}

