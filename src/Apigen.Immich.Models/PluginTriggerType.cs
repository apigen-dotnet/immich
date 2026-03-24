using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Trigger type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PluginTriggerType
{
    [JsonStringEnumMemberName("AssetCreate")]
    AssetCreate,
    [JsonStringEnumMemberName("PersonRecognized")]
    PersonRecognized,
}
