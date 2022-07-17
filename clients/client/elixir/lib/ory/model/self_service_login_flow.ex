# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.SelfServiceLoginFlow do
  @moduledoc """
  This object represents a login flow. A login flow is initiated at the \"Initiate Login API / Browser Flow\" endpoint by a client.  Once a login flow is completed successfully, a session cookie or session token will be issued.
  """

  @derive [Poison.Encoder]
  defstruct [
    :active,
    :created_at,
    :expires_at,
    :id,
    :issued_at,
    :refresh,
    :request_url,
    :requested_aal,
    :return_to,
    :type,
    :ui,
    :updated_at
  ]

  @type t :: %__MODULE__{
    :active => Ory.Model.IdentityCredentialsType.t | nil,
    :created_at => DateTime.t | nil,
    :expires_at => DateTime.t,
    :id => String.t,
    :issued_at => DateTime.t,
    :refresh => boolean() | nil,
    :request_url => String.t,
    :requested_aal => Ory.Model.AuthenticatorAssuranceLevel.t | nil,
    :return_to => String.t | nil,
    :type => String.t,
    :ui => Ory.Model.UiContainer.t,
    :updated_at => DateTime.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.SelfServiceLoginFlow do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:active, :struct, Ory.Model.IdentityCredentialsType, options)
    |> deserialize(:requested_aal, :struct, Ory.Model.AuthenticatorAssuranceLevel, options)
    |> deserialize(:ui, :struct, Ory.Model.UiContainer, options)
  end
end

