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
    /// Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts :  IEquatable<Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts" /> class.
        /// </summary>
        /// <param name="Code">Additional amount type. This field is supported only for **American Express Direct**.  For processor-specific information, see the &#x60;additional_amount_type0&#x60; request-level field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Amount">Additional amount. This field is supported only for **American Express Direct**. .</param>
        public Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts(string Code = default(string), string Amount = default(string))
        {
            this.Code = Code;
            this.Amount = Amount;
        }
        
        /// <summary>
        /// Additional amount type. This field is supported only for **American Express Direct**.  For processor-specific information, see the &#x60;additional_amount_type0&#x60; request-level field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Additional amount type. This field is supported only for **American Express Direct**.  For processor-specific information, see the &#x60;additional_amount_type0&#x60; request-level field description in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Additional amount. This field is supported only for **American Express Direct**. 
        /// </summary>
        /// <value>Additional amount. This field is supported only for **American Express Direct**. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationAmountDetailsAmexAdditionalAmounts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
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
