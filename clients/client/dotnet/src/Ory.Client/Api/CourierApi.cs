/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.5.1
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Client.Client;
using Ory.Client.Model;

namespace Ory.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ClientMessage</returns>
        ClientMessage GetCourierMessage(string id);

        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ApiResponse of ClientMessage</returns>
        ApiResponse<ClientMessage> GetCourierMessageWithHttpInfo(string id);
        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>List&lt;ClientMessage&gt;</returns>
        List<ClientMessage> ListCourierMessages(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string));

        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>ApiResponse of List&lt;ClientMessage&gt;</returns>
        ApiResponse<List<ClientMessage>> ListCourierMessagesWithHttpInfo(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientMessage</returns>
        System.Threading.Tasks.Task<ClientMessage> GetCourierMessageAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a Message
        /// </summary>
        /// <remarks>
        /// Gets a specific messages by the given ID.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientMessage)</returns>
        System.Threading.Tasks.Task<ApiResponse<ClientMessage>> GetCourierMessageWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ClientMessage&gt;</returns>
        System.Threading.Tasks.Task<List<ClientMessage>> ListCourierMessagesAsync(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List Messages
        /// </summary>
        /// <remarks>
        /// Lists all messages by given status and recipient.
        /// </remarks>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ClientMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ClientMessage>>> ListCourierMessagesWithHttpInfoAsync(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICourierApi : ICourierApiSync, ICourierApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CourierApi : ICourierApi
    {
        private Ory.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CourierApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CourierApi(string basePath)
        {
            this.Configuration = Ory.Client.Client.Configuration.MergeConfigurations(
                Ory.Client.Client.GlobalConfiguration.Instance,
                new Ory.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CourierApi(Ory.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Client.Client.Configuration.MergeConfigurations(
                Ory.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CourierApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CourierApi(Ory.Client.Client.ISynchronousClient client, Ory.Client.Client.IAsynchronousClient asyncClient, Ory.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ClientMessage</returns>
        public ClientMessage GetCourierMessage(string id)
        {
            Ory.Client.Client.ApiResponse<ClientMessage> localVarResponse = GetCourierMessageWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <returns>ApiResponse of ClientMessage</returns>
        public Ory.Client.Client.ApiResponse<ClientMessage> GetCourierMessageWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Ory.Client.Client.ApiException(400, "Missing required parameter 'id' when calling CourierApi->GetCourierMessage");
            }

            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Ory.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ClientMessage>("/admin/courier/messages/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCourierMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ClientMessage</returns>
        public async System.Threading.Tasks.Task<ClientMessage> GetCourierMessageAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Client.Client.ApiResponse<ClientMessage> localVarResponse = await GetCourierMessageWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Message Gets a specific messages by the given ID.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">MessageID is the ID of the message.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ClientMessage)</returns>
        public async System.Threading.Tasks.Task<Ory.Client.Client.ApiResponse<ClientMessage>> GetCourierMessageWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new Ory.Client.Client.ApiException(400, "Missing required parameter 'id' when calling CourierApi->GetCourierMessage");
            }


            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Ory.Client.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ClientMessage>("/admin/courier/messages/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCourierMessage", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>List&lt;ClientMessage&gt;</returns>
        public List<ClientMessage> ListCourierMessages(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string))
        {
            Ory.Client.Client.ApiResponse<List<ClientMessage>> localVarResponse = ListCourierMessagesWithHttpInfo(pageSize, pageToken, status, recipient);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <returns>ApiResponse of List&lt;ClientMessage&gt;</returns>
        public Ory.Client.Client.ApiResponse<List<ClientMessage>> ListCourierMessagesWithHttpInfo(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string))
        {
            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (pageToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "page_token", pageToken));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (recipient != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "recipient", recipient));
            }

            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<ClientMessage>>("/admin/courier/messages", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCourierMessages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;ClientMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<ClientMessage>> ListCourierMessagesAsync(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Client.Client.ApiResponse<List<ClientMessage>> localVarResponse = await ListCourierMessagesWithHttpInfoAsync(pageSize, pageToken, status, recipient, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Messages Lists all messages by given status and recipient.
        /// </summary>
        /// <exception cref="Ory.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Items per Page  This is the number of items per page to return. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional, default to 250)</param>
        /// <param name="pageToken">Next Page Token  The next page token. For details on pagination please head over to the [pagination documentation](https://www.ory.sh/docs/ecosystem/api-design#pagination). (optional)</param>
        /// <param name="status">Status filters out messages based on status. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="recipient">Recipient filters out messages based on recipient. If no value is provided, it doesn&#39;t take effect on filter. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;ClientMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<Ory.Client.Client.ApiResponse<List<ClientMessage>>> ListCourierMessagesWithHttpInfoAsync(long? pageSize = default(long?), string pageToken = default(string), ClientCourierMessageStatus? status = default(ClientCourierMessageStatus?), string recipient = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Client.Client.RequestOptions localVarRequestOptions = new Ory.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (pageToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "page_token", pageToken));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }
            if (recipient != null)
            {
                localVarRequestOptions.QueryParameters.Add(Ory.Client.Client.ClientUtils.ParameterToMultiMap("", "recipient", recipient));
            }

            // authentication (oryAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<ClientMessage>>("/admin/courier/messages", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListCourierMessages", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
