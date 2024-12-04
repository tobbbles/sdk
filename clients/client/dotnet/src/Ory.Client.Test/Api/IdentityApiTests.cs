/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Ory.Client.Client;
using Ory.Client.Api;
// uncomment below to import models
//using Ory.Client.Model;

namespace Ory.Client.Test.Api
{
    /// <summary>
    ///  Class for testing IdentityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IdentityApiTests : IDisposable
    {
        private IdentityApi instance;

        public IdentityApiTests()
        {
            instance = new IdentityApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IdentityApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IdentityApi
            //Assert.IsType<IdentityApi>(instance);
        }

        /// <summary>
        /// Test BatchPatchIdentities
        /// </summary>
        [Fact]
        public void BatchPatchIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientPatchIdentitiesBody? clientPatchIdentitiesBody = null;
            //var response = instance.BatchPatchIdentities(clientPatchIdentitiesBody);
            //Assert.IsType<ClientBatchPatchIdentitiesResponse>(response);
        }

        /// <summary>
        /// Test CreateIdentity
        /// </summary>
        [Fact]
        public void CreateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientCreateIdentityBody? clientCreateIdentityBody = null;
            //var response = instance.CreateIdentity(clientCreateIdentityBody);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test CreateRecoveryCodeForIdentity
        /// </summary>
        [Fact]
        public void CreateRecoveryCodeForIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ClientCreateRecoveryCodeForIdentityBody? clientCreateRecoveryCodeForIdentityBody = null;
            //var response = instance.CreateRecoveryCodeForIdentity(clientCreateRecoveryCodeForIdentityBody);
            //Assert.IsType<ClientRecoveryCodeForIdentity>(response);
        }

        /// <summary>
        /// Test CreateRecoveryLinkForIdentity
        /// </summary>
        [Fact]
        public void CreateRecoveryLinkForIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? returnTo = null;
            //ClientCreateRecoveryLinkForIdentityBody? clientCreateRecoveryLinkForIdentityBody = null;
            //var response = instance.CreateRecoveryLinkForIdentity(returnTo, clientCreateRecoveryLinkForIdentityBody);
            //Assert.IsType<ClientRecoveryLinkForIdentity>(response);
        }

        /// <summary>
        /// Test DeleteIdentity
        /// </summary>
        [Fact]
        public void DeleteIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteIdentity(id);
        }

        /// <summary>
        /// Test DeleteIdentityCredentials
        /// </summary>
        [Fact]
        public void DeleteIdentityCredentialsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string type = null;
            //string? identifier = null;
            //instance.DeleteIdentityCredentials(id, type, identifier);
        }

        /// <summary>
        /// Test DeleteIdentitySessions
        /// </summary>
        [Fact]
        public void DeleteIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteIdentitySessions(id);
        }

        /// <summary>
        /// Test DisableSession
        /// </summary>
        [Fact]
        public void DisableSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DisableSession(id);
        }

        /// <summary>
        /// Test ExtendSession
        /// </summary>
        [Fact]
        public void ExtendSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.ExtendSession(id);
            //Assert.IsType<ClientSession>(response);
        }

        /// <summary>
        /// Test GetIdentity
        /// </summary>
        [Fact]
        public void GetIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? includeCredential = null;
            //var response = instance.GetIdentity(id, includeCredential);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test GetIdentitySchema
        /// </summary>
        [Fact]
        public void GetIdentitySchemaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetIdentitySchema(id);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetSession
        /// </summary>
        [Fact]
        public void GetSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string>? expand = null;
            //var response = instance.GetSession(id, expand);
            //Assert.IsType<ClientSession>(response);
        }

        /// <summary>
        /// Test ListIdentities
        /// </summary>
        [Fact]
        public void ListIdentitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //string? consistency = null;
            //List<string>? ids = null;
            //string? credentialsIdentifier = null;
            //string? previewCredentialsIdentifierSimilar = null;
            //List<string>? includeCredential = null;
            //string? organizationId = null;
            //var response = instance.ListIdentities(perPage, page, pageSize, pageToken, consistency, ids, credentialsIdentifier, previewCredentialsIdentifierSimilar, includeCredential, organizationId);
            //Assert.IsType<List<ClientIdentity>>(response);
        }

        /// <summary>
        /// Test ListIdentitySchemas
        /// </summary>
        [Fact]
        public void ListIdentitySchemasTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //var response = instance.ListIdentitySchemas(perPage, page, pageSize, pageToken);
            //Assert.IsType<List<ClientIdentitySchemaContainer>>(response);
        }

        /// <summary>
        /// Test ListIdentitySessions
        /// </summary>
        [Fact]
        public void ListIdentitySessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //long? perPage = null;
            //long? page = null;
            //long? pageSize = null;
            //string? pageToken = null;
            //bool? active = null;
            //var response = instance.ListIdentitySessions(id, perPage, page, pageSize, pageToken, active);
            //Assert.IsType<List<ClientSession>>(response);
        }

        /// <summary>
        /// Test ListSessions
        /// </summary>
        [Fact]
        public void ListSessionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? pageSize = null;
            //string? pageToken = null;
            //bool? active = null;
            //List<string>? expand = null;
            //var response = instance.ListSessions(pageSize, pageToken, active, expand);
            //Assert.IsType<List<ClientSession>>(response);
        }

        /// <summary>
        /// Test PatchIdentity
        /// </summary>
        [Fact]
        public void PatchIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<ClientJsonPatch>? clientJsonPatch = null;
            //var response = instance.PatchIdentity(id, clientJsonPatch);
            //Assert.IsType<ClientIdentity>(response);
        }

        /// <summary>
        /// Test UpdateIdentity
        /// </summary>
        [Fact]
        public void UpdateIdentityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //ClientUpdateIdentityBody? clientUpdateIdentityBody = null;
            //var response = instance.UpdateIdentity(id, clientUpdateIdentityBody);
            //Assert.IsType<ClientIdentity>(response);
        }
    }
}
