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
    /// Riskv1authenticationsetupsTokenInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsetupsTokenInformation :  IEquatable<Riskv1authenticationsetupsTokenInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsetupsTokenInformation" /> class.
        /// </summary>
        /// <param name="TransientToken">A temporary ID that represents the customer&#39;s payment data (which is securely stored in Visa Data Centers). Flex Microform generates this ID and sets it to expire within 15 minutes from when the ID is generated or until the first payment authorization is carried out (whichever occurs first).  Valid value for the ID is a 64-character, alphanumeric string.  Example: 1D08M4YB968R1F7YVL4TBBKYVNRIR02VZFH9CBYSQIJJXORPI1NK5C98D7F6EB53 .</param>
        /// <param name="Jti">TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). .</param>
        public Riskv1authenticationsetupsTokenInformation(string TransientToken = default(string), string Jti = default(string))
        {
            this.TransientToken = TransientToken;
            this.Jti = Jti;
        }
        
        /// <summary>
        /// A temporary ID that represents the customer&#39;s payment data (which is securely stored in Visa Data Centers). Flex Microform generates this ID and sets it to expire within 15 minutes from when the ID is generated or until the first payment authorization is carried out (whichever occurs first).  Valid value for the ID is a 64-character, alphanumeric string.  Example: 1D08M4YB968R1F7YVL4TBBKYVNRIR02VZFH9CBYSQIJJXORPI1NK5C98D7F6EB53 
        /// </summary>
        /// <value>A temporary ID that represents the customer&#39;s payment data (which is securely stored in Visa Data Centers). Flex Microform generates this ID and sets it to expire within 15 minutes from when the ID is generated or until the first payment authorization is carried out (whichever occurs first).  Valid value for the ID is a 64-character, alphanumeric string.  Example: 1D08M4YB968R1F7YVL4TBBKYVNRIR02VZFH9CBYSQIJJXORPI1NK5C98D7F6EB53 </value>
        [DataMember(Name="transientToken", EmitDefaultValue=false)]
        public string TransientToken { get; set; }

        /// <summary>
        /// TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). 
        /// </summary>
        /// <value>TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). </value>
        [DataMember(Name="jti", EmitDefaultValue=false)]
        public string Jti { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsetupsTokenInformation {\n");
            sb.Append("  TransientToken: ").Append(TransientToken).Append("\n");
            sb.Append("  Jti: ").Append(Jti).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsetupsTokenInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsetupsTokenInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsetupsTokenInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsetupsTokenInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransientToken == other.TransientToken ||
                    this.TransientToken != null &&
                    this.TransientToken.Equals(other.TransientToken)
                ) && 
                (
                    this.Jti == other.Jti ||
                    this.Jti != null &&
                    this.Jti.Equals(other.Jti)
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
                if (this.TransientToken != null)
                    hash = hash * 59 + this.TransientToken.GetHashCode();
                if (this.Jti != null)
                    hash = hash * 59 + this.Jti.GetHashCode();
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
