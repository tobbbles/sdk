# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule Ory.Api.Project do
  @moduledoc """
  API calls for all endpoints tagged `Project`.
  """

  alias Ory.Connection
  import Ory.RequestBuilder

  @doc """
  Create an Enterprise SSO Organization
  Creates an Enterprise SSO Organization in a project.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters
    - `:body` (OrganizationBody): 

  ### Returns

  - `{:ok, Ory.Model.Organization.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec create_organization(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.Organization.t} | {:error, Tesla.Env.t}
  def create_organization(connection, project_id, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:post)
      |> url("/projects/#{project_id}/organizations")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {201, Ory.Model.Organization},
      {400, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {409, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Create a Project
  Creates a new project.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `opts` (keyword): Optional parameters
    - `:body` (CreateProjectBody): 

  ### Returns

  - `{:ok, Ory.Model.Project.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec create_project(Tesla.Env.client, keyword()) :: {:ok, Ory.Model.Project.t} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def create_project(connection, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:post)
      |> url("/projects")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {201, Ory.Model.Project},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Create project API key
  Create an API key for a project.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project` (String.t): The Project ID or Project slug
  - `opts` (keyword): Optional parameters
    - `:body` (CreateProjectApiKeyRequest): 

  ### Returns

  - `{:ok, Ory.Model.ProjectApiKey.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec create_project_api_key(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.ProjectApiKey.t} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def create_project_api_key(connection, project, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:post)
      |> url("/projects/#{project}/tokens")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {201, Ory.Model.ProjectApiKey},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Delete Enterprise SSO Organization
  Irrecoverably deletes an Enterprise SSO Organization in a project by its ID.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `organization_id` (String.t): Organization ID  The Organization's ID.
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, nil}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec delete_organization(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, nil} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def delete_organization(connection, project_id, organization_id, _opts \\ []) do
    request =
      %{}
      |> method(:delete)
      |> url("/projects/#{project_id}/organizations/#{organization_id}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {204, false},
      {400, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {409, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Delete project API key
  Deletes an API key and immediately removes it.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project` (String.t): The Project ID or Project slug
  - `token_id` (String.t): The Token ID
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, nil}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec delete_project_api_key(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, nil} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def delete_project_api_key(connection, project, token_id, _opts \\ []) do
    request =
      %{}
      |> method(:delete)
      |> url("/projects/#{project}/tokens/#{token_id}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {204, false},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Get Enterprise SSO Organization by ID
  Retrieves an Enterprise SSO Organization for a project by its ID

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `organization_id` (String.t): Organization ID  The Organization's ID.
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, Ory.Model.GetOrganizationResponse.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec get_organization(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.GetOrganizationResponse.t} | {:error, Tesla.Env.t}
  def get_organization(connection, project_id, organization_id, _opts \\ []) do
    request =
      %{}
      |> method(:get)
      |> url("/projects/#{project_id}/organizations/#{organization_id}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.GetOrganizationResponse},
      {400, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Get a Project
  Get a projects you have access to by its ID.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, Ory.Model.Project.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec get_project(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.Project.t} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def get_project(connection, project_id, _opts \\ []) do
    request =
      %{}
      |> method(:get)
      |> url("/projects/#{project_id}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.Project},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Get all members associated with this project
  This endpoint requires the user to be a member of the project with the role `OWNER` or `DEVELOPER`.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project` (String.t): 
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, [%ProjectMember{}, ...]}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec get_project_members(Tesla.Env.client, String.t, keyword()) :: {:ok, [Ory.Model.ProjectMember.t]} | {:ok, Ory.Model.GenericError.t} | {:error, Tesla.Env.t}
  def get_project_members(connection, project, _opts \\ []) do
    request =
      %{}
      |> method(:get)
      |> url("/projects/#{project}/members")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.ProjectMember},
      {401, Ory.Model.GenericError},
      {406, Ory.Model.GenericError},
      {:default, Ory.Model.GenericError}
    ])
  end

  @doc """
  List all Enterprise SSO organizations
  Lists all Enterprise SSO organizations in a project.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters
    - `:page_size` (integer()): Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    - `:page_token` (String.t): Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination).
    - `:domain` (String.t): Domain  If set, only organizations with that domain will be returned.

  ### Returns

  - `{:ok, Ory.Model.ListOrganizationsResponse.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec list_organizations(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.ListOrganizationsResponse.t} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def list_organizations(connection, project_id, opts \\ []) do
    optional_params = %{
      :page_size => :query,
      :page_token => :query,
      :domain => :query
    }

    request =
      %{}
      |> method(:get)
      |> url("/projects/#{project_id}/organizations")
      |> add_optional_params(optional_params, opts)
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.ListOrganizationsResponse},
      {400, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  List a project's API keys
  A list of all the project's API keys.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project` (String.t): The Project ID or Project slug
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, [%ProjectApiKey{}, ...]}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec list_project_api_keys(Tesla.Env.client, String.t, keyword()) :: {:ok, [Ory.Model.ProjectApiKey.t]} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def list_project_api_keys(connection, project, _opts \\ []) do
    request =
      %{}
      |> method(:get)
      |> url("/projects/#{project}/tokens")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.ProjectApiKey},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  List All Projects
  Lists all projects you have access to.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, [%ProjectMetadata{}, ...]}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec list_projects(Tesla.Env.client, keyword()) :: {:ok, [Ory.Model.ProjectMetadata.t]} | {:ok, Ory.Model.ErrorGeneric.t} | {:error, Tesla.Env.t}
  def list_projects(connection, _opts \\ []) do
    request =
      %{}
      |> method(:get)
      |> url("/projects")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.ProjectMetadata},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Patch an Ory Network Project Configuration
  Deprecated: Use the `patchProjectWithRevision` endpoint instead to specify the exact revision the patch was generated for.  This endpoints allows you to patch individual Ory Network project configuration keys for Ory's services (identity, permission, ...). The configuration format is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the `version` key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to the Ory Network, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters
    - `:body` ([Ory.Model.JsonPatch.t]): 

  ### Returns

  - `{:ok, Ory.Model.SuccessfulProjectUpdate.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec patch_project(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.SuccessfulProjectUpdate.t} | {:error, Tesla.Env.t}
  def patch_project(connection, project_id, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:patch)
      |> url("/projects/#{project_id}")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.SuccessfulProjectUpdate},
      {400, Ory.Model.ErrorGeneric},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Patch an Ory Network Project Configuration based on a revision ID
  This endpoints allows you to patch individual Ory Network Project configuration keys for Ory's services (identity, permission, ...). The configuration format is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the `version` key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to the Ory Network, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `revision_id` (String.t): Revision ID  The revision ID that this patch was generated for.
  - `opts` (keyword): Optional parameters
    - `:body` ([Ory.Model.JsonPatch.t]): 

  ### Returns

  - `{:ok, Ory.Model.SuccessfulProjectUpdate.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec patch_project_with_revision(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.SuccessfulProjectUpdate.t} | {:error, Tesla.Env.t}
  def patch_project_with_revision(connection, project_id, revision_id, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:patch)
      |> url("/projects/#{project_id}/revision/#{revision_id}")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.SuccessfulProjectUpdate},
      {400, Ory.Model.ErrorGeneric},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Irrecoverably purge a project
  !! Use with extreme caution !!  Using this API endpoint you can purge (completely delete) a project and its data. This action can not be undone and will delete ALL your data.  Calling this endpoint will additionally delete custom domains and other related data.  If the project is linked to a subscription, the subscription needs to be unlinked first.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, nil}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec purge_project(Tesla.Env.client, String.t, keyword()) :: {:ok, nil} | {:ok, Ory.Model.GenericError.t} | {:error, Tesla.Env.t}
  def purge_project(connection, project_id, _opts \\ []) do
    request =
      %{}
      |> method(:delete)
      |> url("/projects/#{project_id}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {204, false},
      {401, Ory.Model.GenericError},
      {403, Ory.Model.GenericError},
      {404, Ory.Model.GenericError},
      {:default, Ory.Model.GenericError}
    ])
  end

  @doc """
  Remove a member associated with this project
  This also sets their invite status to `REMOVED`. This endpoint requires the user to be a member of the project with the role `OWNER`.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project` (String.t): 
  - `member` (String.t): 
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, nil}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec remove_project_member(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, nil} | {:ok, Ory.Model.GenericError.t} | {:error, Tesla.Env.t}
  def remove_project_member(connection, project, member, _opts \\ []) do
    request =
      %{}
      |> method(:delete)
      |> url("/projects/#{project}/members/#{member}")
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {204, false},
      {401, Ory.Model.GenericError},
      {406, Ory.Model.GenericError},
      {:default, Ory.Model.GenericError}
    ])
  end

  @doc """
  Update an Ory Network Project Configuration
  This endpoints allows you to update the Ory Network project configuration for individual services (identity, permission, ...). The configuration is fully compatible with the open source projects for the respective services (e.g. Ory Kratos for Identity, Ory Keto for Permissions).  This endpoint expects the `version` key to be set in the payload. If it is unset, it will try to import the config as if it is from the most recent version.  If you have an older version of a configuration, you should set the version key in the payload!  While this endpoint is able to process all configuration items related to features (e.g. password reset), it does not support operational configuration items (e.g. port, tracing, logging) otherwise available in the open source.  For configuration items that can not be translated to the Ory Network, this endpoint will return a list of warnings to help you understand which parts of your config could not be processed.  Be aware that updating any service's configuration will completely override your current configuration for that service!

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `opts` (keyword): Optional parameters
    - `:body` (SetProject): 

  ### Returns

  - `{:ok, Ory.Model.SuccessfulProjectUpdate.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec set_project(Tesla.Env.client, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.SuccessfulProjectUpdate.t} | {:error, Tesla.Env.t}
  def set_project(connection, project_id, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:put)
      |> url("/projects/#{project_id}")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.SuccessfulProjectUpdate},
      {400, Ory.Model.ErrorGeneric},
      {401, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end

  @doc """
  Update an Enterprise SSO Organization
  Updates an Enterprise SSO Organization in a project by its ID.

  ### Parameters

  - `connection` (Ory.Connection): Connection to server
  - `project_id` (String.t): Project ID  The project's ID.
  - `organization_id` (String.t): Organization ID  The Organization's ID.
  - `opts` (keyword): Optional parameters
    - `:body` (OrganizationBody): 

  ### Returns

  - `{:ok, Ory.Model.Organization.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec update_organization(Tesla.Env.client, String.t, String.t, keyword()) :: {:ok, Ory.Model.ErrorGeneric.t} | {:ok, Ory.Model.Organization.t} | {:error, Tesla.Env.t}
  def update_organization(connection, project_id, organization_id, opts \\ []) do
    optional_params = %{
      :body => :body
    }

    request =
      %{}
      |> method(:put)
      |> url("/projects/#{project_id}/organizations/#{organization_id}")
      |> add_optional_params(optional_params, opts)
      |> ensure_body()
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, Ory.Model.Organization},
      {400, Ory.Model.ErrorGeneric},
      {403, Ory.Model.ErrorGeneric},
      {404, Ory.Model.ErrorGeneric},
      {409, Ory.Model.ErrorGeneric},
      {:default, Ory.Model.ErrorGeneric}
    ])
  end
end
