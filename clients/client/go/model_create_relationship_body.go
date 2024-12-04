/*
Ory APIs

# Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 

API version: v1.15.14
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// checks if the CreateRelationshipBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CreateRelationshipBody{}

// CreateRelationshipBody Create Relationship Request Body
type CreateRelationshipBody struct {
	// Namespace to query
	Namespace *string `json:"namespace,omitempty"`
	// Object to query
	Object *string `json:"object,omitempty"`
	// Relation to query
	Relation *string `json:"relation,omitempty"`
	// SubjectID to query  Either SubjectSet or SubjectID can be provided.
	SubjectId *string `json:"subject_id,omitempty"`
	SubjectSet *SubjectSet `json:"subject_set,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _CreateRelationshipBody CreateRelationshipBody

// NewCreateRelationshipBody instantiates a new CreateRelationshipBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateRelationshipBody() *CreateRelationshipBody {
	this := CreateRelationshipBody{}
	return &this
}

// NewCreateRelationshipBodyWithDefaults instantiates a new CreateRelationshipBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateRelationshipBodyWithDefaults() *CreateRelationshipBody {
	this := CreateRelationshipBody{}
	return &this
}

// GetNamespace returns the Namespace field value if set, zero value otherwise.
func (o *CreateRelationshipBody) GetNamespace() string {
	if o == nil || IsNil(o.Namespace) {
		var ret string
		return ret
	}
	return *o.Namespace
}

// GetNamespaceOk returns a tuple with the Namespace field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRelationshipBody) GetNamespaceOk() (*string, bool) {
	if o == nil || IsNil(o.Namespace) {
		return nil, false
	}
	return o.Namespace, true
}

// HasNamespace returns a boolean if a field has been set.
func (o *CreateRelationshipBody) HasNamespace() bool {
	if o != nil && !IsNil(o.Namespace) {
		return true
	}

	return false
}

// SetNamespace gets a reference to the given string and assigns it to the Namespace field.
func (o *CreateRelationshipBody) SetNamespace(v string) {
	o.Namespace = &v
}

// GetObject returns the Object field value if set, zero value otherwise.
func (o *CreateRelationshipBody) GetObject() string {
	if o == nil || IsNil(o.Object) {
		var ret string
		return ret
	}
	return *o.Object
}

// GetObjectOk returns a tuple with the Object field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRelationshipBody) GetObjectOk() (*string, bool) {
	if o == nil || IsNil(o.Object) {
		return nil, false
	}
	return o.Object, true
}

// HasObject returns a boolean if a field has been set.
func (o *CreateRelationshipBody) HasObject() bool {
	if o != nil && !IsNil(o.Object) {
		return true
	}

	return false
}

// SetObject gets a reference to the given string and assigns it to the Object field.
func (o *CreateRelationshipBody) SetObject(v string) {
	o.Object = &v
}

// GetRelation returns the Relation field value if set, zero value otherwise.
func (o *CreateRelationshipBody) GetRelation() string {
	if o == nil || IsNil(o.Relation) {
		var ret string
		return ret
	}
	return *o.Relation
}

// GetRelationOk returns a tuple with the Relation field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRelationshipBody) GetRelationOk() (*string, bool) {
	if o == nil || IsNil(o.Relation) {
		return nil, false
	}
	return o.Relation, true
}

// HasRelation returns a boolean if a field has been set.
func (o *CreateRelationshipBody) HasRelation() bool {
	if o != nil && !IsNil(o.Relation) {
		return true
	}

	return false
}

// SetRelation gets a reference to the given string and assigns it to the Relation field.
func (o *CreateRelationshipBody) SetRelation(v string) {
	o.Relation = &v
}

// GetSubjectId returns the SubjectId field value if set, zero value otherwise.
func (o *CreateRelationshipBody) GetSubjectId() string {
	if o == nil || IsNil(o.SubjectId) {
		var ret string
		return ret
	}
	return *o.SubjectId
}

// GetSubjectIdOk returns a tuple with the SubjectId field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRelationshipBody) GetSubjectIdOk() (*string, bool) {
	if o == nil || IsNil(o.SubjectId) {
		return nil, false
	}
	return o.SubjectId, true
}

// HasSubjectId returns a boolean if a field has been set.
func (o *CreateRelationshipBody) HasSubjectId() bool {
	if o != nil && !IsNil(o.SubjectId) {
		return true
	}

	return false
}

// SetSubjectId gets a reference to the given string and assigns it to the SubjectId field.
func (o *CreateRelationshipBody) SetSubjectId(v string) {
	o.SubjectId = &v
}

// GetSubjectSet returns the SubjectSet field value if set, zero value otherwise.
func (o *CreateRelationshipBody) GetSubjectSet() SubjectSet {
	if o == nil || IsNil(o.SubjectSet) {
		var ret SubjectSet
		return ret
	}
	return *o.SubjectSet
}

// GetSubjectSetOk returns a tuple with the SubjectSet field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateRelationshipBody) GetSubjectSetOk() (*SubjectSet, bool) {
	if o == nil || IsNil(o.SubjectSet) {
		return nil, false
	}
	return o.SubjectSet, true
}

// HasSubjectSet returns a boolean if a field has been set.
func (o *CreateRelationshipBody) HasSubjectSet() bool {
	if o != nil && !IsNil(o.SubjectSet) {
		return true
	}

	return false
}

// SetSubjectSet gets a reference to the given SubjectSet and assigns it to the SubjectSet field.
func (o *CreateRelationshipBody) SetSubjectSet(v SubjectSet) {
	o.SubjectSet = &v
}

func (o CreateRelationshipBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CreateRelationshipBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Namespace) {
		toSerialize["namespace"] = o.Namespace
	}
	if !IsNil(o.Object) {
		toSerialize["object"] = o.Object
	}
	if !IsNil(o.Relation) {
		toSerialize["relation"] = o.Relation
	}
	if !IsNil(o.SubjectId) {
		toSerialize["subject_id"] = o.SubjectId
	}
	if !IsNil(o.SubjectSet) {
		toSerialize["subject_set"] = o.SubjectSet
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CreateRelationshipBody) UnmarshalJSON(data []byte) (err error) {
	varCreateRelationshipBody := _CreateRelationshipBody{}

	err = json.Unmarshal(data, &varCreateRelationshipBody)

	if err != nil {
		return err
	}

	*o = CreateRelationshipBody(varCreateRelationshipBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "namespace")
		delete(additionalProperties, "object")
		delete(additionalProperties, "relation")
		delete(additionalProperties, "subject_id")
		delete(additionalProperties, "subject_set")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCreateRelationshipBody struct {
	value *CreateRelationshipBody
	isSet bool
}

func (v NullableCreateRelationshipBody) Get() *CreateRelationshipBody {
	return v.value
}

func (v *NullableCreateRelationshipBody) Set(val *CreateRelationshipBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateRelationshipBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateRelationshipBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateRelationshipBody(val *CreateRelationshipBody) *NullableCreateRelationshipBody {
	return &NullableCreateRelationshipBody{value: val, isSet: true}
}

func (v NullableCreateRelationshipBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateRelationshipBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


