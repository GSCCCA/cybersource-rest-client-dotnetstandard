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
    /// TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint" /> class.
        /// </summary>
        /// <param name="TrueIpaddress">Customer’s true IP address detected by the application.  For details, see the &#x60;true_ipaddress&#x60; field description in _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). .</param>
        /// <param name="Hash">The unique identifier of the device that is returned in the &#x60;riskInformation.providers.fingerprint.device_fingerprint_hash&#x60; API reply field.  NOTE: For details about the value of this field, see the &#x60;decision_provider_#_field_#_value&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).  For more details about this field, see the &#x60;device_fingerprint_hash&#x60; field description in the _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). .</param>
        /// <param name="SmartId">The device identifier generated from attributes collected during profiling. Returned by a 3rd party when you use device fingerprinting.  For details, see the &#x60;device_fingerprint_smart_id&#x60; field description in [CyberSource Decision Manager Device Fingerprinting Guide.](https://www.cybersource.com/developers/documentation/fraud_management) .</param>
        public TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint(string TrueIpaddress = default(string), string Hash = default(string), string SmartId = default(string))
        {
            this.TrueIpaddress = TrueIpaddress;
            this.Hash = Hash;
            this.SmartId = SmartId;
        }
        
        /// <summary>
        /// Customer’s true IP address detected by the application.  For details, see the &#x60;true_ipaddress&#x60; field description in _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). 
        /// </summary>
        /// <value>Customer’s true IP address detected by the application.  For details, see the &#x60;true_ipaddress&#x60; field description in _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). </value>
        [DataMember(Name="true_ipaddress", EmitDefaultValue=false)]
        public string TrueIpaddress { get; set; }

        /// <summary>
        /// The unique identifier of the device that is returned in the &#x60;riskInformation.providers.fingerprint.device_fingerprint_hash&#x60; API reply field.  NOTE: For details about the value of this field, see the &#x60;decision_provider_#_field_#_value&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).  For more details about this field, see the &#x60;device_fingerprint_hash&#x60; field description in the _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). 
        /// </summary>
        /// <value>The unique identifier of the device that is returned in the &#x60;riskInformation.providers.fingerprint.device_fingerprint_hash&#x60; API reply field.  NOTE: For details about the value of this field, see the &#x60;decision_provider_#_field_#_value&#x60; field description in the _Decision Manager Using the SCMP API Developer Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Decision Manager Using the SCMP API Developer Guide_ (PDF link).  For more details about this field, see the &#x60;device_fingerprint_hash&#x60; field description in the _Device Fingerprinting Guide_ on the [CyberSource Business Center.](https://ebc2.cybersource.com/ebc2/) Click **Decision Manager** &gt; **Documentation** &gt; **Guides** &gt; _Device Fingerprinting Guide_ (PDF link). </value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// The device identifier generated from attributes collected during profiling. Returned by a 3rd party when you use device fingerprinting.  For details, see the &#x60;device_fingerprint_smart_id&#x60; field description in [CyberSource Decision Manager Device Fingerprinting Guide.](https://www.cybersource.com/developers/documentation/fraud_management) 
        /// </summary>
        /// <value>The device identifier generated from attributes collected during profiling. Returned by a 3rd party when you use device fingerprinting.  For details, see the &#x60;device_fingerprint_smart_id&#x60; field description in [CyberSource Decision Manager Device Fingerprinting Guide.](https://www.cybersource.com/developers/documentation/fraud_management) </value>
        [DataMember(Name="smartId", EmitDefaultValue=false)]
        public string SmartId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint {\n");
            sb.Append("  TrueIpaddress: ").Append(TrueIpaddress).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  SmartId: ").Append(SmartId).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedRiskInformationProvidersFingerprint other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TrueIpaddress == other.TrueIpaddress ||
                    this.TrueIpaddress != null &&
                    this.TrueIpaddress.Equals(other.TrueIpaddress)
                ) && 
                (
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
                ) && 
                (
                    this.SmartId == other.SmartId ||
                    this.SmartId != null &&
                    this.SmartId.Equals(other.SmartId)
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
                if (this.TrueIpaddress != null)
                    hash = hash * 59 + this.TrueIpaddress.GetHashCode();
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
                if (this.SmartId != null)
                    hash = hash * 59 + this.SmartId.GetHashCode();
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
