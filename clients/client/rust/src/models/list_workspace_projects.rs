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
pub struct ListWorkspaceProjects {
    #[serde(rename = "has_next_page")]
    pub has_next_page: bool,
    #[serde(rename = "next_page")]
    pub next_page: String,
    #[serde(rename = "projects")]
    pub projects: Vec<models::ProjectMetadata>,
}

impl ListWorkspaceProjects {
    pub fn new(has_next_page: bool, next_page: String, projects: Vec<models::ProjectMetadata>) -> ListWorkspaceProjects {
        ListWorkspaceProjects {
            has_next_page,
            next_page,
            projects,
        }
    }
}

