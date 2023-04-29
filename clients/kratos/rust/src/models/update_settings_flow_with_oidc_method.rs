/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * The version of the OpenAPI document: v0.13.1
 * Contact: office@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// UpdateSettingsFlowWithOidcMethod : Update Settings Flow with OpenID Connect Method



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct UpdateSettingsFlowWithOidcMethod {
    /// Flow ID is the flow's ID.  in: query
    #[serde(rename = "flow", skip_serializing_if = "Option::is_none")]
    pub flow: Option<String>,
    /// Link this provider  Either this or `unlink` must be set.  type: string in: body
    #[serde(rename = "link", skip_serializing_if = "Option::is_none")]
    pub link: Option<String>,
    /// Method  Should be set to profile when trying to update a profile.
    #[serde(rename = "method")]
    pub method: String,
    /// The identity's traits  in: body
    #[serde(rename = "traits", skip_serializing_if = "Option::is_none")]
    pub traits: Option<serde_json::Value>,
    /// Unlink this provider  Either this or `link` must be set.  type: string in: body
    #[serde(rename = "unlink", skip_serializing_if = "Option::is_none")]
    pub unlink: Option<String>,
    /// UpstreamParameters are the parameters that are passed to the upstream identity provider.  These parameters are optional and depend on what the upstream identity provider supports. Supported parameters are: `login_hint` (string): The `login_hint` parameter suppresses the account chooser and either pre-fills the email box on the sign-in form, or selects the proper session. `hd` (string): The `hd` parameter limits the login/registration process to a Google Organization, e.g. `mycollege.edu`.
    #[serde(rename = "upstream_parameters", skip_serializing_if = "Option::is_none")]
    pub upstream_parameters: Option<serde_json::Value>,
}


impl UpdateSettingsFlowWithOidcMethod {
    /// Update Settings Flow with OpenID Connect Method
    pub fn new(method: String) -> UpdateSettingsFlowWithOidcMethod {
        UpdateSettingsFlowWithOidcMethod {
                flow: None,
                link: None,
                method,
                traits: None,
                unlink: None,
                upstream_parameters: None,
        }
    }
}


