// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Account hosting model. </summary>
    public readonly partial struct HostingModel : IEquatable<HostingModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HostingModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HostingModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebValue = "Web";
        private const string ConnectedContainerValue = "ConnectedContainer";
        private const string DisconnectedContainerValue = "DisconnectedContainer";

        /// <summary> Web. </summary>
        public static HostingModel Web { get; } = new HostingModel(WebValue);
        /// <summary> ConnectedContainer. </summary>
        public static HostingModel ConnectedContainer { get; } = new HostingModel(ConnectedContainerValue);
        /// <summary> DisconnectedContainer. </summary>
        public static HostingModel DisconnectedContainer { get; } = new HostingModel(DisconnectedContainerValue);
        /// <summary> Determines if two <see cref="HostingModel"/> values are the same. </summary>
        public static bool operator ==(HostingModel left, HostingModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HostingModel"/> values are not the same. </summary>
        public static bool operator !=(HostingModel left, HostingModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HostingModel"/>. </summary>
        public static implicit operator HostingModel(string value) => new HostingModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HostingModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HostingModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
