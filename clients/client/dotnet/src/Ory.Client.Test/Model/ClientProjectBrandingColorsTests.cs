/*
 * Ory APIs
 *
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | - -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | - -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- - | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Client.Model;
using Ory.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Client.Test.Model
{
    /// <summary>
    ///  Class for testing ClientProjectBrandingColors
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ClientProjectBrandingColorsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ClientProjectBrandingColors
        //private ClientProjectBrandingColors instance;

        public ClientProjectBrandingColorsTests()
        {
            // TODO uncomment below to create an instance of ClientProjectBrandingColors
            //instance = new ClientProjectBrandingColors();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ClientProjectBrandingColors
        /// </summary>
        [Fact]
        public void ClientProjectBrandingColorsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ClientProjectBrandingColors
            //Assert.IsType<ClientProjectBrandingColors>(instance);
        }

        /// <summary>
        /// Test the property 'AccentDefaultColor'
        /// </summary>
        [Fact]
        public void AccentDefaultColorTest()
        {
            // TODO unit test for the property 'AccentDefaultColor'
        }

        /// <summary>
        /// Test the property 'AccentDisabledColor'
        /// </summary>
        [Fact]
        public void AccentDisabledColorTest()
        {
            // TODO unit test for the property 'AccentDisabledColor'
        }

        /// <summary>
        /// Test the property 'AccentEmphasisColor'
        /// </summary>
        [Fact]
        public void AccentEmphasisColorTest()
        {
            // TODO unit test for the property 'AccentEmphasisColor'
        }

        /// <summary>
        /// Test the property 'AccentMutedColor'
        /// </summary>
        [Fact]
        public void AccentMutedColorTest()
        {
            // TODO unit test for the property 'AccentMutedColor'
        }

        /// <summary>
        /// Test the property 'AccentSubtleColor'
        /// </summary>
        [Fact]
        public void AccentSubtleColorTest()
        {
            // TODO unit test for the property 'AccentSubtleColor'
        }

        /// <summary>
        /// Test the property 'BackgroundCanvasColor'
        /// </summary>
        [Fact]
        public void BackgroundCanvasColorTest()
        {
            // TODO unit test for the property 'BackgroundCanvasColor'
        }

        /// <summary>
        /// Test the property 'BackgroundSubtleColor'
        /// </summary>
        [Fact]
        public void BackgroundSubtleColorTest()
        {
            // TODO unit test for the property 'BackgroundSubtleColor'
        }

        /// <summary>
        /// Test the property 'BackgroundSurfaceColor'
        /// </summary>
        [Fact]
        public void BackgroundSurfaceColorTest()
        {
            // TODO unit test for the property 'BackgroundSurfaceColor'
        }

        /// <summary>
        /// Test the property 'BorderDefaultColor'
        /// </summary>
        [Fact]
        public void BorderDefaultColorTest()
        {
            // TODO unit test for the property 'BorderDefaultColor'
        }

        /// <summary>
        /// Test the property 'ErrorDefaultColor'
        /// </summary>
        [Fact]
        public void ErrorDefaultColorTest()
        {
            // TODO unit test for the property 'ErrorDefaultColor'
        }

        /// <summary>
        /// Test the property 'ErrorEmphasisColor'
        /// </summary>
        [Fact]
        public void ErrorEmphasisColorTest()
        {
            // TODO unit test for the property 'ErrorEmphasisColor'
        }

        /// <summary>
        /// Test the property 'ErrorMutedColor'
        /// </summary>
        [Fact]
        public void ErrorMutedColorTest()
        {
            // TODO unit test for the property 'ErrorMutedColor'
        }

        /// <summary>
        /// Test the property 'ErrorSubtleColor'
        /// </summary>
        [Fact]
        public void ErrorSubtleColorTest()
        {
            // TODO unit test for the property 'ErrorSubtleColor'
        }

        /// <summary>
        /// Test the property 'ForegroundDefaultColor'
        /// </summary>
        [Fact]
        public void ForegroundDefaultColorTest()
        {
            // TODO unit test for the property 'ForegroundDefaultColor'
        }

        /// <summary>
        /// Test the property 'ForegroundDisabledColor'
        /// </summary>
        [Fact]
        public void ForegroundDisabledColorTest()
        {
            // TODO unit test for the property 'ForegroundDisabledColor'
        }

        /// <summary>
        /// Test the property 'ForegroundMutedColor'
        /// </summary>
        [Fact]
        public void ForegroundMutedColorTest()
        {
            // TODO unit test for the property 'ForegroundMutedColor'
        }

        /// <summary>
        /// Test the property 'ForegroundOnAccentColor'
        /// </summary>
        [Fact]
        public void ForegroundOnAccentColorTest()
        {
            // TODO unit test for the property 'ForegroundOnAccentColor'
        }

        /// <summary>
        /// Test the property 'ForegroundOnDarkColor'
        /// </summary>
        [Fact]
        public void ForegroundOnDarkColorTest()
        {
            // TODO unit test for the property 'ForegroundOnDarkColor'
        }

        /// <summary>
        /// Test the property 'ForegroundOnDisabledColor'
        /// </summary>
        [Fact]
        public void ForegroundOnDisabledColorTest()
        {
            // TODO unit test for the property 'ForegroundOnDisabledColor'
        }

        /// <summary>
        /// Test the property 'ForegroundSubtleColor'
        /// </summary>
        [Fact]
        public void ForegroundSubtleColorTest()
        {
            // TODO unit test for the property 'ForegroundSubtleColor'
        }

        /// <summary>
        /// Test the property 'InputBackgroundColor'
        /// </summary>
        [Fact]
        public void InputBackgroundColorTest()
        {
            // TODO unit test for the property 'InputBackgroundColor'
        }

        /// <summary>
        /// Test the property 'InputDisabledColor'
        /// </summary>
        [Fact]
        public void InputDisabledColorTest()
        {
            // TODO unit test for the property 'InputDisabledColor'
        }

        /// <summary>
        /// Test the property 'InputPlaceholderColor'
        /// </summary>
        [Fact]
        public void InputPlaceholderColorTest()
        {
            // TODO unit test for the property 'InputPlaceholderColor'
        }

        /// <summary>
        /// Test the property 'InputTextColor'
        /// </summary>
        [Fact]
        public void InputTextColorTest()
        {
            // TODO unit test for the property 'InputTextColor'
        }

        /// <summary>
        /// Test the property 'PrimaryColor'
        /// </summary>
        [Fact]
        public void PrimaryColorTest()
        {
            // TODO unit test for the property 'PrimaryColor'
        }

        /// <summary>
        /// Test the property 'SecondaryColor'
        /// </summary>
        [Fact]
        public void SecondaryColorTest()
        {
            // TODO unit test for the property 'SecondaryColor'
        }

        /// <summary>
        /// Test the property 'SuccessEmphasisColor'
        /// </summary>
        [Fact]
        public void SuccessEmphasisColorTest()
        {
            // TODO unit test for the property 'SuccessEmphasisColor'
        }

        /// <summary>
        /// Test the property 'TextDefaultColor'
        /// </summary>
        [Fact]
        public void TextDefaultColorTest()
        {
            // TODO unit test for the property 'TextDefaultColor'
        }

        /// <summary>
        /// Test the property 'TextDisabledColor'
        /// </summary>
        [Fact]
        public void TextDisabledColorTest()
        {
            // TODO unit test for the property 'TextDisabledColor'
        }
    }
}
