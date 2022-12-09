

# UpdateIdentityBody

Update Identity Body

## Properties

| Name | Type | Description | Notes |
|------------ | ------------- | ------------- | -------------|
|**credentials** | [**IdentityWithCredentials**](IdentityWithCredentials.md) |  |  [optional] |
|**metadataAdmin** | **Object** | Store metadata about the user which is only accessible through admin APIs such as &#x60;GET /admin/identities/&lt;id&gt;&#x60;. |  [optional] |
|**metadataPublic** | **Object** | Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field. |  [optional] |
|**schemaId** | **String** | SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID. |  |
|**state** | **IdentityState** |  |  |
|**traits** | **Object** | Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;. |  |


