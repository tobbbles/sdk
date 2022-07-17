# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.Project do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :id,
    :name,
    :revision_id,
    :services,
    :slug,
    :state
  ]

  @type t :: %__MODULE__{
    :id => String.t,
    :name => String.t,
    :revision_id => String.t,
    :services => Ory.Model.ProjectServices.t,
    :slug => String.t,
    :state => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.Project do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:services, :struct, Ory.Model.ProjectServices, options)
  end
end

