# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UiText do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :context,
    :id,
    :text,
    :type
  ]

  @type t :: %__MODULE__{
    :context => map() | nil,
    :id => integer(),
    :text => String.t,
    :type => String.t
  }

  def decode(value) do
    value
  end
end

