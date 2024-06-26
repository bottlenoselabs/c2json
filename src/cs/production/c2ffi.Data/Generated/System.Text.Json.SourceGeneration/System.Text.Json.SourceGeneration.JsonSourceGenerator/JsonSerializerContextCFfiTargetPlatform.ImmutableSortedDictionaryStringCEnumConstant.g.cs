﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiTargetPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>>? _ImmutableSortedDictionaryStringCEnumConstant;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>> ImmutableSortedDictionaryStringCEnumConstant
        {
            get => _ImmutableSortedDictionaryStringCEnumConstant ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>> Create_ImmutableSortedDictionaryStringCEnumConstant(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, CEnumConstant>, string, CEnumConstant>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableSortedDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}
