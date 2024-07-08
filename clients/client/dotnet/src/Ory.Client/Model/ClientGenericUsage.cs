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
    /// ClientGenericUsage
    /// </summary>
    [DataContract(Name = "GenericUsage")]
    public partial class ClientGenericUsage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGenericUsage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientGenericUsage()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGenericUsage" /> class.
        /// </summary>
        /// <param name="additionalPrice">additionalPrice (required).</param>
        /// <param name="includedUsage">IncludedUsage is the number of included items. (required).</param>
        public ClientGenericUsage(ClientMoney additionalPrice = default(ClientMoney), long includedUsage = default(long))
        {
            // to ensure "additionalPrice" is required (not null)
            if (additionalPrice == null)
            {
                throw new ArgumentNullException("additionalPrice is a required property for ClientGenericUsage and cannot be null");
            }
            this.AdditionalPrice = additionalPrice;
            this.IncludedUsage = includedUsage;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets AdditionalPrice
        /// </summary>
        [DataMember(Name = "additional_price", IsRequired = true, EmitDefaultValue = true)]
        public ClientMoney AdditionalPrice { get; set; }

        /// <summary>
        /// IncludedUsage is the number of included items.
        /// </summary>
        /// <value>IncludedUsage is the number of included items.</value>
        [DataMember(Name = "included_usage", IsRequired = true, EmitDefaultValue = true)]
        public long IncludedUsage { get; set; }

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
            sb.Append("class ClientGenericUsage {\n");
            sb.Append("  AdditionalPrice: ").Append(AdditionalPrice).Append("\n");
            sb.Append("  IncludedUsage: ").Append(IncludedUsage).Append("\n");
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
