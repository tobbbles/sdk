# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.SubmitSelfServiceSettingsFlowWithPasswordMethodBody do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :csrf_token,
    :method,
    :password
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :password => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.SubmitSelfServiceSettingsFlowWithPasswordMethodBody do
  def decode(value, _options) do
    value
  end
end
