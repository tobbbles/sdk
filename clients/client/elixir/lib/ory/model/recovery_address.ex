# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.RecoveryAddress do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :created_at,
    :id,
    :updated_at,
    :value,
    :via
  ]

  @type t :: %__MODULE__{
    :created_at => DateTime.t | nil,
    :id => String.t,
    :updated_at => DateTime.t | nil,
    :value => String.t,
    :via => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.RecoveryAddress do
  def decode(value, _options) do
    value
  end
end

