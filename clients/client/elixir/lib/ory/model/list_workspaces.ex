# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ListWorkspaces do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :has_next_page,
    :next_page_token,
    :workspaces
  ]

  @type t :: %__MODULE__{
    :has_next_page => boolean(),
    :next_page_token => String.t,
    :workspaces => [Ory.Model.Workspace.t]
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:workspaces, :list, Ory.Model.Workspace)
  end
end

