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
    /// PostRegistrationBody
    /// </summary>
    [DataContract]
    public partial class PostRegistrationBody :  IEquatable<PostRegistrationBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostRegistrationBody" /> class.
        /// </summary>
        /// <param name="RegistrationInformation">RegistrationInformation.</param>
        /// <param name="IntegrationInformation">IntegrationInformation.</param>
        /// <param name="OrganizationInformation">OrganizationInformation.</param>
        /// <param name="ProductInformation">ProductInformation.</param>
        /// <param name="DocumentInformation">DocumentInformation.</param>
        public PostRegistrationBody(Boardingv1registrationsRegistrationInformation RegistrationInformation = default(Boardingv1registrationsRegistrationInformation), Boardingv1registrationsIntegrationInformation IntegrationInformation = default(Boardingv1registrationsIntegrationInformation), Boardingv1registrationsOrganizationInformation OrganizationInformation = default(Boardingv1registrationsOrganizationInformation), Boardingv1registrationsProductInformation ProductInformation = default(Boardingv1registrationsProductInformation), Boardingv1registrationsDocumentInformation DocumentInformation = default(Boardingv1registrationsDocumentInformation))
        {
            this.RegistrationInformation = RegistrationInformation;
            this.IntegrationInformation = IntegrationInformation;
            this.OrganizationInformation = OrganizationInformation;
            this.ProductInformation = ProductInformation;
            this.DocumentInformation = DocumentInformation;
        }
        
        /// <summary>
        /// Gets or Sets RegistrationInformation
        /// </summary>
        [DataMember(Name="registrationInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsRegistrationInformation RegistrationInformation { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationInformation
        /// </summary>
        [DataMember(Name="integrationInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsIntegrationInformation IntegrationInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationInformation
        /// </summary>
        [DataMember(Name="organizationInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsOrganizationInformation OrganizationInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProductInformation
        /// </summary>
        [DataMember(Name="productInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsProductInformation ProductInformation { get; set; }

        /// <summary>
        /// Gets or Sets DocumentInformation
        /// </summary>
        [DataMember(Name="documentInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsDocumentInformation DocumentInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostRegistrationBody {\n");
            sb.Append("  RegistrationInformation: ").Append(RegistrationInformation).Append("\n");
            sb.Append("  IntegrationInformation: ").Append(IntegrationInformation).Append("\n");
            sb.Append("  OrganizationInformation: ").Append(OrganizationInformation).Append("\n");
            sb.Append("  ProductInformation: ").Append(ProductInformation).Append("\n");
            sb.Append("  DocumentInformation: ").Append(DocumentInformation).Append("\n");
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
            return this.Equals(obj as PostRegistrationBody);
        }

        /// <summary>
        /// Returns true if PostRegistrationBody instances are equal
        /// </summary>
        /// <param name="other">Instance of PostRegistrationBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostRegistrationBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RegistrationInformation == other.RegistrationInformation ||
                    this.RegistrationInformation != null &&
                    this.RegistrationInformation.Equals(other.RegistrationInformation)
                ) && 
                (
                    this.IntegrationInformation == other.IntegrationInformation ||
                    this.IntegrationInformation != null &&
                    this.IntegrationInformation.Equals(other.IntegrationInformation)
                ) && 
                (
                    this.OrganizationInformation == other.OrganizationInformation ||
                    this.OrganizationInformation != null &&
                    this.OrganizationInformation.Equals(other.OrganizationInformation)
                ) && 
                (
                    this.ProductInformation == other.ProductInformation ||
                    this.ProductInformation != null &&
                    this.ProductInformation.Equals(other.ProductInformation)
                ) && 
                (
                    this.DocumentInformation == other.DocumentInformation ||
                    this.DocumentInformation != null &&
                    this.DocumentInformation.Equals(other.DocumentInformation)
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
                if (this.RegistrationInformation != null)
                    hash = hash * 59 + this.RegistrationInformation.GetHashCode();
                if (this.IntegrationInformation != null)
                    hash = hash * 59 + this.IntegrationInformation.GetHashCode();
                if (this.OrganizationInformation != null)
                    hash = hash * 59 + this.OrganizationInformation.GetHashCode();
                if (this.ProductInformation != null)
                    hash = hash * 59 + this.ProductInformation.GetHashCode();
                if (this.DocumentInformation != null)
                    hash = hash * 59 + this.DocumentInformation.GetHashCode();
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