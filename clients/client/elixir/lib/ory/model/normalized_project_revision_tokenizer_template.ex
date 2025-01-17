# NOTE: This file is auto generated by OpenAPI Generator 6.6.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.NormalizedProjectRevisionTokenizerTemplate do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :claims_mapper_url,
    :created_at,
    :id,
    :jwks_url,
    :key,
    :project_revision_id,
    :ttl,
    :updated_at
  ]

  @type t :: %__MODULE__{
    :claims_mapper_url => String.t | nil,
    :created_at => DateTime.t | nil,
    :id => String.t | nil,
    :jwks_url => String.t | nil,
    :key => String.t | nil,
    :project_revision_id => String.t | nil,
    :ttl => String.t | nil,
    :updated_at => DateTime.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.NormalizedProjectRevisionTokenizerTemplate do
  def decode(value, _options) do
    value
  end
end

