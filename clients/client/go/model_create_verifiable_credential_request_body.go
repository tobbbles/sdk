/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.12.0
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// checks if the CreateVerifiableCredentialRequestBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &CreateVerifiableCredentialRequestBody{}

// CreateVerifiableCredentialRequestBody struct for CreateVerifiableCredentialRequestBody
type CreateVerifiableCredentialRequestBody struct {
	Format *string `json:"format,omitempty"`
	Proof *VerifiableCredentialProof `json:"proof,omitempty"`
	Types []string `json:"types,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _CreateVerifiableCredentialRequestBody CreateVerifiableCredentialRequestBody

// NewCreateVerifiableCredentialRequestBody instantiates a new CreateVerifiableCredentialRequestBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewCreateVerifiableCredentialRequestBody() *CreateVerifiableCredentialRequestBody {
	this := CreateVerifiableCredentialRequestBody{}
	return &this
}

// NewCreateVerifiableCredentialRequestBodyWithDefaults instantiates a new CreateVerifiableCredentialRequestBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewCreateVerifiableCredentialRequestBodyWithDefaults() *CreateVerifiableCredentialRequestBody {
	this := CreateVerifiableCredentialRequestBody{}
	return &this
}

// GetFormat returns the Format field value if set, zero value otherwise.
func (o *CreateVerifiableCredentialRequestBody) GetFormat() string {
	if o == nil || IsNil(o.Format) {
		var ret string
		return ret
	}
	return *o.Format
}

// GetFormatOk returns a tuple with the Format field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateVerifiableCredentialRequestBody) GetFormatOk() (*string, bool) {
	if o == nil || IsNil(o.Format) {
		return nil, false
	}
	return o.Format, true
}

// HasFormat returns a boolean if a field has been set.
func (o *CreateVerifiableCredentialRequestBody) HasFormat() bool {
	if o != nil && !IsNil(o.Format) {
		return true
	}

	return false
}

// SetFormat gets a reference to the given string and assigns it to the Format field.
func (o *CreateVerifiableCredentialRequestBody) SetFormat(v string) {
	o.Format = &v
}

// GetProof returns the Proof field value if set, zero value otherwise.
func (o *CreateVerifiableCredentialRequestBody) GetProof() VerifiableCredentialProof {
	if o == nil || IsNil(o.Proof) {
		var ret VerifiableCredentialProof
		return ret
	}
	return *o.Proof
}

// GetProofOk returns a tuple with the Proof field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateVerifiableCredentialRequestBody) GetProofOk() (*VerifiableCredentialProof, bool) {
	if o == nil || IsNil(o.Proof) {
		return nil, false
	}
	return o.Proof, true
}

// HasProof returns a boolean if a field has been set.
func (o *CreateVerifiableCredentialRequestBody) HasProof() bool {
	if o != nil && !IsNil(o.Proof) {
		return true
	}

	return false
}

// SetProof gets a reference to the given VerifiableCredentialProof and assigns it to the Proof field.
func (o *CreateVerifiableCredentialRequestBody) SetProof(v VerifiableCredentialProof) {
	o.Proof = &v
}

// GetTypes returns the Types field value if set, zero value otherwise.
func (o *CreateVerifiableCredentialRequestBody) GetTypes() []string {
	if o == nil || IsNil(o.Types) {
		var ret []string
		return ret
	}
	return o.Types
}

// GetTypesOk returns a tuple with the Types field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *CreateVerifiableCredentialRequestBody) GetTypesOk() ([]string, bool) {
	if o == nil || IsNil(o.Types) {
		return nil, false
	}
	return o.Types, true
}

// HasTypes returns a boolean if a field has been set.
func (o *CreateVerifiableCredentialRequestBody) HasTypes() bool {
	if o != nil && !IsNil(o.Types) {
		return true
	}

	return false
}

// SetTypes gets a reference to the given []string and assigns it to the Types field.
func (o *CreateVerifiableCredentialRequestBody) SetTypes(v []string) {
	o.Types = v
}

func (o CreateVerifiableCredentialRequestBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o CreateVerifiableCredentialRequestBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Format) {
		toSerialize["format"] = o.Format
	}
	if !IsNil(o.Proof) {
		toSerialize["proof"] = o.Proof
	}
	if !IsNil(o.Types) {
		toSerialize["types"] = o.Types
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *CreateVerifiableCredentialRequestBody) UnmarshalJSON(data []byte) (err error) {
	varCreateVerifiableCredentialRequestBody := _CreateVerifiableCredentialRequestBody{}

	err = json.Unmarshal(data, &varCreateVerifiableCredentialRequestBody)

	if err != nil {
		return err
	}

	*o = CreateVerifiableCredentialRequestBody(varCreateVerifiableCredentialRequestBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "format")
		delete(additionalProperties, "proof")
		delete(additionalProperties, "types")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableCreateVerifiableCredentialRequestBody struct {
	value *CreateVerifiableCredentialRequestBody
	isSet bool
}

func (v NullableCreateVerifiableCredentialRequestBody) Get() *CreateVerifiableCredentialRequestBody {
	return v.value
}

func (v *NullableCreateVerifiableCredentialRequestBody) Set(val *CreateVerifiableCredentialRequestBody) {
	v.value = val
	v.isSet = true
}

func (v NullableCreateVerifiableCredentialRequestBody) IsSet() bool {
	return v.isSet
}

func (v *NullableCreateVerifiableCredentialRequestBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableCreateVerifiableCredentialRequestBody(val *CreateVerifiableCredentialRequestBody) *NullableCreateVerifiableCredentialRequestBody {
	return &NullableCreateVerifiableCredentialRequestBody{value: val, isSet: true}
}

func (v NullableCreateVerifiableCredentialRequestBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableCreateVerifiableCredentialRequestBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


