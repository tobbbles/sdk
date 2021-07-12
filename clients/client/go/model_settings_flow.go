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
	"time"
)

// SettingsFlow This flow is used when an identity wants to update settings (e.g. profile data, passwords, ...) in a selfservice manner.  We recommend reading the [User Settings Documentation](../self-service/flows/user-settings)
type SettingsFlow struct {
	// Active, if set, contains the registration method that is being used. It is initially not set.
	Active *string `json:"active,omitempty"`
	// ExpiresAt is the time (UTC) when the flow expires. If the user still wishes to update the setting, a new flow has to be initiated.
	ExpiresAt time.Time `json:"expires_at"`
	Id string `json:"id"`
	Identity Identity `json:"identity"`
	// IssuedAt is the time (UTC) when the flow occurred.
	IssuedAt time.Time `json:"issued_at"`
	// RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL's path or query for example.
	RequestUrl string `json:"request_url"`
	State string `json:"state"`
	// The flow type can either be `api` or `browser`.
	Type *string `json:"type,omitempty"`
	Ui UiContainer `json:"ui"`
}

// NewSettingsFlow instantiates a new SettingsFlow object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSettingsFlow(expiresAt time.Time, id string, identity Identity, issuedAt time.Time, requestUrl string, state string, ui UiContainer) *SettingsFlow {
	this := SettingsFlow{}
	this.ExpiresAt = expiresAt
	this.Id = id
	this.Identity = identity
	this.IssuedAt = issuedAt
	this.RequestUrl = requestUrl
	this.State = state
	this.Ui = ui
	return &this
}

// NewSettingsFlowWithDefaults instantiates a new SettingsFlow object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSettingsFlowWithDefaults() *SettingsFlow {
	this := SettingsFlow{}
	return &this
}

// GetActive returns the Active field value if set, zero value otherwise.
func (o *SettingsFlow) GetActive() string {
	if o == nil || o.Active == nil {
		var ret string
		return ret
	}
	return *o.Active
}

// GetActiveOk returns a tuple with the Active field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetActiveOk() (*string, bool) {
	if o == nil || o.Active == nil {
		return nil, false
	}
	return o.Active, true
}

// HasActive returns a boolean if a field has been set.
func (o *SettingsFlow) HasActive() bool {
	if o != nil && o.Active != nil {
		return true
	}

	return false
}

// SetActive gets a reference to the given string and assigns it to the Active field.
func (o *SettingsFlow) SetActive(v string) {
	o.Active = &v
}

// GetExpiresAt returns the ExpiresAt field value
func (o *SettingsFlow) GetExpiresAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.ExpiresAt
}

// GetExpiresAtOk returns a tuple with the ExpiresAt field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetExpiresAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.ExpiresAt, true
}

// SetExpiresAt sets field value
func (o *SettingsFlow) SetExpiresAt(v time.Time) {
	o.ExpiresAt = v
}

// GetId returns the Id field value
func (o *SettingsFlow) GetId() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Id
}

// GetIdOk returns a tuple with the Id field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetIdOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Id, true
}

// SetId sets field value
func (o *SettingsFlow) SetId(v string) {
	o.Id = v
}

// GetIdentity returns the Identity field value
func (o *SettingsFlow) GetIdentity() Identity {
	if o == nil {
		var ret Identity
		return ret
	}

	return o.Identity
}

// GetIdentityOk returns a tuple with the Identity field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetIdentityOk() (*Identity, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Identity, true
}

// SetIdentity sets field value
func (o *SettingsFlow) SetIdentity(v Identity) {
	o.Identity = v
}

// GetIssuedAt returns the IssuedAt field value
func (o *SettingsFlow) GetIssuedAt() time.Time {
	if o == nil {
		var ret time.Time
		return ret
	}

	return o.IssuedAt
}

// GetIssuedAtOk returns a tuple with the IssuedAt field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetIssuedAtOk() (*time.Time, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.IssuedAt, true
}

// SetIssuedAt sets field value
func (o *SettingsFlow) SetIssuedAt(v time.Time) {
	o.IssuedAt = v
}

// GetRequestUrl returns the RequestUrl field value
func (o *SettingsFlow) GetRequestUrl() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.RequestUrl
}

// GetRequestUrlOk returns a tuple with the RequestUrl field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetRequestUrlOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.RequestUrl, true
}

// SetRequestUrl sets field value
func (o *SettingsFlow) SetRequestUrl(v string) {
	o.RequestUrl = v
}

// GetState returns the State field value
func (o *SettingsFlow) GetState() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.State
}

// GetStateOk returns a tuple with the State field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetStateOk() (*string, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.State, true
}

// SetState sets field value
func (o *SettingsFlow) SetState(v string) {
	o.State = v
}

// GetType returns the Type field value if set, zero value otherwise.
func (o *SettingsFlow) GetType() string {
	if o == nil || o.Type == nil {
		var ret string
		return ret
	}
	return *o.Type
}

// GetTypeOk returns a tuple with the Type field value if set, nil otherwise
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetTypeOk() (*string, bool) {
	if o == nil || o.Type == nil {
		return nil, false
	}
	return o.Type, true
}

// HasType returns a boolean if a field has been set.
func (o *SettingsFlow) HasType() bool {
	if o != nil && o.Type != nil {
		return true
	}

	return false
}

// SetType gets a reference to the given string and assigns it to the Type field.
func (o *SettingsFlow) SetType(v string) {
	o.Type = &v
}

// GetUi returns the Ui field value
func (o *SettingsFlow) GetUi() UiContainer {
	if o == nil {
		var ret UiContainer
		return ret
	}

	return o.Ui
}

// GetUiOk returns a tuple with the Ui field value
// and a boolean to check if the value has been set.
func (o *SettingsFlow) GetUiOk() (*UiContainer, bool) {
	if o == nil  {
		return nil, false
	}
	return &o.Ui, true
}

// SetUi sets field value
func (o *SettingsFlow) SetUi(v UiContainer) {
	o.Ui = v
}

func (o SettingsFlow) MarshalJSON() ([]byte, error) {
	toSerialize := map[string]interface{}{}
	if o.Active != nil {
		toSerialize["active"] = o.Active
	}
	if true {
		toSerialize["expires_at"] = o.ExpiresAt
	}
	if true {
		toSerialize["id"] = o.Id
	}
	if true {
		toSerialize["identity"] = o.Identity
	}
	if true {
		toSerialize["issued_at"] = o.IssuedAt
	}
	if true {
		toSerialize["request_url"] = o.RequestUrl
	}
	if true {
		toSerialize["state"] = o.State
	}
	if o.Type != nil {
		toSerialize["type"] = o.Type
	}
	if true {
		toSerialize["ui"] = o.Ui
	}
	return json.Marshal(toSerialize)
}

type NullableSettingsFlow struct {
	value *SettingsFlow
	isSet bool
}

func (v NullableSettingsFlow) Get() *SettingsFlow {
	return v.value
}

func (v *NullableSettingsFlow) Set(val *SettingsFlow) {
	v.value = val
	v.isSet = true
}

func (v NullableSettingsFlow) IsSet() bool {
	return v.isSet
}

func (v *NullableSettingsFlow) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSettingsFlow(val *SettingsFlow) *NullableSettingsFlow {
	return &NullableSettingsFlow{value: val, isSet: true}
}

func (v NullableSettingsFlow) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSettingsFlow) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}

