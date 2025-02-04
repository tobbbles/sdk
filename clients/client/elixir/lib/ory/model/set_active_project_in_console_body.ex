# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.SetActiveProjectInConsoleBody do
  @moduledoc """
  Set active project in the Ory Network Console Request Body
  """

  @derive Jason.Encoder
  defstruct [
    :project_id
  ]

  @type t :: %__MODULE__{
    :project_id => String.t
  }

  def decode(value) do
    value
  end
end

