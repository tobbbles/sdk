# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.ProjectServicePermission do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :config
  ]

  @type t :: %__MODULE__{
    :config => map()
  }
end

defimpl Poison.Decoder, for: Ory.Model.ProjectServicePermission do
  def decode(value, _options) do
    value
  end
end

