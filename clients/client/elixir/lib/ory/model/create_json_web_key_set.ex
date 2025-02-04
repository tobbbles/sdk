# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.CreateJsonWebKeySet do
  @moduledoc """
  Create JSON Web Key Set Request Body
  """

  @derive Jason.Encoder
  defstruct [
    :alg,
    :kid,
    :use
  ]

  @type t :: %__MODULE__{
    :alg => String.t,
    :kid => String.t,
    :use => String.t
  }

  def decode(value) do
    value
  end
end

