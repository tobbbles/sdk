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
    /// Patch Identities Body
    /// </summary>
    [DataContract(Name = "patchIdentitiesBody")]
    public partial class ClientPatchIdentitiesBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientPatchIdentitiesBody" /> class.
        /// </summary>
        /// <param name="identities">Identities holds the list of patches to apply  required.</param>
        public ClientPatchIdentitiesBody(List<ClientIdentityPatch> identities = default(List<ClientIdentityPatch>))
        {
            this.Identities = identities;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Identities holds the list of patches to apply  required
        /// </summary>
        /// <value>Identities holds the list of patches to apply  required</value>
        [DataMember(Name = "identities", EmitDefaultValue = false)]
        public List<ClientIdentityPatch> Identities { get; set; }

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
            sb.Append("class ClientPatchIdentitiesBody {\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
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
