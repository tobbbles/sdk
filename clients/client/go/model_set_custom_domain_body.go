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
)

// checks if the SetCustomDomainBody type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SetCustomDomainBody{}

// SetCustomDomainBody Update Custom Hostname Body
type SetCustomDomainBody struct {
	// The domain where cookies will be set. Has to be a parent domain of the custom hostname to work.
	CookieDomain *string `json:"cookie_domain,omitempty"`
	// CORS Allowed origins for the custom hostname.
	CorsAllowedOrigins []string `json:"cors_allowed_origins,omitempty"`
	// CORS Enabled for the custom hostname.
	CorsEnabled *bool `json:"cors_enabled,omitempty"`
	// The custom UI base URL where the UI will be exposed.
	CustomUiBaseUrl *string `json:"custom_ui_base_url,omitempty"`
	// The custom hostname where the API will be exposed.
	Hostname *string `json:"hostname,omitempty"`
	AdditionalProperties map[string]interface{}
}

type _SetCustomDomainBody SetCustomDomainBody

// NewSetCustomDomainBody instantiates a new SetCustomDomainBody object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSetCustomDomainBody() *SetCustomDomainBody {
	this := SetCustomDomainBody{}
	return &this
}

// NewSetCustomDomainBodyWithDefaults instantiates a new SetCustomDomainBody object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSetCustomDomainBodyWithDefaults() *SetCustomDomainBody {
	this := SetCustomDomainBody{}
	return &this
}

// GetCookieDomain returns the CookieDomain field value if set, zero value otherwise.
func (o *SetCustomDomainBody) GetCookieDomain() string {
	if o == nil || IsNil(o.CookieDomain) {
		var ret string
		return ret
	}
	return *o.CookieDomain
}

// GetCookieDomainOk returns a tuple with the CookieDomain field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SetCustomDomainBody) GetCookieDomainOk() (*string, bool) {
	if o == nil || IsNil(o.CookieDomain) {
		return nil, false
	}
	return o.CookieDomain, true
}

// HasCookieDomain returns a boolean if a field has been set.
func (o *SetCustomDomainBody) HasCookieDomain() bool {
	if o != nil && !IsNil(o.CookieDomain) {
		return true
	}

	return false
}

// SetCookieDomain gets a reference to the given string and assigns it to the CookieDomain field.
func (o *SetCustomDomainBody) SetCookieDomain(v string) {
	o.CookieDomain = &v
}

// GetCorsAllowedOrigins returns the CorsAllowedOrigins field value if set, zero value otherwise.
func (o *SetCustomDomainBody) GetCorsAllowedOrigins() []string {
	if o == nil || IsNil(o.CorsAllowedOrigins) {
		var ret []string
		return ret
	}
	return o.CorsAllowedOrigins
}

// GetCorsAllowedOriginsOk returns a tuple with the CorsAllowedOrigins field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SetCustomDomainBody) GetCorsAllowedOriginsOk() ([]string, bool) {
	if o == nil || IsNil(o.CorsAllowedOrigins) {
		return nil, false
	}
	return o.CorsAllowedOrigins, true
}

// HasCorsAllowedOrigins returns a boolean if a field has been set.
func (o *SetCustomDomainBody) HasCorsAllowedOrigins() bool {
	if o != nil && !IsNil(o.CorsAllowedOrigins) {
		return true
	}

	return false
}

// SetCorsAllowedOrigins gets a reference to the given []string and assigns it to the CorsAllowedOrigins field.
func (o *SetCustomDomainBody) SetCorsAllowedOrigins(v []string) {
	o.CorsAllowedOrigins = v
}

// GetCorsEnabled returns the CorsEnabled field value if set, zero value otherwise.
func (o *SetCustomDomainBody) GetCorsEnabled() bool {
	if o == nil || IsNil(o.CorsEnabled) {
		var ret bool
		return ret
	}
	return *o.CorsEnabled
}

// GetCorsEnabledOk returns a tuple with the CorsEnabled field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SetCustomDomainBody) GetCorsEnabledOk() (*bool, bool) {
	if o == nil || IsNil(o.CorsEnabled) {
		return nil, false
	}
	return o.CorsEnabled, true
}

// HasCorsEnabled returns a boolean if a field has been set.
func (o *SetCustomDomainBody) HasCorsEnabled() bool {
	if o != nil && !IsNil(o.CorsEnabled) {
		return true
	}

	return false
}

// SetCorsEnabled gets a reference to the given bool and assigns it to the CorsEnabled field.
func (o *SetCustomDomainBody) SetCorsEnabled(v bool) {
	o.CorsEnabled = &v
}

// GetCustomUiBaseUrl returns the CustomUiBaseUrl field value if set, zero value otherwise.
func (o *SetCustomDomainBody) GetCustomUiBaseUrl() string {
	if o == nil || IsNil(o.CustomUiBaseUrl) {
		var ret string
		return ret
	}
	return *o.CustomUiBaseUrl
}

// GetCustomUiBaseUrlOk returns a tuple with the CustomUiBaseUrl field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SetCustomDomainBody) GetCustomUiBaseUrlOk() (*string, bool) {
	if o == nil || IsNil(o.CustomUiBaseUrl) {
		return nil, false
	}
	return o.CustomUiBaseUrl, true
}

// HasCustomUiBaseUrl returns a boolean if a field has been set.
func (o *SetCustomDomainBody) HasCustomUiBaseUrl() bool {
	if o != nil && !IsNil(o.CustomUiBaseUrl) {
		return true
	}

	return false
}

// SetCustomUiBaseUrl gets a reference to the given string and assigns it to the CustomUiBaseUrl field.
func (o *SetCustomDomainBody) SetCustomUiBaseUrl(v string) {
	o.CustomUiBaseUrl = &v
}

// GetHostname returns the Hostname field value if set, zero value otherwise.
func (o *SetCustomDomainBody) GetHostname() string {
	if o == nil || IsNil(o.Hostname) {
		var ret string
		return ret
	}
	return *o.Hostname
}

// GetHostnameOk returns a tuple with the Hostname field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SetCustomDomainBody) GetHostnameOk() (*string, bool) {
	if o == nil || IsNil(o.Hostname) {
		return nil, false
	}
	return o.Hostname, true
}

// HasHostname returns a boolean if a field has been set.
func (o *SetCustomDomainBody) HasHostname() bool {
	if o != nil && !IsNil(o.Hostname) {
		return true
	}

	return false
}

// SetHostname gets a reference to the given string and assigns it to the Hostname field.
func (o *SetCustomDomainBody) SetHostname(v string) {
	o.Hostname = &v
}

func (o SetCustomDomainBody) MarshalJSON() ([]byte, error) {
	toSerialize,err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SetCustomDomainBody) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	if !IsNil(o.CookieDomain) {
		toSerialize["cookie_domain"] = o.CookieDomain
	}
	if !IsNil(o.CorsAllowedOrigins) {
		toSerialize["cors_allowed_origins"] = o.CorsAllowedOrigins
	}
	if !IsNil(o.CorsEnabled) {
		toSerialize["cors_enabled"] = o.CorsEnabled
	}
	if !IsNil(o.CustomUiBaseUrl) {
		toSerialize["custom_ui_base_url"] = o.CustomUiBaseUrl
	}
	if !IsNil(o.Hostname) {
		toSerialize["hostname"] = o.Hostname
	}

	for key, value := range o.AdditionalProperties {
		toSerialize[key] = value
	}

	return toSerialize, nil
}

func (o *SetCustomDomainBody) UnmarshalJSON(data []byte) (err error) {
	varSetCustomDomainBody := _SetCustomDomainBody{}

	err = json.Unmarshal(data, &varSetCustomDomainBody)

	if err != nil {
		return err
	}

	*o = SetCustomDomainBody(varSetCustomDomainBody)

	additionalProperties := make(map[string]interface{})

	if err = json.Unmarshal(data, &additionalProperties); err == nil {
		delete(additionalProperties, "cookie_domain")
		delete(additionalProperties, "cors_allowed_origins")
		delete(additionalProperties, "cors_enabled")
		delete(additionalProperties, "custom_ui_base_url")
		delete(additionalProperties, "hostname")
		o.AdditionalProperties = additionalProperties
	}

	return err
}

type NullableSetCustomDomainBody struct {
	value *SetCustomDomainBody
	isSet bool
}

func (v NullableSetCustomDomainBody) Get() *SetCustomDomainBody {
	return v.value
}

func (v *NullableSetCustomDomainBody) Set(val *SetCustomDomainBody) {
	v.value = val
	v.isSet = true
}

func (v NullableSetCustomDomainBody) IsSet() bool {
	return v.isSet
}

func (v *NullableSetCustomDomainBody) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSetCustomDomainBody(val *SetCustomDomainBody) *NullableSetCustomDomainBody {
	return &NullableSetCustomDomainBody{value: val, isSet: true}
}

func (v NullableSetCustomDomainBody) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSetCustomDomainBody) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}


