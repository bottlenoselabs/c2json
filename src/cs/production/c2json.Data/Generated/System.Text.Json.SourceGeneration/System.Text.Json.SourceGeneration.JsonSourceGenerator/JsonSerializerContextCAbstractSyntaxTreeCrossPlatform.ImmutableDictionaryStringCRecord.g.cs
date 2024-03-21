﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2json.Data.Serialization
{
    public partial class JsonSerializerContextCAbstractSyntaxTreeCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>>? _ImmutableDictionaryStringCRecord;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>> ImmutableDictionaryStringCRecord
        {
            get => _ImmutableDictionaryStringCRecord ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>> Create_ImmutableDictionaryStringCRecord(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CRecord>, string, global::c2json.Data.Nodes.CRecord>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}
