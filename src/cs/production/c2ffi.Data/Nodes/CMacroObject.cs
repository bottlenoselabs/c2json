// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace c2ffi.Data.Nodes;

// NOTE: Properties are required for System.Text.Json serialization

/// <summary>
///     Represents a macro object in a C foreign function interface.
/// </summary>
[PublicAPI]
public class CMacroObject : CNodeWithLocation
{
    /// <summary>
    ///     Gets or sets the type information.
    /// </summary>
    [JsonPropertyName("type")]
    public CType Type { get; set; } = null!;

    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;

    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public override string ToString()
    {
        return $"{nameof(CMacroObject)} '{Name}' : {Value} @ {Location}";
    }

    /// <inheritdoc />
    public override bool Equals(CNode? other)
    {
        if (!base.Equals(other) || other is not CMacroObject other2)
        {
            return false;
        }

        return Type.Equals(other2.Type) && Value == other2.Value;
    }

    public bool EqualsWithoutValue(CMacroObject other)
    {
        if (!base.Equals(other))
        {
            return false;
        }

        return Type.Equals(other.Type);
    }

    /// <inheritdoc />
    public override int GetHashCode()
    {
        var baseHashCode = base.GetHashCode();

        var hashCode = default(HashCode);
        hashCode.Add(baseHashCode);

        // ReSharper disable NonReadonlyMemberInGetHashCode
        hashCode.Add(Type);
        hashCode.Add(Value);

        // ReSharper restore NonReadonlyMemberInGetHashCode

        return hashCode.ToHashCode();
    }
}
