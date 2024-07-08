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

/// GetMetricsEventTypesResponse : Response of the getMetricsEventTypes endpoint
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct GetMetricsEventTypesResponse {
    /// The list of data points.
    #[serde(rename = "events")]
    pub events: Vec<String>,
}

impl GetMetricsEventTypesResponse {
    /// Response of the getMetricsEventTypes endpoint
    pub fn new(events: Vec<String>) -> GetMetricsEventTypesResponse {
        GetMetricsEventTypesResponse {
            events,
        }
    }
}

