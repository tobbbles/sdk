# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.VerifiableCredentialProof do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :jwt,
    :proof_type
  ]

  @type t :: %__MODULE__{
    :jwt => String.t | nil,
    :proof_type => String.t | nil
  }

  def decode(value) do
    value
  end
end

