﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>? _ImmutableSortedDictionaryStringCTypeAlias;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>> ImmutableSortedDictionaryStringCTypeAlias
        {
            get => _ImmutableSortedDictionaryStringCTypeAlias ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>> Create_ImmutableSortedDictionaryStringCTypeAlias(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableSortedDictionary<string, global::c2ffi.Data.Nodes.CTypeAlias>, string, global::c2ffi.Data.Nodes.CTypeAlias>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableSortedDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}
