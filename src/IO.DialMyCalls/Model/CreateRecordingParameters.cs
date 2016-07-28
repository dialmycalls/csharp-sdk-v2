/* 
 * DialMyCalls API
 *
 * The DialMyCalls API
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@dialmycalls.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.DialMyCalls.Model
{
    /// <summary>
    /// CreateRecordingParameters
    /// </summary>
    [DataContract]
    public partial class CreateRecordingParameters :  IEquatable<CreateRecordingParameters>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecordingParameters" /> class.
        /// </summary>
        /// <param name="Name">(Required)  The name of the recording..</param>
        /// <param name="Gender">(Required)  Gender of the recording. Options: M or F.</param>
        /// <param name="Language">(Required)  The language of the recording. Options: en, es.</param>
        /// <param name="Text">(Required)  The text to convert to speech..</param>
        public CreateRecordingParameters(string Name = null, string Gender = null, string Language = null, string Text = null)
        {
            this.Name = Name;
            this.Gender = Gender;
            this.Language = Language;
            this.Text = Text;
        }
        
        /// <summary>
        /// (Required)  The name of the recording.
        /// </summary>
        /// <value>(Required)  The name of the recording.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// (Required)  Gender of the recording. Options: M or F
        /// </summary>
        /// <value>(Required)  Gender of the recording. Options: M or F</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// (Required)  The language of the recording. Options: en, es
        /// </summary>
        /// <value>(Required)  The language of the recording. Options: en, es</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// (Required)  The text to convert to speech.
        /// </summary>
        /// <value>(Required)  The text to convert to speech.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRecordingParameters {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as CreateRecordingParameters);
        }

        /// <summary>
        /// Returns true if CreateRecordingParameters instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateRecordingParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRecordingParameters other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                return hash;
            }
        }
    }

}