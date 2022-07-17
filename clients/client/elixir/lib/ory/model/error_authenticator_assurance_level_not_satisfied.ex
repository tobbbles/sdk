# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.ErrorAuthenticatorAssuranceLevelNotSatisfied do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :code,
    :debug,
    :details,
    :id,
    :message,
    :reason,
    :redirect_browser_to,
    :request,
    :status
  ]

  @type t :: %__MODULE__{
    :code => integer() | nil,
    :debug => String.t | nil,
    :details => %{optional(String.t) => AnyType} | nil,
    :id => String.t | nil,
    :message => String.t,
    :reason => String.t | nil,
    :redirect_browser_to => String.t | nil,
    :request => String.t | nil,
    :status => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.ErrorAuthenticatorAssuranceLevelNotSatisfied do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:details, :map, Ory.Model.AnyType, options)
  end
end

