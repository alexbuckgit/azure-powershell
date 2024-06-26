// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// VirtualHubRouteTableV2 route.
    /// </summary>
    public partial class VirtualHubRouteV2
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHubRouteV2 class.
        /// </summary>
        public VirtualHubRouteV2()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualHubRouteV2 class.
        /// </summary>

        /// <param name="destinationType">The type of destinations.
        /// </param>

        /// <param name="destinations">List of all destinations.
        /// </param>

        /// <param name="nextHopType">The type of next hops.
        /// </param>

        /// <param name="nextHops">NextHops ip address.
        /// </param>
        public VirtualHubRouteV2(string destinationType = default(string), System.Collections.Generic.IList<string> destinations = default(System.Collections.Generic.IList<string>), string nextHopType = default(string), System.Collections.Generic.IList<string> nextHops = default(System.Collections.Generic.IList<string>))

        {
            this.DestinationType = destinationType;
            this.Destinations = destinations;
            this.NextHopType = nextHopType;
            this.NextHops = nextHops;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the type of destinations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinationType")]
        public string DestinationType {get; set; }

        /// <summary>
        /// Gets or sets list of all destinations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "destinations")]
        public System.Collections.Generic.IList<string> Destinations {get; set; }

        /// <summary>
        /// Gets or sets the type of next hops.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHopType")]
        public string NextHopType {get; set; }

        /// <summary>
        /// Gets or sets nextHops ip address.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextHops")]
        public System.Collections.Generic.IList<string> NextHops {get; set; }
    }
}