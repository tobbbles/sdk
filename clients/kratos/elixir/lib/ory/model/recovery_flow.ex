# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.RecoveryFlow do
  @moduledoc """
  This request is used when an identity wants to recover their account.  We recommend reading the [Account Recovery Documentation](../self-service/flows/password-reset-account-recovery)
  """

  @derive [Poison.Encoder]
  defstruct [
    :active,
    :expires_at,
    :id,
    :issued_at,
    :request_url,
    :return_to,
    :state,
    :type,
    :ui
  ]

  @type t :: %__MODULE__{
    :active => String.t | nil,
    :expires_at => DateTime.t,
    :id => String.t,
    :issued_at => DateTime.t,
    :request_url => String.t,
    :return_to => String.t | nil,
    :state => Ory.Model.RecoveryFlowState.t,
    :type => String.t,
    :ui => Ory.Model.UiContainer.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.RecoveryFlow do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:state, :struct, Ory.Model.RecoveryFlowState, options)
    |> deserialize(:ui, :struct, Ory.Model.UiContainer, options)
  end
end

