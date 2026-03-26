using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Asset type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetTypeEnum
{
    [JsonStringEnumMemberName("IMAGE")]
    Image,
    [JsonStringEnumMemberName("VIDEO")]
    Video,
    [JsonStringEnumMemberName("AUDIO")]
    Audio,
    [JsonStringEnumMemberName("OTHER")]
    Other,
}
