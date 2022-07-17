# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.SuccessfulSelfServiceRegistrationWithoutBrowser do
  @moduledoc """
  The Response for Registration Flows via API
  """

  @derive [Poison.Encoder]
  defstruct [
    :identity,
    :session,
    :session_token
  ]

  @type t :: %__MODULE__{
    :identity => Ory.Model.Identity.t,
    :session => Ory.Model.Session.t | nil,
    :session_token => String.t | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.SuccessfulSelfServiceRegistrationWithoutBrowser do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:identity, :struct, Ory.Model.Identity, options)
    |> deserialize(:session, :struct, Ory.Model.Session, options)
  end
end

