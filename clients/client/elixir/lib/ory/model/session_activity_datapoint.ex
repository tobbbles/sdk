# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.SessionActivityDatapoint do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :country,
    :failed,
    :succeeded
  ]

  @type t :: %__MODULE__{
    :country => String.t,
    :failed => integer(),
    :succeeded => integer()
  }

  def decode(value) do
    value
  end
end

