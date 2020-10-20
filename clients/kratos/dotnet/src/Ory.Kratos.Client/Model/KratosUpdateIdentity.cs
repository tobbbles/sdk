/* 
 * Ory Kratos
 *
 * Welcome to the ORY Kratos HTTP API documentation!
 *
 * The version of the OpenAPI document: v0.5.1-alpha.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosUpdateIdentity
    /// </summary>
    [DataContract]
    public partial class KratosUpdateIdentity :  IEquatable<KratosUpdateIdentity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateIdentity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KratosUpdateIdentity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateIdentity" /> class.
        /// </summary>
        /// <param name="schemaId">SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID..</param>
        /// <param name="traits">Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;. (required).</param>
        public KratosUpdateIdentity(string schemaId = default(string), Object traits = default(Object))
        {
            // to ensure "traits" is required (not null)
            this.Traits = traits ?? throw new ArgumentNullException("traits is a required property for KratosUpdateIdentity and cannot be null");
            this.SchemaId = schemaId;
        }
        
        /// <summary>
        /// SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID.
        /// </summary>
        /// <value>SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits. If set will update the Identity&#39;s SchemaID.</value>
        [DataMember(Name="schema_id", EmitDefaultValue=false)]
        public string SchemaId { get; set; }

        /// <summary>
        /// Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;.
        /// </summary>
        /// <value>Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_id&#x60;.</value>
        [DataMember(Name="traits", EmitDefaultValue=false)]
        public Object Traits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUpdateIdentity {\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosUpdateIdentity);
        }

        /// <summary>
        /// Returns true if KratosUpdateIdentity instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosUpdateIdentity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosUpdateIdentity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SchemaId == input.SchemaId ||
                    (this.SchemaId != null &&
                    this.SchemaId.Equals(input.SchemaId))
                ) && 
                (
                    this.Traits == input.Traits ||
                    (this.Traits != null &&
                    this.Traits.Equals(input.Traits))
                );
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
                if (this.SchemaId != null)
                    hashCode = hashCode * 59 + this.SchemaId.GetHashCode();
                if (this.Traits != null)
                    hashCode = hashCode * 59 + this.Traits.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
