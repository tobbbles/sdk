/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * API version: v0.0.4-alpha.1
 * Contact: hi@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// PluginConfigNetwork PluginConfigNetwork plugin config network
type PluginConfigNetwork struct {
	// type
	Type string `json:"Type"`
}

// NewPluginConfigNetwork instantiates a new PluginConfigNetwork object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewPluginConfigNetwork(type_ string) *PluginConfigNetwork {
	this := PluginConfigNetwork{}
	this.Type = type_
	return &this
}

// NewPluginConfigNetworkWithDefaults instantiates a new PluginConfigNetwork object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewPluginConfigNetworkWithDefaults() *PluginConfigNetwork {
	this := PluginConfigNetwork{}
	return &this
}

// GetType returns the Type field value
func (o *PluginConfigNetwork) GetType() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Type
}

// GetTypeOk returns a tuple with the Type field value
// and a boolean to check if the value has been set.
func (o *PluginConfigNetwork) GetTypeOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Type, true
}

// SetType sets field value
func (o *PluginConfigNetwork) SetType(v string) {
	o.Type = v
}

func (o PluginConfigNetwork) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["Type"] = o.Type
	}
	return json.Marshal(toSerialize)
}

type NullablePluginConfigNetwork struct {
	value *PluginConfigNetwork
	isSet bool
}

func (v NullablePluginConfigNetwork) Get() *PluginConfigNetwork {
	return v.value
}

func (v *NullablePluginConfigNetwork) Set(val *PluginConfigNetwork) {
	v.value = val
	v.isSet = true
}

func (v NullablePluginConfigNetwork) IsSet() bool {
	return v.isSet
}

func (v *NullablePluginConfigNetwork) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullablePluginConfigNetwork(val *PluginConfigNetwork) *NullablePluginConfigNetwork {
	return &NullablePluginConfigNetwork{value: val, isSet: true}
}

func (v NullablePluginConfigNetwork) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullablePluginConfigNetwork) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


