# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.GetOrganizationResponse do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :organization
  ]

  @type t :: %__MODULE__{
    :organization => Ory.Model.Organization.t
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:organization, :struct, Ory.Model.Organization)
  end
end

