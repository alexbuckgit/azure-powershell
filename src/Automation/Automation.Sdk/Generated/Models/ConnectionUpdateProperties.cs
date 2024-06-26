// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The properties of the update connection operation.
    /// </summary>
    public partial class ConnectionUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionUpdateProperties class.
        /// </summary>
        public ConnectionUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionUpdateProperties class.
        /// </summary>

        /// <param name="description">Gets or sets the description of the connection.
        /// </param>

        /// <param name="fieldDefinitionValues">Gets or sets the field definition values of the connection.
        /// </param>
        public ConnectionUpdateProperties(string description = default(string), System.Collections.Generic.IDictionary<string, string> fieldDefinitionValues = default(System.Collections.Generic.IDictionary<string, string>))

        {
            this.Description = description;
            this.FieldDefinitionValues = fieldDefinitionValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the description of the connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the field definition values of the connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fieldDefinitionValues")]
        public System.Collections.Generic.IDictionary<string, string> FieldDefinitionValues {get; set; }
    }
}