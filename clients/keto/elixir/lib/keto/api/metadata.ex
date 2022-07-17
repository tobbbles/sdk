# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Keto.Api.Metadata do
  @moduledoc """
  API calls for all endpoints tagged `Metadata`.
  """

  alias Keto.Connection
  import Keto.RequestBuilder


  @doc """
  Return Running Software Version.
  This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the `X-Forwarded-Proto` header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.

  ## Parameters

  - connection (Keto.Connection): Connection to server
  - opts (KeywordList): [optional] Optional parameters
  ## Returns

  {:ok, Keto.Model.InlineResponse2001.t} on success
  {:error, Tesla.Env.t} on failure
  """
  @spec get_version(Tesla.Env.client, keyword()) :: {:ok, Keto.Model.InlineResponse2001.t} | {:error, Tesla.Env.t}
  def get_version(connection, _opts \\ []) do
    %{}
    |> method(:get)
    |> url("/version")
    |> Enum.into([])
    |> (&Connection.request(connection, &1)).()
    |> evaluate_response([
      { 200, %Keto.Model.InlineResponse2001{}}
    ])
  end

  @doc """
  Check HTTP Server Status
  This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the `X-Forwarded-Proto` header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.

  ## Parameters

  - connection (Keto.Connection): Connection to server
  - opts (KeywordList): [optional] Optional parameters
  ## Returns

  {:ok, Keto.Model.InlineResponse200.t} on success
  {:error, Tesla.Env.t} on failure
  """
  @spec is_alive(Tesla.Env.client, keyword()) :: {:ok, Keto.Model.InlineResponse200.t} | {:ok, Keto.Model.GenericError.t} | {:error, Tesla.Env.t}
  def is_alive(connection, _opts \\ []) do
    %{}
    |> method(:get)
    |> url("/health/alive")
    |> Enum.into([])
    |> (&Connection.request(connection, &1)).()
    |> evaluate_response([
      { 200, %Keto.Model.InlineResponse200{}},
      { 500, %Keto.Model.GenericError{}}
    ])
  end

  @doc """
  Check HTTP Server and Database Status
  This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the `X-Forwarded-Proto` header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.

  ## Parameters

  - connection (Keto.Connection): Connection to server
  - opts (KeywordList): [optional] Optional parameters
  ## Returns

  {:ok, Keto.Model.InlineResponse200.t} on success
  {:error, Tesla.Env.t} on failure
  """
  @spec is_ready(Tesla.Env.client, keyword()) :: {:ok, Keto.Model.InlineResponse503.t} | {:ok, Keto.Model.InlineResponse200.t} | {:error, Tesla.Env.t}
  def is_ready(connection, _opts \\ []) do
    %{}
    |> method(:get)
    |> url("/health/ready")
    |> Enum.into([])
    |> (&Connection.request(connection, &1)).()
    |> evaluate_response([
      { 200, %Keto.Model.InlineResponse200{}},
      { 503, %Keto.Model.InlineResponse503{}}
    ])
  end
end