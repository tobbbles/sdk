# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ProjectMetadata do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :created_at,
    :environment,
    :home_region,
    :hosts,
    :id,
    :name,
    :slug,
    :state,
    :subscription_id,
    :subscription_plan,
    :updated_at,
    :workspace,
    :workspace_id
  ]

  @type t :: %__MODULE__{
    :created_at => DateTime.t,
    :environment => String.t,
    :home_region => String.t,
    :hosts => [String.t],
    :id => String.t,
    :name => String.t,
    :slug => String.t,
    :state => String.t,
    :subscription_id => String.t | nil,
    :subscription_plan => String.t | nil,
    :updated_at => DateTime.t,
    :workspace => Ory.Model.Workspace.t | nil,
    :workspace_id => String.t | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:created_at, :datetime, nil)
     |> Deserializer.deserialize(:updated_at, :datetime, nil)
     |> Deserializer.deserialize(:workspace, :struct, Ory.Model.Workspace)
  end
end

