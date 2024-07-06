// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Microsoft.PowerBI.Api.Models
{
    /// <summary> The current state of the export to file job. </summary>
    public readonly partial struct ExportStatus : IEquatable<ExportStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ExportStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExportStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UndefinedValue = "Undefined";
        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";

        /// <summary> Undefined. </summary>
        public static ExportStatus Undefined { get; } = new ExportStatus(UndefinedValue);
        /// <summary> NotStarted. </summary>
        public static ExportStatus NotStarted { get; } = new ExportStatus(NotStartedValue);
        /// <summary> Running. </summary>
        public static ExportStatus Running { get; } = new ExportStatus(RunningValue);
        /// <summary> Succeeded. </summary>
        public static ExportStatus Succeeded { get; } = new ExportStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static ExportStatus Failed { get; } = new ExportStatus(FailedValue);
        /// <summary> Determines if two <see cref="ExportStatus"/> values are the same. </summary>
        public static bool operator ==(ExportStatus left, ExportStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExportStatus"/> values are not the same. </summary>
        public static bool operator !=(ExportStatus left, ExportStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExportStatus"/>. </summary>
        public static implicit operator ExportStatus(string value) => new ExportStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExportStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExportStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}