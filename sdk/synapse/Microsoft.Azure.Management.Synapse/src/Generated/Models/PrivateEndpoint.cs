// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Private endpoint details
    /// </summary>
    public partial class PrivateEndpoint : IResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        public PrivateEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        /// <param name="id">Resource id of the private endpoint.</param>
        public PrivateEndpoint(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource id of the private endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

    }
}
