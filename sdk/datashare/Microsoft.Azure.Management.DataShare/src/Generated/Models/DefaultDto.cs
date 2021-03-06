// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base data transfer object implementation for default resources.
    /// </summary>
    public partial class DefaultDto : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DefaultDto class.
        /// </summary>
        public DefaultDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultDto class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="location">Location of the azure resource.</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="tags">Tags on the azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        public DefaultDto(string id = default(string), string location = default(string), string name = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string type = default(string))
        {
            Id = id;
            Location = location;
            Name = name;
            Tags = tags;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource id of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets location of the azure resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets name of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets tags on the azure resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets type of the azure resource
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
