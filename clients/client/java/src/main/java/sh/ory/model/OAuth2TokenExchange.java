/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonArray;
import com.google.gson.JsonDeserializationContext;
import com.google.gson.JsonDeserializer;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;
import com.google.gson.JsonParseException;
import com.google.gson.TypeAdapterFactory;
import com.google.gson.reflect.TypeToken;
import com.google.gson.TypeAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import java.io.IOException;

import java.lang.reflect.Type;
import java.util.HashMap;
import java.util.HashSet;
import java.util.List;
import java.util.Map;
import java.util.Set;

import sh.ory.JSON;

/**
 * OAuth2 Token Exchange Result
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-09-23T09:52:09.030246654Z[Etc/UTC]", comments = "Generator version: 7.7.0")
public class OAuth2TokenExchange {
  public static final String SERIALIZED_NAME_ACCESS_TOKEN = "access_token";
  @SerializedName(SERIALIZED_NAME_ACCESS_TOKEN)
  private String accessToken;

  public static final String SERIALIZED_NAME_EXPIRES_IN = "expires_in";
  @SerializedName(SERIALIZED_NAME_EXPIRES_IN)
  private Long expiresIn;

  public static final String SERIALIZED_NAME_ID_TOKEN = "id_token";
  @SerializedName(SERIALIZED_NAME_ID_TOKEN)
  private String idToken;

  public static final String SERIALIZED_NAME_REFRESH_TOKEN = "refresh_token";
  @SerializedName(SERIALIZED_NAME_REFRESH_TOKEN)
  private String refreshToken;

  public static final String SERIALIZED_NAME_SCOPE = "scope";
  @SerializedName(SERIALIZED_NAME_SCOPE)
  private String scope;

  public static final String SERIALIZED_NAME_TOKEN_TYPE = "token_type";
  @SerializedName(SERIALIZED_NAME_TOKEN_TYPE)
  private String tokenType;

  public OAuth2TokenExchange() {
  }

  public OAuth2TokenExchange accessToken(String accessToken) {
    this.accessToken = accessToken;
    return this;
  }

  /**
   * The access token issued by the authorization server.
   * @return accessToken
   */
  @javax.annotation.Nullable
  public String getAccessToken() {
    return accessToken;
  }

  public void setAccessToken(String accessToken) {
    this.accessToken = accessToken;
  }


  public OAuth2TokenExchange expiresIn(Long expiresIn) {
    this.expiresIn = expiresIn;
    return this;
  }

  /**
   * The lifetime in seconds of the access token. For example, the value \&quot;3600\&quot; denotes that the access token will expire in one hour from the time the response was generated.
   * @return expiresIn
   */
  @javax.annotation.Nullable
  public Long getExpiresIn() {
    return expiresIn;
  }

  public void setExpiresIn(Long expiresIn) {
    this.expiresIn = expiresIn;
  }


  public OAuth2TokenExchange idToken(String idToken) {
    this.idToken = idToken;
    return this;
  }

  /**
   * To retrieve a refresh token request the id_token scope.
   * @return idToken
   */
  @javax.annotation.Nullable
  public String getIdToken() {
    return idToken;
  }

  public void setIdToken(String idToken) {
    this.idToken = idToken;
  }


  public OAuth2TokenExchange refreshToken(String refreshToken) {
    this.refreshToken = refreshToken;
    return this;
  }

  /**
   * The refresh token, which can be used to obtain new access tokens. To retrieve it add the scope \&quot;offline\&quot; to your access token request.
   * @return refreshToken
   */
  @javax.annotation.Nullable
  public String getRefreshToken() {
    return refreshToken;
  }

  public void setRefreshToken(String refreshToken) {
    this.refreshToken = refreshToken;
  }


  public OAuth2TokenExchange scope(String scope) {
    this.scope = scope;
    return this;
  }

  /**
   * The scope of the access token
   * @return scope
   */
  @javax.annotation.Nullable
  public String getScope() {
    return scope;
  }

  public void setScope(String scope) {
    this.scope = scope;
  }


  public OAuth2TokenExchange tokenType(String tokenType) {
    this.tokenType = tokenType;
    return this;
  }

  /**
   * The type of the token issued
   * @return tokenType
   */
  @javax.annotation.Nullable
  public String getTokenType() {
    return tokenType;
  }

  public void setTokenType(String tokenType) {
    this.tokenType = tokenType;
  }

  /**
   * A container for additional, undeclared properties.
   * This is a holder for any undeclared properties as specified with
   * the 'additionalProperties' keyword in the OAS document.
   */
  private Map<String, Object> additionalProperties;

  /**
   * Set the additional (undeclared) property with the specified name and value.
   * If the property does not already exist, create it otherwise replace it.
   *
   * @param key name of the property
   * @param value value of the property
   * @return the OAuth2TokenExchange instance itself
   */
  public OAuth2TokenExchange putAdditionalProperty(String key, Object value) {
    if (this.additionalProperties == null) {
        this.additionalProperties = new HashMap<String, Object>();
    }
    this.additionalProperties.put(key, value);
    return this;
  }

  /**
   * Return the additional (undeclared) property.
   *
   * @return a map of objects
   */
  public Map<String, Object> getAdditionalProperties() {
    return additionalProperties;
  }

  /**
   * Return the additional (undeclared) property with the specified name.
   *
   * @param key name of the property
   * @return an object
   */
  public Object getAdditionalProperty(String key) {
    if (this.additionalProperties == null) {
        return null;
    }
    return this.additionalProperties.get(key);
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OAuth2TokenExchange oAuth2TokenExchange = (OAuth2TokenExchange) o;
    return Objects.equals(this.accessToken, oAuth2TokenExchange.accessToken) &&
        Objects.equals(this.expiresIn, oAuth2TokenExchange.expiresIn) &&
        Objects.equals(this.idToken, oAuth2TokenExchange.idToken) &&
        Objects.equals(this.refreshToken, oAuth2TokenExchange.refreshToken) &&
        Objects.equals(this.scope, oAuth2TokenExchange.scope) &&
        Objects.equals(this.tokenType, oAuth2TokenExchange.tokenType)&&
        Objects.equals(this.additionalProperties, oAuth2TokenExchange.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accessToken, expiresIn, idToken, refreshToken, scope, tokenType, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OAuth2TokenExchange {\n");
    sb.append("    accessToken: ").append(toIndentedString(accessToken)).append("\n");
    sb.append("    expiresIn: ").append(toIndentedString(expiresIn)).append("\n");
    sb.append("    idToken: ").append(toIndentedString(idToken)).append("\n");
    sb.append("    refreshToken: ").append(toIndentedString(refreshToken)).append("\n");
    sb.append("    scope: ").append(toIndentedString(scope)).append("\n");
    sb.append("    tokenType: ").append(toIndentedString(tokenType)).append("\n");
    sb.append("    additionalProperties: ").append(toIndentedString(additionalProperties)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }


  public static HashSet<String> openapiFields;
  public static HashSet<String> openapiRequiredFields;

  static {
    // a set of all properties/fields (JSON key names)
    openapiFields = new HashSet<String>();
    openapiFields.add("access_token");
    openapiFields.add("expires_in");
    openapiFields.add("id_token");
    openapiFields.add("refresh_token");
    openapiFields.add("scope");
    openapiFields.add("token_type");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
  }

  /**
   * Validates the JSON Element and throws an exception if issues found
   *
   * @param jsonElement JSON Element
   * @throws IOException if the JSON Element is invalid with respect to OAuth2TokenExchange
   */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!OAuth2TokenExchange.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in OAuth2TokenExchange is not found in the empty JSON string", OAuth2TokenExchange.openapiRequiredFields.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if ((jsonObj.get("access_token") != null && !jsonObj.get("access_token").isJsonNull()) && !jsonObj.get("access_token").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `access_token` to be a primitive type in the JSON string but got `%s`", jsonObj.get("access_token").toString()));
      }
      if ((jsonObj.get("id_token") != null && !jsonObj.get("id_token").isJsonNull()) && !jsonObj.get("id_token").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `id_token` to be a primitive type in the JSON string but got `%s`", jsonObj.get("id_token").toString()));
      }
      if ((jsonObj.get("refresh_token") != null && !jsonObj.get("refresh_token").isJsonNull()) && !jsonObj.get("refresh_token").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `refresh_token` to be a primitive type in the JSON string but got `%s`", jsonObj.get("refresh_token").toString()));
      }
      if ((jsonObj.get("scope") != null && !jsonObj.get("scope").isJsonNull()) && !jsonObj.get("scope").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `scope` to be a primitive type in the JSON string but got `%s`", jsonObj.get("scope").toString()));
      }
      if ((jsonObj.get("token_type") != null && !jsonObj.get("token_type").isJsonNull()) && !jsonObj.get("token_type").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `token_type` to be a primitive type in the JSON string but got `%s`", jsonObj.get("token_type").toString()));
      }
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!OAuth2TokenExchange.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'OAuth2TokenExchange' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<OAuth2TokenExchange> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(OAuth2TokenExchange.class));

       return (TypeAdapter<T>) new TypeAdapter<OAuth2TokenExchange>() {
           @Override
           public void write(JsonWriter out, OAuth2TokenExchange value) throws IOException {
             JsonObject obj = thisAdapter.toJsonTree(value).getAsJsonObject();
             obj.remove("additionalProperties");
             // serialize additional properties
             if (value.getAdditionalProperties() != null) {
               for (Map.Entry<String, Object> entry : value.getAdditionalProperties().entrySet()) {
                 if (entry.getValue() instanceof String)
                   obj.addProperty(entry.getKey(), (String) entry.getValue());
                 else if (entry.getValue() instanceof Number)
                   obj.addProperty(entry.getKey(), (Number) entry.getValue());
                 else if (entry.getValue() instanceof Boolean)
                   obj.addProperty(entry.getKey(), (Boolean) entry.getValue());
                 else if (entry.getValue() instanceof Character)
                   obj.addProperty(entry.getKey(), (Character) entry.getValue());
                 else {
                   JsonElement jsonElement = gson.toJsonTree(entry.getValue());
                   if (jsonElement.isJsonArray()) {
                     obj.add(entry.getKey(), jsonElement.getAsJsonArray());
                   } else {
                     obj.add(entry.getKey(), jsonElement.getAsJsonObject());
                   }
                 }
               }
             }
             elementAdapter.write(out, obj);
           }

           @Override
           public OAuth2TokenExchange read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             JsonObject jsonObj = jsonElement.getAsJsonObject();
             // store additional fields in the deserialized instance
             OAuth2TokenExchange instance = thisAdapter.fromJsonTree(jsonObj);
             for (Map.Entry<String, JsonElement> entry : jsonObj.entrySet()) {
               if (!openapiFields.contains(entry.getKey())) {
                 if (entry.getValue().isJsonPrimitive()) { // primitive type
                   if (entry.getValue().getAsJsonPrimitive().isString())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsString());
                   else if (entry.getValue().getAsJsonPrimitive().isNumber())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsNumber());
                   else if (entry.getValue().getAsJsonPrimitive().isBoolean())
                     instance.putAdditionalProperty(entry.getKey(), entry.getValue().getAsBoolean());
                   else
                     throw new IllegalArgumentException(String.format("The field `%s` has unknown primitive type. Value: %s", entry.getKey(), entry.getValue().toString()));
                 } else if (entry.getValue().isJsonArray()) {
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), List.class));
                 } else { // JSON object
                     instance.putAdditionalProperty(entry.getKey(), gson.fromJson(entry.getValue(), HashMap.class));
                 }
               }
             }
             return instance;
           }

       }.nullSafe();
    }
  }

  /**
   * Create an instance of OAuth2TokenExchange given an JSON string
   *
   * @param jsonString JSON string
   * @return An instance of OAuth2TokenExchange
   * @throws IOException if the JSON string is invalid with respect to OAuth2TokenExchange
   */
  public static OAuth2TokenExchange fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, OAuth2TokenExchange.class);
  }

  /**
   * Convert an instance of OAuth2TokenExchange to an JSON string
   *
   * @return JSON string
   */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

