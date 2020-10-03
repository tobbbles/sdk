/* 
 * ORY Hydra
 *
 * Welcome to the ORY Hydra HTTP API documentation. You will find documentation for all HTTP APIs here.
 *
 * The version of the OpenAPI document: v1.8.0-pre.1
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
using OpenAPIDateConverter = Ory.Hydra.Client.Client.OpenAPIDateConverter;

namespace Ory.Hydra.Client.Model
{
    /// <summary>
    /// VolumeUsageData Usage details about the volume. This information is used by the &#x60;GET /system/df&#x60; endpoint, and omitted in other endpoints.
    /// </summary>
    [DataContract]
    public partial class HydraVolumeUsageData :  IEquatable<HydraVolumeUsageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraVolumeUsageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HydraVolumeUsageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HydraVolumeUsageData" /> class.
        /// </summary>
        /// <param name="refCount">The number of containers referencing this volume. This field is set to &#x60;-1&#x60; if the reference-count is not available. (required).</param>
        /// <param name="size">Amount of disk space used by the volume (in bytes). This information is only available for volumes created with the &#x60;\&quot;local\&quot;&#x60; volume driver. For volumes created with other volume drivers, this field is set to &#x60;-1&#x60; (\&quot;not available\&quot;) (required).</param>
        public HydraVolumeUsageData(long refCount = default(long), long size = default(long))
        {
            this.RefCount = refCount;
            this.Size = size;
        }
        
        /// <summary>
        /// The number of containers referencing this volume. This field is set to &#x60;-1&#x60; if the reference-count is not available.
        /// </summary>
        /// <value>The number of containers referencing this volume. This field is set to &#x60;-1&#x60; if the reference-count is not available.</value>
        [DataMember(Name="RefCount", EmitDefaultValue=false)]
        public long RefCount { get; set; }

        /// <summary>
        /// Amount of disk space used by the volume (in bytes). This information is only available for volumes created with the &#x60;\&quot;local\&quot;&#x60; volume driver. For volumes created with other volume drivers, this field is set to &#x60;-1&#x60; (\&quot;not available\&quot;)
        /// </summary>
        /// <value>Amount of disk space used by the volume (in bytes). This information is only available for volumes created with the &#x60;\&quot;local\&quot;&#x60; volume driver. For volumes created with other volume drivers, this field is set to &#x60;-1&#x60; (\&quot;not available\&quot;)</value>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public long Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HydraVolumeUsageData {\n");
            sb.Append("  RefCount: ").Append(RefCount).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as HydraVolumeUsageData);
        }

        /// <summary>
        /// Returns true if HydraVolumeUsageData instances are equal
        /// </summary>
        /// <param name="input">Instance of HydraVolumeUsageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HydraVolumeUsageData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefCount == input.RefCount ||
                    this.RefCount.Equals(input.RefCount)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
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
                hashCode = hashCode * 59 + this.RefCount.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
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