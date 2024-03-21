﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2json.Data.Serialization
{
    public partial class JsonSerializerContextCAbstractSyntaxTreeTargetPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>>? _ImmutableDictionaryStringCVariable;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>> ImmutableDictionaryStringCVariable
        {
            get => _ImmutableDictionaryStringCVariable ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>> Create_ImmutableDictionaryStringCVariable(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CVariable>, string, global::c2json.Data.Nodes.CVariable>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}
