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

/// UpdateLoginFlowWithTotpMethod : Update Login Flow with TOTP Method
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct UpdateLoginFlowWithTotpMethod {
    /// Sending the anti-csrf token is only required for browser login flows.
    #[serde(rename = "csrf_token", skip_serializing_if = "Option::is_none")]
    pub csrf_token: Option<String>,
    /// Method should be set to \"totp\" when logging in using the TOTP strategy.
    #[serde(rename = "method")]
    pub method: String,
    /// The TOTP code.
    #[serde(rename = "totp_code")]
    pub totp_code: String,
    /// Transient data to pass along to any webhooks
    #[serde(rename = "transient_payload", skip_serializing_if = "Option::is_none")]
    pub transient_payload: Option<serde_json::Value>,
}

impl UpdateLoginFlowWithTotpMethod {
    /// Update Login Flow with TOTP Method
    pub fn new(method: String, totp_code: String) -> UpdateLoginFlowWithTotpMethod {
        UpdateLoginFlowWithTotpMethod {
            csrf_token: None,
            method,
            totp_code,
            transient_payload: None,
        }
    }
}

