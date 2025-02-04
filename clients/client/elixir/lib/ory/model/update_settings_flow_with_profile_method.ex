# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateSettingsFlowWithProfileMethod do
  @moduledoc """
  Update Settings Flow with Profile Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :method,
    :traits,
    :transient_payload
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :traits => map(),
    :transient_payload => map() | nil
  }

  def decode(value) do
    value
  end
end

