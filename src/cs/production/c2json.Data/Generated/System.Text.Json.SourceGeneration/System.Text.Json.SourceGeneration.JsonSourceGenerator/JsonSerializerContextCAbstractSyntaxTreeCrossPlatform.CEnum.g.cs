﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2json.Data.Serialization
{
    public partial class JsonSerializerContextCAbstractSyntaxTreeCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2json.Data.Nodes.CEnum>? _CEnum;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2json.Data.Nodes.CEnum> CEnum
        {
            get => _CEnum ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2json.Data.Nodes.CEnum>)Options.GetTypeInfo(typeof(global::c2json.Data.Nodes.CEnum));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2json.Data.Nodes.CEnum> Create_CEnum(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::c2json.Data.Nodes.CEnum>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::c2json.Data.Nodes.CEnum> jsonTypeInfo))
            {
                var objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::c2json.Data.Nodes.CEnum>
                {
                    ObjectCreator = () => new global::c2json.Data.Nodes.CEnum(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => CEnumPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::c2json.Data.Nodes.CEnum>(options, objectInfo);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }

        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] CEnumPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            var properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[6];

            var info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2json.Data.CTypeInfo>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CEnum),
                Converter = null,
                Getter = static obj => ((global::c2json.Data.Nodes.CEnum)obj).IntegerTypeInfo,
                Setter = static (obj, value) => ((global::c2json.Data.Nodes.CEnum)obj).IntegerTypeInfo = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "IntegerTypeInfo",
                JsonPropertyName = "type_integer"
            };
            
            properties[0] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2json.Data.CTypeInfo>(options, info0);

            var info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Immutable.ImmutableArray<global::c2json.Data.Nodes.CEnumValue>>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CEnum),
                Converter = null,
                Getter = static obj => ((global::c2json.Data.Nodes.CEnum)obj).Values,
                Setter = static (obj, value) => ((global::c2json.Data.Nodes.CEnum)obj).Values = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Values",
                JsonPropertyName = "values"
            };
            
            properties[1] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Immutable.ImmutableArray<global::c2json.Data.Nodes.CEnumValue>>(options, info1);

            var info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::c2json.Data.CLocation?>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CNodeWithLocation),
                Converter = null,
                Getter = static obj => ((global::c2json.Data.Nodes.CNodeWithLocation)obj).Location,
                Setter = static (obj, value) => ((global::c2json.Data.Nodes.CNodeWithLocation)obj).Location = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Location",
                JsonPropertyName = "location"
            };
            
            properties[2] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::c2json.Data.CLocation?>(options, info2);

            var info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CNode),
                Converter = null,
                Getter = static obj => ((global::c2json.Data.Nodes.CNode)obj).Comment,
                Setter = static (obj, value) => ((global::c2json.Data.Nodes.CNode)obj).Comment = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "Comment",
                JsonPropertyName = "comment"
            };
            
            properties[3] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<string>(options, info3);

            var info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<bool>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CNode),
                Converter = null,
                Getter = static obj => ((global::c2json.Data.Nodes.CNode)obj).IsSystem,
                Setter = static (obj, value) => ((global::c2json.Data.Nodes.CNode)obj).IsSystem = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = null,
                PropertyName = "IsSystem",
                JsonPropertyName = "is_system"
            };
            
            properties[4] = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<bool>(options, info4);

            var info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<string>
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::c2json.Data.Nodes.CNode),
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
