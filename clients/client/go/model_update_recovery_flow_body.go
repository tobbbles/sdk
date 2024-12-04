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

// UpdateRecoveryFlowBody - Update Recovery Flow Request Body
type UpdateRecoveryFlowBody struct {
	UpdateRecoveryFlowWithCodeMethod *UpdateRecoveryFlowWithCodeMethod
	UpdateRecoveryFlowWithLinkMethod *UpdateRecoveryFlowWithLinkMethod
}

// UpdateRecoveryFlowWithCodeMethodAsUpdateRecoveryFlowBody is a convenience function that returns UpdateRecoveryFlowWithCodeMethod wrapped in UpdateRecoveryFlowBody
func UpdateRecoveryFlowWithCodeMethodAsUpdateRecoveryFlowBody(v *UpdateRecoveryFlowWithCodeMethod) UpdateRecoveryFlowBody {
	return UpdateRecoveryFlowBody{
		UpdateRecoveryFlowWithCodeMethod: v,
	}
}

// UpdateRecoveryFlowWithLinkMethodAsUpdateRecoveryFlowBody is a convenience function that returns UpdateRecoveryFlowWithLinkMethod wrapped in UpdateRecoveryFlowBody
func UpdateRecoveryFlowWithLinkMethodAsUpdateRecoveryFlowBody(v *UpdateRecoveryFlowWithLinkMethod) UpdateRecoveryFlowBody {
	return UpdateRecoveryFlowBody{
		UpdateRecoveryFlowWithLinkMethod: v,
	}
}


// Unmarshal JSON data into one of the pointers in the struct
func (dst *UpdateRecoveryFlowBody) UnmarshalJSON(data []byte) error {
	var err error
	// use discriminator value to speed up the lookup
	var jsonDict map[string]interface{}
	err = newStrictDecoder(data).Decode(&jsonDict)
	if err != nil {
		return fmt.Errorf("failed to unmarshal JSON into map for the discriminator lookup")
	}

	// check if the discriminator value is 'code'
	if jsonDict["method"] == "code" {
		// try to unmarshal JSON data into UpdateRecoveryFlowWithCodeMethod
		err = json.Unmarshal(data, &dst.UpdateRecoveryFlowWithCodeMethod)
		if err == nil {
			return nil // data stored in dst.UpdateRecoveryFlowWithCodeMethod, return on the first match
		} else {
			dst.UpdateRecoveryFlowWithCodeMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateRecoveryFlowBody as UpdateRecoveryFlowWithCodeMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'link'
	if jsonDict["method"] == "link" {
		// try to unmarshal JSON data into UpdateRecoveryFlowWithLinkMethod
		err = json.Unmarshal(data, &dst.UpdateRecoveryFlowWithLinkMethod)
		if err == nil {
			return nil // data stored in dst.UpdateRecoveryFlowWithLinkMethod, return on the first match
		} else {
			dst.UpdateRecoveryFlowWithLinkMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateRecoveryFlowBody as UpdateRecoveryFlowWithLinkMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateRecoveryFlowWithCodeMethod'
	if jsonDict["method"] == "updateRecoveryFlowWithCodeMethod" {
		// try to unmarshal JSON data into UpdateRecoveryFlowWithCodeMethod
		err = json.Unmarshal(data, &dst.UpdateRecoveryFlowWithCodeMethod)
		if err == nil {
			return nil // data stored in dst.UpdateRecoveryFlowWithCodeMethod, return on the first match
		} else {
			dst.UpdateRecoveryFlowWithCodeMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateRecoveryFlowBody as UpdateRecoveryFlowWithCodeMethod: %s", err.Error())
		}
	}

	// check if the discriminator value is 'updateRecoveryFlowWithLinkMethod'
	if jsonDict["method"] == "updateRecoveryFlowWithLinkMethod" {
		// try to unmarshal JSON data into UpdateRecoveryFlowWithLinkMethod
		err = json.Unmarshal(data, &dst.UpdateRecoveryFlowWithLinkMethod)
		if err == nil {
			return nil // data stored in dst.UpdateRecoveryFlowWithLinkMethod, return on the first match
		} else {
			dst.UpdateRecoveryFlowWithLinkMethod = nil
			return fmt.Errorf("failed to unmarshal UpdateRecoveryFlowBody as UpdateRecoveryFlowWithLinkMethod: %s", err.Error())
		}
	}

	return nil
}

// Marshal data from the first non-nil pointers in the struct to JSON
func (src UpdateRecoveryFlowBody) MarshalJSON() ([]byte, error) {
	if src.UpdateRecoveryFlowWithCodeMethod != nil {
		return json.Marshal(&src.UpdateRecoveryFlowWithCodeMethod)
	}

	if src.UpdateRecoveryFlowWithLinkMethod != nil {
		return json.Marshal(&src.UpdateRecoveryFlowWithLinkMethod)
	}

	return nil, nil // no data in oneOf schemas
}

// Get the actual instance
func (obj *UpdateRecoveryFlowBody) GetActualInstance() (interface{}) {
	if obj == nil {
		return nil
	}
	if obj.UpdateRecoveryFlowWithCodeMethod != nil {
		return obj.UpdateRecoveryFlowWithCodeMethod
	}

	if obj.UpdateRecoveryFlowWithLinkMethod != nil {
		return obj.UpdateRecoveryFlowWithLinkMethod
	}

	// all schemas are nil
	return nil
}

type NullableUpdateRecoveryFlowBody struct {
	value *UpdateRecoveryFlowBody
	isSet bool
}

func (v NullableUpdateRecoveryFlowBody) Get() *UpdateRecoveryFlowBody {
	return v.value
}

func (v *NullableUpdateRecoveryFlowBody) Set(val *UpdateRecoveryFlowBody) {
	v.value = val
	v.isSet = true
}

func (v NullableUpdateRecoveryFlowBody) IsSet() bool {
	return v.isSet
}

func (v *NullableUpdateRecoveryFlowBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableUpdateRecoveryFlowBody(val *UpdateRecoveryFlowBody) *NullableUpdateRecoveryFlowBody {
	return &NullableUpdateRecoveryFlowBody{value: val, isSet: true}
}

func (v NullableUpdateRecoveryFlowBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableUpdateRecoveryFlowBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


