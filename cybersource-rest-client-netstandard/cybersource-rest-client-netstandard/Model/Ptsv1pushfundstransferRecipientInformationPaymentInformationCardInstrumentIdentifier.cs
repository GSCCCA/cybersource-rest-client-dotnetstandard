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
    /// Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier :  IEquatable<Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the Instrument Identifier token used in the transaction. When you include this value in your request, many of the fields that can be supplied for an authorization or credit become optional. .</param>
        public Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier(string Id = default(string))
        {
            this.Id = Id;
        }
        
        /// <summary>
        /// Unique identifier for the Instrument Identifier token used in the transaction. When you include this value in your request, many of the fields that can be supplied for an authorization or credit become optional. 
        /// </summary>
        /// <value>Unique identifier for the Instrument Identifier token used in the transaction. When you include this value in your request, many of the fields that can be supplied for an authorization or credit become optional. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferRecipientInformationPaymentInformationCardInstrumentIdentifier other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
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
