# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UiNodeImageAttributes do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :height,
    :id,
    :node_type,
    :src,
    :width
  ]

  @type t :: %__MODULE__{
    :height => integer(),
    :id => String.t,
    :node_type => String.t,
    :src => String.t,
    :width => integer()
  }

  def decode(value) do
    value
  end
end

