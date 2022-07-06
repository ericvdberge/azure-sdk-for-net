// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> A list of server configurations. </summary>
    public partial class ConfigurationListResult
    {
        /// <summary> Initializes a new instance of ConfigurationListResult. </summary>
        public ConfigurationListResult()
        {
            Value = new ChangeTrackingList<ConfigurationData>();
        }

        /// <summary> Initializes a new instance of ConfigurationListResult. </summary>
        /// <param name="value"> The list of server configurations. </param>
        internal ConfigurationListResult(IList<ConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> The list of server configurations. </summary>
        public IList<ConfigurationData> Value { get; }
    }
}
