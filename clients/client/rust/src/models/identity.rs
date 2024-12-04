/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 * Generated by: https://openapi-generator.tech
 */

use crate::models;
use serde::{Deserialize, Serialize};

/// Identity : An [identity](https://www.ory.sh/docs/kratos/concepts/identity-user-model) represents a (human) user in Ory.
#[derive(Clone, Default, Debug, PartialEq, Serialize, Deserialize)]
pub struct Identity {
    /// CreatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "created_at", skip_serializing_if = "Option::is_none")]
    pub created_at: Option<String>,
    /// Credentials represents all credentials that can be used for authenticating this identity.
    #[serde(rename = "credentials", skip_serializing_if = "Option::is_none")]
    pub credentials: Option<std::collections::HashMap<String, models::IdentityCredentials>>,
    /// ID is the identity's unique identifier.  The Identity ID can not be changed and can not be chosen. This ensures future compatibility and optimization for distributed stores such as CockroachDB.
    #[serde(rename = "id")]
    pub id: String,
    /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
    #[serde(rename = "metadata_admin", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub metadata_admin: Option<Option<serde_json::Value>>,
    /// NullJSONRawMessage represents a json.RawMessage that works well with JSON, SQL, and Swagger and is NULLable-
    #[serde(rename = "metadata_public", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub metadata_public: Option<Option<serde_json::Value>>,
    #[serde(rename = "organization_id", default, with = "::serde_with::rust::double_option", skip_serializing_if = "Option::is_none")]
    pub organization_id: Option<Option<String>>,
    /// RecoveryAddresses contains all the addresses that can be used to recover an identity.
    #[serde(rename = "recovery_addresses", skip_serializing_if = "Option::is_none")]
    pub recovery_addresses: Option<Vec<models::RecoveryIdentityAddress>>,
    /// SchemaID is the ID of the JSON Schema to be used for validating the identity's traits.
    #[serde(rename = "schema_id")]
    pub schema_id: String,
    /// SchemaURL is the URL of the endpoint where the identity's traits schema can be fetched from.  format: url
    #[serde(rename = "schema_url")]
    pub schema_url: String,
    /// State is the identity's state.  This value has currently no effect. active StateActive inactive StateInactive
    #[serde(rename = "state", skip_serializing_if = "Option::is_none")]
    pub state: Option<StateEnum>,
    #[serde(rename = "state_changed_at", skip_serializing_if = "Option::is_none")]
    pub state_changed_at: Option<String>,
    /// Traits represent an identity's traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in `schema_url`.
    #[serde(rename = "traits", deserialize_with = "Option::deserialize")]
    pub traits: Option<serde_json::Value>,
    /// UpdatedAt is a helper struct field for gobuffalo.pop.
    #[serde(rename = "updated_at", skip_serializing_if = "Option::is_none")]
    pub updated_at: Option<String>,
    /// VerifiableAddresses contains all the addresses that can be verified by the user.
    #[serde(rename = "verifiable_addresses", skip_serializing_if = "Option::is_none")]
    pub verifiable_addresses: Option<Vec<models::VerifiableIdentityAddress>>,
}

impl Identity {
    /// An [identity](https://www.ory.sh/docs/kratos/concepts/identity-user-model) represents a (human) user in Ory.
    pub fn new(id: String, schema_id: String, schema_url: String, traits: Option<serde_json::Value>) -> Identity {
        Identity {
            created_at: None,
            credentials: None,
            id,
            metadata_admin: None,
            metadata_public: None,
            organization_id: None,
            recovery_addresses: None,
            schema_id,
            schema_url,
            state: None,
            state_changed_at: None,
            traits,
            updated_at: None,
            verifiable_addresses: None,
        }
    }
}
/// State is the identity's state.  This value has currently no effect. active StateActive inactive StateInactive
#[derive(Clone, Copy, Debug, Eq, PartialEq, Ord, PartialOrd, Hash, Serialize, Deserialize)]
pub enum StateEnum {
    #[serde(rename = "active")]
    Active,
    #[serde(rename = "inactive")]
    Inactive,
}

impl Default for StateEnum {
    fn default() -> StateEnum {
        Self::Active
    }
}

