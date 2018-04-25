/* 
 * OpenHack
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Question for the Trivia API
    /// </summary>
    [DataContract]
    public partial class QuestionModel :  IEquatable<QuestionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionModel" /> class.
        /// </summary>
        /// <param name="Id">Question Id.</param>
        /// <param name="Text">Question text.</param>
        /// <param name="QuestionOptions">Possible answers for the question.</param>
        public QuestionModel(int? Id = default(int?), string Text = default(string), List<QuestionOptionModel> QuestionOptions = default(List<QuestionOptionModel>))
        {
            this.Id = Id;
            this.Text = Text;
            this.QuestionOptions = QuestionOptions;
        }
        
        /// <summary>
        /// Question Id
        /// </summary>
        /// <value>Question Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Question text
        /// </summary>
        /// <value>Question text</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Possible answers for the question
        /// </summary>
        /// <value>Possible answers for the question</value>
        [DataMember(Name="questionOptions", EmitDefaultValue=false)]
        public List<QuestionOptionModel> QuestionOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuestionModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  QuestionOptions: ").Append(QuestionOptions).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuestionModel);
        }

        /// <summary>
        /// Returns true if QuestionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of QuestionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuestionModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.QuestionOptions == input.QuestionOptions ||
                    this.QuestionOptions != null &&
                    this.QuestionOptions.SequenceEqual(input.QuestionOptions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.QuestionOptions != null)
                    hashCode = hashCode * 59 + this.QuestionOptions.GetHashCode();
                return hashCode;
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
