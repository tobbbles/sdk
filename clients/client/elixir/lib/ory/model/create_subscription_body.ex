# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.CreateSubscriptionBody do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :currency,
    :interval,
    :plan,
    :provision_first_project,
    :return_to
  ]

  @type t :: %__MODULE__{
    :currency => String.t | nil,
    :interval => String.t,
    :plan => String.t,
    :provision_first_project => String.t,
    :return_to => String.t | nil
  }

  def decode(value) do
    value
  end
end

