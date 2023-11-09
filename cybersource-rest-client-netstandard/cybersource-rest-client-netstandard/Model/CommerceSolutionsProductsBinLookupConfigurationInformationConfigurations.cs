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
    /// CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations
    /// </summary>
    [DataContract]
    public partial class CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations :  IEquatable<CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations" /> class.
        /// </summary>
        /// <param name="IsPayoutOptionsEnabled">This flag indicates if the merchant is configured to make payout calls.</param>
        /// <param name="IsAccountPrefixEnabled">This flag indicates if the merchant is configured to receive account prefix.</param>
        public CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations(bool? IsPayoutOptionsEnabled = default(bool?), bool? IsAccountPrefixEnabled = default(bool?))
        {
            this.IsPayoutOptionsEnabled = IsPayoutOptionsEnabled;
            this.IsAccountPrefixEnabled = IsAccountPrefixEnabled;
        }
        
        /// <summary>
        /// This flag indicates if the merchant is configured to make payout calls
        /// </summary>
        /// <value>This flag indicates if the merchant is configured to make payout calls</value>
        [DataMember(Name="isPayoutOptionsEnabled", EmitDefaultValue=false)]
        public bool? IsPayoutOptionsEnabled { get; set; }

        /// <summary>
        /// This flag indicates if the merchant is configured to receive account prefix
        /// </summary>
        /// <value>This flag indicates if the merchant is configured to receive account prefix</value>
        [DataMember(Name="isAccountPrefixEnabled", EmitDefaultValue=false)]
        public bool? IsAccountPrefixEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations {\n");
            sb.Append("  IsPayoutOptionsEnabled: ").Append(IsPayoutOptionsEnabled).Append("\n");
            sb.Append("  IsAccountPrefixEnabled: ").Append(IsAccountPrefixEnabled).Append("\n");
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
            return this.Equals(obj as CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations);
        }

        /// <summary>
        /// Returns true if CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations instances are equal
        /// </summary>
        /// <param name="other">Instance of CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceSolutionsProductsBinLookupConfigurationInformationConfigurations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsPayoutOptionsEnabled == other.IsPayoutOptionsEnabled ||
                    this.IsPayoutOptionsEnabled != null &&
                    this.IsPayoutOptionsEnabled.Equals(other.IsPayoutOptionsEnabled)
                ) && 
                (
                    this.IsAccountPrefixEnabled == other.IsAccountPrefixEnabled ||
                    this.IsAccountPrefixEnabled != null &&
                    this.IsAccountPrefixEnabled.Equals(other.IsAccountPrefixEnabled)
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
                if (this.IsPayoutOptionsEnabled != null)
                    hash = hash * 59 + this.IsPayoutOptionsEnabled.GetHashCode();
                if (this.IsAccountPrefixEnabled != null)
                    hash = hash * 59 + this.IsAccountPrefixEnabled.GetHashCode();
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
