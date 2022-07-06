// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Input to get wait statistics. </summary>
    public partial class WaitStatisticsInput
    {
        /// <summary> Initializes a new instance of WaitStatisticsInput. </summary>
        /// <param name="observationStartOn"> Observation start time. </param>
        /// <param name="observationEndOn"> Observation end time. </param>
        /// <param name="aggregationWindow"> Aggregation interval type in ISO 8601 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregationWindow"/> is null. </exception>
        public WaitStatisticsInput(DateTimeOffset observationStartOn, DateTimeOffset observationEndOn, string aggregationWindow)
        {
            if (aggregationWindow == null)
            {
                throw new ArgumentNullException(nameof(aggregationWindow));
            }

            ObservationStartOn = observationStartOn;
            ObservationEndOn = observationEndOn;
            AggregationWindow = aggregationWindow;
        }

        /// <summary> Observation start time. </summary>
        public DateTimeOffset ObservationStartOn { get; }
        /// <summary> Observation end time. </summary>
        public DateTimeOffset ObservationEndOn { get; }
        /// <summary> Aggregation interval type in ISO 8601 format. </summary>
        public string AggregationWindow { get; }
    }
}
