// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> SQL Server Management type. </summary>
    public readonly partial struct SqlManagementMode : IEquatable<SqlManagementMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlManagementMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlManagementMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FullValue = "Full";
        private const string LightWeightValue = "LightWeight";
        private const string NoAgentValue = "NoAgent";

        /// <summary> Full. </summary>
        public static SqlManagementMode Full { get; } = new SqlManagementMode(FullValue);
        /// <summary> LightWeight. </summary>
        public static SqlManagementMode LightWeight { get; } = new SqlManagementMode(LightWeightValue);
        /// <summary> NoAgent. </summary>
        public static SqlManagementMode NoAgent { get; } = new SqlManagementMode(NoAgentValue);
        /// <summary> Determines if two <see cref="SqlManagementMode"/> values are the same. </summary>
        public static bool operator ==(SqlManagementMode left, SqlManagementMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlManagementMode"/> values are not the same. </summary>
        public static bool operator !=(SqlManagementMode left, SqlManagementMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SqlManagementMode"/>. </summary>
        public static implicit operator SqlManagementMode(string value) => new SqlManagementMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlManagementMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlManagementMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
