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
    /// Ptsv1pushfundstransferProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferProcessingInformation :  IEquatable<Ptsv1pushfundstransferProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferProcessingInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ptsv1pushfundstransferProcessingInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferProcessingInformation" /> class.
        /// </summary>
        /// <param name="BusinessApplicationId"> Payouts transaction type. Required for Mastercard Send.  Valid Values- Visa Platform Connect: - &#x60;AA&#x60;: Account to account. - &#x60;CP&#x60;: Card bill payment - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person. - &#x60;TU&#x60;: Top-up for enhanced prepaid loads.   Mastercard Send: - &#x60;BB&#x60;: Business to business. - &#x60;BD&#x60;: Business Disbursement - &#x60;CP&#x60;: Card bill payment - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;OG&#x60;: Online gambling payout.   Chase Paymentech Solutions: - &#x60;AA&#x60;: Account to account. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person.   FDC Compass: - &#x60;BB&#x60;: Business to business. - &#x60;BI&#x60;: Bank-initiated money transfer. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;GP&#x60;: Gambling Payment - &#x60;LO&#x60;: Loyalty Offers - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;MI&#x60;: Merchant initated money transfer - &#x60;OG&#x60;: Online gambling payout. - &#x60;PD&#x60;: Payroll pension disbursement. - &#x60;PP&#x60;: Person to person. - &#x60;WT&#x60;: Wallet transfer. .</param>
        /// <param name="CommerceIndicator">Type of transaction.  Value for an OCT transaction: internet  For details, see the e_commerce_indicator field description in Payouts Using the SCMP API.  (required).</param>
        /// <param name="NetworkRoutingOrder">Visa Platform Connect This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer&#39;s preference. If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer&#39;s routing priorities.  For details, see the network_order field description in BIN Lookup Service Using the SCMP API. .</param>
        /// <param name="PayoutsOptions">PayoutsOptions.</param>
        /// <param name="PurposeOfPayment">This will send purpose of funds code for original credit transactions (OCTs).  Visa Platform Connect (VPC) This will send purpose of transaction code for original credit transactions (OCTs). Purpose of Payment codes are defined by the recipient issuer&#39;s country and vary by country.  Mastercard Send: - &#x60;00&#x60;: Family Support - &#x60;01&#x60;: Regular Labor Transfers (expatriates), - &#x60;02&#x60;: Travel &amp; Tourism - &#x60;03&#x60;: Education - &#x60;04&#x60;: Hospitalization &amp; Medical Treatment, - &#x60;05&#x60;: Emergency Need - &#x60;06&#x60;: Savings - &#x60;07&#x60;: Gifts - &#x60;08&#x60;: Other - &#x60;09&#x60;: Salary - &#x60;10&#x60;: Crowd lending - &#x60;11&#x60;: Crypto currency - &#x60;12&#x60;: Refund to original card - &#x60;13&#x60;: Refund to new card .</param>
        /// <param name="ReconciliationId">Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request.  For Payouts: max length for FDCCompass is String (22). .</param>
        /// <param name="RecurringOptions">RecurringOptions.</param>
        /// <param name="TransactionReason">Transaction reason code.  This field applies only to Visa Platform Connect .</param>
        public Ptsv1pushfundstransferProcessingInformation(string BusinessApplicationId = default(string), string CommerceIndicator = default(string), string NetworkRoutingOrder = default(string), Ptsv1pushfundstransferProcessingInformationPayoutsOptions PayoutsOptions = default(Ptsv1pushfundstransferProcessingInformationPayoutsOptions), string PurposeOfPayment = default(string), string ReconciliationId = default(string), Ptsv1pushfundstransferProcessingInformationRecurringOptions RecurringOptions = default(Ptsv1pushfundstransferProcessingInformationRecurringOptions), string TransactionReason = default(string))
        {
            this.BusinessApplicationId = BusinessApplicationId;
            this.CommerceIndicator = CommerceIndicator;
            this.NetworkRoutingOrder = NetworkRoutingOrder;
            this.PayoutsOptions = PayoutsOptions;
            this.PurposeOfPayment = PurposeOfPayment;
            this.ReconciliationId = ReconciliationId;
            this.RecurringOptions = RecurringOptions;
            this.TransactionReason = TransactionReason;
        }
        
        /// <summary>
        ///  Payouts transaction type. Required for Mastercard Send.  Valid Values- Visa Platform Connect: - &#x60;AA&#x60;: Account to account. - &#x60;CP&#x60;: Card bill payment - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person. - &#x60;TU&#x60;: Top-up for enhanced prepaid loads.   Mastercard Send: - &#x60;BB&#x60;: Business to business. - &#x60;BD&#x60;: Business Disbursement - &#x60;CP&#x60;: Card bill payment - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;OG&#x60;: Online gambling payout.   Chase Paymentech Solutions: - &#x60;AA&#x60;: Account to account. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person.   FDC Compass: - &#x60;BB&#x60;: Business to business. - &#x60;BI&#x60;: Bank-initiated money transfer. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;GP&#x60;: Gambling Payment - &#x60;LO&#x60;: Loyalty Offers - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;MI&#x60;: Merchant initated money transfer - &#x60;OG&#x60;: Online gambling payout. - &#x60;PD&#x60;: Payroll pension disbursement. - &#x60;PP&#x60;: Person to person. - &#x60;WT&#x60;: Wallet transfer. 
        /// </summary>
        /// <value> Payouts transaction type. Required for Mastercard Send.  Valid Values- Visa Platform Connect: - &#x60;AA&#x60;: Account to account. - &#x60;CP&#x60;: Card bill payment - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person. - &#x60;TU&#x60;: Top-up for enhanced prepaid loads.   Mastercard Send: - &#x60;BB&#x60;: Business to business. - &#x60;BD&#x60;: Business Disbursement - &#x60;CP&#x60;: Card bill payment - &#x60;GD&#x60;: Government disbursement - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;OG&#x60;: Online gambling payout.   Chase Paymentech Solutions: - &#x60;AA&#x60;: Account to account. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;PP&#x60;: Person to person.   FDC Compass: - &#x60;BB&#x60;: Business to business. - &#x60;BI&#x60;: Bank-initiated money transfer. - &#x60;FD&#x60;: Funds disbursement (general) - &#x60;GD&#x60;: Government disbursement - &#x60;GP&#x60;: Gambling Payment - &#x60;LO&#x60;: Loyalty Offers - &#x60;MD&#x60;: Merchant disbursement (acquirers or aggregators settling to merchants). - &#x60;MI&#x60;: Merchant initated money transfer - &#x60;OG&#x60;: Online gambling payout. - &#x60;PD&#x60;: Payroll pension disbursement. - &#x60;PP&#x60;: Person to person. - &#x60;WT&#x60;: Wallet transfer. </value>
        [DataMember(Name="businessApplicationId", EmitDefaultValue=false)]
        public string BusinessApplicationId { get; set; }

        /// <summary>
        /// Type of transaction.  Value for an OCT transaction: internet  For details, see the e_commerce_indicator field description in Payouts Using the SCMP API. 
        /// </summary>
        /// <value>Type of transaction.  Value for an OCT transaction: internet  For details, see the e_commerce_indicator field description in Payouts Using the SCMP API. </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// Visa Platform Connect This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer&#39;s preference. If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer&#39;s routing priorities.  For details, see the network_order field description in BIN Lookup Service Using the SCMP API. 
        /// </summary>
        /// <value>Visa Platform Connect This field is optionally used by Push Payments Gateway participants (merchants and acquirers) to get the attributes for specified networks only. The networks specified in this field must be a subset of the information provided during program enrollment. Refer to Sharing Group Code/Network Routing Order. Note: Supported only in US for domestic transactions involving Push Payments Gateway Service.  VisaNet checks to determine if there are issuer routing preferences for any of the networks specified by the network routing order. If an issuer preference exists for one of the specified debit networks, VisaNet makes a routing selection based on the issuer&#39;s preference. If an issuer preference exists for more than one of the specified debit networks, or if no issuer preference exists, VisaNet makes a selection based on the acquirer&#39;s routing priorities.  For details, see the network_order field description in BIN Lookup Service Using the SCMP API. </value>
        [DataMember(Name="networkRoutingOrder", EmitDefaultValue=false)]
        public string NetworkRoutingOrder { get; set; }

        /// <summary>
        /// Gets or Sets PayoutsOptions
        /// </summary>
        [DataMember(Name="payoutsOptions", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferProcessingInformationPayoutsOptions PayoutsOptions { get; set; }

        /// <summary>
        /// This will send purpose of funds code for original credit transactions (OCTs).  Visa Platform Connect (VPC) This will send purpose of transaction code for original credit transactions (OCTs). Purpose of Payment codes are defined by the recipient issuer&#39;s country and vary by country.  Mastercard Send: - &#x60;00&#x60;: Family Support - &#x60;01&#x60;: Regular Labor Transfers (expatriates), - &#x60;02&#x60;: Travel &amp; Tourism - &#x60;03&#x60;: Education - &#x60;04&#x60;: Hospitalization &amp; Medical Treatment, - &#x60;05&#x60;: Emergency Need - &#x60;06&#x60;: Savings - &#x60;07&#x60;: Gifts - &#x60;08&#x60;: Other - &#x60;09&#x60;: Salary - &#x60;10&#x60;: Crowd lending - &#x60;11&#x60;: Crypto currency - &#x60;12&#x60;: Refund to original card - &#x60;13&#x60;: Refund to new card 
        /// </summary>
        /// <value>This will send purpose of funds code for original credit transactions (OCTs).  Visa Platform Connect (VPC) This will send purpose of transaction code for original credit transactions (OCTs). Purpose of Payment codes are defined by the recipient issuer&#39;s country and vary by country.  Mastercard Send: - &#x60;00&#x60;: Family Support - &#x60;01&#x60;: Regular Labor Transfers (expatriates), - &#x60;02&#x60;: Travel &amp; Tourism - &#x60;03&#x60;: Education - &#x60;04&#x60;: Hospitalization &amp; Medical Treatment, - &#x60;05&#x60;: Emergency Need - &#x60;06&#x60;: Savings - &#x60;07&#x60;: Gifts - &#x60;08&#x60;: Other - &#x60;09&#x60;: Salary - &#x60;10&#x60;: Crowd lending - &#x60;11&#x60;: Crypto currency - &#x60;12&#x60;: Refund to original card - &#x60;13&#x60;: Refund to new card </value>
        [DataMember(Name="purposeOfPayment", EmitDefaultValue=false)]
        public string PurposeOfPayment { get; set; }

        /// <summary>
        /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request.  For Payouts: max length for FDCCompass is String (22). 
        /// </summary>
        /// <value>Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request.  For Payouts: max length for FDCCompass is String (22). </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Gets or Sets RecurringOptions
        /// </summary>
        [DataMember(Name="recurringOptions", EmitDefaultValue=false)]
        public Ptsv1pushfundstransferProcessingInformationRecurringOptions RecurringOptions { get; set; }

        /// <summary>
        /// Transaction reason code.  This field applies only to Visa Platform Connect 
        /// </summary>
        /// <value>Transaction reason code.  This field applies only to Visa Platform Connect </value>
        [DataMember(Name="transactionReason", EmitDefaultValue=false)]
        public string TransactionReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferProcessingInformation {\n");
            sb.Append("  BusinessApplicationId: ").Append(BusinessApplicationId).Append("\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  NetworkRoutingOrder: ").Append(NetworkRoutingOrder).Append("\n");
            sb.Append("  PayoutsOptions: ").Append(PayoutsOptions).Append("\n");
            sb.Append("  PurposeOfPayment: ").Append(PurposeOfPayment).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  RecurringOptions: ").Append(RecurringOptions).Append("\n");
            sb.Append("  TransactionReason: ").Append(TransactionReason).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferProcessingInformation);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BusinessApplicationId == other.BusinessApplicationId ||
                    this.BusinessApplicationId != null &&
                    this.BusinessApplicationId.Equals(other.BusinessApplicationId)
                ) && 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.NetworkRoutingOrder == other.NetworkRoutingOrder ||
                    this.NetworkRoutingOrder != null &&
                    this.NetworkRoutingOrder.Equals(other.NetworkRoutingOrder)
                ) && 
                (
                    this.PayoutsOptions == other.PayoutsOptions ||
                    this.PayoutsOptions != null &&
                    this.PayoutsOptions.Equals(other.PayoutsOptions)
                ) && 
                (
                    this.PurposeOfPayment == other.PurposeOfPayment ||
                    this.PurposeOfPayment != null &&
                    this.PurposeOfPayment.Equals(other.PurposeOfPayment)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.RecurringOptions == other.RecurringOptions ||
                    this.RecurringOptions != null &&
                    this.RecurringOptions.Equals(other.RecurringOptions)
                ) && 
                (
                    this.TransactionReason == other.TransactionReason ||
                    this.TransactionReason != null &&
                    this.TransactionReason.Equals(other.TransactionReason)
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
                if (this.BusinessApplicationId != null)
                    hash = hash * 59 + this.BusinessApplicationId.GetHashCode();
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.NetworkRoutingOrder != null)
                    hash = hash * 59 + this.NetworkRoutingOrder.GetHashCode();
                if (this.PayoutsOptions != null)
                    hash = hash * 59 + this.PayoutsOptions.GetHashCode();
                if (this.PurposeOfPayment != null)
                    hash = hash * 59 + this.PurposeOfPayment.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.RecurringOptions != null)
                    hash = hash * 59 + this.RecurringOptions.GetHashCode();
                if (this.TransactionReason != null)
                    hash = hash * 59 + this.TransactionReason.GetHashCode();
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
