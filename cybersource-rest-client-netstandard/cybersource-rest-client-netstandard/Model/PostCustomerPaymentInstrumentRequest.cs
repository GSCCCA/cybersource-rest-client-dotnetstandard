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
    /// PostCustomerPaymentInstrumentRequest
    /// </summary>
    [DataContract]
    public partial class PostCustomerPaymentInstrumentRequest :  IEquatable<PostCustomerPaymentInstrumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomerPaymentInstrumentRequest" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The Id of the Payment Instrument Token..</param>
        /// <param name="_Default">Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default. .</param>
        /// <param name="BankAccount">BankAccount.</param>
        /// <param name="Card">Card.</param>
        /// <param name="BuyerInformation">BuyerInformation.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="ProcessingInformation">ProcessingInformation.</param>
        /// <param name="MerchantInformation">MerchantInformation.</param>
        /// <param name="InstrumentIdentifier">InstrumentIdentifier.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="Embedded">Embedded.</param>
        public PostCustomerPaymentInstrumentRequest(Tmsv2customersEmbeddedDefaultPaymentInstrumentLinks Links = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentLinks), string Id = default(string), bool? _Default = default(bool?), Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount BankAccount = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount), Tmsv2customersEmbeddedDefaultPaymentInstrumentCard Card = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentCard), Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformation BuyerInformation = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformation), Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo BillTo = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo), Tmsv2customersEmbeddedDefaultPaymentInstrumentProcessingInformation ProcessingInformation = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentProcessingInformation), Tmsv2customersEmbeddedDefaultPaymentInstrumentMerchantInformation MerchantInformation = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentMerchantInformation), Tmsv2customersEmbeddedDefaultPaymentInstrumentInstrumentIdentifier InstrumentIdentifier = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentInstrumentIdentifier), Tmsv2customersEmbeddedDefaultPaymentInstrumentMetadata Metadata = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentMetadata), Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbedded Embedded = default(Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbedded))
        {
            this.Links = Links;
            this.Id = Id;
            this._Default = _Default;
            this.BankAccount = BankAccount;
            this.Card = Card;
            this.BuyerInformation = BuyerInformation;
            this.BillTo = BillTo;
            this.ProcessingInformation = ProcessingInformation;
            this.MerchantInformation = MerchantInformation;
            this.InstrumentIdentifier = InstrumentIdentifier;
            this.Metadata = Metadata;
            this.Embedded = Embedded;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentLinks Links { get; set; }

        /// <summary>
        /// The Id of the Payment Instrument Token.
        /// </summary>
        /// <value>The Id of the Payment Instrument Token.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The type.  Possible Values: - paymentInstrument 
        /// </summary>
        /// <value>The type.  Possible Values: - paymentInstrument </value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string _Object { get; private set; }

        /// <summary>
        /// Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default. 
        /// </summary>
        /// <value>Flag that indicates whether customer payment instrument is the dafault. Possible Values:  - &#x60;true&#x60;: Payment instrument is customer&#39;s default.  - &#x60;false&#x60;: Payment instrument is not customer&#39;s default. </value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }

        /// <summary>
        /// Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed. 
        /// </summary>
        /// <value>Issuers state for the card number. Possible Values: - ACTIVE - CLOSED : The account has been closed. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// The type of Payment Instrument. Possible Values: - cardHash 
        /// </summary>
        /// <value>The type of Payment Instrument. Possible Values: - cardHash </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bankAccount", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentBankAccount BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentCard Card { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInformation
        /// </summary>
        [DataMember(Name="buyerInformation", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentBuyerInformation BuyerInformation { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets ProcessingInformation
        /// </summary>
        [DataMember(Name="processingInformation", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentProcessingInformation ProcessingInformation { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInformation
        /// </summary>
        [DataMember(Name="merchantInformation", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentMerchantInformation MerchantInformation { get; set; }

        /// <summary>
        /// Gets or Sets InstrumentIdentifier
        /// </summary>
        [DataMember(Name="instrumentIdentifier", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentInstrumentIdentifier InstrumentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name="_embedded", EmitDefaultValue=false)]
        public Tmsv2customersEmbeddedDefaultPaymentInstrumentEmbedded Embedded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostCustomerPaymentInstrumentRequest {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  BuyerInformation: ").Append(BuyerInformation).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  ProcessingInformation: ").Append(ProcessingInformation).Append("\n");
            sb.Append("  MerchantInformation: ").Append(MerchantInformation).Append("\n");
            sb.Append("  InstrumentIdentifier: ").Append(InstrumentIdentifier).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
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
            return this.Equals(obj as PostCustomerPaymentInstrumentRequest);
        }

        /// <summary>
        /// Returns true if PostCustomerPaymentInstrumentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PostCustomerPaymentInstrumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostCustomerPaymentInstrumentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.BankAccount == other.BankAccount ||
                    this.BankAccount != null &&
                    this.BankAccount.Equals(other.BankAccount)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.BuyerInformation == other.BuyerInformation ||
                    this.BuyerInformation != null &&
                    this.BuyerInformation.Equals(other.BuyerInformation)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.ProcessingInformation == other.ProcessingInformation ||
                    this.ProcessingInformation != null &&
                    this.ProcessingInformation.Equals(other.ProcessingInformation)
                ) && 
                (
                    this.MerchantInformation == other.MerchantInformation ||
                    this.MerchantInformation != null &&
                    this.MerchantInformation.Equals(other.MerchantInformation)
                ) && 
                (
                    this.InstrumentIdentifier == other.InstrumentIdentifier ||
                    this.InstrumentIdentifier != null &&
                    this.InstrumentIdentifier.Equals(other.InstrumentIdentifier)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Embedded == other.Embedded ||
                    this.Embedded != null &&
                    this.Embedded.Equals(other.Embedded)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.BankAccount != null)
                    hash = hash * 59 + this.BankAccount.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.BuyerInformation != null)
                    hash = hash * 59 + this.BuyerInformation.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.ProcessingInformation != null)
                    hash = hash * 59 + this.ProcessingInformation.GetHashCode();
                if (this.MerchantInformation != null)
                    hash = hash * 59 + this.MerchantInformation.GetHashCode();
                if (this.InstrumentIdentifier != null)
                    hash = hash * 59 + this.InstrumentIdentifier.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Embedded != null)
                    hash = hash * 59 + this.Embedded.GetHashCode();
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
