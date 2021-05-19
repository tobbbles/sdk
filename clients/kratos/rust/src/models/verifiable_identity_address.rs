/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.0.4-alpha.1
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */

/// VerifiableIdentityAddress : VerifiableAddress is an identity's verifiable address



#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct VerifiableIdentityAddress {
    /// When this entry was created
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    #[serde(rename = "id")]
    pub id: String,
    /// VerifiableAddressStatus must not exceed 16 characters as that is the limitation in the SQL Schema
    #[serde(rename = "status")]
    pub status: String,
    /// When this entry was last updated
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
    /// The address value  example foo@user.com
    #[serde(rename = "value")]
    pub value: String,
    /// Indicates if the address has already been verified
    #[serde(rename = "verified")]
    pub verified: bool,
    #[serde(rename = "verified_at", skip_serializing_if = "Option::is_none")]
    pub verified_at: Option<String>,
    /// VerifiableAddressType must not exceed 16 characters as that is the limitation in the SQL Schema
    #[serde(rename = "via")]
    pub via: String,
}

impl VerifiableIdentityAddress {
    /// VerifiableAddress is an identity's verifiable address
    pub fn new(id: String, status: String, value: String, verified: bool, via: String) -> VerifiableIdentityAddress {
        VerifiableIdentityAddress {
            created_at: None,
            id,
            status,
            updated_at: None,
            value,
            verified,
            verified_at: None,
            via,
        }
    }
}


