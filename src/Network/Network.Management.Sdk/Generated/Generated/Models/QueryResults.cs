// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query result
    /// </summary>
    public partial class QueryResults
    {
        /// <summary>
        /// Initializes a new instance of the QueryResults class.
        /// </summary>
        public QueryResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryResults class.
        /// </summary>
        /// <param name="matchingRecordsCount">Number of total records matching
        /// the query.</param>
        /// <param name="signatures">Array containing the results of the
        /// query</param>
        public QueryResults(long? matchingRecordsCount = default(long?), IList<SingleQueryResult> signatures = default(IList<SingleQueryResult>))
        {
            MatchingRecordsCount = matchingRecordsCount;
            Signatures = signatures;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of total records matching the query.
        /// </summary>
        [JsonProperty(PropertyName = "matchingRecordsCount")]
        public long? MatchingRecordsCount { get; set; }

        /// <summary>
        /// Gets or sets array containing the results of the query
        /// </summary>
        [JsonProperty(PropertyName = "signatures")]
        public IList<SingleQueryResult> Signatures { get; set; }

    }
}
