/*
Ory Keto API

Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 

API version: v0.10.0-alpha.0
Contact: hi@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// GetVersion200Response struct for GetVersion200Response
type GetVersion200Response struct {
	// The version of Ory Keto.
	Version string `json:"version"`
}

// NewGetVersion200Response instantiates a new GetVersion200Response object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewGetVersion200Response(version string) *GetVersion200Response {
	this := GetVersion200Response{}
	this.Version = version
	return &this
}

// NewGetVersion200ResponseWithDefaults instantiates a new GetVersion200Response object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewGetVersion200ResponseWithDefaults() *GetVersion200Response {
	this := GetVersion200Response{}
	return &this
}

// GetVersion returns the Version field value
func (o *GetVersion200Response) GetVersion() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Version
}

// GetVersionOk returns a tuple with the Version field value
// and a boolean to check if the value has been set.
func (o *GetVersion200Response) GetVersionOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Version, true
}

// SetVersion sets field value
func (o *GetVersion200Response) SetVersion(v string) {
	o.Version = v
}

func (o GetVersion200Response) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if true {
		toSerialize["version"] = o.Version
	}
	return json.Marshal(toSerialize)
}

type NullableGetVersion200Response struct {
	value *GetVersion200Response
	isSet bool
}

func (v NullableGetVersion200Response) Get() *GetVersion200Response {
	return v.value
}

func (v *NullableGetVersion200Response) Set(val *GetVersion200Response) {
	v.value = val
	v.isSet = true
}

func (v NullableGetVersion200Response) IsSet() bool {
	return v.isSet
}

func (v *NullableGetVersion200Response) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableGetVersion200Response(val *GetVersion200Response) *NullableGetVersion200Response {
	return &NullableGetVersion200Response{value: val, isSet: true}
}

func (v NullableGetVersion200Response) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableGetVersion200Response) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


