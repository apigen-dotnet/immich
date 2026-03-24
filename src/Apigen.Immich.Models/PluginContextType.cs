using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Context type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PluginContextType
{
    [JsonStringEnumMemberName("asset")]
    Asset,
    [JsonStringEnumMemberName("album")]
    Album,
    [JsonStringEnumMemberName("person")]
    Person,
}
