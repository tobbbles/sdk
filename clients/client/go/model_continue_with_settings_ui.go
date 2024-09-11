/*
Ory APIs

Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

API version: v1.15.0
Contact: support@ory.sh
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// checks if the ContinueWithSettingsUi type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &ContinueWithSettingsUi{}

// ContinueWithSettingsUi Indicates, that the UI flow could be continued by showing a settings ui
type ContinueWithSettingsUi struct {
	// Action will always be `show_settings_ui` show_settings_ui ContinueWithActionShowSettingsUIString
	Action string `json:"action"`
	Flow ContinueWithSettingsUiFlow `json:"flow"`
	AdditionalProperties map[string]interface{}
}

type _ContinueWithSettingsUi ContinueWithSettingsUi

// NewContinueWithSettingsUi instantiates a new ContinueWithSettingsUi object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewContinueWithSettingsUi(action string, flow ContinueWithSettingsUiFlow) *ContinueWithSettingsUi {
	this := ContinueWithSettingsUi{}
	this.Action = action
	this.Flow = flow
	return &this
}

// NewContinueWithSettingsUiWithDefaults instantiates a new ContinueWithSettingsUi object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewContinueWithSettingsUiWithDefaults() *ContinueWithSettingsUi {
	this := ContinueWithSettingsUi{}
	return &this
}

// GetAction returns the Action field value
func (o *ContinueWithSettingsUi) GetAction() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Action
}

// GetActionOk returns a tuple with the Action field value
// and a boolean to check if the value has been set.
func (o *ContinueWithSettingsUi) GetActionOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Action, true
}

// SetAction sets field value
func (o *ContinueWithSettingsUi) SetAction(v string) {
	o.Action = v
}

// GetFlow returns the Flow field value
func (o *ContinueWithSettingsUi) GetFlow() ContinueWithSettingsUiFlow {
	if o == nil {
		var ret ContinueWithSettingsUiFlow
		return ret
	}

	return o.Flow
}

// GetFlowOk returns a tuple with the Flow field value
// and a boolean to check if the value has been set.
func (o *ContinueWithSettingsUi) GetFlowOk() (*ContinueWithSettingsUiFlow, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Flow, true
}

// SetFlow sets field value
func (o *ContinueWithSettingsUi) SetFlow(v ContinueWithSettingsUiFlow) {
	o.Flow = v
}

func (o ContinueWithSettingsUi) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o ContinueWithSettingsUi) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["action"] = o.Action
	toSerialize["flow"] = o.Flow

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *ContinueWithSettingsUi) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"action",
		"flow",
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

	varContinueWithSettingsUi := _ContinueWithSettingsUi{}

	err = json.Unmarshal(data, &varContinueWithSettingsUi)

	if err != nil {
		return err
	}

	*o = ContinueWithSettingsUi(varContinueWithSettingsUi)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "action")
		delete(additionalProperties, "flow")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableContinueWithSettingsUi struct {
	value *ContinueWithSettingsUi
	isSet bool
}

func (v NullableContinueWithSettingsUi) Get() *ContinueWithSettingsUi {
	return v.value
}

func (v *NullableContinueWithSettingsUi) Set(val *ContinueWithSettingsUi) {
	v.value = val
	v.isSet = true
}

func (v NullableContinueWithSettingsUi) IsSet() bool {
	return v.isSet
}

func (v *NullableContinueWithSettingsUi) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableContinueWithSettingsUi(val *ContinueWithSettingsUi) *NullableContinueWithSettingsUi {
	return &NullableContinueWithSettingsUi{value: val, isSet: true}
}

func (v NullableContinueWithSettingsUi) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableContinueWithSettingsUi) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


