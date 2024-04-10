﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.Nodes.CFunction>? _CFunction;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.Nodes.CFunction> CFunction
        {
            get => _CFunction ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.Nodes.CFunction>)Options.GetTypeInfo(typeof(global::c2ffi.Data.Nodes.CFunction));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.Nodes.CFunction> Create_CFunction(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::c2ffi.Data.Nodes.CFunction>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.Nodes.CFunction> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::c2ffi.Data.Nodes.CFunction>
                {
                    ObjectCreator = () => new global::c2ffi.Data.Nodes.CFunction(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => CFunctionPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::c2ffi.Data.Nodes.CFunction>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] CFunctionPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[6];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2ffi.Data.CFunctionCallingConvention>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CFunction),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.Nodes.CFunction)obj).CallingConvention,
                Setter = static (obj, value) => ((global::c2ffi.Data.Nodes.CFunction)obj).CallingConvention = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "CallingConvention",
                JsonPropertyName = "calling_convention"
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2ffi.Data.CFunctionCallingConvention>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2ffi.Data.CType>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CFunction),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.Nodes.CFunction)obj).ReturnType,
                Setter = static (obj, value) => ((global::c2ffi.Data.Nodes.CFunction)obj).ReturnType = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "ReturnType",
                JsonPropertyName = "return_type"
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2ffi.Data.CType>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableArray<global::c2ffi.Data.Nodes.CFunctionParameter>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CFunction),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.Nodes.CFunction)obj).Parameters,
                Setter = static (obj, value) => ((global::c2ffi.Data.Nodes.CFunction)obj).Parameters = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Parameters",
                JsonPropertyName = "parameters"
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableArray<global::c2ffi.Data.Nodes.CFunctionParameter>>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2ffi.Data.CLocation?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CNodeWithLocation),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.Nodes.CNodeWithLocation)obj).Location,
                Setter = static (obj, value) => ((global::c2ffi.Data.Nodes.CNodeWithLocation)obj).Location = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Location",
                JsonPropertyName = "location"
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2ffi.Data.CLocation?>(options, info3);

            var info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CNode),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.Nodes.CNode)obj).Comment,
                Setter = static (obj, value) => ((global::c2ffi.Data.Nodes.CNode)obj).Comment = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Comment",
                JsonPropertyName = "comment"
            };
            
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info4);

            var info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.Nodes.CNode),
                Converter = null,
                Getter = null,
                Setter = null,
                IgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.Always,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Name",
                JsonPropertyName = null
            };
            
            properties[5] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info5);

            return properties;
        }
    }
}
