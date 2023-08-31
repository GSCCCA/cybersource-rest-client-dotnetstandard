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
    /// Ptsv2billingagreementsConsumerAuthenticationInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2billingagreementsConsumerAuthenticationInformation :  IEquatable<Ptsv2billingagreementsConsumerAuthenticationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2billingagreementsConsumerAuthenticationInformation" /> class.
        /// </summary>
        /// <param name="AuthenticationTransactionContextId">Payer authentication transaction identifier passed to link the validation and authorization calls. .</param>
        /// <param name="Cavv">Unique identifier generated by the card-issuing bank for Visa, American Express, JCB, Diners Club, and Discover transactions after the customer is authenticated. The value is in base64. When you request the card authorization service, CyberSource automatically converts the value, not the field name, to the format required by your payment processor. .</param>
        /// <param name="TransactionToken">Web based token used to authenticate consumer with Rupay authentication provider. .</param>
        /// <param name="Xid">Transaction identifier generated by CyberSource for successful enrollment or validation checks. Use this value, which is in base64, to match an outgoing PAReq with an incoming PARes. CyberSource forwards the XID with the card authorization service to these payment processors in these cases: - Barclays - Streamline (when the **ecommerceIndicator**&#x60;&#x3D;spa&#x60;) .</param>
        public Ptsv2billingagreementsConsumerAuthenticationInformation(string AuthenticationTransactionContextId = default(string), string Cavv = default(string), string TransactionToken = default(string), string Xid = default(string))
        {
            this.AuthenticationTransactionContextId = AuthenticationTransactionContextId;
            this.Cavv = Cavv;
            this.TransactionToken = TransactionToken;
            this.Xid = Xid;
        }
        
        /// <summary>
        /// Payer authentication transaction identifier passed to link the validation and authorization calls. 
        /// </summary>
        /// <value>Payer authentication transaction identifier passed to link the validation and authorization calls. </value>
        [DataMember(Name="authenticationTransactionContextId", EmitDefaultValue=false)]
        public string AuthenticationTransactionContextId { get; set; }

        /// <summary>
        /// Unique identifier generated by the card-issuing bank for Visa, American Express, JCB, Diners Club, and Discover transactions after the customer is authenticated. The value is in base64. When you request the card authorization service, CyberSource automatically converts the value, not the field name, to the format required by your payment processor. 
        /// </summary>
        /// <value>Unique identifier generated by the card-issuing bank for Visa, American Express, JCB, Diners Club, and Discover transactions after the customer is authenticated. The value is in base64. When you request the card authorization service, CyberSource automatically converts the value, not the field name, to the format required by your payment processor. </value>
        [DataMember(Name="cavv", EmitDefaultValue=false)]
        public string Cavv { get; set; }

        /// <summary>
        /// Web based token used to authenticate consumer with Rupay authentication provider. 
        /// </summary>
        /// <value>Web based token used to authenticate consumer with Rupay authentication provider. </value>
        [DataMember(Name="transactionToken", EmitDefaultValue=false)]
        public string TransactionToken { get; set; }

        /// <summary>
        /// Transaction identifier generated by CyberSource for successful enrollment or validation checks. Use this value, which is in base64, to match an outgoing PAReq with an incoming PARes. CyberSource forwards the XID with the card authorization service to these payment processors in these cases: - Barclays - Streamline (when the **ecommerceIndicator**&#x60;&#x3D;spa&#x60;) 
        /// </summary>
        /// <value>Transaction identifier generated by CyberSource for successful enrollment or validation checks. Use this value, which is in base64, to match an outgoing PAReq with an incoming PARes. CyberSource forwards the XID with the card authorization service to these payment processors in these cases: - Barclays - Streamline (when the **ecommerceIndicator**&#x60;&#x3D;spa&#x60;) </value>
        [DataMember(Name="xid", EmitDefaultValue=false)]
        public string Xid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2billingagreementsConsumerAuthenticationInformation {\n");
            sb.Append("  AuthenticationTransactionContextId: ").Append(AuthenticationTransactionContextId).Append("\n");
            sb.Append("  Cavv: ").Append(Cavv).Append("\n");
            sb.Append("  TransactionToken: ").Append(TransactionToken).Append("\n");
            sb.Append("  Xid: ").Append(Xid).Append("\n");
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
            return this.Equals(obj as Ptsv2billingagreementsConsumerAuthenticationInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2billingagreementsConsumerAuthenticationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2billingagreementsConsumerAuthenticationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2billingagreementsConsumerAuthenticationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationTransactionContextId == other.AuthenticationTransactionContextId ||
                    this.AuthenticationTransactionContextId != null &&
                    this.AuthenticationTransactionContextId.Equals(other.AuthenticationTransactionContextId)
                ) && 
                (
                    this.Cavv == other.Cavv ||
                    this.Cavv != null &&
                    this.Cavv.Equals(other.Cavv)
                ) && 
                (
                    this.TransactionToken == other.TransactionToken ||
                    this.TransactionToken != null &&
                    this.TransactionToken.Equals(other.TransactionToken)
                ) && 
                (
                    this.Xid == other.Xid ||
                    this.Xid != null &&
                    this.Xid.Equals(other.Xid)
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
                if (this.AuthenticationTransactionContextId != null)
                    hash = hash * 59 + this.AuthenticationTransactionContextId.GetHashCode();
                if (this.Cavv != null)
                    hash = hash * 59 + this.Cavv.GetHashCode();
                if (this.TransactionToken != null)
                    hash = hash * 59 + this.TransactionToken.GetHashCode();
                if (this.Xid != null)
                    hash = hash * 59 + this.Xid.GetHashCode();
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
