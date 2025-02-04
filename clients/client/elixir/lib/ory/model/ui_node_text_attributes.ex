# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UiNodeTextAttributes do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :id,
    :node_type,
    :text
  ]

  @type t :: %__MODULE__{
    :id => String.t,
    :node_type => String.t,
    :text => Ory.Model.UiText.t
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:text, :struct, Ory.Model.UiText)
  end
end

