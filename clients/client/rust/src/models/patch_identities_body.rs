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

/// PatchIdentitiesBody : Patch Identities Body
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct PatchIdentitiesBody {
    /// Identities holds the list of patches to apply  required
    #[serde(rename = "identities", skip_serializing_if = "Option::is_none")]
    pub identities: Option<Vec<models::IdentityPatch>>,
}

impl PatchIdentitiesBody {
    /// Patch Identities Body
    pub fn new() -> PatchIdentitiesBody {
        PatchIdentitiesBody {
            identities: None,
        }
    }
}

