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
    IMAGE,
    [JsonStringEnumMemberName("VIDEO")]
    VIDEO,
    [JsonStringEnumMemberName("AUDIO")]
    AUDIO,
    [JsonStringEnumMemberName("OTHER")]
    OTHER,
}
