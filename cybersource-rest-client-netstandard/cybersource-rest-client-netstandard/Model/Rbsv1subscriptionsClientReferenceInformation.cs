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
    /// Rbsv1subscriptionsClientReferenceInformation
    /// </summary>
    [DataContract]
    public partial class Rbsv1subscriptionsClientReferenceInformation :  IEquatable<Rbsv1subscriptionsClientReferenceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rbsv1subscriptionsClientReferenceInformation" /> class.
        /// </summary>
        /// <param name="Code">Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. .</param>
        /// <param name="Comments">Brief description of the order or any comment you wish to add to the order. .</param>
        /// <param name="Partner">Partner.</param>
        /// <param name="ApplicationName">The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. .</param>
        /// <param name="ApplicationVersion">Version of the CyberSource application or integration used for a transaction. .</param>
        /// <param name="ApplicationUser">The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. .</param>
        public Rbsv1subscriptionsClientReferenceInformation(string Code = default(string), string Comments = default(string), Riskv1decisionsClientReferenceInformationPartner Partner = default(Riskv1decisionsClientReferenceInformationPartner), string ApplicationName = default(string), string ApplicationVersion = default(string), string ApplicationUser = default(string))
        {
            this.Code = Code;
            this.Comments = Comments;
            this.Partner = Partner;
            this.ApplicationName = ApplicationName;
            this.ApplicationVersion = ApplicationVersion;
            this.ApplicationUser = ApplicationUser;
        }
        
        /// <summary>
        /// Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. 
        /// </summary>
        /// <value>Merchant-generated order reference or tracking number. It is recommended that you send a unique value for each transaction so that you can perform meaningful searches for the transaction.  #### Used by **Authorization** Required field.  #### PIN Debit Requests for PIN debit reversals need to use the same merchant reference number that was used in the transaction that is being reversed.  Required field for all PIN Debit requests (purchase, credit, and reversal).  #### FDC Nashville Global Certain circumstances can cause the processor to truncate this value to 15 or 17 characters for Level II and Level III processing, which can cause a discrepancy between the value you submit and the value included in some processor reports. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Brief description of the order or any comment you wish to add to the order. 
        /// </summary>
        /// <value>Brief description of the order or any comment you wish to add to the order. </value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Partner
        /// </summary>
        [DataMember(Name="partner", EmitDefaultValue=false)]
        public Riskv1decisionsClientReferenceInformationPartner Partner { get; set; }

        /// <summary>
        /// The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. 
        /// </summary>
        /// <value>The name of the Connection Method client (such as Virtual Terminal or SOAP Toolkit API) that the merchant uses to send a transaction request to CyberSource. </value>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Version of the CyberSource application or integration used for a transaction. 
        /// </summary>
        /// <value>Version of the CyberSource application or integration used for a transaction. </value>
        [DataMember(Name="applicationVersion", EmitDefaultValue=false)]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. 
        /// </summary>
        /// <value>The entity that is responsible for running the transaction and submitting the processing request to CyberSource. This could be a person, a system, or a connection method. </value>
        [DataMember(Name="applicationUser", EmitDefaultValue=false)]
        public string ApplicationUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rbsv1subscriptionsClientReferenceInformation {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Partner: ").Append(Partner).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationVersion: ").Append(ApplicationVersion).Append("\n");
            sb.Append("  ApplicationUser: ").Append(ApplicationUser).Append("\n");
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
            return this.Equals(obj as Rbsv1subscriptionsClientReferenceInformation);
        }

        /// <summary>
        /// Returns true if Rbsv1subscriptionsClientReferenceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Rbsv1subscriptionsClientReferenceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rbsv1subscriptionsClientReferenceInformation other)
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
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.Partner == other.Partner ||
                    this.Partner != null &&
                    this.Partner.Equals(other.Partner)
                ) && 
                (
                    this.ApplicationName == other.ApplicationName ||
                    this.ApplicationName != null &&
                    this.ApplicationName.Equals(other.ApplicationName)
                ) && 
                (
                    this.ApplicationVersion == other.ApplicationVersion ||
                    this.ApplicationVersion != null &&
                    this.ApplicationVersion.Equals(other.ApplicationVersion)
                ) && 
                (
                    this.ApplicationUser == other.ApplicationUser ||
                    this.ApplicationUser != null &&
                    this.ApplicationUser.Equals(other.ApplicationUser)
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
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Partner != null)
                    hash = hash * 59 + this.Partner.GetHashCode();
                if (this.ApplicationName != null)
                    hash = hash * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationVersion != null)
                    hash = hash * 59 + this.ApplicationVersion.GetHashCode();
                if (this.ApplicationUser != null)
                    hash = hash * 59 + this.ApplicationUser.GetHashCode();
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
