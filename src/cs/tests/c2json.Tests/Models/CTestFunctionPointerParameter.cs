// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace c2json.Tests.Models;

[PublicAPI]
public class CTestFunctionPointerParameter
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("type_name")]
    public string TypeName { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }
}
