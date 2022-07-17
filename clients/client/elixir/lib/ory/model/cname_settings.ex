# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.CnameSettings do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :cookie_domain,
    :cors_allowed_origins,
    :cors_enabled,
    :created_at,
    :hostname,
    :id,
    :updated_at,
    :verification_errors,
    :verification_status
  ]

  @type t :: %__MODULE__{
    :cookie_domain => String.t | nil,
    :cors_allowed_origins => [String.t] | nil,
    :cors_enabled => boolean() | nil,
    :created_at => DateTime.t | nil,
    :hostname => String.t | nil,
    :id => String.t | nil,
    :updated_at => DateTime.t | nil,
    :verification_errors => [String.t] | nil,
    :verification_status => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.CnameSettings do
  def decode(value, _options) do
    value
  end
end

