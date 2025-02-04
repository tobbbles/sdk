# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Model.ContinueWith do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :action,
    :flow,
    :ory_session_token,
    :redirect_browser_to
  ]

  @type t :: %__MODULE__{
    :action => String.t,
    :flow => Ory.Model.ContinueWithRecoveryUiFlow.t,
    :ory_session_token => String.t,
    :redirect_browser_to => String.t
  }

  alias Ory.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:flow, :struct, Ory.Model.ContinueWithRecoveryUiFlow)
  end
end

