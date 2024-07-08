/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.13.10
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
    /// ClientCreateVerifiableCredentialRequestBody
    /// </summary>
    [DataContract(Name = "CreateVerifiableCredentialRequestBody")]
    public partial class ClientCreateVerifiableCredentialRequestBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateVerifiableCredentialRequestBody" /> class.
        /// </summary>
        /// <param name="format">format.</param>
        /// <param name="proof">proof.</param>
        /// <param name="types">types.</param>
        public ClientCreateVerifiableCredentialRequestBody(string format = default(string), ClientVerifiableCredentialProof proof = default(ClientVerifiableCredentialProof), List<string> types = default(List<string>))
        {
            this.Format = format;
            this.Proof = proof;
            this.Types = types;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Proof
        /// </summary>
        [DataMember(Name = "proof", EmitDefaultValue = false)]
        public ClientVerifiableCredentialProof Proof { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<string> Types { get; set; }

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
            sb.Append("class ClientCreateVerifiableCredentialRequestBody {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Proof: ").Append(Proof).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
