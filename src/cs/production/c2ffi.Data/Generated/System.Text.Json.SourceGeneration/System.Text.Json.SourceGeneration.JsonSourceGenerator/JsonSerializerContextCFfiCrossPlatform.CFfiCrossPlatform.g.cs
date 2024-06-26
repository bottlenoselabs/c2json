﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiCrossPlatform>? _CFfiCrossPlatform;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiCrossPlatform> CFfiCrossPlatform
        {
            get => _CFfiCrossPlatform ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiCrossPlatform>)Options.GetTypeInfo(typeof(global::c2ffi.Data.CFfiCrossPlatform));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiCrossPlatform> Create_CFfiCrossPlatform(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::c2ffi.Data.CFfiCrossPlatform>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiCrossPlatform> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::c2ffi.Data.CFfiCrossPlatform>
                {
                    ObjectCreator = () => new global::c2ffi.Data.CFfiCrossPlatform(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => CFfiCrossPlatformPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::c2ffi.Data.CFfiCrossPlatform>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] CFfiCrossPlatformPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[9];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableArray<global::c2ffi.Data.TargetPlatform>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Platforms,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Platforms = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Platforms",
                JsonPropertyName = "platforms"
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableArray<global::c2ffi.Data.TargetPlatform>>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CMacroObject>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).MacroObjects,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).MacroObjects = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "MacroObjects",
                JsonPropertyName = "macroObjects"
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CMacroObject>>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CVariable>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Variables,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Variables = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Variables",
                JsonPropertyName = "variables"
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CVariable>>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunction>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Functions,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Functions = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Functions",
                JsonPropertyName = "functions"
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunction>>(options, info3);

            var info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CRecord>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Records,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Records = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Records",
                JsonPropertyName = "records"
            };
            
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CRecord>>(options, info4);

            var info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CEnum>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Enums,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).Enums = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Enums",
                JsonPropertyName = "enums"
            };
            
            properties[5] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CEnum>>(options, info5);

            var info6 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).TypeAliases,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).TypeAliases = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "TypeAliases",
                JsonPropertyName = "typeAliases"
            };
            
            properties[6] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>(options, info6);

            var info7 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.COpaqueType>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).OpaqueTypes,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).OpaqueTypes = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "OpaqueTypes",
                JsonPropertyName = "opaqueTypes"
            };
            
            properties[7] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.COpaqueType>>(options, info7);

            var info8 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunctionPointer>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiCrossPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiCrossPlatform)obj).FunctionPointers,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiCrossPlatform)obj).FunctionPointers = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "FunctionPointers",
                JsonPropertyName = "functionPointers"
            };
            
            properties[8] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunctionPointer>>(options, info8);

            return properties;
        }
    }
}
