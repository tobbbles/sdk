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

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;
import java.util.Arrays;
import sh.ory.model.UpdateRecoveryFlowWithCodeMethod;
import sh.ory.model.UpdateRecoveryFlowWithLinkMethod;



import java.io.IOException;
import java.lang.reflect.Type;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.ArrayList;
import java.util.Collections;
import java.util.HashSet;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapter;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.JsonPrimitive;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonSerializationContext;
import com.google.gson.JsonSerializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonArray;
import com.google.gson.JsonParseException;

import sh.ory.JSON;

@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-12-04T09:35:11.581942706Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class UpdateRecoveryFlowBody extends AbstractOpenApiSchema {
    private static final Logger log = Logger.getLogger(UpdateRecoveryFlowBody.class.getName());

    public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
        @SuppressWarnings("unchecked")
        @Override
        public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
            if (!UpdateRecoveryFlowBody.class.isAssignableFrom(type.getRawType())) {
                return null; // this class only serializes 'UpdateRecoveryFlowBody' and its subtypes
            }
            final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
            final TypeAdapter<UpdateRecoveryFlowWithLinkMethod> adapterUpdateRecoveryFlowWithLinkMethod = gson.getDelegateAdapter(this, TypeToken.get(UpdateRecoveryFlowWithLinkMethod.class));
            final TypeAdapter<UpdateRecoveryFlowWithCodeMethod> adapterUpdateRecoveryFlowWithCodeMethod = gson.getDelegateAdapter(this, TypeToken.get(UpdateRecoveryFlowWithCodeMethod.class));

            return (TypeAdapter<T>) new TypeAdapter<UpdateRecoveryFlowBody>() {
                @Override
                public void write(JsonWriter out, UpdateRecoveryFlowBody value) throws IOException {
                    if (value == null || value.getActualInstance() == null) {
                        elementAdapter.write(out, null);
                        return;
                    }

                    // check if the actual instance is of the type `UpdateRecoveryFlowWithLinkMethod`
                    if (value.getActualInstance() instanceof UpdateRecoveryFlowWithLinkMethod) {
                        JsonElement element = adapterUpdateRecoveryFlowWithLinkMethod.toJsonTree((UpdateRecoveryFlowWithLinkMethod)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    // check if the actual instance is of the type `UpdateRecoveryFlowWithCodeMethod`
                    if (value.getActualInstance() instanceof UpdateRecoveryFlowWithCodeMethod) {
                        JsonElement element = adapterUpdateRecoveryFlowWithCodeMethod.toJsonTree((UpdateRecoveryFlowWithCodeMethod)value.getActualInstance());
                        elementAdapter.write(out, element);
                        return;
                    }
                    throw new IOException("Failed to serialize as the type doesn't match oneOf schemas: UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod");
                }

                @Override
                public UpdateRecoveryFlowBody read(JsonReader in) throws IOException {
                    Object deserialized = null;
                    JsonElement jsonElement = elementAdapter.read(in);

                    JsonObject jsonObject = jsonElement.getAsJsonObject();

                    // use discriminator value for faster oneOf lookup
                    UpdateRecoveryFlowBody newUpdateRecoveryFlowBody = new UpdateRecoveryFlowBody();
                    if (jsonObject.get("method") == null) {
                        log.log(Level.WARNING, "Failed to lookup discriminator value for UpdateRecoveryFlowBody as `method` was not found in the payload or the payload is empty.");
                    } else  {
                        // look up the discriminator value in the field `method`
                        switch (jsonObject.get("method").getAsString()) {
                            case "code":
                                deserialized = adapterUpdateRecoveryFlowWithCodeMethod.fromJsonTree(jsonObject);
                                newUpdateRecoveryFlowBody.setActualInstance(deserialized);
                                return newUpdateRecoveryFlowBody;
                            case "link":
                                deserialized = adapterUpdateRecoveryFlowWithLinkMethod.fromJsonTree(jsonObject);
                                newUpdateRecoveryFlowBody.setActualInstance(deserialized);
                                return newUpdateRecoveryFlowBody;
                            case "updateRecoveryFlowWithCodeMethod":
                                deserialized = adapterUpdateRecoveryFlowWithCodeMethod.fromJsonTree(jsonObject);
                                newUpdateRecoveryFlowBody.setActualInstance(deserialized);
                                return newUpdateRecoveryFlowBody;
                            case "updateRecoveryFlowWithLinkMethod":
                                deserialized = adapterUpdateRecoveryFlowWithLinkMethod.fromJsonTree(jsonObject);
                                newUpdateRecoveryFlowBody.setActualInstance(deserialized);
                                return newUpdateRecoveryFlowBody;
                            default:
                                log.log(Level.WARNING, String.format("Failed to lookup discriminator value `%s` for UpdateRecoveryFlowBody. Possible values: code link updateRecoveryFlowWithCodeMethod updateRecoveryFlowWithLinkMethod", jsonObject.get("method").getAsString()));
                        }
                    }

                    int match = 0;
                    ArrayList<String> errorMessages = new ArrayList<>();
                    TypeAdapter actualAdapter = elementAdapter;

                    // deserialize UpdateRecoveryFlowWithLinkMethod
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UpdateRecoveryFlowWithLinkMethod.validateJsonElement(jsonElement);
                        actualAdapter = adapterUpdateRecoveryFlowWithLinkMethod;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UpdateRecoveryFlowWithLinkMethod'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UpdateRecoveryFlowWithLinkMethod failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UpdateRecoveryFlowWithLinkMethod'", e);
                    }
                    // deserialize UpdateRecoveryFlowWithCodeMethod
                    try {
                        // validate the JSON object to see if any exception is thrown
                        UpdateRecoveryFlowWithCodeMethod.validateJsonElement(jsonElement);
                        actualAdapter = adapterUpdateRecoveryFlowWithCodeMethod;
                        match++;
                        log.log(Level.FINER, "Input data matches schema 'UpdateRecoveryFlowWithCodeMethod'");
                    } catch (Exception e) {
                        // deserialization failed, continue
                        errorMessages.add(String.format("Deserialization for UpdateRecoveryFlowWithCodeMethod failed with `%s`.", e.getMessage()));
                        log.log(Level.FINER, "Input data does not match schema 'UpdateRecoveryFlowWithCodeMethod'", e);
                    }

                    if (match == 1) {
                        UpdateRecoveryFlowBody ret = new UpdateRecoveryFlowBody();
                        ret.setActualInstance(actualAdapter.fromJsonTree(jsonElement));
                        return ret;
                    }

                    throw new IOException(String.format("Failed deserialization for UpdateRecoveryFlowBody: %d classes match result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", match, errorMessages, jsonElement.toString()));
                }
            }.nullSafe();
        }
    }

    // store a list of schema names defined in oneOf
    public static final Map<String, Class<?>> schemas = new HashMap<String, Class<?>>();

    public UpdateRecoveryFlowBody() {
        super("oneOf", Boolean.FALSE);
    }

    public UpdateRecoveryFlowBody(Object o) {
        super("oneOf", Boolean.FALSE);
        setActualInstance(o);
    }

    static {
        schemas.put("UpdateRecoveryFlowWithLinkMethod", UpdateRecoveryFlowWithLinkMethod.class);
        schemas.put("UpdateRecoveryFlowWithCodeMethod", UpdateRecoveryFlowWithCodeMethod.class);
    }

    @Override
    public Map<String, Class<?>> getSchemas() {
        return UpdateRecoveryFlowBody.schemas;
    }

    /**
     * Set the instance that matches the oneOf child schema, check
     * the instance parameter is valid against the oneOf child schemas:
     * UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod
     *
     * It could be an instance of the 'oneOf' schemas.
     */
    @Override
    public void setActualInstance(Object instance) {
        if (instance instanceof UpdateRecoveryFlowWithLinkMethod) {
            super.setActualInstance(instance);
            return;
        }

        if (instance instanceof UpdateRecoveryFlowWithCodeMethod) {
            super.setActualInstance(instance);
            return;
        }

        throw new RuntimeException("Invalid instance type. Must be UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod");
    }

    /**
     * Get the actual instance, which can be the following:
     * UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod
     *
     * @return The actual instance (UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod)
     */
    @SuppressWarnings("unchecked")
    @Override
    public Object getActualInstance() {
        return super.getActualInstance();
    }

    /**
     * Get the actual instance of `UpdateRecoveryFlowWithLinkMethod`. If the actual instance is not `UpdateRecoveryFlowWithLinkMethod`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UpdateRecoveryFlowWithLinkMethod`
     * @throws ClassCastException if the instance is not `UpdateRecoveryFlowWithLinkMethod`
     */
    public UpdateRecoveryFlowWithLinkMethod getUpdateRecoveryFlowWithLinkMethod() throws ClassCastException {
        return (UpdateRecoveryFlowWithLinkMethod)super.getActualInstance();
    }
    /**
     * Get the actual instance of `UpdateRecoveryFlowWithCodeMethod`. If the actual instance is not `UpdateRecoveryFlowWithCodeMethod`,
     * the ClassCastException will be thrown.
     *
     * @return The actual instance of `UpdateRecoveryFlowWithCodeMethod`
     * @throws ClassCastException if the instance is not `UpdateRecoveryFlowWithCodeMethod`
     */
    public UpdateRecoveryFlowWithCodeMethod getUpdateRecoveryFlowWithCodeMethod() throws ClassCastException {
        return (UpdateRecoveryFlowWithCodeMethod)super.getActualInstance();
    }

    /**
     * Validates the JSON Element and throws an exception if issues found
     *
     * @param jsonElement JSON Element
     * @throws IOException if the JSON Element is invalid with respect to UpdateRecoveryFlowBody
     */
    public static void validateJsonElement(JsonElement jsonElement) throws IOException {
        // validate oneOf schemas one by one
        int validCount = 0;
        ArrayList<String> errorMessages = new ArrayList<>();
        // validate the json string with UpdateRecoveryFlowWithLinkMethod
        try {
            UpdateRecoveryFlowWithLinkMethod.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UpdateRecoveryFlowWithLinkMethod failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        // validate the json string with UpdateRecoveryFlowWithCodeMethod
        try {
            UpdateRecoveryFlowWithCodeMethod.validateJsonElement(jsonElement);
            validCount++;
        } catch (Exception e) {
            errorMessages.add(String.format("Deserialization for UpdateRecoveryFlowWithCodeMethod failed with `%s`.", e.getMessage()));
            // continue to the next one
        }
        if (validCount != 1) {
            throw new IOException(String.format("The JSON string is invalid for UpdateRecoveryFlowBody with oneOf schemas: UpdateRecoveryFlowWithCodeMethod, UpdateRecoveryFlowWithLinkMethod. %d class(es) match the result, expected 1. Detailed failure message for oneOf schemas: %s. JSON: %s", validCount, errorMessages, jsonElement.toString()));
        }
    }

    /**
     * Create an instance of UpdateRecoveryFlowBody given an JSON string
     *
     * @param jsonString JSON string
     * @return An instance of UpdateRecoveryFlowBody
     * @throws IOException if the JSON string is invalid with respect to UpdateRecoveryFlowBody
     */
    public static UpdateRecoveryFlowBody fromJson(String jsonString) throws IOException {
        return JSON.getGson().fromJson(jsonString, UpdateRecoveryFlowBody.class);
    }

    /**
     * Convert an instance of UpdateRecoveryFlowBody to an JSON string
     *
     * @return JSON string
     */
    public String toJson() {
        return JSON.getGson().toJson(this);
    }
}

