using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Upload status
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetMediaStatus
{
    [JsonStringEnumMemberName("created")]
    Created,
    [JsonStringEnumMemberName("replaced")]
    Replaced,
    [JsonStringEnumMemberName("duplicate")]
    Duplicate,
}
