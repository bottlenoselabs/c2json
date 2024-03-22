﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2json.Data.Serialization
{
    public partial class JsonSerializerContextCFfiCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>>? _ImmutableDictionaryStringCMacroObject;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>> ImmutableDictionaryStringCMacroObject
        {
            get => _ImmutableDictionaryStringCMacroObject ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>>)Options.GetTypeInfo(typeof(global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>> Create_ImmutableDictionaryStringCMacroObject(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>> jsonTypeInfo))
            {
                var info = new global::System.Text.Json.Serialization.Metadata.JsonCollectionInfoValues<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>>
                {
                    ObjectCreator = null,
                    SerializeHandler = null
                };
                
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateImmutableDictionaryInfo<global::System.Collections.Immutable.ImmutableDictionary<string, global::c2json.Data.Nodes.CMacroObject>, string, global::c2json.Data.Nodes.CMacroObject>(options, info, createRangeFunc: global::System.Collections.Immutable.ImmutableDictionary.CreateRange);
                jsonTypeInfo.NumberHandling = null;
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}