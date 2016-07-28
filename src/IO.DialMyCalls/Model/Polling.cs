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
    /// Polling
    /// </summary>
    [DataContract]
    public partial class Polling :  IEquatable<Polling>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Polling" /> class.
        /// </summary>
        /// <param name="Type">The add-on type. Option: polling.</param>
        /// <param name="Options">A list of polling options..</param>
        /// <param name="AddMessage">Add a generic add-on message..</param>
        public Polling(string Type = null, string Options = null, Object AddMessage = null)
        {
            this.Type = Type;
            this.Options = Options;
            this.AddMessage = AddMessage;
        }
        
        /// <summary>
        /// The add-on type. Option: polling
        /// </summary>
        /// <value>The add-on type. Option: polling</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// A list of polling options.
        /// </summary>
        /// <value>A list of polling options.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public string Options { get; set; }
        /// <summary>
        /// Add a generic add-on message.
        /// </summary>
        /// <value>Add a generic add-on message.</value>
        [DataMember(Name="add_message", EmitDefaultValue=false)]
        public Object AddMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Polling {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  AddMessage: ").Append(AddMessage).Append("\n");
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
            return this.Equals(obj as Polling);
        }

        /// <summary>
        /// Returns true if Polling instances are equal
        /// </summary>
        /// <param name="other">Instance of Polling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Polling other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.AddMessage == other.AddMessage ||
                    this.AddMessage != null &&
                    this.AddMessage.Equals(other.AddMessage)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.AddMessage != null)
                    hash = hash * 59 + this.AddMessage.GetHashCode();
                return hash;
            }
        }
    }

}