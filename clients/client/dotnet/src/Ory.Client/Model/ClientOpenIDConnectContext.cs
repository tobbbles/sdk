/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v0.2.0-alpha.33
 * Contact: support@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Client.Client.OpenAPIDateConverter;

namespace Ory.Client.Model
{
    /// <summary>
    /// ClientOpenIDConnectContext
    /// </summary>
    [DataContract(Name = "openIDConnectContext")]
    public partial class ClientOpenIDConnectContext : IEquatable<ClientOpenIDConnectContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientOpenIDConnectContext" /> class.
        /// </summary>
        /// <param name="acrValues">ACRValues is the Authentication AuthorizationContext Class Reference requested in the OAuth 2.0 Authorization request. It is a parameter defined by OpenID Connect and expresses which level of authentication (e.g. 2FA) is required.  OpenID Connect defines it as follows: &gt; Requested Authentication AuthorizationContext Class Reference values. Space-separated string that specifies the acr values that the Authorization Server is being requested to use for processing this Authentication Request, with the values appearing in order of preference. The Authentication AuthorizationContext Class satisfied by the authentication performed is returned as the acr Claim Value, as specified in Section 2. The acr Claim is requested as a Voluntary Claim by this parameter..</param>
        /// <param name="display">Display is a string value that specifies how the Authorization Server displays the authentication and consent user interface pages to the End-User. The defined values are: page: The Authorization Server SHOULD display the authentication and consent UI consistent with a full User Agent page view. If the display parameter is not specified, this is the default display mode. popup: The Authorization Server SHOULD display the authentication and consent UI consistent with a popup User Agent window. The popup User Agent window should be of an appropriate size for a login-focused dialog and should not obscure the entire window that it is popping up over. touch: The Authorization Server SHOULD display the authentication and consent UI consistent with a device that leverages a touch interface. wap: The Authorization Server SHOULD display the authentication and consent UI consistent with a \&quot;feature phone\&quot; type display.  The Authorization Server MAY also attempt to detect the capabilities of the User Agent and present an appropriate display..</param>
        /// <param name="idTokenHintClaims">IDTokenHintClaims are the claims of the ID Token previously issued by the Authorization Server being passed as a hint about the End-User&#39;s current or past authenticated session with the Client..</param>
        /// <param name="loginHint">LoginHint hints about the login identifier the End-User might use to log in (if necessary). This hint can be used by an RP if it first asks the End-User for their e-mail address (or other identifier) and then wants to pass that value as a hint to the discovered authorization service. This value MAY also be a phone number in the format specified for the phone_number Claim. The use of this parameter is optional..</param>
        /// <param name="uiLocales">UILocales is the End-User&#39;id preferred languages and scripts for the user interface, represented as a space-separated list of BCP47 [RFC5646] language tag values, ordered by preference. For instance, the value \&quot;fr-CA fr en\&quot; represents a preference for French as spoken in Canada, then French (without a region designation), followed by English (without a region designation). An error SHOULD NOT result if some or all of the requested locales are not supported by the OpenID Provider..</param>
        public ClientOpenIDConnectContext(List<string> acrValues = default(List<string>), string display = default(string), Dictionary<string, Object> idTokenHintClaims = default(Dictionary<string, Object>), string loginHint = default(string), List<string> uiLocales = default(List<string>))
        {
            this.AcrValues = acrValues;
            this.Display = display;
            this.IdTokenHintClaims = idTokenHintClaims;
            this.LoginHint = loginHint;
            this.UiLocales = uiLocales;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// ACRValues is the Authentication AuthorizationContext Class Reference requested in the OAuth 2.0 Authorization request. It is a parameter defined by OpenID Connect and expresses which level of authentication (e.g. 2FA) is required.  OpenID Connect defines it as follows: &gt; Requested Authentication AuthorizationContext Class Reference values. Space-separated string that specifies the acr values that the Authorization Server is being requested to use for processing this Authentication Request, with the values appearing in order of preference. The Authentication AuthorizationContext Class satisfied by the authentication performed is returned as the acr Claim Value, as specified in Section 2. The acr Claim is requested as a Voluntary Claim by this parameter.
        /// </summary>
        /// <value>ACRValues is the Authentication AuthorizationContext Class Reference requested in the OAuth 2.0 Authorization request. It is a parameter defined by OpenID Connect and expresses which level of authentication (e.g. 2FA) is required.  OpenID Connect defines it as follows: &gt; Requested Authentication AuthorizationContext Class Reference values. Space-separated string that specifies the acr values that the Authorization Server is being requested to use for processing this Authentication Request, with the values appearing in order of preference. The Authentication AuthorizationContext Class satisfied by the authentication performed is returned as the acr Claim Value, as specified in Section 2. The acr Claim is requested as a Voluntary Claim by this parameter.</value>
        [DataMember(Name = "acr_values", EmitDefaultValue = false)]
        public List<string> AcrValues { get; set; }

        /// <summary>
        /// Display is a string value that specifies how the Authorization Server displays the authentication and consent user interface pages to the End-User. The defined values are: page: The Authorization Server SHOULD display the authentication and consent UI consistent with a full User Agent page view. If the display parameter is not specified, this is the default display mode. popup: The Authorization Server SHOULD display the authentication and consent UI consistent with a popup User Agent window. The popup User Agent window should be of an appropriate size for a login-focused dialog and should not obscure the entire window that it is popping up over. touch: The Authorization Server SHOULD display the authentication and consent UI consistent with a device that leverages a touch interface. wap: The Authorization Server SHOULD display the authentication and consent UI consistent with a \&quot;feature phone\&quot; type display.  The Authorization Server MAY also attempt to detect the capabilities of the User Agent and present an appropriate display.
        /// </summary>
        /// <value>Display is a string value that specifies how the Authorization Server displays the authentication and consent user interface pages to the End-User. The defined values are: page: The Authorization Server SHOULD display the authentication and consent UI consistent with a full User Agent page view. If the display parameter is not specified, this is the default display mode. popup: The Authorization Server SHOULD display the authentication and consent UI consistent with a popup User Agent window. The popup User Agent window should be of an appropriate size for a login-focused dialog and should not obscure the entire window that it is popping up over. touch: The Authorization Server SHOULD display the authentication and consent UI consistent with a device that leverages a touch interface. wap: The Authorization Server SHOULD display the authentication and consent UI consistent with a \&quot;feature phone\&quot; type display.  The Authorization Server MAY also attempt to detect the capabilities of the User Agent and present an appropriate display.</value>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public string Display { get; set; }

        /// <summary>
        /// IDTokenHintClaims are the claims of the ID Token previously issued by the Authorization Server being passed as a hint about the End-User&#39;s current or past authenticated session with the Client.
        /// </summary>
        /// <value>IDTokenHintClaims are the claims of the ID Token previously issued by the Authorization Server being passed as a hint about the End-User&#39;s current or past authenticated session with the Client.</value>
        [DataMember(Name = "id_token_hint_claims", EmitDefaultValue = false)]
        public Dictionary<string, Object> IdTokenHintClaims { get; set; }

        /// <summary>
        /// LoginHint hints about the login identifier the End-User might use to log in (if necessary). This hint can be used by an RP if it first asks the End-User for their e-mail address (or other identifier) and then wants to pass that value as a hint to the discovered authorization service. This value MAY also be a phone number in the format specified for the phone_number Claim. The use of this parameter is optional.
        /// </summary>
        /// <value>LoginHint hints about the login identifier the End-User might use to log in (if necessary). This hint can be used by an RP if it first asks the End-User for their e-mail address (or other identifier) and then wants to pass that value as a hint to the discovered authorization service. This value MAY also be a phone number in the format specified for the phone_number Claim. The use of this parameter is optional.</value>
        [DataMember(Name = "login_hint", EmitDefaultValue = false)]
        public string LoginHint { get; set; }

        /// <summary>
        /// UILocales is the End-User&#39;id preferred languages and scripts for the user interface, represented as a space-separated list of BCP47 [RFC5646] language tag values, ordered by preference. For instance, the value \&quot;fr-CA fr en\&quot; represents a preference for French as spoken in Canada, then French (without a region designation), followed by English (without a region designation). An error SHOULD NOT result if some or all of the requested locales are not supported by the OpenID Provider.
        /// </summary>
        /// <value>UILocales is the End-User&#39;id preferred languages and scripts for the user interface, represented as a space-separated list of BCP47 [RFC5646] language tag values, ordered by preference. For instance, the value \&quot;fr-CA fr en\&quot; represents a preference for French as spoken in Canada, then French (without a region designation), followed by English (without a region designation). An error SHOULD NOT result if some or all of the requested locales are not supported by the OpenID Provider.</value>
        [DataMember(Name = "ui_locales", EmitDefaultValue = false)]
        public List<string> UiLocales { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientOpenIDConnectContext {\n");
            sb.Append("  AcrValues: ").Append(AcrValues).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  IdTokenHintClaims: ").Append(IdTokenHintClaims).Append("\n");
            sb.Append("  LoginHint: ").Append(LoginHint).Append("\n");
            sb.Append("  UiLocales: ").Append(UiLocales).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientOpenIDConnectContext);
        }

        /// <summary>
        /// Returns true if ClientOpenIDConnectContext instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientOpenIDConnectContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientOpenIDConnectContext input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcrValues == input.AcrValues ||
                    this.AcrValues != null &&
                    input.AcrValues != null &&
                    this.AcrValues.SequenceEqual(input.AcrValues)
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
                ) && 
                (
                    this.IdTokenHintClaims == input.IdTokenHintClaims ||
                    this.IdTokenHintClaims != null &&
                    input.IdTokenHintClaims != null &&
                    this.IdTokenHintClaims.SequenceEqual(input.IdTokenHintClaims)
                ) && 
                (
                    this.LoginHint == input.LoginHint ||
                    (this.LoginHint != null &&
                    this.LoginHint.Equals(input.LoginHint))
                ) && 
                (
                    this.UiLocales == input.UiLocales ||
                    this.UiLocales != null &&
                    input.UiLocales != null &&
                    this.UiLocales.SequenceEqual(input.UiLocales)
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcrValues != null)
                {
                    hashCode = (hashCode * 59) + this.AcrValues.GetHashCode();
                }
                if (this.Display != null)
                {
                    hashCode = (hashCode * 59) + this.Display.GetHashCode();
                }
                if (this.IdTokenHintClaims != null)
                {
                    hashCode = (hashCode * 59) + this.IdTokenHintClaims.GetHashCode();
                }
                if (this.LoginHint != null)
                {
                    hashCode = (hashCode * 59) + this.LoginHint.GetHashCode();
                }
                if (this.UiLocales != null)
                {
                    hashCode = (hashCode * 59) + this.UiLocales.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}