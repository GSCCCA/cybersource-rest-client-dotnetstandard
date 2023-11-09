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
    /// Boardingv1registrationsOrganizationInformationBusinessInformationAddress
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsOrganizationInformationBusinessInformationAddress :  IEquatable<Boardingv1registrationsOrganizationInformationBusinessInformationAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationBusinessInformationAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boardingv1registrationsOrganizationInformationBusinessInformationAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationBusinessInformationAddress" /> class.
        /// </summary>
        /// <param name="Country">Country (required).</param>
        /// <param name="Address1">Address1 (required).</param>
        /// <param name="Address2">Address2.</param>
        /// <param name="Locality">City of the billing address. (required).</param>
        /// <param name="AdministrativeArea">State or province of the billing address. Required for United States and Canada..</param>
        /// <param name="PostalCode">Postal code for the billing address. The postal code must consist of 5 to 9 digits. Required for United States and Canada..</param>
        public Boardingv1registrationsOrganizationInformationBusinessInformationAddress(string Country = default(string), string Address1 = default(string), string Address2 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string PostalCode = default(string))
        {
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationAddress and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
            // to ensure "Address1" is required (not null)
            if (Address1 == null)
            {
                throw new InvalidDataException("Address1 is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationAddress and cannot be null");
            }
            else
            {
                this.Address1 = Address1;
            }
            // to ensure "Locality" is required (not null)
            if (Locality == null)
            {
                throw new InvalidDataException("Locality is a required property for Boardingv1registrationsOrganizationInformationBusinessInformationAddress and cannot be null");
            }
            else
            {
                this.Locality = Locality;
            }
            this.Address2 = Address2;
            this.AdministrativeArea = AdministrativeArea;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets Address2
        /// </summary>
        [DataMember(Name="address2", EmitDefaultValue=false)]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the billing address.
        /// </summary>
        /// <value>City of the billing address.</value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// State or province of the billing address. Required for United States and Canada.
        /// </summary>
        /// <value>State or province of the billing address. Required for United States and Canada.</value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Postal code for the billing address. The postal code must consist of 5 to 9 digits. Required for United States and Canada.
        /// </summary>
        /// <value>Postal code for the billing address. The postal code must consist of 5 to 9 digits. Required for United States and Canada.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsOrganizationInformationBusinessInformationAddress {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Address2: ").Append(Address2).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsOrganizationInformationBusinessInformationAddress);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsOrganizationInformationBusinessInformationAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsOrganizationInformationBusinessInformationAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsOrganizationInformationBusinessInformationAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Address2 == other.Address2 ||
                    this.Address2 != null &&
                    this.Address2.Equals(other.Address2)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Address2 != null)
                    hash = hash * 59 + this.Address2.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
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
            // Country (string) pattern
            Regex regexCountry = new Regex(@"^[À-ÖØ-öø-ǿa-zA-Z0-9().\\-_#,;\/@$:!% ]{1,}$", RegexOptions.CultureInvariant);
            if (false == regexCountry.Match(this.Country).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new[] { "Country" });
            }

            // Address1 (string) pattern
            Regex regexAddress1 = new Regex(@"^[À-ÖØ-öø-ǿa-zA-Z0-9().\\-_#,;\/@$:!% ]{1,}$", RegexOptions.CultureInvariant);
            if (false == regexAddress1.Match(this.Address1).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, must match a pattern of " + regexAddress1, new[] { "Address1" });
            }

            // Address2 (string) pattern
            Regex regexAddress2 = new Regex(@"^[À-ÖØ-öø-ǿa-zA-Z0-9().\\-_#,;\/@$:!% ]{1,}$", RegexOptions.CultureInvariant);
            if (false == regexAddress2.Match(this.Address2).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address2, must match a pattern of " + regexAddress2, new[] { "Address2" });
            }

            // Locality (string) pattern
            Regex regexLocality = new Regex(@"^[0-9a-zA-Z _\\-¡-￿]+$", RegexOptions.CultureInvariant);
            if (false == regexLocality.Match(this.Locality).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, must match a pattern of " + regexLocality, new[] { "Locality" });
            }

            // AdministrativeArea (string) pattern
            Regex regexAdministrativeArea = new Regex(@"^[0-9a-zA-Z¡-￿ ]*$", RegexOptions.CultureInvariant);
            if (false == regexAdministrativeArea.Match(this.AdministrativeArea).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, must match a pattern of " + regexAdministrativeArea, new[] { "AdministrativeArea" });
            }

            // PostalCode (string) pattern
            Regex regexPostalCode = new Regex(@"^[0-9a-zA-Z ]*$", RegexOptions.CultureInvariant);
            if (false == regexPostalCode.Match(this.PostalCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, must match a pattern of " + regexPostalCode, new[] { "PostalCode" });
            }

            yield break;
        }
    }

}
