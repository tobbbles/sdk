# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.RelationQuery do
  @moduledoc """
  Relation Query
  """

  @derive Jason.Encoder
  defstruct [
    :namespace,
    :object,
    :relation,
    :subject_id,
    :subject_set
  ]

  @type t :: %__MODULE__{
    :namespace => String.t | nil,
    :object => String.t | nil,
    :relation => String.t | nil,
    :subject_id => String.t | nil,
    :subject_set => Ory.Model.SubjectSet.t | nil
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:subject_set, :struct, Ory.Model.SubjectSet)
  end
end

