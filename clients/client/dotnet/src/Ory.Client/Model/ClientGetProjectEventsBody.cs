/*
 * Ory APIs
 *
 * Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers. 
 *
 * The version of the OpenAPI document: v1.15.0
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
    /// Body of the getProjectEvents endpoint
    /// </summary>
    [DataContract(Name = "getProjectEventsBody")]
    public partial class ClientGetProjectEventsBody : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGetProjectEventsBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientGetProjectEventsBody()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientGetProjectEventsBody" /> class.
        /// </summary>
        /// <param name="eventName">The event name to query for.</param>
        /// <param name="filters">Event attribute filters.</param>
        /// <param name="from">The start RFC3339 date of the time window (required).</param>
        /// <param name="pageSize">Maximum number of events to return (default to 25).</param>
        /// <param name="pageToken">Pagination token to fetch next page, empty if first page.</param>
        /// <param name="to">The end RFC3339 date of the time window (required).</param>
        public ClientGetProjectEventsBody(string eventName = default(string), List<ClientAttributeFilter> filters = default(List<ClientAttributeFilter>), DateTime from = default(DateTime), long pageSize = 25, string pageToken = default(string), DateTime to = default(DateTime))
        {
            this.From = from;
            this.To = to;
            this.EventName = eventName;
            this.Filters = filters;
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// The event name to query for
        /// </summary>
        /// <value>The event name to query for</value>
        [DataMember(Name = "event_name", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// Event attribute filters
        /// </summary>
        /// <value>Event attribute filters</value>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public List<ClientAttributeFilter> Filters { get; set; }

        /// <summary>
        /// The start RFC3339 date of the time window
        /// </summary>
        /// <value>The start RFC3339 date of the time window</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public DateTime From { get; set; }

        /// <summary>
        /// Maximum number of events to return
        /// </summary>
        /// <value>Maximum number of events to return</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public long PageSize { get; set; }

        /// <summary>
        /// Pagination token to fetch next page, empty if first page
        /// </summary>
        /// <value>Pagination token to fetch next page, empty if first page</value>
        [DataMember(Name = "page_token", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// The end RFC3339 date of the time window
        /// </summary>
        /// <value>The end RFC3339 date of the time window</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public DateTime To { get; set; }

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
            sb.Append("class ClientGetProjectEventsBody {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
