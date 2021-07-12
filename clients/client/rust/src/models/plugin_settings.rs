/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.0.1-alpha.15
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct PluginSettings {
    /// args
    #[serde(rename = "Args")]
    pub args: Vec<String>,
    /// devices
    #[serde(rename = "Devices")]
    pub devices: Vec<crate::models::PluginDevice>,
    /// env
    #[serde(rename = "Env")]
    pub env: Vec<String>,
    /// mounts
    #[serde(rename = "Mounts")]
    pub mounts: Vec<crate::models::PluginMount>,
}

impl PluginSettings {
    pub fn new(args: Vec<String>, devices: Vec<crate::models::PluginDevice>, env: Vec<String>, mounts: Vec<crate::models::PluginMount>) -> PluginSettings {
        PluginSettings {
            args,
            devices,
            env,
            mounts,
        }
    }
}

