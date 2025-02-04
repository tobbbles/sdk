# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ListEventStreams do
  @moduledoc """
  Event Stream List
  """

  @derive Jason.Encoder
  defstruct [
    :event_streams
  ]

  @type t :: %__MODULE__{
    :event_streams => [Ory.Model.EventStream.t] | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:event_streams, :list, Ory.Model.EventStream)
  end
end

