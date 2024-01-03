# NOTE: This file is auto generated by OpenAPI Generator 7.2.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.RecoveryIdentityAddress do
  @moduledoc """
  
  """

  @derive Jason.Encoder
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

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:created_at, :datetime, nil)
     |> Deserializer.deserialize(:updated_at, :datetime, nil)
  end
end

