// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using c2json.Tests.Models;

#pragma warning disable CA1707

namespace c2json.Tests.EndToEnd.Functions.function_int;

public class Test : AbstractSyntaxTreeTest
{
    private const string FunctionName = "function_int";

    [Fact]
    public void FunctionExists()
    {
        var asts = GetAbstractSyntaxTrees(
            $"src/c/tests/functions/{FunctionName}/config.json");
        Assert.True(asts.Length > 0);

        foreach (var ast in asts)
        {
            AstFunctionExists(ast);
        }
    }

    private void AstFunctionExists(CTestAbstractSyntaxTree ast)
    {
        var function = ast.GetFunction(FunctionName);
        Assert.True(function.CallingConvention == "cdecl");
        Assert.True(function.ReturnTypeName == "int");

        Assert.True(function.Parameters.IsDefaultOrEmpty);
    }
}
