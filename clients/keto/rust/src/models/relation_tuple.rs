/*
 * Ory Keto API
 *
 * Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 
 *
 * The version of the OpenAPI document: v0.10.0-alpha.0
 * Contact: hi@ory.sh
 * Generated by: https://openapi-generator.tech
 */




#[derive(Clone, Debug, PartialEq, Serialize, Deserialize)]
pub struct RelationTuple {
    /// Namespace of the Relation Tuple
    #[serde(rename = "namespace")]
    pub namespace: String,
    /// Object of the Relation Tuple
    #[serde(rename = "object")]
    pub object: String,
    /// Relation of the Relation Tuple
    #[serde(rename = "relation")]
    pub relation: String,
    /// SubjectID of the Relation Tuple  Either SubjectSet or SubjectID can be provided.
    #[serde(rename = "subject_id", skip_serializing_if = "Option::is_none")]
    pub subject_id: Option<String>,
    #[serde(rename = "subject_set", skip_serializing_if = "Option::is_none")]
    pub subject_set: Option<Box<crate::models::SubjectSet>>,
}


impl RelationTuple {
    pub fn new(namespace: String, object: String, relation: String) -> RelationTuple {
        RelationTuple {
                namespace,
                object,
                relation,
                subject_id: None,
                subject_set: None,
        }
    }
}


