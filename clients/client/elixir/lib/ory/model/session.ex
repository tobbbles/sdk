# NOTE: This file is auto generated by OpenAPI Generator 7.2.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.Session do
  @moduledoc """
  A Session
  """

  @derive Jason.Encoder
  defstruct [
    :active,
    :authenticated_at,
    :authentication_methods,
    :authenticator_assurance_level,
    :devices,
    :expires_at,
    :id,
    :identity,
    :issued_at,
    :tokenized
  ]

  @type t :: %__MODULE__{
    :active => boolean() | nil,
    :authenticated_at => DateTime.t | nil,
    :authentication_methods => [Ory.Model.SessionAuthenticationMethod.t] | nil,
    :authenticator_assurance_level => String.t | nil,
    :devices => [Ory.Model.SessionDevice.t] | nil,
    :expires_at => DateTime.t | nil,
    :id => String.t,
    :identity => Ory.Model.Identity.t | nil,
    :issued_at => DateTime.t | nil,
    :tokenized => String.t | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:authenticated_at, :datetime, nil)
     |> Deserializer.deserialize(:authentication_methods, :list, Ory.Model.SessionAuthenticationMethod)
     |> Deserializer.deserialize(:devices, :list, Ory.Model.SessionDevice)
     |> Deserializer.deserialize(:expires_at, :datetime, nil)
     |> Deserializer.deserialize(:identity, :struct, Ory.Model.Identity)
     |> Deserializer.deserialize(:issued_at, :datetime, nil)
  end
end

