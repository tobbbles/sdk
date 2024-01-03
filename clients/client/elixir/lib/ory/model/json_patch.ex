# NOTE: This file is auto generated by OpenAPI Generator 7.2.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.JsonPatch do
  @moduledoc """
  A JSONPatch document as defined by RFC 6902
  """

  @derive Jason.Encoder
  defstruct [
    :from,
    :op,
    :path,
    :value
  ]

  @type t :: %__MODULE__{
    :from => String.t | nil,
    :op => String.t,
    :path => String.t,
    :value => any() | nil
  }

  def decode(value) do
    value
  end
end

