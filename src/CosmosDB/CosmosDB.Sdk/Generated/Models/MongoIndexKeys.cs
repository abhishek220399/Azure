// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cosmos DB MongoDB collection resource object
    /// </summary>
    public partial class MongoIndexKeys
    {
        /// <summary>
        /// Initializes a new instance of the MongoIndexKeys class.
        /// </summary>
        public MongoIndexKeys()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoIndexKeys class.
        /// </summary>
        /// <param name="keys">List of keys for each MongoDB collection in the
        /// Azure Cosmos DB service</param>
        public MongoIndexKeys(IList<string> keys = default(IList<string>))
        {
            Keys = keys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of keys for each MongoDB collection in the Azure
        /// Cosmos DB service
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public IList<string> Keys { get; set; }

    }
}
