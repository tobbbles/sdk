/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct ContinueWithRecoveryUiFlow {
    /// The ID of the recovery flow
    #[serde(rename = "id")]
    pub id: String,
    /// The URL of the recovery flow
    #[serde(rename = "url", skip_serializing_if = "Option::is_none")]
    pub url: Option<String>,
}

impl ContinueWithRecoveryUiFlow {
    pub fn new(id: String) -> ContinueWithRecoveryUiFlow {
        ContinueWithRecoveryUiFlow {
            id,
            url: None,
        }
    }
}

