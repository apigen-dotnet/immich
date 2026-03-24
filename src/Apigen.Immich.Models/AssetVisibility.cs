using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Asset visibility
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetVisibility
{
    [JsonStringEnumMemberName("archive")]
    Archive,
    [JsonStringEnumMemberName("timeline")]
    Timeline,
    [JsonStringEnumMemberName("hidden")]
    Hidden,
    [JsonStringEnumMemberName("locked")]
    Locked,
}
