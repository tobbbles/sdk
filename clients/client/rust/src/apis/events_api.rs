/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.5.1
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */


use std::fmt::Display;

use num_traits;
use reqwest;

use crate::apis::ResponseContent;
use super::{Error, configuration};

trait NumVecJoin {
    fn join(&self, sep: &str) -> String;
}

impl <T: Display + num_traits::Num> NumVecJoin for Vec<T> {
    fn join(&self, sep: &str) -> String {
        self.iter()
            .map(ToString::to_string)
            .collect::<Vec<String>>()
            .join(sep)
    }
}


/// struct for typed errors of method `create_event_stream`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum CreateEventStreamError {
    Status400(crate::models::ErrorGeneric),
    Status403(crate::models::ErrorGeneric),
    Status409(crate::models::ErrorGeneric),
    DefaultResponse(crate::models::ErrorGeneric),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `delete_event_stream`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum DeleteEventStreamError {
    Status400(crate::models::ErrorGeneric),
    Status403(crate::models::ErrorGeneric),
    Status409(crate::models::ErrorGeneric),
    DefaultResponse(crate::models::ErrorGeneric),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `list_event_streams`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum ListEventStreamsError {
    Status400(crate::models::ErrorGeneric),
    Status403(crate::models::ErrorGeneric),
    DefaultResponse(crate::models::ErrorGeneric),
    UnknownValue(serde_json::Value),
}

/// struct for typed errors of method `set_event_stream`
#[derive(Debug, Clone, Serialize, Deserialize)]
#[serde(untagged)]
pub enum SetEventStreamError {
    Status400(crate::models::ErrorGeneric),
    Status403(crate::models::ErrorGeneric),
    Status409(crate::models::ErrorGeneric),
    DefaultResponse(crate::models::ErrorGeneric),
    UnknownValue(serde_json::Value),
}


pub async fn create_event_stream(configuration: &configuration::Configuration, project_id: &str, create_event_stream_body: &crate::models::CreateEventStreamBody) -> Result<crate::models::EventStream, Error<CreateEventStreamError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/projects/{project_id}/eventstreams", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::POST, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&create_event_stream_body);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<CreateEventStreamError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

/// Remove an event stream from a project.
pub async fn delete_event_stream(configuration: &configuration::Configuration, project_id: &str, event_stream_id: &str) -> Result<(), Error<DeleteEventStreamError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/projects/{project_id}/eventstreams/{event_stream_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id), event_stream_id=crate::apis::urlencode(event_stream_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::DELETE, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        Ok(())
    } else {
        let local_var_entity: Option<DeleteEventStreamError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn list_event_streams(configuration: &configuration::Configuration, project_id: &str) -> Result<crate::models::ListEventStreams, Error<ListEventStreamsError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/projects/{project_id}/eventstreams", configuration.base_path, project_id=crate::apis::urlencode(project_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::GET, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<ListEventStreamsError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

pub async fn set_event_stream(configuration: &configuration::Configuration, project_id: &str, event_stream_id: &str, set_event_stream_body: Option<&crate::models::SetEventStreamBody>) -> Result<crate::models::EventStream, Error<SetEventStreamError>> {

    let local_var_client = &configuration.client;

    let local_var_uri_str = format!("{}/projects/{project_id}/eventstreams/{event_stream_id}", configuration.base_path, project_id=crate::apis::urlencode(project_id), event_stream_id=crate::apis::urlencode(event_stream_id));
    let mut local_var_req_builder = local_var_client.request(reqwest::Method::PUT, local_var_uri_str.as_str());

    if let Some(ref local_var_user_agent) = configuration.user_agent {
        local_var_req_builder = local_var_req_builder.header(reqwest::header::USER_AGENT, local_var_user_agent.clone());
    }
    if let Some(ref local_var_token) = configuration.bearer_access_token {
        local_var_req_builder = local_var_req_builder.bearer_auth(local_var_token.to_owned());
    };
    local_var_req_builder = local_var_req_builder.json(&set_event_stream_body);

    let local_var_req = local_var_req_builder.build()?;
    let local_var_resp = local_var_client.execute(local_var_req).await?;

    let local_var_status = local_var_resp.status();
    let local_var_content = local_var_resp.text().await?;

    if !local_var_status.is_client_error() && !local_var_status.is_server_error() {
        serde_json::from_str(&local_var_content).map_err(Error::from)
    } else {
        let local_var_entity: Option<SetEventStreamError> = serde_json::from_str(&local_var_content).ok();
        let local_var_error = ResponseContent { status: local_var_status, content: local_var_content, entity: local_var_entity };
        Err(Error::ResponseError(local_var_error))
    }
}

