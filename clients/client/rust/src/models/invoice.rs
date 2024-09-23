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
pub struct Invoice {
    /// The ID of the invoice.
    #[serde(rename = "id")]
    pub id: String,
    #[serde(rename = "invoiced_at")]
    pub invoiced_at: String,
    /// Type is the type of the invoice. usage InvoiceTypeUsage base InvoiceTypeBase
    #[serde(rename = "type")]
    pub r#type: TypeEnum,
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
    #[serde(rename = "v1", skip_serializing_if = "Option::is_none")]
    pub v1: Option<Box<models::InvoiceDataV1>>,
}

impl Invoice {
    pub fn new(id: String, invoiced_at: String, r#type: TypeEnum) -> Invoice {
        Invoice {
            id,
            invoiced_at,
            r#type,
            updated_at: None,
            v1: None,
        }
    }
}
/// Type is the type of the invoice. usage InvoiceTypeUsage base InvoiceTypeBase
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum TypeEnum {
    #[serde(rename = "usage")]
    Usage,
    #[serde(rename = "base")]
    Base,
}

impl Default for TypeEnum {
    fn default() -> TypeEnum {
        Self::Usage
    }
}

