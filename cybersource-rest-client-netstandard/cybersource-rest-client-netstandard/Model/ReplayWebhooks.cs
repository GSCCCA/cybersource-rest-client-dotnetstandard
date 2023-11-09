/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// ReplayWebhooks
    /// </summary>
    [DataContract]
    public partial class ReplayWebhooks :  IEquatable<ReplayWebhooks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhooks" /> class.
        /// </summary>
        /// <param name="ByTransactionTraceIdentifiers">ByTransactionTraceIdentifiers.</param>
        /// <param name="ByDeliveryStatus">ByDeliveryStatus.</param>
        public ReplayWebhooks(List<string> ByTransactionTraceIdentifiers = default(List<string>), Nrtfv1webhookswebhookIdreplaysByDeliveryStatus ByDeliveryStatus = default(Nrtfv1webhookswebhookIdreplaysByDeliveryStatus))
        {
            this.ByTransactionTraceIdentifiers = ByTransactionTraceIdentifiers;
            this.ByDeliveryStatus = ByDeliveryStatus;
        }
        
        /// <summary>
        /// Gets or Sets ByTransactionTraceIdentifiers
        /// </summary>
        [DataMember(Name="byTransactionTraceIdentifiers", EmitDefaultValue=false)]
        public List<string> ByTransactionTraceIdentifiers { get; set; }

        /// <summary>
        /// Gets or Sets ByDeliveryStatus
        /// </summary>
        [DataMember(Name="byDeliveryStatus", EmitDefaultValue=false)]
        public Nrtfv1webhookswebhookIdreplaysByDeliveryStatus ByDeliveryStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayWebhooks {\n");
            sb.Append("  ByTransactionTraceIdentifiers: ").Append(ByTransactionTraceIdentifiers).Append("\n");
            sb.Append("  ByDeliveryStatus: ").Append(ByDeliveryStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReplayWebhooks);
        }

        /// <summary>
        /// Returns true if ReplayWebhooks instances are equal
        /// </summary>
        /// <param name="other">Instance of ReplayWebhooks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplayWebhooks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ByTransactionTraceIdentifiers == other.ByTransactionTraceIdentifiers ||
                    this.ByTransactionTraceIdentifiers != null &&
                    this.ByTransactionTraceIdentifiers.SequenceEqual(other.ByTransactionTraceIdentifiers)
                ) && 
                (
                    this.ByDeliveryStatus == other.ByDeliveryStatus ||
                    this.ByDeliveryStatus != null &&
                    this.ByDeliveryStatus.Equals(other.ByDeliveryStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ByTransactionTraceIdentifiers != null)
                    hash = hash * 59 + this.ByTransactionTraceIdentifiers.GetHashCode();
                if (this.ByDeliveryStatus != null)
                    hash = hash * 59 + this.ByDeliveryStatus.GetHashCode();
                return hash;
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
