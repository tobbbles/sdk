# NOTE: This file is auto generated by OpenAPI Generator 7.2.0 (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.UpdateLoginFlowWithPasswordMethod do
  @moduledoc """
  Update Login Flow with Password Method
  """

  @derive Jason.Encoder
  defstruct [
    :csrf_token,
    :identifier,
    :method,
    :password,
    :password_identifier
  ]

  @type t :: %__MODULE__{
    :csrf_token => String.t | nil,
    :identifier => String.t,
    :method => String.t,
    :password => String.t,
    :password_identifier => String.t | nil
  }

  def decode(value) do
    value
  end
end

