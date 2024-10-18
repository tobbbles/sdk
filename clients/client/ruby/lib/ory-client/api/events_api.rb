=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.15.7
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
Generator version: 7.7.0

=end

require 'cgi'

module OryClient
  class EventsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Create an event stream for your project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param create_event_stream_body [CreateEventStreamBody] 
    # @param [Hash] opts the optional parameters
    # @return [EventStream]
    def create_event_stream(project_id, create_event_stream_body, opts = {})
      data, _status_code, _headers = create_event_stream_with_http_info(project_id, create_event_stream_body, opts)
      data
    end

    # Create an event stream for your project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param create_event_stream_body [CreateEventStreamBody] 
    # @param [Hash] opts the optional parameters
    # @return [Array<(EventStream, Integer, Hash)>] EventStream data, response status code and response headers
    def create_event_stream_with_http_info(project_id, create_event_stream_body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: EventsApi.create_event_stream ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling EventsApi.create_event_stream"
      end
      # verify the required parameter 'create_event_stream_body' is set
      if @api_client.config.client_side_validation && create_event_stream_body.nil?
        fail ArgumentError, "Missing the required parameter 'create_event_stream_body' when calling EventsApi.create_event_stream"
      end
      # resource path
      local_var_path = '/projects/{project_id}/eventstreams'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(create_event_stream_body)

      # return_type
      return_type = opts[:debug_return_type] || 'EventStream'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryWorkspaceApiKey']

      new_options = opts.merge(
        :operation => :"EventsApi.create_event_stream",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventsApi#create_event_stream\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Remove an event stream from a project
    # Remove an event stream from a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param event_stream_id [String] Event Stream ID  The ID of the event stream to be deleted, as returned when created.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def delete_event_stream(project_id, event_stream_id, opts = {})
      delete_event_stream_with_http_info(project_id, event_stream_id, opts)
      nil
    end

    # Remove an event stream from a project
    # Remove an event stream from a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param event_stream_id [String] Event Stream ID  The ID of the event stream to be deleted, as returned when created.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def delete_event_stream_with_http_info(project_id, event_stream_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: EventsApi.delete_event_stream ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling EventsApi.delete_event_stream"
      end
      # verify the required parameter 'event_stream_id' is set
      if @api_client.config.client_side_validation && event_stream_id.nil?
        fail ArgumentError, "Missing the required parameter 'event_stream_id' when calling EventsApi.delete_event_stream"
      end
      # resource path
      local_var_path = '/projects/{project_id}/eventstreams/{event_stream_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s)).sub('{' + 'event_stream_id' + '}', CGI.escape(event_stream_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type]

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryWorkspaceApiKey']

      new_options = opts.merge(
        :operation => :"EventsApi.delete_event_stream",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventsApi#delete_event_stream\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # List all event streams for the project. This endpoint is not paginated.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [ListEventStreams]
    def list_event_streams(project_id, opts = {})
      data, _status_code, _headers = list_event_streams_with_http_info(project_id, opts)
      data
    end

    # List all event streams for the project. This endpoint is not paginated.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @return [Array<(ListEventStreams, Integer, Hash)>] ListEventStreams data, response status code and response headers
    def list_event_streams_with_http_info(project_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: EventsApi.list_event_streams ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling EventsApi.list_event_streams"
      end
      # resource path
      local_var_path = '/projects/{project_id}/eventstreams'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body]

      # return_type
      return_type = opts[:debug_return_type] || 'ListEventStreams'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryWorkspaceApiKey']

      new_options = opts.merge(
        :operation => :"EventsApi.list_event_streams",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventsApi#list_event_streams\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Update an event stream for a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param event_stream_id [String] Event Stream ID  The event stream&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [SetEventStreamBody] :set_event_stream_body 
    # @return [EventStream]
    def set_event_stream(project_id, event_stream_id, opts = {})
      data, _status_code, _headers = set_event_stream_with_http_info(project_id, event_stream_id, opts)
      data
    end

    # Update an event stream for a project.
    # @param project_id [String] Project ID  The project&#39;s ID.
    # @param event_stream_id [String] Event Stream ID  The event stream&#39;s ID.
    # @param [Hash] opts the optional parameters
    # @option opts [SetEventStreamBody] :set_event_stream_body 
    # @return [Array<(EventStream, Integer, Hash)>] EventStream data, response status code and response headers
    def set_event_stream_with_http_info(project_id, event_stream_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: EventsApi.set_event_stream ...'
      end
      # verify the required parameter 'project_id' is set
      if @api_client.config.client_side_validation && project_id.nil?
        fail ArgumentError, "Missing the required parameter 'project_id' when calling EventsApi.set_event_stream"
      end
      # verify the required parameter 'event_stream_id' is set
      if @api_client.config.client_side_validation && event_stream_id.nil?
        fail ArgumentError, "Missing the required parameter 'event_stream_id' when calling EventsApi.set_event_stream"
      end
      # resource path
      local_var_path = '/projects/{project_id}/eventstreams/{event_stream_id}'.sub('{' + 'project_id' + '}', CGI.escape(project_id.to_s)).sub('{' + 'event_stream_id' + '}', CGI.escape(event_stream_id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      content_type = @api_client.select_header_content_type(['application/json'])
      if !content_type.nil?
          header_params['Content-Type'] = content_type
      end

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:debug_body] || @api_client.object_to_http_body(opts[:'set_event_stream_body'])

      # return_type
      return_type = opts[:debug_return_type] || 'EventStream'

      # auth_names
      auth_names = opts[:debug_auth_names] || ['oryWorkspaceApiKey']

      new_options = opts.merge(
        :operation => :"EventsApi.set_event_stream",
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:PUT, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EventsApi#set_event_stream\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
