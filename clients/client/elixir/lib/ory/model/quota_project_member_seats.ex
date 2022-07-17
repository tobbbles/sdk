# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.QuotaProjectMemberSeats do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :project_id,
    :remaining_seats,
    :total_seats
  ]

  @type t :: %__MODULE__{
    :project_id => String.t | nil,
    :remaining_seats => integer() | nil,
    :total_seats => integer() | nil
  }
end

defimpl Poison.Decoder, for: Ory.Model.QuotaProjectMemberSeats do
  def decode(value, _options) do
    value
  end
end

