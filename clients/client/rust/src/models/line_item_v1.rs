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

#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct LineItemV1 {
    #[serde(rename = "amount_in_cent", skip_serializing_if = "Option::is_none")]
    pub amount_in_cent: Option<i64>,
    #[serde(rename = "description", skip_serializing_if = "Option::is_none")]
    pub description: Option<String>,
    /// Each line item can have sub-items to create a hierarchy.
    #[serde(rename = "items", skip_serializing_if = "Option::is_none")]
    pub items: Option<Vec<models::LineItemV1>>,
    #[serde(rename = "quantity", skip_serializing_if = "Option::is_none")]
    pub quantity: Option<i64>,
    #[serde(rename = "title", skip_serializing_if = "Option::is_none")]
    pub title: Option<String>,
    #[serde(rename = "unit_price", skip_serializing_if = "Option::is_none")]
    pub unit_price: Option<String>,
}

impl LineItemV1 {
    pub fn new() -> LineItemV1 {
        LineItemV1 {
            amount_in_cent: None,
            description: None,
            items: None,
            quantity: None,
            title: None,
            unit_price: None,
        }
    }
}

