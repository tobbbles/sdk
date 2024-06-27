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
    /// ClientCreateInviteResponse
    /// </summary>
    [DataContract(Name = "CreateInviteResponse")]
    public partial class ClientCreateInviteResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateInviteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientCreateInviteResponse()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientCreateInviteResponse" /> class.
        /// </summary>
        /// <param name="allInvites">A list of all invites for this resource (required).</param>
        /// <param name="createdInvite">createdInvite (required).</param>
        public ClientCreateInviteResponse(List<ClientMemberInvite> allInvites = default(List<ClientMemberInvite>), ClientMemberInvite createdInvite = default(ClientMemberInvite))
        {
            // to ensure "allInvites" is required (not null)
            if (allInvites == null)
            {
                throw new ArgumentNullException("allInvites is a required property for ClientCreateInviteResponse and cannot be null");
            }
            this.AllInvites = allInvites;
            // to ensure "createdInvite" is required (not null)
            if (createdInvite == null)
            {
                throw new ArgumentNullException("createdInvite is a required property for ClientCreateInviteResponse and cannot be null");
            }
            this.CreatedInvite = createdInvite;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// A list of all invites for this resource
        /// </summary>
        /// <value>A list of all invites for this resource</value>
        [DataMember(Name = "all_invites", IsRequired = true, EmitDefaultValue = true)]
        public List<ClientMemberInvite> AllInvites { get; set; }

        /// <summary>
        /// Gets or Sets CreatedInvite
        /// </summary>
        [DataMember(Name = "created_invite", IsRequired = true, EmitDefaultValue = true)]
        public ClientMemberInvite CreatedInvite { get; set; }

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
            sb.Append("class ClientCreateInviteResponse {\n");
            sb.Append("  AllInvites: ").Append(AllInvites).Append("\n");
            sb.Append("  CreatedInvite: ").Append(CreatedInvite).Append("\n");
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
