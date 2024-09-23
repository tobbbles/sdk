/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.15.3
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
)

// checks if the OrganizationBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &OrganizationBody{}

// OrganizationBody Create B2B SSO Organization Request Body
type OrganizationBody struct {
	// Domains contains the list of organization's domains.
	Domains []string `json:"domains,omitempty"`
	// Label contains the organization's label.
	Label *string `json:"label,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _OrganizationBody OrganizationBody

// NewOrganizationBody instantiates a new OrganizationBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewOrganizationBody() *OrganizationBody {
	this := OrganizationBody{}
	return &this
}

// NewOrganizationBodyWithDefaults instantiates a new OrganizationBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewOrganizationBodyWithDefaults() *OrganizationBody {
	this := OrganizationBody{}
	return &this
}

// GetDomains returns the Domains field value if set, zero value otherwise.
func (o *OrganizationBody) GetDomains() []string {
	if o == nil || IsNil(o.Domains) {
		var ret []string
		return ret
	}
	return o.Domains
}

// GetDomainsOk returns a tuple with the Domains field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OrganizationBody) GetDomainsOk() ([]string, bool) {
	if o == nil || IsNil(o.Domains) {
		return nil, false
	}
	return o.Domains, true
}

// HasDomains returns a boolean if a field has been set.
func (o *OrganizationBody) HasDomains() bool {
	if o != nil && !IsNil(o.Domains) {
		return true
	}

	return false
}

// SetDomains gets a reference to the given []string and assigns it to the Domains field.
func (o *OrganizationBody) SetDomains(v []string) {
	o.Domains = v
}

// GetLabel returns the Label field value if set, zero value otherwise.
func (o *OrganizationBody) GetLabel() string {
	if o == nil || IsNil(o.Label) {
		var ret string
		return ret
	}
	return *o.Label
}

// GetLabelOk returns a tuple with the Label field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *OrganizationBody) GetLabelOk() (*string, bool) {
	if o == nil || IsNil(o.Label) {
		return nil, false
	}
	return o.Label, true
}

// HasLabel returns a boolean if a field has been set.
func (o *OrganizationBody) HasLabel() bool {
	if o != nil && !IsNil(o.Label) {
		return true
	}

	return false
}

// SetLabel gets a reference to the given string and assigns it to the Label field.
func (o *OrganizationBody) SetLabel(v string) {
	o.Label = &v
}

func (o OrganizationBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o OrganizationBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.Domains) {
		toSerialize["domains"] = o.Domains
	}
	if !IsNil(o.Label) {
		toSerialize["label"] = o.Label
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *OrganizationBody) UnmarshalJSON(data []byte) (err error) {
	varOrganizationBody := _OrganizationBody{}

	err = json.Unmarshal(data, &varOrganizationBody)

	if err != nil {
		return err
	}

	*o = OrganizationBody(varOrganizationBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "domains")
		delete(additionalProperties, "label")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableOrganizationBody struct {
	value *OrganizationBody
	isSet bool
}

func (v NullableOrganizationBody) Get() *OrganizationBody {
	return v.value
}

func (v *NullableOrganizationBody) Set(val *OrganizationBody) {
	v.value = val
	v.isSet = true
}

func (v NullableOrganizationBody) IsSet() bool {
	return v.isSet
}

func (v *NullableOrganizationBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOrganizationBody(val *OrganizationBody) *NullableOrganizationBody {
	return &NullableOrganizationBody{value: val, isSet: true}
}

func (v NullableOrganizationBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOrganizationBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


