/*
 * Ory APIs
 * # Introduction Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.  ## SDKs This document describes the APIs available in the Ory Network. The APIs are available as SDKs for the following languages:  | Language       | Download SDK                                                     | Documentation                                                                        | | -------------- | ---------------------------------------------------------------- | ------------------------------------------------------------------------------------ | | Dart           | [pub.dev](https://pub.dev/packages/ory_client)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/dart/README.md)       | | .NET           | [nuget.org](https://www.nuget.org/packages/Ory.Client/)          | [README](https://github.com/ory/sdk/blob/master/clients/client/dotnet/README.md)     | | Elixir         | [hex.pm](https://hex.pm/packages/ory_client)                     | [README](https://github.com/ory/sdk/blob/master/clients/client/elixir/README.md)     | | Go             | [github.com](https://github.com/ory/client-go)                   | [README](https://github.com/ory/sdk/blob/master/clients/client/go/README.md)         | | Java           | [maven.org](https://search.maven.org/artifact/sh.ory/ory-client) | [README](https://github.com/ory/sdk/blob/master/clients/client/java/README.md)       | | JavaScript     | [npmjs.com](https://www.npmjs.com/package/@ory/client)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript/README.md) | | JavaScript (With fetch) | [npmjs.com](https://www.npmjs.com/package/@ory/client-fetch)           | [README](https://github.com/ory/sdk/blob/master/clients/client/typescript-fetch/README.md) |  | PHP            | [packagist.org](https://packagist.org/packages/ory/client)       | [README](https://github.com/ory/sdk/blob/master/clients/client/php/README.md)        | | Python         | [pypi.org](https://pypi.org/project/ory-client/)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/python/README.md)     | | Ruby           | [rubygems.org](https://rubygems.org/gems/ory-client)             | [README](https://github.com/ory/sdk/blob/master/clients/client/ruby/README.md)       | | Rust           | [crates.io](https://crates.io/crates/ory-client)                 | [README](https://github.com/ory/sdk/blob/master/clients/client/rust/README.md)       | 
 *
 * The version of the OpenAPI document: v1.15.14
 * Contact: support@ory.sh
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package sh.ory.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.time.OffsetDateTime;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import sh.ory.model.AcceptOAuth2ConsentRequestSession;
import sh.ory.model.OAuth2ConsentRequest;
import sh.ory.model.OAuth2ConsentSessionExpiresAt;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

/**
 * Model tests for OAuth2ConsentSession
 */
public class OAuth2ConsentSessionTest {
    private final OAuth2ConsentSession model = new OAuth2ConsentSession();

    /**
     * Model tests for OAuth2ConsentSession
     */
    @Test
    public void testOAuth2ConsentSession() {
        // TODO: test OAuth2ConsentSession
    }

    /**
     * Test the property 'consentRequest'
     */
    @Test
    public void consentRequestTest() {
        // TODO: test consentRequest
    }

    /**
     * Test the property 'context'
     */
    @Test
    public void contextTest() {
        // TODO: test context
    }

    /**
     * Test the property 'expiresAt'
     */
    @Test
    public void expiresAtTest() {
        // TODO: test expiresAt
    }

    /**
     * Test the property 'grantAccessTokenAudience'
     */
    @Test
    public void grantAccessTokenAudienceTest() {
        // TODO: test grantAccessTokenAudience
    }

    /**
     * Test the property 'grantScope'
     */
    @Test
    public void grantScopeTest() {
        // TODO: test grantScope
    }

    /**
     * Test the property 'handledAt'
     */
    @Test
    public void handledAtTest() {
        // TODO: test handledAt
    }

    /**
     * Test the property 'remember'
     */
    @Test
    public void rememberTest() {
        // TODO: test remember
    }

    /**
     * Test the property 'rememberFor'
     */
    @Test
    public void rememberForTest() {
        // TODO: test rememberFor
    }

    /**
     * Test the property 'session'
     */
    @Test
    public void sessionTest() {
        // TODO: test session
    }

}
