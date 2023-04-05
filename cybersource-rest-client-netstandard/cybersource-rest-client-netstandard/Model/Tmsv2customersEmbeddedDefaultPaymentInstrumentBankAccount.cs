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
    /// Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount
    /// </summary>
    [DataContract]
    public partial class Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount :  IEquatable<Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount" /> class.
        /// </summary>
        /// <param name="Type">Account type.  Possible Values:  - checking : C  - general ledger : G This value is supported only on Wells Fargo ACH  - savings : S (U.S. dollars only)  - corporate checking : X (U.S. dollars only) .</param>
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount(string Type = default(string))
        {
            this.Type = Type;
        }
        
        /// <summary>
        /// Account type.  Possible Values:  - checking : C  - general ledger : G This value is supported only on Wells Fargo ACH  - savings : S (U.S. dollars only)  - corporate checking : X (U.S. dollars only) 
        /// </summary>
        /// <value>Account type.  Possible Values:  - checking : C  - general ledger : G This value is supported only on Wells Fargo ACH  - savings : S (U.S. dollars only)  - corporate checking : X (U.S. dollars only) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount);
        }

        /// <summary>
        /// Returns true if Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
