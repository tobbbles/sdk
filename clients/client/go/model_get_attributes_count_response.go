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
	"fmt"
)

// checks if the GetAttributesCountResponse type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &GetAttributesCountResponse{}

// GetAttributesCountResponse Response of the getAttributesCount endpoint
type GetAttributesCountResponse struct {
	// The list of data points.
	Data []AttributesCountDatapoint `json:"data"`
	AdditionalProperties map[string]interface{}
}

type _GetAttributesCountResponse GetAttributesCountResponse

// NewGetAttributesCountResponse instantiates a new GetAttributesCountResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetAttributesCountResponse(data []AttributesCountDatapoint) *GetAttributesCountResponse {
	this := GetAttributesCountResponse{}
	this.Data = data
	return &this
}

// NewGetAttributesCountResponseWithDefaults instantiates a new GetAttributesCountResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetAttributesCountResponseWithDefaults() *GetAttributesCountResponse {
	this := GetAttributesCountResponse{}
	return &this
}

// GetData returns the Data field value
func (o *GetAttributesCountResponse) GetData() []AttributesCountDatapoint {
	if o == nil {
		var ret []AttributesCountDatapoint
		return ret
	}

	return o.Data
}

// GetDataOk returns a tuple with the Data field value
// and a boolean to check if the value has been set.
func (o *GetAttributesCountResponse) GetDataOk() ([]AttributesCountDatapoint, bool) {
	if o == nil {
		return nil, false
	}
	return o.Data, true
}

// SetData sets field value
func (o *GetAttributesCountResponse) SetData(v []AttributesCountDatapoint) {
	o.Data = v
}

func (o GetAttributesCountResponse) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o GetAttributesCountResponse) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["data"] = o.Data

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *GetAttributesCountResponse) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"data",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(data, &allProperties)

	if err != nil {
		return err;
	}

	for _, requiredProperty := range(requiredProperties) {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varGetAttributesCountResponse := _GetAttributesCountResponse{}

	err = json.Unmarshal(data, &varGetAttributesCountResponse)

	if err != nil {
		return err
	}

	*o = GetAttributesCountResponse(varGetAttributesCountResponse)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "data")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableGetAttributesCountResponse struct {
	value *GetAttributesCountResponse
	isSet bool
}

func (v NullableGetAttributesCountResponse) Get() *GetAttributesCountResponse {
	return v.value
}

func (v *NullableGetAttributesCountResponse) Set(val *GetAttributesCountResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableGetAttributesCountResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableGetAttributesCountResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetAttributesCountResponse(val *GetAttributesCountResponse) *NullableGetAttributesCountResponse {
	return &NullableGetAttributesCountResponse{value: val, isSet: true}
}

func (v NullableGetAttributesCountResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetAttributesCountResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


