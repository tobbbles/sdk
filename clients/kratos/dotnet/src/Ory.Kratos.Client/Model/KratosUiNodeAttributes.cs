/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.0.4-alpha.1
 * Contact: hi@ory.sh
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
using OpenAPIDateConverter = Ory.Kratos.Client.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Ory.Kratos.Client.Model
{
    /// <summary>
    /// KratosUiNodeAttributes
    /// </summary>
    [JsonConverter(typeof(KratosUiNodeAttributesJsonConverter))]
    [DataContract(Name = "uiNodeAttributes")]
    public partial class KratosUiNodeAttributes : AbstractOpenAPISchema, IEquatable<KratosUiNodeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAttributes" /> class
        /// with the <see cref="KratosUiNodeAnchorAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUiNodeAnchorAttributes.</param>
        public KratosUiNodeAttributes(KratosUiNodeAnchorAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAttributes" /> class
        /// with the <see cref="KratosUiNodeImageAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUiNodeImageAttributes.</param>
        public KratosUiNodeAttributes(KratosUiNodeImageAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAttributes" /> class
        /// with the <see cref="KratosUiNodeInputAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUiNodeInputAttributes.</param>
        public KratosUiNodeAttributes(KratosUiNodeInputAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUiNodeAttributes" /> class
        /// with the <see cref="KratosUiNodeTextAttributes" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KratosUiNodeTextAttributes.</param>
        public KratosUiNodeAttributes(KratosUiNodeTextAttributes actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(KratosUiNodeAnchorAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUiNodeImageAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUiNodeInputAttributes))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KratosUiNodeTextAttributes))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: KratosUiNodeAnchorAttributes, KratosUiNodeImageAttributes, KratosUiNodeInputAttributes, KratosUiNodeTextAttributes");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `KratosUiNodeAnchorAttributes`. If the actual instanct is not `KratosUiNodeAnchorAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUiNodeAnchorAttributes</returns>
        public KratosUiNodeAnchorAttributes GetKratosUiNodeAnchorAttributes()
        {
            return (KratosUiNodeAnchorAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUiNodeImageAttributes`. If the actual instanct is not `KratosUiNodeImageAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUiNodeImageAttributes</returns>
        public KratosUiNodeImageAttributes GetKratosUiNodeImageAttributes()
        {
            return (KratosUiNodeImageAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUiNodeInputAttributes`. If the actual instanct is not `KratosUiNodeInputAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUiNodeInputAttributes</returns>
        public KratosUiNodeInputAttributes GetKratosUiNodeInputAttributes()
        {
            return (KratosUiNodeInputAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KratosUiNodeTextAttributes`. If the actual instanct is not `KratosUiNodeTextAttributes`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KratosUiNodeTextAttributes</returns>
        public KratosUiNodeTextAttributes GetKratosUiNodeTextAttributes()
        {
            return (KratosUiNodeTextAttributes)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KratosUiNodeAttributes {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KratosUiNodeAttributes.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KratosUiNodeAttributes
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KratosUiNodeAttributes</returns>
        public static KratosUiNodeAttributes FromJson(string jsonString)
        {
            KratosUiNodeAttributes newKratosUiNodeAttributes = null;

            if (jsonString == null)
            {
                return newKratosUiNodeAttributes;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUiNodeAnchorAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeAnchorAttributes>(jsonString, KratosUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeAnchorAttributes>(jsonString, KratosUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUiNodeAnchorAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosUiNodeAnchorAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUiNodeImageAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeImageAttributes>(jsonString, KratosUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeImageAttributes>(jsonString, KratosUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUiNodeImageAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosUiNodeImageAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUiNodeInputAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeInputAttributes>(jsonString, KratosUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeInputAttributes>(jsonString, KratosUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUiNodeInputAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosUiNodeInputAttributes: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(KratosUiNodeTextAttributes).GetProperty("AdditionalProperties") == null)
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeTextAttributes>(jsonString, KratosUiNodeAttributes.SerializerSettings));
                }
                else
                {
                    newKratosUiNodeAttributes = new KratosUiNodeAttributes(JsonConvert.DeserializeObject<KratosUiNodeTextAttributes>(jsonString, KratosUiNodeAttributes.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("KratosUiNodeTextAttributes");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(String.Format("Failed to deserialize `{0}` into KratosUiNodeTextAttributes: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newKratosUiNodeAttributes;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KratosUiNodeAttributes);
        }

        /// <summary>
        /// Returns true if KratosUiNodeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of KratosUiNodeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KratosUiNodeAttributes input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for KratosUiNodeAttributes
    /// </summary>
    public class KratosUiNodeAttributesJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((String)(typeof(KratosUiNodeAttributes).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return KratosUiNodeAttributes.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
