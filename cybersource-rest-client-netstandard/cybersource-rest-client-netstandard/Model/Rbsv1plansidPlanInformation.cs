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
    /// Rbsv1plansidPlanInformation
    /// </summary>
    [DataContract]
    public partial class Rbsv1plansidPlanInformation :  IEquatable<Rbsv1plansidPlanInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rbsv1plansidPlanInformation" /> class.
        /// </summary>
        /// <param name="Code">Plan code is an optional field, If not provided system generates and assign one .</param>
        /// <param name="Name">Plan name .</param>
        /// <param name="Description">Plan description .</param>
        /// <param name="Status">Updating to &#x60;DRAFT&#x60; is not allowed from &#x60;ACTIVE&#x60; and &#x60;INACTIVE&#x60; status.  Plan Status:  - &#x60;DRAFT&#x60;  - &#x60;ACTIVE&#x60;  - &#x60;INACTIVE&#x60; .</param>
        /// <param name="BillingPeriod">BillingPeriod.</param>
        /// <param name="BillingCycles">BillingCycles.</param>
        public Rbsv1plansidPlanInformation(string Code = default(string), string Name = default(string), string Description = default(string), string Status = default(string), GetAllPlansResponsePlanInformationBillingPeriod BillingPeriod = default(GetAllPlansResponsePlanInformationBillingPeriod), Rbsv1plansPlanInformationBillingCycles BillingCycles = default(Rbsv1plansPlanInformationBillingCycles))
        {
            this.Code = Code;
            this.Name = Name;
            this.Description = Description;
            this.Status = Status;
            this.BillingPeriod = BillingPeriod;
            this.BillingCycles = BillingCycles;
        }
        
        /// <summary>
        /// Plan code is an optional field, If not provided system generates and assign one 
        /// </summary>
        /// <value>Plan code is an optional field, If not provided system generates and assign one </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Plan name 
        /// </summary>
        /// <value>Plan name </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Plan description 
        /// </summary>
        /// <value>Plan description </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Updating to &#x60;DRAFT&#x60; is not allowed from &#x60;ACTIVE&#x60; and &#x60;INACTIVE&#x60; status.  Plan Status:  - &#x60;DRAFT&#x60;  - &#x60;ACTIVE&#x60;  - &#x60;INACTIVE&#x60; 
        /// </summary>
        /// <value>Updating to &#x60;DRAFT&#x60; is not allowed from &#x60;ACTIVE&#x60; and &#x60;INACTIVE&#x60; status.  Plan Status:  - &#x60;DRAFT&#x60;  - &#x60;ACTIVE&#x60;  - &#x60;INACTIVE&#x60; </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
        public GetAllPlansResponsePlanInformationBillingPeriod BillingPeriod { get; set; }

        /// <summary>
        /// Gets or Sets BillingCycles
        /// </summary>
        [DataMember(Name="billingCycles", EmitDefaultValue=false)]
        public Rbsv1plansPlanInformationBillingCycles BillingCycles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Rbsv1plansidPlanInformation {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  BillingCycles: ").Append(BillingCycles).Append("\n");
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
            return this.Equals(obj as Rbsv1plansidPlanInformation);
        }

        /// <summary>
        /// Returns true if Rbsv1plansidPlanInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Rbsv1plansidPlanInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rbsv1plansidPlanInformation other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.BillingPeriod == other.BillingPeriod ||
                    this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(other.BillingPeriod)
                ) && 
                (
                    this.BillingCycles == other.BillingCycles ||
                    this.BillingCycles != null &&
                    this.BillingCycles.Equals(other.BillingCycles)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.BillingPeriod != null)
                    hash = hash * 59 + this.BillingPeriod.GetHashCode();
                if (this.BillingCycles != null)
                    hash = hash * 59 + this.BillingCycles.GetHashCode();
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