# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.IsOwnerForProjectBySlug do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :ProjectSlug,
    :Subject
  ]

  @type t :: %__MODULE__{
    :ProjectSlug => String.t,
    :Subject => String.t
  }

  def decode(value) do
    value
  end
end

