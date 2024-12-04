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

// checks if the OAuth2RedirectTo type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &OAuth2RedirectTo{}

// OAuth2RedirectTo Contains a redirect URL used to complete a login, consent, or logout request.
type OAuth2RedirectTo struct {
	// RedirectURL is the URL which you should redirect the user's browser to once the authentication process is completed.
	RedirectTo string `json:"redirect_to"`
	AdditionalProperties map[string]interface{}
}

type _OAuth2RedirectTo OAuth2RedirectTo

// NewOAuth2RedirectTo instantiates a new OAuth2RedirectTo object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewOAuth2RedirectTo(redirectTo string) *OAuth2RedirectTo {
	this := OAuth2RedirectTo{}
	this.RedirectTo = redirectTo
	return &this
}

// NewOAuth2RedirectToWithDefaults instantiates a new OAuth2RedirectTo object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewOAuth2RedirectToWithDefaults() *OAuth2RedirectTo {
	this := OAuth2RedirectTo{}
	return &this
}

// GetRedirectTo returns the RedirectTo field value
func (o *OAuth2RedirectTo) GetRedirectTo() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.RedirectTo
}

// GetRedirectToOk returns a tuple with the RedirectTo field value
// and a boolean to check if the value has been set.
func (o *OAuth2RedirectTo) GetRedirectToOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.RedirectTo, true
}

// SetRedirectTo sets field value
func (o *OAuth2RedirectTo) SetRedirectTo(v string) {
	o.RedirectTo = v
}

func (o OAuth2RedirectTo) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o OAuth2RedirectTo) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["redirect_to"] = o.RedirectTo

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *OAuth2RedirectTo) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"redirect_to",
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

	varOAuth2RedirectTo := _OAuth2RedirectTo{}

	err = json.Unmarshal(data, &varOAuth2RedirectTo)

	if err != nil {
		return err
	}

	*o = OAuth2RedirectTo(varOAuth2RedirectTo)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "redirect_to")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableOAuth2RedirectTo struct {
	value *OAuth2RedirectTo
	isSet bool
}

func (v NullableOAuth2RedirectTo) Get() *OAuth2RedirectTo {
	return v.value
}

func (v *NullableOAuth2RedirectTo) Set(val *OAuth2RedirectTo) {
	v.value = val
	v.isSet = true
}

func (v NullableOAuth2RedirectTo) IsSet() bool {
	return v.isSet
}

func (v *NullableOAuth2RedirectTo) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableOAuth2RedirectTo(val *OAuth2RedirectTo) *NullableOAuth2RedirectTo {
	return &NullableOAuth2RedirectTo{value: val, isSet: true}
}

func (v NullableOAuth2RedirectTo) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableOAuth2RedirectTo) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


