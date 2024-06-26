// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

using System.Collections.Immutable;
using c2ffi.Data;
using c2ffi.Data.Nodes;
using c2ffi.Tool.Commands.Extract.Domain.Explore.Context;
using c2ffi.Tool.Commands.Extract.Infrastructure.Clang;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using static bottlenoselabs.clang;

namespace c2ffi.Tool.Commands.Extract.Domain.Explore.NodeExplorers;

[UsedImplicitly]
public sealed class FunctionExplorer(ILogger<FunctionExplorer> logger)
    : NodeExplorer<CFunction>(logger, false)
{
    // NOTE: Function visiting by name.
    //  When a header file contains the declaration of the function, it may later be implemented in the same header
    //  file or another header file. When this happens there will be two function declaration cursors with the same
    //  name even if they have the same type signature (result type and parameter types).
    //  For this reason, do not log if already visited.

    protected override ExploreKindCursors ExpectedCursors { get; } =
        ExploreKindCursors.Is(CXCursorKind.CXCursor_FunctionDecl);

    protected override ExploreKindTypes ExpectedTypes { get; } = ExploreKindTypes.Either(
        CXTypeKind.CXType_FunctionProto, CXTypeKind.CXType_FunctionNoProto);

    protected override bool IsAllowed(ExploreContext context, ExploreNodeInfo info)
    {
        var regexes = context.ParseContext.ExtractInput.IgnoredFunctionRegexes;
        foreach (var regex in regexes)
        {
            if (regex.IsMatch(info.Name))
            {
                return false;
            }
        }

        return true;
    }

    protected override CNode GetNode(ExploreContext context, ExploreNodeInfo info)
    {
        var function = Function(context, info);
        return function;
    }

    private CFunction Function(ExploreContext context, ExploreNodeInfo info)
    {
        var returnType = FunctionReturnType(context, info);
        var parameters = FunctionParameters(context, info);
        var callingConvention = FunctionCallingConvention(info.ClangType);
        var comment = context.Comment(info.ClangCursor);

        var result = new CFunction
        {
            Name = info.Name,
            Location = info.Location,
            ReturnType = returnType,
            Parameters = parameters,
            CallingConvention = callingConvention,
            Comment = comment
        };

        return result;
    }

    private static CFunctionCallingConvention FunctionCallingConvention(CXType type)
    {
        var callingConvention = clang_getFunctionTypeCallingConv(type);
        var result = callingConvention switch
        {
            CXCallingConv.CXCallingConv_C => CFunctionCallingConvention.Cdecl,
            CXCallingConv.CXCallingConv_X86StdCall => CFunctionCallingConvention.StdCall,
            CXCallingConv.CXCallingConv_X86FastCall => CFunctionCallingConvention.FastCall,
            _ => CFunctionCallingConvention.Unknown
        };

        return result;
    }

    private static CType FunctionReturnType(
        ExploreContext context, ExploreNodeInfo parentInfo)
    {
        var resultType = clang_getCursorResultType(parentInfo.ClangCursor);
        return context.VisitType(resultType, parentInfo);
    }

    private ImmutableArray<CFunctionParameter> FunctionParameters(
        ExploreContext context,
        ExploreNodeInfo info)
    {
        var builder = ImmutableArray.CreateBuilder<CFunctionParameter>();

        var count = clang_Cursor_getNumArguments(info.ClangCursor);
        for (uint i = 0; i < count; i++)
        {
            var parameterCursor = clang_Cursor_getArgument(info.ClangCursor, i);
            var functionParameter = FunctionParameter(context, parameterCursor, info);

            builder.Add(functionParameter);
        }

        var result = builder.ToImmutable();
        return result;
    }

    private static CFunctionParameter FunctionParameter(
        ExploreContext context,
        CXCursor parameterCursor,
        ExploreNodeInfo parentInfo)
    {
        var name = parameterCursor.Spelling();
        var parameterType = clang_getCursorType(parameterCursor);

        var parameterTypeInfo = context.VisitType(parameterType, parentInfo);
        var comment = context.Comment(parameterCursor);

        var functionExternParameter = new CFunctionParameter
        {
            Name = name,
            Location = parameterTypeInfo.Location,
            Type = parameterTypeInfo,
            Comment = comment
        };
        return functionExternParameter;
    }
}
