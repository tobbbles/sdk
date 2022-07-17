# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.Warning do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :code,
    :message
  ]

  @type t :: %__MODULE__{
    :code => integer() | nil,
    :message => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.Warning do
  def decode(value, _options) do
    value
  end
end

