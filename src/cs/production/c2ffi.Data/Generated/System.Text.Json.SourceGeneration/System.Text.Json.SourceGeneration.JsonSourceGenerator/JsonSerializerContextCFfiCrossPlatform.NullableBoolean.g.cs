﻿// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0612, CS0618

namespace c2ffi.Data.Serialization
{
    public partial class JsonSerializerContextCFfiCrossPlatform
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool?>? _NullableBoolean;
        
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool?> NullableBoolean
        {
            get => _NullableBoolean ??= (global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool?>)Options.GetTypeInfo(typeof(bool?));
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool?> Create_NullableBoolean(global::System.Text.Json.JsonSerializerOptions options)
        {
            if (!TryGetTypeInfoForRuntimeCustomConverter<bool?>(options, out global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool?> jsonTypeInfo))
            {
                global::System.Text.Json.Serialization.JsonConverter converter = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.GetNullableConverter<bool>(options);
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<bool?>(options, converter);
            }
        
            jsonTypeInfo.OriginatingResolver = this;
            return jsonTypeInfo;
        }
    }
}