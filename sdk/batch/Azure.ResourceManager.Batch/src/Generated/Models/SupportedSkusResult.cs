// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The Batch List supported SKUs operation response. </summary>
    internal partial class SupportedSkusResult
    {
        /// <summary> Initializes a new instance of SupportedSkusResult. </summary>
        /// <param name="value"> The list of SKUs available for the Batch service in the location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SupportedSkusResult(IEnumerable<SupportedSku> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SupportedSkusResult. </summary>
        /// <param name="value"> The list of SKUs available for the Batch service in the location. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal SupportedSkusResult(IReadOnlyList<SupportedSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of SKUs available for the Batch service in the location. </summary>
        public IReadOnlyList<SupportedSku> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
