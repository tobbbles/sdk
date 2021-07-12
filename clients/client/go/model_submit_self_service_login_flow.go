/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * API version: v0.0.1-alpha.15
 * Contact: support@ory.sh
 */

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package client

import (
	"encoding/json"
	"fmt"
)

// SubmitSelfServiceLoginFlow - struct for SubmitSelfServiceLoginFlow
type SubmitSelfServiceLoginFlow struct {
	SubmitSelfServiceLoginFlowWithPasswordMethod *SubmitSelfServiceLoginFlowWithPasswordMethod
}

// SubmitSelfServiceLoginFlowWithPasswordMethodAsSubmitSelfServiceLoginFlow is a convenience function that returns SubmitSelfServiceLoginFlowWithPasswordMethod wrapped in SubmitSelfServiceLoginFlow
func SubmitSelfServiceLoginFlowWithPasswordMethodAsSubmitSelfServiceLoginFlow(v *SubmitSelfServiceLoginFlowWithPasswordMethod) SubmitSelfServiceLoginFlow {
	return SubmitSelfServiceLoginFlow{
		SubmitSelfServiceLoginFlowWithPasswordMethod: v,
	}
}


// Unmarshal JSON data into one of the pointers in the struct
func (dst *SubmitSelfServiceLoginFlow) UnmarshalJSON(data []byte) error {
	var err error
	match := 0
	// try to unmarshal data into SubmitSelfServiceLoginFlowWithPasswordMethod
	err = newStrictDecoder(data).Decode(&dst.SubmitSelfServiceLoginFlowWithPasswordMethod)
	if err == nil {
		jsonSubmitSelfServiceLoginFlowWithPasswordMethod, _ := json.Marshal(dst.SubmitSelfServiceLoginFlowWithPasswordMethod)
		if string(jsonSubmitSelfServiceLoginFlowWithPasswordMethod) == "{}" { // empty struct
			dst.SubmitSelfServiceLoginFlowWithPasswordMethod = nil
		} else {
			match++
		}
	} else {
		dst.SubmitSelfServiceLoginFlowWithPasswordMethod = nil
	}

	if match > 1 { // more than 1 match
		// reset to nil
		dst.SubmitSelfServiceLoginFlowWithPasswordMethod = nil

		return fmt.Errorf("Data matches more than one schema in oneOf(SubmitSelfServiceLoginFlow)")
	} else if match == 1 {
		return nil // exactly one match
	} else { // no match
		return fmt.Errorf("Data failed to match schemas in oneOf(SubmitSelfServiceLoginFlow)")
	}
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src SubmitSelfServiceLoginFlow) MarshalJSON() ([]byte, error) {
	if src.SubmitSelfServiceLoginFlowWithPasswordMethod != nil {
		return json.Marshal(&src.SubmitSelfServiceLoginFlowWithPasswordMethod)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *SubmitSelfServiceLoginFlow) GetActualInstance() (interface{}) {
	if obj == nil {
		return nil
	}
	if obj.SubmitSelfServiceLoginFlowWithPasswordMethod != nil {
		return obj.SubmitSelfServiceLoginFlowWithPasswordMethod
	}

	// all schemas are nil
	return nil
}

type NullableSubmitSelfServiceLoginFlow struct {
	value *SubmitSelfServiceLoginFlow
	isSet bool
}

func (v NullableSubmitSelfServiceLoginFlow) Get() *SubmitSelfServiceLoginFlow {
	return v.value
}

func (v *NullableSubmitSelfServiceLoginFlow) Set(val *SubmitSelfServiceLoginFlow) {
	v.value = val
	v.isSet = true
}

func (v NullableSubmitSelfServiceLoginFlow) IsSet() bool {
	return v.isSet
}

func (v *NullableSubmitSelfServiceLoginFlow) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSubmitSelfServiceLoginFlow(val *SubmitSelfServiceLoginFlow) *NullableSubmitSelfServiceLoginFlow {
	return &NullableSubmitSelfServiceLoginFlow{value: val, isSet: true}
}

func (v NullableSubmitSelfServiceLoginFlow) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSubmitSelfServiceLoginFlow) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

