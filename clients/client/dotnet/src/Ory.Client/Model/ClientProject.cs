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
    /// ClientProject
    /// </summary>
    [DataContract(Name = "project")]
    public partial class ClientProject : IValidatableObject
    {
        /// <summary>
        /// The environment of the project. prod Production stage Staging dev Development
        /// </summary>
        /// <value>The environment of the project. prod Production stage Staging dev Development</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VarEnvironmentEnum
        {
            /// <summary>
            /// Enum Prod for value: prod
            /// </summary>
            [EnumMember(Value = "prod")]
            Prod = 1,

            /// <summary>
            /// Enum Stage for value: stage
            /// </summary>
            [EnumMember(Value = "stage")]
            Stage = 2,

            /// <summary>
            /// Enum Dev for value: dev
            /// </summary>
            [EnumMember(Value = "dev")]
            Dev = 3
        }


        /// <summary>
        /// The environment of the project. prod Production stage Staging dev Development
        /// </summary>
        /// <value>The environment of the project. prod Production stage Staging dev Development</value>
        [DataMember(Name = "environment", IsRequired = true, EmitDefaultValue = true)]
        public VarEnvironmentEnum VarEnvironment { get; set; }
        /// <summary>
        /// The project home region.  This is used to set where the project data is stored and where the project&#39;s endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global
        /// </summary>
        /// <value>The project home region.  This is used to set where the project data is stored and where the project&#39;s endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HomeRegionEnum
        {
            /// <summary>
            /// Enum EuCentral for value: eu-central
            /// </summary>
            [EnumMember(Value = "eu-central")]
            EuCentral = 1,

            /// <summary>
            /// Enum UsEast for value: us-east
            /// </summary>
            [EnumMember(Value = "us-east")]
            UsEast = 2,

            /// <summary>
            /// Enum UsWest for value: us-west
            /// </summary>
            [EnumMember(Value = "us-west")]
            UsWest = 3,

            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 4
        }


        /// <summary>
        /// The project home region.  This is used to set where the project data is stored and where the project&#39;s endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global
        /// </summary>
        /// <value>The project home region.  This is used to set where the project data is stored and where the project&#39;s endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global</value>
        [DataMember(Name = "home_region", IsRequired = true, EmitDefaultValue = true)]
        public HomeRegionEnum HomeRegion { get; set; }
        /// <summary>
        /// The state of the project. running Running halted Halted deleted Deleted
        /// </summary>
        /// <value>The state of the project. running Running halted Halted deleted Deleted</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Running for value: running
            /// </summary>
            [EnumMember(Value = "running")]
            Running = 1,

            /// <summary>
            /// Enum Halted for value: halted
            /// </summary>
            [EnumMember(Value = "halted")]
            Halted = 2,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 3
        }


        /// <summary>
        /// The state of the project. running Running halted Halted deleted Deleted
        /// </summary>
        /// <value>The state of the project. running Running halted Halted deleted Deleted</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }

        /// <summary>
        /// Returns false as State should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeState()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientProject()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProject" /> class.
        /// </summary>
        /// <param name="corsAdmin">corsAdmin.</param>
        /// <param name="corsPublic">corsPublic.</param>
        /// <param name="varEnvironment">The environment of the project. prod Production stage Staging dev Development (required).</param>
        /// <param name="homeRegion">The project home region.  This is used to set where the project data is stored and where the project&#39;s endpoints are located. eu-central EUCentral us-east USEast us-west USWest global Global (required).</param>
        /// <param name="name">The name of the project. (required).</param>
        /// <param name="services">services (required).</param>
        /// <param name="workspaceId">workspaceId.</param>
        public ClientProject(ClientProjectCors corsAdmin = default(ClientProjectCors), ClientProjectCors corsPublic = default(ClientProjectCors), VarEnvironmentEnum varEnvironment = default(VarEnvironmentEnum), HomeRegionEnum homeRegion = default(HomeRegionEnum), string name = default(string), ClientProjectServices services = default(ClientProjectServices), string workspaceId = default(string))
        {
            this.VarEnvironment = varEnvironment;
            this.HomeRegion = homeRegion;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ClientProject and cannot be null");
            }
            this.Name = name;
            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new ArgumentNullException("services is a required property for ClientProject and cannot be null");
            }
            this.Services = services;
            this.CorsAdmin = corsAdmin;
            this.CorsPublic = corsPublic;
            this.WorkspaceId = workspaceId;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets CorsAdmin
        /// </summary>
        [DataMember(Name = "cors_admin", EmitDefaultValue = false)]
        public ClientProjectCors CorsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets CorsPublic
        /// </summary>
        [DataMember(Name = "cors_public", EmitDefaultValue = false)]
        public ClientProjectCors CorsPublic { get; set; }

        /// <summary>
        /// The project&#39;s ID.
        /// </summary>
        /// <value>The project&#39;s ID.</value>
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
        /// The name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The configuration revision ID.
        /// </summary>
        /// <value>The configuration revision ID.</value>
        [DataMember(Name = "revision_id", IsRequired = true, EmitDefaultValue = true)]
        public string RevisionId { get; private set; }

        /// <summary>
        /// Returns false as RevisionId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRevisionId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name = "services", IsRequired = true, EmitDefaultValue = true)]
        public ClientProjectServices Services { get; set; }

        /// <summary>
        /// The project&#39;s slug
        /// </summary>
        /// <value>The project&#39;s slug</value>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public string Slug { get; private set; }

        /// <summary>
        /// Returns false as Slug should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSlug()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets WorkspaceId
        /// </summary>
        [DataMember(Name = "workspace_id", EmitDefaultValue = true)]
        public string WorkspaceId { get; set; }

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
            sb.Append("class ClientProject {\n");
            sb.Append("  CorsAdmin: ").Append(CorsAdmin).Append("\n");
            sb.Append("  CorsPublic: ").Append(CorsPublic).Append("\n");
            sb.Append("  VarEnvironment: ").Append(VarEnvironment).Append("\n");
            sb.Append("  HomeRegion: ").Append(HomeRegion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RevisionId: ").Append(RevisionId).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
