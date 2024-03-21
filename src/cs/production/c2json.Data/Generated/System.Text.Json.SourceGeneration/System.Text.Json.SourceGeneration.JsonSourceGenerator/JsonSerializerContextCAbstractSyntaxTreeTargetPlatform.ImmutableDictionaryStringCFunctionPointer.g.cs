﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2json.Data.Serialization
{
    public partial class JsonSerializerContextCAbstractSyntaxTreeTargetPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>>? _ImmutableDictionaryStringCFunctionPointer;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>> ImmutableDictionaryStringCFunctionPointer
        {
            get => _ImmutableDictionaryStringCFunctionPointer ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>> Create_ImmutableDictionaryStringCFunctionPointer(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CFunctionPointer>, string, global::c2json.Data.Nodes.CFunctionPointer>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}
