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
pub struct Money {
    #[serde(rename = "Cents", skip_serializing_if = "Option::is_none")]
    pub cents: Option<i64>,
    #[serde(rename = "String", skip_serializing_if = "Option::is_none")]
    pub string: Option<String>,
    #[serde(rename = "Unit", skip_serializing_if = "Option::is_none")]
    pub unit: Option<String>,
}

impl Money {
    pub fn new() -> Money {
        Money {
            cents: None,
            string: None,
            unit: None,
        }
    }
}

