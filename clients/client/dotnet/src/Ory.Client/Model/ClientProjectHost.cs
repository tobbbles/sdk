/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.12.0
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
    /// ClientProjectHost
    /// </summary>
    [DataContract(Name = "projectHost")]
    public partial class ClientProjectHost : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectHost" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProjectHost()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProjectHost" /> class.
        /// </summary>
        /// <param name="host">The project&#39;s host. (required).</param>
        /// <param name="projectId">The Revision&#39;s Project ID (required).</param>
        public ClientProjectHost(string host = default(string), string projectId = default(string))
        {
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for ClientProjectHost and cannot be null");
            }
            this.Host = host;
            // to ensure "projectId" is required (not null)
            if (projectId == null)
            {
                throw new ArgumentNullException("projectId is a required property for ClientProjectHost and cannot be null");
            }
            this.ProjectId = projectId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The project&#39;s host.
        /// </summary>
        /// <value>The project&#39;s host.</value>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// The mapping&#39;s ID.
        /// </summary>
        /// <value>The mapping&#39;s ID.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// The Revision&#39;s Project ID
        /// </summary>
        /// <value>The Revision&#39;s Project ID</value>
        [DataMember(Name = "project_id", IsRequired = true, EmitDefaultValue = true)]
        public string ProjectId { get; set; }

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
            sb.Append("class ClientProjectHost {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
