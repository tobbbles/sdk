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

// UpdateVerificationFlowBody - Update Verification Flow Request Body
type UpdateVerificationFlowBody struct {
	UpdateVerificationFlowWithCodeMethod *UpdateVerificationFlowWithCodeMethod
	UpdateVerificationFlowWithLinkMethod *UpdateVerificationFlowWithLinkMethod
}

// UpdateVerificationFlowWithCodeMethodAsUpdateVerificationFlowBody is a convenience function that returns UpdateVerificationFlowWithCodeMethod wrapped in UpdateVerificationFlowBody
func UpdateVerificationFlowWithCodeMethodAsUpdateVerificationFlowBody(v *UpdateVerificationFlowWithCodeMethod) UpdateVerificationFlowBody {
	return UpdateVerificationFlowBody{
		UpdateVerificationFlowWithCodeMethod: v,
	}
}

// UpdateVerificationFlowWithLinkMethodAsUpdateVerificationFlowBody is a convenience function that returns UpdateVerificationFlowWithLinkMethod wrapped in UpdateVerificationFlowBody
func UpdateVerificationFlowWithLinkMethodAsUpdateVerificationFlowBody(v *UpdateVerificationFlowWithLinkMethod) UpdateVerificationFlowBody {
	return UpdateVerificationFlowBody{
		UpdateVerificationFlowWithLinkMethod: v,
	}
}


// Unmarshal JSON data into one of the pointers in the struct
func (dst *UpdateVerificationFlowBody) UnmarshalJSON(data []byte) error {
	var err error
	// use discriminator value to speed up the lookup
	var jsonDict map[string]interface{}
	err = newStrictDecoder(data).Decode(&jsonDict)
	if err != nil {
		return fmt.Errorf("failed to unmarshal JSON into map for the discriminator lookup")
	}

	// check if the discriminator value is 'code'
	if jsonDict["method"] == "code" {
		// try to unmarshal JSON data into UpdateVerificationFlowWithCodeMethod
		err = json.Unmarshal(data, &dst.UpdateVerificationFlowWithCodeMethod)
		if err == nil {
			return nil // data stored in dst.UpdateVerificationFlowWithCodeMethod, return on the first match
		} else {
			dst.UpdateVerificationFlowWithCodeMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateVerificationFlowBody as UpdateVerificationFlowWithCodeMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'link'
	if jsonDict["method"] == "link" {
		// try to unmarshal JSON data into UpdateVerificationFlowWithLinkMethod
		err = json.Unmarshal(data, &dst.UpdateVerificationFlowWithLinkMethod)
		if err == nil {
			return nil // data stored in dst.UpdateVerificationFlowWithLinkMethod, return on the first match
		} else {
			dst.UpdateVerificationFlowWithLinkMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateVerificationFlowBody as UpdateVerificationFlowWithLinkMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateVerificationFlowWithCodeMethod'
	if jsonDict["method"] == "updateVerificationFlowWithCodeMethod" {
		// try to unmarshal JSON data into UpdateVerificationFlowWithCodeMethod
		err = json.Unmarshal(data, &dst.UpdateVerificationFlowWithCodeMethod)
		if err == nil {
			return nil // data stored in dst.UpdateVerificationFlowWithCodeMethod, return on the first match
		} else {
			dst.UpdateVerificationFlowWithCodeMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateVerificationFlowBody as UpdateVerificationFlowWithCodeMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateVerificationFlowWithLinkMethod'
	if jsonDict["method"] == "updateVerificationFlowWithLinkMethod" {
		// try to unmarshal JSON data into UpdateVerificationFlowWithLinkMethod
		err = json.Unmarshal(data, &dst.UpdateVerificationFlowWithLinkMethod)
		if err == nil {
			return nil // data stored in dst.UpdateVerificationFlowWithLinkMethod, return on the first match
		} else {
			dst.UpdateVerificationFlowWithLinkMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateVerificationFlowBody as UpdateVerificationFlowWithLinkMethod: %s", err.Error())
		}
	}

	return nil
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src UpdateVerificationFlowBody) MarshalJSON() ([]byte, error) {
	if src.UpdateVerificationFlowWithCodeMethod != nil {
		return json.Marshal(&src.UpdateVerificationFlowWithCodeMethod)
	}

	if src.UpdateVerificationFlowWithLinkMethod != nil {
		return json.Marshal(&src.UpdateVerificationFlowWithLinkMethod)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *UpdateVerificationFlowBody) GetActualInstance() (interface{}) {
	if obj == nil {
		return nil
	}
	if obj.UpdateVerificationFlowWithCodeMethod != nil {
		return obj.UpdateVerificationFlowWithCodeMethod
	}

	if obj.UpdateVerificationFlowWithLinkMethod != nil {
		return obj.UpdateVerificationFlowWithLinkMethod
	}

	// all schemas are nil
	return nil
}

type NullableUpdateVerificationFlowBody struct {
	value *UpdateVerificationFlowBody
	isSet bool
}

func (v NullableUpdateVerificationFlowBody) Get() *UpdateVerificationFlowBody {
	return v.value
}

func (v *NullableUpdateVerificationFlowBody) Set(val *UpdateVerificationFlowBody) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateVerificationFlowBody) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateVerificationFlowBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateVerificationFlowBody(val *UpdateVerificationFlowBody) *NullableUpdateVerificationFlowBody {
	return &NullableUpdateVerificationFlowBody{value: val, isSet: true}
}

func (v NullableUpdateVerificationFlowBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateVerificationFlowBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


