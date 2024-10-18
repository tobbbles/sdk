/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.7
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// UpdateVerificationFlowBody : Update Verification Flow Request Body
#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
#[serde(tag = "method")]
pub enum UpdateVerificationFlowBody {
    #[serde(rename="link")]
    Link(Box<models::UpdateVerificationFlowWithLinkMethod>),
    #[serde(rename="code")]
    Code(Box<models::UpdateVerificationFlowWithCodeMethod>),
}

impl Default for UpdateVerificationFlowBody {
    fn default() -> Self {
        Self::Link(Default::default())
    }
}


