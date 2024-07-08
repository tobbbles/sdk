/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.10
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// Relationships : Paginated Relationship List
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct Relationships {
    /// The opaque token to provide in a subsequent request to get the next page. It is the empty string iff this is the last page.
    #[serde(rename = "next_page_token", skip_serializing_if = "Option::is_none")]
    pub next_page_token: Option<String>,
    #[serde(rename = "relation_tuples", skip_serializing_if = "Option::is_none")]
    pub relation_tuples: Option<Vec<models::Relationship>>,
}

impl Relationships {
    /// Paginated Relationship List
    pub fn new() -> Relationships {
        Relationships {
            next_page_token: None,
            relation_tuples: None,
        }
    }
}

