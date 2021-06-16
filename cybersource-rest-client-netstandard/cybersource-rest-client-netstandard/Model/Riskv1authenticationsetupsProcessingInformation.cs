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
    /// Riskv1authenticationsetupsProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsetupsProcessingInformation :  IEquatable<Riskv1authenticationsetupsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsetupsProcessingInformation" /> class.
        /// </summary>
        /// <param name="PaymentSolution">Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay.  - &#x60;013&#x60;: Cybersource P2PE Decryption  - &#x60;014&#x60;: Mastercard credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.  - &#x60;015&#x60;: Visa credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token. .</param>
        /// <param name="VisaCheckoutId">Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field. .</param>
        public Riskv1authenticationsetupsProcessingInformation(string PaymentSolution = default(string), string VisaCheckoutId = default(string))
        {
            this.PaymentSolution = PaymentSolution;
            this.VisaCheckoutId = VisaCheckoutId;
        }
        
        /// <summary>
        /// Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay.  - &#x60;013&#x60;: Cybersource P2PE Decryption  - &#x60;014&#x60;: Mastercard credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.  - &#x60;015&#x60;: Visa credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token. 
        /// </summary>
        /// <value>Type of digital payment solution for the transaction. Possible Values:   - &#x60;visacheckout&#x60;: Visa Checkout. This value is required for Visa Checkout transactions. For details, see &#x60;payment_solution&#x60; field description in [Visa Checkout Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/VCO_SCMP_API/html/)  - &#x60;001&#x60;: Apple Pay.  - &#x60;004&#x60;: Cybersource In-App Solution.  - &#x60;005&#x60;: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. For details, see \&quot;Masterpass\&quot; in the [Credit Card Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  - &#x60;006&#x60;: Android Pay.  - &#x60;007&#x60;: Chase Pay.  - &#x60;008&#x60;: Samsung Pay.  - &#x60;012&#x60;: Google Pay.  - &#x60;013&#x60;: Cybersource P2PE Decryption  - &#x60;014&#x60;: Mastercard credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token.  - &#x60;015&#x60;: Visa credential on file (COF) payment network token. Returned in authorizations that use a payment network token associated with a TMS token. </value>
        [DataMember(Name="paymentSolution", EmitDefaultValue=false)]
        public string PaymentSolution { get; set; }

        /// <summary>
        /// Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field. 
        /// </summary>
        /// <value>Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field. </value>
        [DataMember(Name="visaCheckoutId", EmitDefaultValue=false)]
        public string VisaCheckoutId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsetupsProcessingInformation {\n");
            sb.Append("  PaymentSolution: ").Append(PaymentSolution).Append("\n");
            sb.Append("  VisaCheckoutId: ").Append(VisaCheckoutId).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsetupsProcessingInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsetupsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsetupsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsetupsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentSolution == other.PaymentSolution ||
                    this.PaymentSolution != null &&
                    this.PaymentSolution.Equals(other.PaymentSolution)
                ) && 
                (
                    this.VisaCheckoutId == other.VisaCheckoutId ||
                    this.VisaCheckoutId != null &&
                    this.VisaCheckoutId.Equals(other.VisaCheckoutId)
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
                if (this.PaymentSolution != null)
                    hash = hash * 59 + this.PaymentSolution.GetHashCode();
                if (this.VisaCheckoutId != null)
                    hash = hash * 59 + this.VisaCheckoutId.GetHashCode();
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
            // PaymentSolution (string) maxLength
            if(this.PaymentSolution != null && this.PaymentSolution.Length >= 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentSolution, length must be less than or equal to 12.", new [] { "PaymentSolution" });
            }

            // VisaCheckoutId (string) maxLength
            if(this.VisaCheckoutId != null && this.VisaCheckoutId.Length >= 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisaCheckoutId, length must be less than or equal to 48.", new [] { "VisaCheckoutId" });
            }

            yield break;
        }
    }

}
