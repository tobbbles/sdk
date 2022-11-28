=begin
#Ory APIs

#Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 

The version of the OpenAPI document: v1.0.0-alpha.0
Contact: support@ory.sh
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 6.0.1

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for OryClient::PerformNativeLogoutBody
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe OryClient::PerformNativeLogoutBody do
  let(:instance) { OryClient::PerformNativeLogoutBody.new }

  describe 'test an instance of PerformNativeLogoutBody' do
    it 'should create an instance of PerformNativeLogoutBody' do
      expect(instance).to be_instance_of(OryClient::PerformNativeLogoutBody)
    end
  end
  describe 'test attribute "session_token"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end