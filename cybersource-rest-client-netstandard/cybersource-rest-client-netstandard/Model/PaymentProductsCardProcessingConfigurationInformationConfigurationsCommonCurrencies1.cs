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
    /// PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1
    /// </summary>
    [DataContract]
    public partial class PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1 :  IEquatable<PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1" /> class.
        /// </summary>
        /// <param name="Enabled">Enabled.</param>
        /// <param name="EnabledCardPresent">Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardPresent will have the value of enabled. .</param>
        /// <param name="EnabledCardNotPresent">Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardNotPresent will have the value of enabled. .</param>
        /// <param name="TerminalIds">Applicable for Prisma (prisma) processor..</param>
        public PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1(bool? Enabled = default(bool?), bool? EnabledCardPresent = default(bool?), bool? EnabledCardNotPresent = default(bool?), List<string> TerminalIds = default(List<string>))
        {
            this.Enabled = Enabled;
            this.EnabledCardPresent = EnabledCardPresent;
            this.EnabledCardNotPresent = EnabledCardNotPresent;
            this.TerminalIds = TerminalIds;
        }
        
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardPresent will have the value of enabled. 
        /// </summary>
        /// <value>Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardPresent will have the value of enabled. </value>
        [DataMember(Name="enabledCardPresent", EmitDefaultValue=false)]
        public bool? EnabledCardPresent { get; set; }

        /// <summary>
        /// Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardNotPresent will have the value of enabled. 
        /// </summary>
        /// <value>Indicates whether the card-present transaction is activated for the selected currency. If both enabledCardPresent and enabledCardNotPresent are set to null, then enabledCardNotPresent will have the value of enabled. </value>
        [DataMember(Name="enabledCardNotPresent", EmitDefaultValue=false)]
        public bool? EnabledCardNotPresent { get; set; }

        /// <summary>
        /// Applicable for Prisma (prisma) processor.
        /// </summary>
        /// <value>Applicable for Prisma (prisma) processor.</value>
        [DataMember(Name="terminalIds", EmitDefaultValue=false)]
        public List<string> TerminalIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1 {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EnabledCardPresent: ").Append(EnabledCardPresent).Append("\n");
            sb.Append("  EnabledCardNotPresent: ").Append(EnabledCardNotPresent).Append("\n");
            sb.Append("  TerminalIds: ").Append(TerminalIds).Append("\n");
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
            return this.Equals(obj as PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1);
        }

        /// <summary>
        /// Returns true if PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1 instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsCardProcessingConfigurationInformationConfigurationsCommonCurrencies1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.EnabledCardPresent == other.EnabledCardPresent ||
                    this.EnabledCardPresent != null &&
                    this.EnabledCardPresent.Equals(other.EnabledCardPresent)
                ) && 
                (
                    this.EnabledCardNotPresent == other.EnabledCardNotPresent ||
                    this.EnabledCardNotPresent != null &&
                    this.EnabledCardNotPresent.Equals(other.EnabledCardNotPresent)
                ) && 
                (
                    this.TerminalIds == other.TerminalIds ||
                    this.TerminalIds != null &&
                    this.TerminalIds.SequenceEqual(other.TerminalIds)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.EnabledCardPresent != null)
                    hash = hash * 59 + this.EnabledCardPresent.GetHashCode();
                if (this.EnabledCardNotPresent != null)
                    hash = hash * 59 + this.EnabledCardNotPresent.GetHashCode();
                if (this.TerminalIds != null)
                    hash = hash * 59 + this.TerminalIds.GetHashCode();
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
