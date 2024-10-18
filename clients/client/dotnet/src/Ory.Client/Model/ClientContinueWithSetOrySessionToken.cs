/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.7
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
    /// Indicates that a session was issued, and the application should use this token for authenticated requests
    /// </summary>
    [DataContract(Name = "continueWithSetOrySessionToken")]
    public partial class ClientContinueWithSetOrySessionToken : IValidatableObject
    {
        /// <summary>
        /// Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionTokenString
        /// </summary>
        /// <value>Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionTokenString</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum SetOrySessionToken for value: set_ory_session_token
            /// </summary>
            [EnumMember(Value = "set_ory_session_token")]
            SetOrySessionToken = 1
        }


        /// <summary>
        /// Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionTokenString
        /// </summary>
        /// <value>Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionTokenString</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithSetOrySessionToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientContinueWithSetOrySessionToken()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContinueWithSetOrySessionToken" /> class.
        /// </summary>
        /// <param name="action">Action will always be &#x60;set_ory_session_token&#x60; set_ory_session_token ContinueWithActionSetOrySessionTokenString (required).</param>
        /// <param name="orySessionToken">Token is the token of the session (required).</param>
        public ClientContinueWithSetOrySessionToken(ActionEnum action = default(ActionEnum), string orySessionToken = default(string))
        {
            this.Action = action;
            // to ensure "orySessionToken" is required (not null)
            if (orySessionToken == null)
            {
                throw new ArgumentNullException("orySessionToken is a required property for ClientContinueWithSetOrySessionToken and cannot be null");
            }
            this.OrySessionToken = orySessionToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Token is the token of the session
        /// </summary>
        /// <value>Token is the token of the session</value>
        [DataMember(Name = "ory_session_token", IsRequired = true, EmitDefaultValue = true)]
        public string OrySessionToken { get; set; }

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
            sb.Append("class ClientContinueWithSetOrySessionToken {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  OrySessionToken: ").Append(OrySessionToken).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
