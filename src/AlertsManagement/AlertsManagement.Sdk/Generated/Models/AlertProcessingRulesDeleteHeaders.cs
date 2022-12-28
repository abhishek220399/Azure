// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class AlertProcessingRulesDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the AlertProcessingRulesDeleteHeaders
        /// class.
        /// </summary>
        public AlertProcessingRulesDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertProcessingRulesDeleteHeaders
        /// class.
        /// </summary>
        /// <param name="xMsRequestId">Service generated Request ID.</param>
        public AlertProcessingRulesDeleteHeaders(string xMsRequestId = default(string))
        {
            XMsRequestId = xMsRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets service generated Request ID.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public string XMsRequestId { get; set; }

    }
}
