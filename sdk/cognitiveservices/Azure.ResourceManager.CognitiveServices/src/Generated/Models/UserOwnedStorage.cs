// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The user owned storage for Cognitive Services account. </summary>
    public partial class UserOwnedStorage
    {
        /// <summary> Initializes a new instance of UserOwnedStorage. </summary>
        public UserOwnedStorage()
        {
        }

        /// <summary> Initializes a new instance of UserOwnedStorage. </summary>
        /// <param name="resourceId"> Full resource id of a Microsoft.Storage resource. </param>
        /// <param name="identityClientId"></param>
        internal UserOwnedStorage(string resourceId, string identityClientId)
        {
            ResourceId = resourceId;
            IdentityClientId = identityClientId;
        }

        /// <summary> Full resource id of a Microsoft.Storage resource. </summary>
        public string ResourceId { get; set; }
        /// <summary> Gets or sets the identity client id. </summary>
        public string IdentityClientId { get; set; }
    }
}
