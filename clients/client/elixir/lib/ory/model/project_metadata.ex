# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.ProjectMetadata do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :created_at,
    :hosts,
    :id,
    :name,
    :slug,
    :state,
    :subscription_id,
    :updated_at
  ]

  @type t :: %__MODULE__{
    :created_at => DateTime.t,
    :hosts => [String.t],
    :id => String.t,
    :name => String.t,
    :slug => String.t | nil,
    :state => String.t,
    :subscription_id => String.t | nil,
    :updated_at => DateTime.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.ProjectMetadata do
  def decode(value, _options) do
    value
  end
end
