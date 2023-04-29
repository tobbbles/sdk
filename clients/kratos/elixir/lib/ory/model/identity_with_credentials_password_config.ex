# NOTE: This file is auto generated by OpenAPI Generator 6.2.1 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.IdentityWithCredentialsPasswordConfig do
  @moduledoc """
  Create Identity and Import Password Credentials Configuration
  """

  @derive [Poison.Encoder]
  defstruct [
    :hashed_password,
    :password
  ]

  @type t :: %__MODULE__{
    :hashed_password => String.t | nil,
    :password => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.IdentityWithCredentialsPasswordConfig do
  def decode(value, _options) do
    value
  end
end

