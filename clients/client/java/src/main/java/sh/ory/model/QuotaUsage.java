/*
 * Ory APIs
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
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
 * QuotaUsage
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2024-06-27T15:28:34.042688941Z[Etc/UTC]")
public class QuotaUsage {
  public static final String SERIALIZED_NAME_ADDITIONAL_PRICE = "additional_price";
  @SerializedName(SERIALIZED_NAME_ADDITIONAL_PRICE)
  private String additionalPrice;

  public static final String SERIALIZED_NAME_CAN_USE_MORE = "can_use_more";
  @SerializedName(SERIALIZED_NAME_CAN_USE_MORE)
  private Boolean canUseMore;

  /**
   *  production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect
   */
  @JsonAdapter(FeatureEnum.Adapter.class)
  public enum FeatureEnum {
    PRODUCTION_PROJECTS("production_projects"),
    
    STAGING_PROJECTS("staging_projects"),
    
    DEVELOPMENT_PROJECTS("development_projects"),
    
    DAILY_ACTIVE_USERS("daily_active_users"),
    
    CUSTOM_DOMAINS("custom_domains"),
    
    EVENT_STREAMS("event_streams"),
    
    EVENT_STREAM_EVENTS("event_stream_events"),
    
    SLA("sla"),
    
    COLLABORATOR_SEATS("collaborator_seats"),
    
    EDGE_CACHE("edge_cache"),
    
    BRANDING_THEMES("branding_themes"),
    
    ZENDESK_SUPPORT("zendesk_support"),
    
    PROJECT_METRICS("project_metrics"),
    
    PROJECT_METRICS_TIME_WINDOW("project_metrics_time_window"),
    
    PROJECT_METRICS_EVENTS_HISTORY("project_metrics_events_history"),
    
    ORGANIZATIONS("organizations"),
    
    ROP_GRANT("rop_grant"),
    
    CONCIERGE_ONBOARDING("concierge_onboarding"),
    
    CREDIT("credit"),
    
    DATA_LOCATION_GLOBAL("data_location_global"),
    
    M2M_TOKEN_ISSUANCE("m2m_token_issuance"),
    
    PERMISSION_CHECKS("permission_checks"),
    
    DATA_LOCATION_REGIONAL("data_location_regional"),
    
    RATE_LIMIT_TIER("rate_limit_tier"),
    
    SESSION_RATE_LIMIT_TIER("session_rate_limit_tier"),
    
    IDENTITIES_LIST_RATE_LIMIT_TIER("identities_list_rate_limit_tier"),
    
    PERMISSION_CHECKS_RATE_LIMIT_TIER("permission_checks_rate_limit_tier"),
    
    OAUTH2_INTROSPECT_RATE_LIMIT_TIER("oauth2_introspect_rate_limit_tier");

    private String value;

    FeatureEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static FeatureEnum fromValue(String value) {
      for (FeatureEnum b : FeatureEnum.values()) {
        if (b.value.equals(value)) {
          return b;
        }
      }
      throw new IllegalArgumentException("Unexpected value '" + value + "'");
    }

    public static class Adapter extends TypeAdapter<FeatureEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final FeatureEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public FeatureEnum read(final JsonReader jsonReader) throws IOException {
        String value =  jsonReader.nextString();
        return FeatureEnum.fromValue(value);
      }
    }

    public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      String value = jsonElement.getAsString();
      FeatureEnum.fromValue(value);
    }
  }

  public static final String SERIALIZED_NAME_FEATURE = "feature";
  @SerializedName(SERIALIZED_NAME_FEATURE)
  private FeatureEnum feature;

  public static final String SERIALIZED_NAME_FEATURE_AVAILABLE = "feature_available";
  @SerializedName(SERIALIZED_NAME_FEATURE_AVAILABLE)
  private Boolean featureAvailable;

  public static final String SERIALIZED_NAME_INCLUDED = "included";
  @SerializedName(SERIALIZED_NAME_INCLUDED)
  private Long included;

  public static final String SERIALIZED_NAME_USED = "used";
  @SerializedName(SERIALIZED_NAME_USED)
  private Long used;

  public QuotaUsage() {
  }

  public QuotaUsage additionalPrice(String additionalPrice) {
    this.additionalPrice = additionalPrice;
    return this;
  }

   /**
   * The additional price per unit in cents.
   * @return additionalPrice
  **/
  @javax.annotation.Nonnull
  public String getAdditionalPrice() {
    return additionalPrice;
  }

  public void setAdditionalPrice(String additionalPrice) {
    this.additionalPrice = additionalPrice;
  }


  public QuotaUsage canUseMore(Boolean canUseMore) {
    this.canUseMore = canUseMore;
    return this;
  }

   /**
   * Get canUseMore
   * @return canUseMore
  **/
  @javax.annotation.Nonnull
  public Boolean getCanUseMore() {
    return canUseMore;
  }

  public void setCanUseMore(Boolean canUseMore) {
    this.canUseMore = canUseMore;
  }


  public QuotaUsage feature(FeatureEnum feature) {
    this.feature = feature;
    return this;
  }

   /**
   *  production_projects ProductionProjects staging_projects StagingProjects development_projects DevelopmentProjects daily_active_users DailyActiveUsers custom_domains CustomDomains event_streams EventStreams event_stream_events EventStreamEvents sla SLA collaborator_seats CollaboratorSeats edge_cache EdgeCache branding_themes BrandingThemes zendesk_support ZendeskSupport project_metrics ProjectMetrics project_metrics_time_window ProjectMetricsTimeWindow project_metrics_events_history ProjectMetricsEventsHistory organizations Organizations rop_grant ResourceOwnerPasswordGrant concierge_onboarding ConciergeOnboarding credit Credit data_location_global DataLocationGlobal m2m_token_issuance M2MTokenIssuance permission_checks PermissionChecks data_location_regional DataLocationRegional  Required Features rate_limit_tier RateLimitTier session_rate_limit_tier RateLimitTierSessions identities_list_rate_limit_tier RateLimitTierIdentitiesList permission_checks_rate_limit_tier RateLimitTierPermissionChecks oauth2_introspect_rate_limit_tier RateLimitTierOAuth2Introspect
   * @return feature
  **/
  @javax.annotation.Nonnull
  public FeatureEnum getFeature() {
    return feature;
  }

  public void setFeature(FeatureEnum feature) {
    this.feature = feature;
  }


  public QuotaUsage featureAvailable(Boolean featureAvailable) {
    this.featureAvailable = featureAvailable;
    return this;
  }

   /**
   * Get featureAvailable
   * @return featureAvailable
  **/
  @javax.annotation.Nonnull
  public Boolean getFeatureAvailable() {
    return featureAvailable;
  }

  public void setFeatureAvailable(Boolean featureAvailable) {
    this.featureAvailable = featureAvailable;
  }


  public QuotaUsage included(Long included) {
    this.included = included;
    return this;
  }

   /**
   * Get included
   * @return included
  **/
  @javax.annotation.Nonnull
  public Long getIncluded() {
    return included;
  }

  public void setIncluded(Long included) {
    this.included = included;
  }


  public QuotaUsage used(Long used) {
    this.used = used;
    return this;
  }

   /**
   * Get used
   * @return used
  **/
  @javax.annotation.Nonnull
  public Long getUsed() {
    return used;
  }

  public void setUsed(Long used) {
    this.used = used;
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
   * @return the QuotaUsage instance itself
   */
  public QuotaUsage putAdditionalProperty(String key, Object value) {
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
    QuotaUsage quotaUsage = (QuotaUsage) o;
    return Objects.equals(this.additionalPrice, quotaUsage.additionalPrice) &&
        Objects.equals(this.canUseMore, quotaUsage.canUseMore) &&
        Objects.equals(this.feature, quotaUsage.feature) &&
        Objects.equals(this.featureAvailable, quotaUsage.featureAvailable) &&
        Objects.equals(this.included, quotaUsage.included) &&
        Objects.equals(this.used, quotaUsage.used)&&
        Objects.equals(this.additionalProperties, quotaUsage.additionalProperties);
  }

  @Override
  public int hashCode() {
    return Objects.hash(additionalPrice, canUseMore, feature, featureAvailable, included, used, additionalProperties);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class QuotaUsage {\n");
    sb.append("    additionalPrice: ").append(toIndentedString(additionalPrice)).append("\n");
    sb.append("    canUseMore: ").append(toIndentedString(canUseMore)).append("\n");
    sb.append("    feature: ").append(toIndentedString(feature)).append("\n");
    sb.append("    featureAvailable: ").append(toIndentedString(featureAvailable)).append("\n");
    sb.append("    included: ").append(toIndentedString(included)).append("\n");
    sb.append("    used: ").append(toIndentedString(used)).append("\n");
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
    openapiFields.add("additional_price");
    openapiFields.add("can_use_more");
    openapiFields.add("feature");
    openapiFields.add("feature_available");
    openapiFields.add("included");
    openapiFields.add("used");

    // a set of required properties/fields (JSON key names)
    openapiRequiredFields = new HashSet<String>();
    openapiRequiredFields.add("additional_price");
    openapiRequiredFields.add("can_use_more");
    openapiRequiredFields.add("feature");
    openapiRequiredFields.add("feature_available");
    openapiRequiredFields.add("included");
    openapiRequiredFields.add("used");
  }

 /**
  * Validates the JSON Element and throws an exception if issues found
  *
  * @param jsonElement JSON Element
  * @throws IOException if the JSON Element is invalid with respect to QuotaUsage
  */
  public static void validateJsonElement(JsonElement jsonElement) throws IOException {
      if (jsonElement == null) {
        if (!QuotaUsage.openapiRequiredFields.isEmpty()) { // has required fields but JSON element is null
          throw new IllegalArgumentException(String.format("The required field(s) %s in QuotaUsage is not found in the empty JSON string", QuotaUsage.openapiRequiredFields.toString()));
        }
      }

      // check to make sure all required properties/fields are present in the JSON string
      for (String requiredField : QuotaUsage.openapiRequiredFields) {
        if (jsonElement.getAsJsonObject().get(requiredField) == null) {
          throw new IllegalArgumentException(String.format("The required field `%s` is not found in the JSON string: %s", requiredField, jsonElement.toString()));
        }
      }
        JsonObject jsonObj = jsonElement.getAsJsonObject();
      if (!jsonObj.get("additional_price").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `additional_price` to be a primitive type in the JSON string but got `%s`", jsonObj.get("additional_price").toString()));
      }
      if (!jsonObj.get("feature").isJsonPrimitive()) {
        throw new IllegalArgumentException(String.format("Expected the field `feature` to be a primitive type in the JSON string but got `%s`", jsonObj.get("feature").toString()));
      }
      // validate the required field `feature`
      FeatureEnum.validateJsonElement(jsonObj.get("feature"));
  }

  public static class CustomTypeAdapterFactory implements TypeAdapterFactory {
    @SuppressWarnings("unchecked")
    @Override
    public <T> TypeAdapter<T> create(Gson gson, TypeToken<T> type) {
       if (!QuotaUsage.class.isAssignableFrom(type.getRawType())) {
         return null; // this class only serializes 'QuotaUsage' and its subtypes
       }
       final TypeAdapter<JsonElement> elementAdapter = gson.getAdapter(JsonElement.class);
       final TypeAdapter<QuotaUsage> thisAdapter
                        = gson.getDelegateAdapter(this, TypeToken.get(QuotaUsage.class));

       return (TypeAdapter<T>) new TypeAdapter<QuotaUsage>() {
           @Override
           public void write(JsonWriter out, QuotaUsage value) throws IOException {
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
           public QuotaUsage read(JsonReader in) throws IOException {
             JsonElement jsonElement = elementAdapter.read(in);
             validateJsonElement(jsonElement);
             JsonObject jsonObj = jsonElement.getAsJsonObject();
             // store additional fields in the deserialized instance
             QuotaUsage instance = thisAdapter.fromJsonTree(jsonObj);
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
  * Create an instance of QuotaUsage given an JSON string
  *
  * @param jsonString JSON string
  * @return An instance of QuotaUsage
  * @throws IOException if the JSON string is invalid with respect to QuotaUsage
  */
  public static QuotaUsage fromJson(String jsonString) throws IOException {
    return JSON.getGson().fromJson(jsonString, QuotaUsage.class);
  }

 /**
  * Convert an instance of QuotaUsage to an JSON string
  *
  * @return JSON string
  */
  public String toJson() {
    return JSON.getGson().toJson(this);
  }
}

