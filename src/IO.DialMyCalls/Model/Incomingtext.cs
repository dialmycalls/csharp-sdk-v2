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
    /// Incomingtext
    /// </summary>
    [DataContract]
    public partial class Incomingtext :  IEquatable<Incomingtext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Incomingtext" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for this text..</param>
        /// <param name="FromNumber">The phone number the text message was sent from..</param>
        /// <param name="ToNumber">The phone number the text message was sent to..</param>
        /// <param name="Message">The text message that was sent.  This data is URL encoded..</param>
        /// <param name="CreatedAt">When the text message was created..</param>
        /// <param name="UpdatedAt">When the text message was last updated..</param>
        public Incomingtext(Guid? Id = null, string FromNumber = null, string ToNumber = null, string Message = null, string CreatedAt = null, string UpdatedAt = null)
        {
            this.Id = Id;
            this.FromNumber = FromNumber;
            this.ToNumber = ToNumber;
            this.Message = Message;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// Unique identifier for this text.
        /// </summary>
        /// <value>Unique identifier for this text.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// The phone number the text message was sent from.
        /// </summary>
        /// <value>The phone number the text message was sent from.</value>
        [DataMember(Name="from_number", EmitDefaultValue=false)]
        public string FromNumber { get; set; }
        /// <summary>
        /// The phone number the text message was sent to.
        /// </summary>
        /// <value>The phone number the text message was sent to.</value>
        [DataMember(Name="to_number", EmitDefaultValue=false)]
        public string ToNumber { get; set; }
        /// <summary>
        /// The text message that was sent.  This data is URL encoded.
        /// </summary>
        /// <value>The text message that was sent.  This data is URL encoded.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// When the text message was created.
        /// </summary>
        /// <value>When the text message was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// When the text message was last updated.
        /// </summary>
        /// <value>When the text message was last updated.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Incomingtext {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  ToNumber: ").Append(ToNumber).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as Incomingtext);
        }

        /// <summary>
        /// Returns true if Incomingtext instances are equal
        /// </summary>
        /// <param name="other">Instance of Incomingtext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Incomingtext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.FromNumber == other.FromNumber ||
                    this.FromNumber != null &&
                    this.FromNumber.Equals(other.FromNumber)
                ) && 
                (
                    this.ToNumber == other.ToNumber ||
                    this.ToNumber != null &&
                    this.ToNumber.Equals(other.ToNumber)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.FromNumber != null)
                    hash = hash * 59 + this.FromNumber.GetHashCode();
                if (this.ToNumber != null)
                    hash = hash * 59 + this.ToNumber.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }
    }

}
