/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// TrustOAuth2JwtGrantIssuer : Trust OAuth2 JWT Bearer Grant Type Issuer Request Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct TrustOAuth2JwtGrantIssuer {
    /// The \"allow_any_subject\" indicates that the issuer is allowed to have any principal as the subject of the JWT.
    #[serde(rename = "allow_any_subject", skip_serializing_if = "Option::is_none")]
    pub allow_any_subject: Option<bool>,
    /// The \"expires_at\" indicates, when grant will expire, so we will reject assertion from \"issuer\" targeting \"subject\".
    #[serde(rename = "expires_at")]
    pub expires_at: String,
    /// The \"issuer\" identifies the principal that issued the JWT assertion (same as \"iss\" claim in JWT).
    #[serde(rename = "issuer")]
    pub issuer: String,
    #[serde(rename = "jwk")]
    pub jwk: Box<models::JsonWebKey>,
    /// The \"scope\" contains list of scope values (as described in Section 3.3 of OAuth 2.0 [RFC6749])
    #[serde(rename = "scope")]
    pub scope: Vec<String>,
    /// The \"subject\" identifies the principal that is the subject of the JWT.
    #[serde(rename = "subject", skip_serializing_if = "Option::is_none")]
    pub subject: Option<String>,
}

impl TrustOAuth2JwtGrantIssuer {
    /// Trust OAuth2 JWT Bearer Grant Type Issuer Request Body
    pub fn new(expires_at: String, issuer: String, jwk: models::JsonWebKey, scope: Vec<String>) -> TrustOAuth2JwtGrantIssuer {
        TrustOAuth2JwtGrantIssuer {
            allow_any_subject: None,
            expires_at,
            issuer,
            jwk: Box::new(jwk),
            scope,
            subject: None,
        }
    }
}

