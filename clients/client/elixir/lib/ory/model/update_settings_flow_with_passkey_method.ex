# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateSettingsFlowWithPasskeyMethod do
  @moduledoc """
  Update Settings Flow with Passkey Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :method,
    :passkey_remove,
    :passkey_settings_register
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :passkey_remove => String.t | nil,
    :passkey_settings_register => String.t | nil
  }

  def decode(value) do
    value
  end
end

