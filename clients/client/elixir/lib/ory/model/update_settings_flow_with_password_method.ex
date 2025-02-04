# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateSettingsFlowWithPasswordMethod do
  @moduledoc """
  Update Settings Flow with Password Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :method,
    :password,
    :transient_payload
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :method => String.t,
    :password => String.t,
    :transient_payload => map() | nil
  }

  def decode(value) do
    value
  end
end

