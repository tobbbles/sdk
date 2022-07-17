# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :csrf_token,
    :method,
    :webauthn_register,
    :webauthn_register_displayname,
    :webauthn_remove
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :webauthn_register => String.t | nil,
    :webauthn_register_displayname => String.t | nil,
    :webauthn_remove => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.SubmitSelfServiceSettingsFlowWithWebAuthnMethodBody do
  def decode(value, _options) do
    value
  end
end

