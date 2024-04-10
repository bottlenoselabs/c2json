// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using c2ffi.Tests.Library.Models;
using FluentAssertions;

#pragma warning disable CA1707

namespace c2ffi.Tests.EndToEnd.Extract.Unions.union_int_int;

public class Test : ExtractFfiTest
{
    private const string UnionName = "union_int_int";

    [Fact]
    public void Union()
    {
        var ffis = GetTargetPlatformFfis(
            $"src/c/tests/unions/{UnionName}/config.json");
        Assert.True(ffis.Length > 0);

        foreach (var ffi in ffis)
        {
            UnionExists(ffi);
        }
    }

    private void UnionExists(CTestFfiTargetPlatform ffi)
    {
        const string name = $"union {UnionName}";
        var record = ffi.GetRecord(name);
        record.Name.Should().Be(name);
        record.IsStruct.Should().Be(false);
        record.IsUnion.Should().Be(true);

        record.Fields.Length.Should().Be(2);

        var field1 = record.Fields[0];
        field1.Name.Should().Be("a");
        field1.OffsetOf.Should().Be(0);
        field1.Type.Name.Should().Be("int");
        field1.Type.SizeOf.Should().Be(4);
        field1.Type.AlignOf.Should().Be(4);
        field1.Type.InnerType.Should().BeNull();

        var field2 = record.Fields[1];
        field2.Name.Should().Be("b");
        field2.OffsetOf.Should().Be(0);
        field2.Type.Name.Should().Be("int");
        field2.Type.SizeOf.Should().Be(4);
        field2.Type.AlignOf.Should().Be(4);
        field2.Type.InnerType.Should().BeNull();
    }
}
