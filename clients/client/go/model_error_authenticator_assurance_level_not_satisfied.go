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

// checks if the ErrorAuthenticatorAssuranceLevelNotSatisfied type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ErrorAuthenticatorAssuranceLevelNotSatisfied{}

// ErrorAuthenticatorAssuranceLevelNotSatisfied struct for ErrorAuthenticatorAssuranceLevelNotSatisfied
type ErrorAuthenticatorAssuranceLevelNotSatisfied struct {
	Error *GenericError `json:"error,omitempty"`
	// Points to where to redirect the user to next.
	RedirectBrowserTo *string `json:"redirect_browser_to,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _ErrorAuthenticatorAssuranceLevelNotSatisfied ErrorAuthenticatorAssuranceLevelNotSatisfied

// NewErrorAuthenticatorAssuranceLevelNotSatisfied instantiates a new ErrorAuthenticatorAssuranceLevelNotSatisfied object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewErrorAuthenticatorAssuranceLevelNotSatisfied() *ErrorAuthenticatorAssuranceLevelNotSatisfied {
	this := ErrorAuthenticatorAssuranceLevelNotSatisfied{}
	return &this
}

// NewErrorAuthenticatorAssuranceLevelNotSatisfiedWithDefaults instantiates a new ErrorAuthenticatorAssuranceLevelNotSatisfied object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewErrorAuthenticatorAssuranceLevelNotSatisfiedWithDefaults() *ErrorAuthenticatorAssuranceLevelNotSatisfied {
	this := ErrorAuthenticatorAssuranceLevelNotSatisfied{}
	return &this
}

// GetError returns the Error field value if set, zero value otherwise.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) GetError() GenericError {
	if o == nil || IsNil(o.Error) {
		var ret GenericError
		return ret
	}
	return *o.Error
}

// GetErrorOk returns a tuple with the Error field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) GetErrorOk() (*GenericError, bool) {
	if o == nil || IsNil(o.Error) {
		return nil, false
	}
	return o.Error, true
}

// HasError returns a boolean if a field has been set.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) HasError() bool {
	if o != nil && !IsNil(o.Error) {
		return true
	}

	return false
}

// SetError gets a reference to the given GenericError and assigns it to the Error field.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) SetError(v GenericError) {
	o.Error = &v
}

// GetRedirectBrowserTo returns the RedirectBrowserTo field value if set, zero value otherwise.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) GetRedirectBrowserTo() string {
	if o == nil || IsNil(o.RedirectBrowserTo) {
		var ret string
		return ret
	}
	return *o.RedirectBrowserTo
}

// GetRedirectBrowserToOk returns a tuple with the RedirectBrowserTo field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) GetRedirectBrowserToOk() (*string, bool) {
	if o == nil || IsNil(o.RedirectBrowserTo) {
		return nil, false
	}
	return o.RedirectBrowserTo, true
}

// HasRedirectBrowserTo returns a boolean if a field has been set.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) HasRedirectBrowserTo() bool {
	if o != nil && !IsNil(o.RedirectBrowserTo) {
		return true
	}

	return false
}

// SetRedirectBrowserTo gets a reference to the given string and assigns it to the RedirectBrowserTo field.
func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) SetRedirectBrowserTo(v string) {
	o.RedirectBrowserTo = &v
}

func (o ErrorAuthenticatorAssuranceLevelNotSatisfied) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ErrorAuthenticatorAssuranceLevelNotSatisfied) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Error) {
		toSerialize["error"] = o.Error
	}
	if !IsNil(o.RedirectBrowserTo) {
		toSerialize["redirect_browser_to"] = o.RedirectBrowserTo
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ErrorAuthenticatorAssuranceLevelNotSatisfied) UnmarshalJSON(data []byte) (err error) {
	varErrorAuthenticatorAssuranceLevelNotSatisfied := _ErrorAuthenticatorAssuranceLevelNotSatisfied{}

	err = json.Unmarshal(data, &varErrorAuthenticatorAssuranceLevelNotSatisfied)

	if err != nil {
		return err
	}

	*o = ErrorAuthenticatorAssuranceLevelNotSatisfied(varErrorAuthenticatorAssuranceLevelNotSatisfied)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "error")
		delete(additionalProperties, "redirect_browser_to")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableErrorAuthenticatorAssuranceLevelNotSatisfied struct {
	value *ErrorAuthenticatorAssuranceLevelNotSatisfied
	isSet bool
}

func (v NullableErrorAuthenticatorAssuranceLevelNotSatisfied) Get() *ErrorAuthenticatorAssuranceLevelNotSatisfied {
	return v.value
}

func (v *NullableErrorAuthenticatorAssuranceLevelNotSatisfied) Set(val *ErrorAuthenticatorAssuranceLevelNotSatisfied) {
	v.value = val
	v.isSet = true
}

func (v NullableErrorAuthenticatorAssuranceLevelNotSatisfied) IsSet() bool {
	return v.isSet
}

func (v *NullableErrorAuthenticatorAssuranceLevelNotSatisfied) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableErrorAuthenticatorAssuranceLevelNotSatisfied(val *ErrorAuthenticatorAssuranceLevelNotSatisfied) *NullableErrorAuthenticatorAssuranceLevelNotSatisfied {
	return &NullableErrorAuthenticatorAssuranceLevelNotSatisfied{value: val, isSet: true}
}

func (v NullableErrorAuthenticatorAssuranceLevelNotSatisfied) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableErrorAuthenticatorAssuranceLevelNotSatisfied) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


