# NOTE: This file is auto generated by OpenAPI Generator 6.6.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ListOrganizationsResponse do
  @moduledoc """
  B2B SSO Organization List
  """

  @derive [Poison.Encoder]
  defstruct [
    :organizations
  ]

  @type t :: %__MODULE__{
    :organizations => [Ory.Model.Organization.t]
  }
end

defimpl Poison.Decoder, for: Ory.Model.ListOrganizationsResponse do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:organizations, :list, Ory.Model.Organization, options)
  end
end

