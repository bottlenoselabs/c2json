﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiTargetPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiTargetPlatform>? _CFfiTargetPlatform;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiTargetPlatform> CFfiTargetPlatform
        {
            get => _CFfiTargetPlatform ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiTargetPlatform>)Options.GetTypeInfo(typeof(global::c2ffi.Data.CFfiTargetPlatform));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiTargetPlatform> Create_CFfiTargetPlatform(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::c2ffi.Data.CFfiTargetPlatform>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2ffi.Data.CFfiTargetPlatform> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::c2ffi.Data.CFfiTargetPlatform>
                {
                    ObjectCreator = () => new global::c2ffi.Data.CFfiTargetPlatform(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => CFfiTargetPlatformPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::c2ffi.Data.CFfiTargetPlatform>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] CFfiTargetPlatformPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[14];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).FileName,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).FileName = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "FileName",
                JsonPropertyName = "fileName"
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2ffi.Data.TargetPlatform>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PlatformRequested,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PlatformRequested = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "PlatformRequested",
                JsonPropertyName = "platformRequested"
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2ffi.Data.TargetPlatform>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2ffi.Data.TargetPlatform>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PlatformActual,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PlatformActual = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "PlatformActual",
                JsonPropertyName = "platformActual"
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2ffi.Data.TargetPlatform>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableArray<string>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).SystemIncludeDirectories,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).SystemIncludeDirectories = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "SystemIncludeDirectories",
                JsonPropertyName = "systemIncludeDirectories"
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableArray<string>>(options, info3);

            var info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableArray<string>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).UserIncludeDirectories,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).UserIncludeDirectories = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "UserIncludeDirectories",
                JsonPropertyName = "userIncludeDirectories"
            };
            
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableArray<string>>(options, info4);

            var info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<int>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PointerSize,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).PointerSize = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "PointerSize",
                JsonPropertyName = "pointerSize"
            };
            
            properties[5] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<int>(options, info5);

            var info6 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CMacroObject>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).MacroObjects,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).MacroObjects = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "MacroObjects",
                JsonPropertyName = "macroObjects"
            };
            
            properties[6] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CMacroObject>>(options, info6);

            var info7 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CVariable>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Variables,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Variables = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Variables",
                JsonPropertyName = "variables"
            };
            
            properties[7] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CVariable>>(options, info7);

            var info8 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunction>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Functions,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Functions = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Functions",
                JsonPropertyName = "functions"
            };
            
            properties[8] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunction>>(options, info8);

            var info9 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CRecord>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Records,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Records = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Records",
                JsonPropertyName = "records"
            };
            
            properties[9] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CRecord>>(options, info9);

            var info10 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CEnum>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Enums,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).Enums = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Enums",
                JsonPropertyName = "enums"
            };
            
            properties[10] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CEnum>>(options, info10);

            var info11 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).TypeAliases,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).TypeAliases = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "TypeAliases",
                JsonPropertyName = "typeAliases"
            };
            
            properties[11] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>(options, info11);

            var info12 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.COpaqueType>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).OpaqueTypes,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).OpaqueTypes = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "OpaqueTypes",
                JsonPropertyName = "opaqueTypes"
            };
            
            properties[12] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.COpaqueType>>(options, info12);

            var info13 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunctionPointer>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2ffi.Data.CFfiTargetPlatform),
                Converter = null,
                Getter = static obj => ((global::c2ffi.Data.CFfiTargetPlatform)obj).FunctionPointers,
                Setter = static (obj, value) => ((global::c2ffi.Data.CFfiTargetPlatform)obj).FunctionPointers = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "FunctionPointers",
                JsonPropertyName = "functionPointers"
            };
            
            properties[13] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CFunctionPointer>>(options, info13);

            return properties;
        }
    }
}
