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
    /// CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations
    /// </summary>
    [DataContract]
    public partial class CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations :  IEquatable<CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations" /> class.
        /// </summary>
        /// <param name="MasterCard">MasterCard.</param>
        /// <param name="Visa">Visa.</param>
        /// <param name="Amex">Amex.</param>
        /// <param name="PreferredDay">PreferredDay.</param>
        /// <param name="DaysWindow">DaysWindow.</param>
        public CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations(CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsMasterCard MasterCard = default(CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsMasterCard), CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsVisa Visa = default(CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsVisa), CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsAmex Amex = default(CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsAmex), decimal? PreferredDay = default(decimal?), decimal? DaysWindow = default(decimal?))
        {
            this.MasterCard = MasterCard;
            this.Visa = Visa;
            this.Amex = Amex;
            this.PreferredDay = PreferredDay;
            this.DaysWindow = DaysWindow;
        }
        
        /// <summary>
        /// Gets or Sets MasterCard
        /// </summary>
        [DataMember(Name="masterCard", EmitDefaultValue=false)]
        public CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsMasterCard MasterCard { get; set; }

        /// <summary>
        /// Gets or Sets Visa
        /// </summary>
        [DataMember(Name="visa", EmitDefaultValue=false)]
        public CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsVisa Visa { get; set; }

        /// <summary>
        /// Gets or Sets Amex
        /// </summary>
        [DataMember(Name="amex", EmitDefaultValue=false)]
        public CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurationsAmex Amex { get; set; }

        /// <summary>
        /// Gets or Sets PreferredDay
        /// </summary>
        [DataMember(Name="preferredDay", EmitDefaultValue=false)]
        public decimal? PreferredDay { get; set; }

        /// <summary>
        /// Gets or Sets DaysWindow
        /// </summary>
        [DataMember(Name="daysWindow", EmitDefaultValue=false)]
        public decimal? DaysWindow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations {\n");
            sb.Append("  MasterCard: ").Append(MasterCard).Append("\n");
            sb.Append("  Visa: ").Append(Visa).Append("\n");
            sb.Append("  Amex: ").Append(Amex).Append("\n");
            sb.Append("  PreferredDay: ").Append(PreferredDay).Append("\n");
            sb.Append("  DaysWindow: ").Append(DaysWindow).Append("\n");
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
            return this.Equals(obj as CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations);
        }

        /// <summary>
        /// Returns true if CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations instances are equal
        /// </summary>
        /// <param name="other">Instance of CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommerceSolutionsProductsAccountUpdaterConfigurationInformationConfigurations other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MasterCard == other.MasterCard ||
                    this.MasterCard != null &&
                    this.MasterCard.Equals(other.MasterCard)
                ) && 
                (
                    this.Visa == other.Visa ||
                    this.Visa != null &&
                    this.Visa.Equals(other.Visa)
                ) && 
                (
                    this.Amex == other.Amex ||
                    this.Amex != null &&
                    this.Amex.Equals(other.Amex)
                ) && 
                (
                    this.PreferredDay == other.PreferredDay ||
                    this.PreferredDay != null &&
                    this.PreferredDay.Equals(other.PreferredDay)
                ) && 
                (
                    this.DaysWindow == other.DaysWindow ||
                    this.DaysWindow != null &&
                    this.DaysWindow.Equals(other.DaysWindow)
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
                if (this.MasterCard != null)
                    hash = hash * 59 + this.MasterCard.GetHashCode();
                if (this.Visa != null)
                    hash = hash * 59 + this.Visa.GetHashCode();
                if (this.Amex != null)
                    hash = hash * 59 + this.Amex.GetHashCode();
                if (this.PreferredDay != null)
                    hash = hash * 59 + this.PreferredDay.GetHashCode();
                if (this.DaysWindow != null)
                    hash = hash * 59 + this.DaysWindow.GetHashCode();
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
