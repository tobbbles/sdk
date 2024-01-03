# NOTE: This file is auto generated by OpenAPI Generator 7.2.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.OAuth2LogoutRequest do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :challenge,
    :client,
    :request_url,
    :rp_initiated,
    :sid,
    :subject
  ]

  @type t :: %__MODULE__{
    :challenge => String.t | nil,
    :client => Ory.Model.OAuth2Client.t | nil,
    :request_url => String.t | nil,
    :rp_initiated => boolean() | nil,
    :sid => String.t | nil,
    :subject => String.t | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:client, :struct, Ory.Model.OAuth2Client)
  end
end

