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
	"fmt"
)

// checks if the ProjectMember type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ProjectMember{}

// ProjectMember struct for ProjectMember
type ProjectMember struct {
	Email string `json:"email"`
	Id string `json:"id"`
	Name string `json:"name"`
	Role string `json:"role"`
	AdditionalProperties map[string]interface{}
}

type _ProjectMember ProjectMember

// NewProjectMember instantiates a new ProjectMember object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewProjectMember(email string, id string, name string, role string) *ProjectMember {
	this := ProjectMember{}
	this.Email = email
	this.Id = id
	this.Name = name
	this.Role = role
	return &this
}

// NewProjectMemberWithDefaults instantiates a new ProjectMember object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewProjectMemberWithDefaults() *ProjectMember {
	this := ProjectMember{}
	return &this
}

// GetEmail returns the Email field value
func (o *ProjectMember) GetEmail() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Email
}

// GetEmailOk returns a tuple with the Email field value
// and a boolean to check if the value has been set.
func (o *ProjectMember) GetEmailOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Email, true
}

// SetEmail sets field value
func (o *ProjectMember) SetEmail(v string) {
	o.Email = v
}

// GetId returns the Id field value
func (o *ProjectMember) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *ProjectMember) GetIdOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *ProjectMember) SetId(v string) {
	o.Id = v
}

// GetName returns the Name field value
func (o *ProjectMember) GetName() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Name
}

// GetNameOk returns a tuple with the Name field value
// and a boolean to check if the value has been set.
func (o *ProjectMember) GetNameOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Name, true
}

// SetName sets field value
func (o *ProjectMember) SetName(v string) {
	o.Name = v
}

// GetRole returns the Role field value
func (o *ProjectMember) GetRole() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Role
}

// GetRoleOk returns a tuple with the Role field value
// and a boolean to check if the value has been set.
func (o *ProjectMember) GetRoleOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Role, true
}

// SetRole sets field value
func (o *ProjectMember) SetRole(v string) {
	o.Role = v
}

func (o ProjectMember) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ProjectMember) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["email"] = o.Email
	toSerialize["id"] = o.Id
	toSerialize["name"] = o.Name
	toSerialize["role"] = o.Role

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ProjectMember) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"email",
		"id",
		"name",
		"role",
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

	varProjectMember := _ProjectMember{}

	err = json.Unmarshal(data, &varProjectMember)

	if err != nil {
		return err
	}

	*o = ProjectMember(varProjectMember)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "email")
		delete(additionalProperties, "id")
		delete(additionalProperties, "name")
		delete(additionalProperties, "role")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableProjectMember struct {
	value *ProjectMember
	isSet bool
}

func (v NullableProjectMember) Get() *ProjectMember {
	return v.value
}

func (v *NullableProjectMember) Set(val *ProjectMember) {
	v.value = val
	v.isSet = true
}

func (v NullableProjectMember) IsSet() bool {
	return v.isSet
}

func (v *NullableProjectMember) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableProjectMember(val *ProjectMember) *NullableProjectMember {
	return &NullableProjectMember{value: val, isSet: true}
}

func (v NullableProjectMember) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableProjectMember) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


