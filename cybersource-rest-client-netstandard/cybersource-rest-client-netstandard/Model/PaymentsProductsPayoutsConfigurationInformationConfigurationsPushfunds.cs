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
    /// Formatted as *{payoutsAcquirerName}. The property name field should be the same as the processor name for which the pull funds or push funds feature is being configured. Here is the list of valid processor names [TBD]
    /// </summary>
    [DataContract]
    public partial class PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds :  IEquatable<PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds" /> class.
        /// </summary>
        /// <param name="AcquirerCountryCode">TBD (required).</param>
        /// <param name="AcquiringBIN">TBD (required).</param>
        /// <param name="AllowCryptoCurrencyPurchase">This configuration allows a transaction to be flagged for cryptocurrency funds transfer..</param>
        /// <param name="FinancialInstitutionId">TBD.</param>
        /// <param name="NetworkOrder">TBD.</param>
        /// <param name="NationalReimbursementFee">TBD.</param>
        /// <param name="OriginatorBusinessApplicationId">TBD (required).</param>
        /// <param name="OriginatorPseudoAbaNumber">TBD.</param>
        /// <param name="ProcessorAccount">TBD (required).</param>
        public PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds(int? AcquirerCountryCode = default(int?), int? AcquiringBIN = default(int?), bool? AllowCryptoCurrencyPurchase = default(bool?), string FinancialInstitutionId = default(string), string NetworkOrder = default(string), string NationalReimbursementFee = default(string), string OriginatorBusinessApplicationId = default(string), string OriginatorPseudoAbaNumber = default(string), List<PaymentsProductsPayoutsConfigurationInformationConfigurationsProcessorAccount> ProcessorAccount = default(List<PaymentsProductsPayoutsConfigurationInformationConfigurationsProcessorAccount>))
        {
            this.AcquirerCountryCode = AcquirerCountryCode;
            this.AcquiringBIN = AcquiringBIN;
            this.AllowCryptoCurrencyPurchase = AllowCryptoCurrencyPurchase;
            this.FinancialInstitutionId = FinancialInstitutionId;
            this.NetworkOrder = NetworkOrder;
            this.NationalReimbursementFee = NationalReimbursementFee;
            this.OriginatorBusinessApplicationId = OriginatorBusinessApplicationId;
            this.OriginatorPseudoAbaNumber = OriginatorPseudoAbaNumber;
            this.ProcessorAccount = ProcessorAccount;
        }
        
        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="acquirerCountryCode", EmitDefaultValue=false)]
        public int? AcquirerCountryCode { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="acquiringBIN", EmitDefaultValue=false)]
        public int? AcquiringBIN { get; set; }

        /// <summary>
        /// This configuration allows a transaction to be flagged for cryptocurrency funds transfer.
        /// </summary>
        /// <value>This configuration allows a transaction to be flagged for cryptocurrency funds transfer.</value>
        [DataMember(Name="allowCryptoCurrencyPurchase", EmitDefaultValue=false)]
        public bool? AllowCryptoCurrencyPurchase { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="financialInstitutionId", EmitDefaultValue=false)]
        public string FinancialInstitutionId { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="networkOrder", EmitDefaultValue=false)]
        public string NetworkOrder { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="nationalReimbursementFee", EmitDefaultValue=false)]
        public string NationalReimbursementFee { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="originatorBusinessApplicationId", EmitDefaultValue=false)]
        public string OriginatorBusinessApplicationId { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="originatorPseudoAbaNumber", EmitDefaultValue=false)]
        public string OriginatorPseudoAbaNumber { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="processorAccount", EmitDefaultValue=false)]
        public List<PaymentsProductsPayoutsConfigurationInformationConfigurationsProcessorAccount> ProcessorAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds {\n");
            sb.Append("  AcquirerCountryCode: ").Append(AcquirerCountryCode).Append("\n");
            sb.Append("  AcquiringBIN: ").Append(AcquiringBIN).Append("\n");
            sb.Append("  AllowCryptoCurrencyPurchase: ").Append(AllowCryptoCurrencyPurchase).Append("\n");
            sb.Append("  FinancialInstitutionId: ").Append(FinancialInstitutionId).Append("\n");
            sb.Append("  NetworkOrder: ").Append(NetworkOrder).Append("\n");
            sb.Append("  NationalReimbursementFee: ").Append(NationalReimbursementFee).Append("\n");
            sb.Append("  OriginatorBusinessApplicationId: ").Append(OriginatorBusinessApplicationId).Append("\n");
            sb.Append("  OriginatorPseudoAbaNumber: ").Append(OriginatorPseudoAbaNumber).Append("\n");
            sb.Append("  ProcessorAccount: ").Append(ProcessorAccount).Append("\n");
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
            return this.Equals(obj as PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds);
        }

        /// <summary>
        /// Returns true if PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentsProductsPayoutsConfigurationInformationConfigurationsPushfunds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcquirerCountryCode == other.AcquirerCountryCode ||
                    this.AcquirerCountryCode != null &&
                    this.AcquirerCountryCode.Equals(other.AcquirerCountryCode)
                ) && 
                (
                    this.AcquiringBIN == other.AcquiringBIN ||
                    this.AcquiringBIN != null &&
                    this.AcquiringBIN.Equals(other.AcquiringBIN)
                ) && 
                (
                    this.AllowCryptoCurrencyPurchase == other.AllowCryptoCurrencyPurchase ||
                    this.AllowCryptoCurrencyPurchase != null &&
                    this.AllowCryptoCurrencyPurchase.Equals(other.AllowCryptoCurrencyPurchase)
                ) && 
                (
                    this.FinancialInstitutionId == other.FinancialInstitutionId ||
                    this.FinancialInstitutionId != null &&
                    this.FinancialInstitutionId.Equals(other.FinancialInstitutionId)
                ) && 
                (
                    this.NetworkOrder == other.NetworkOrder ||
                    this.NetworkOrder != null &&
                    this.NetworkOrder.Equals(other.NetworkOrder)
                ) && 
                (
                    this.NationalReimbursementFee == other.NationalReimbursementFee ||
                    this.NationalReimbursementFee != null &&
                    this.NationalReimbursementFee.Equals(other.NationalReimbursementFee)
                ) && 
                (
                    this.OriginatorBusinessApplicationId == other.OriginatorBusinessApplicationId ||
                    this.OriginatorBusinessApplicationId != null &&
                    this.OriginatorBusinessApplicationId.Equals(other.OriginatorBusinessApplicationId)
                ) && 
                (
                    this.OriginatorPseudoAbaNumber == other.OriginatorPseudoAbaNumber ||
                    this.OriginatorPseudoAbaNumber != null &&
                    this.OriginatorPseudoAbaNumber.Equals(other.OriginatorPseudoAbaNumber)
                ) && 
                (
                    this.ProcessorAccount == other.ProcessorAccount ||
                    this.ProcessorAccount != null &&
                    this.ProcessorAccount.SequenceEqual(other.ProcessorAccount)
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
                if (this.AcquirerCountryCode != null)
                    hash = hash * 59 + this.AcquirerCountryCode.GetHashCode();
                if (this.AcquiringBIN != null)
                    hash = hash * 59 + this.AcquiringBIN.GetHashCode();
                if (this.AllowCryptoCurrencyPurchase != null)
                    hash = hash * 59 + this.AllowCryptoCurrencyPurchase.GetHashCode();
                if (this.FinancialInstitutionId != null)
                    hash = hash * 59 + this.FinancialInstitutionId.GetHashCode();
                if (this.NetworkOrder != null)
                    hash = hash * 59 + this.NetworkOrder.GetHashCode();
                if (this.NationalReimbursementFee != null)
                    hash = hash * 59 + this.NationalReimbursementFee.GetHashCode();
                if (this.OriginatorBusinessApplicationId != null)
                    hash = hash * 59 + this.OriginatorBusinessApplicationId.GetHashCode();
                if (this.OriginatorPseudoAbaNumber != null)
                    hash = hash * 59 + this.OriginatorPseudoAbaNumber.GetHashCode();
                if (this.ProcessorAccount != null)
                    hash = hash * 59 + this.ProcessorAccount.GetHashCode();
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
