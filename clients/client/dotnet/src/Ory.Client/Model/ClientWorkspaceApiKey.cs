/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.3
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
    /// ClientWorkspaceApiKey
    /// </summary>
    [DataContract(Name = "workspaceApiKey")]
    public partial class ClientWorkspaceApiKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientWorkspaceApiKey" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientWorkspaceApiKey()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientWorkspaceApiKey" /> class.
        /// </summary>
        /// <param name="name">The API key&#39;s Name  Set this to help you remember, for example, where you use the API key. (required).</param>
        public ClientWorkspaceApiKey(string name = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientWorkspaceApiKey and cannot be null");
            }
            this.Name = name;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The API key&#39;s creation date
        /// </summary>
        /// <value>The API key&#39;s creation date</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// The key&#39;s ID.
        /// </summary>
        /// <value>The key&#39;s ID.</value>
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
        /// The API key&#39;s Name  Set this to help you remember, for example, where you use the API key.
        /// </summary>
        /// <value>The API key&#39;s Name  Set this to help you remember, for example, where you use the API key.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The key&#39;s owner
        /// </summary>
        /// <value>The key&#39;s owner</value>
        [DataMember(Name = "owner_id", IsRequired = true, EmitDefaultValue = true)]
        public string OwnerId { get; private set; }

        /// <summary>
        /// Returns false as OwnerId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOwnerId()
        {
            return false;
        }
        /// <summary>
        /// The API key&#39;s last update date
        /// </summary>
        /// <value>The API key&#39;s last update date</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// The key&#39;s value
        /// </summary>
        /// <value>The key&#39;s value</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; private set; }

        /// <summary>
        /// Returns false as Value should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValue()
        {
            return false;
        }
        /// <summary>
        /// The API token&#39;s workspace ID
        /// </summary>
        /// <value>The API token&#39;s workspace ID</value>
        [DataMember(Name = "workspace_id", EmitDefaultValue = false)]
        public string WorkspaceId { get; private set; }

        /// <summary>
        /// Returns false as WorkspaceId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWorkspaceId()
        {
            return false;
        }
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
            sb.Append("class ClientWorkspaceApiKey {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
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
