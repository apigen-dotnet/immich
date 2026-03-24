using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetMediaSize
{
    [JsonStringEnumMemberName("original")]
    Original,
    [JsonStringEnumMemberName("fullsize")]
    Fullsize,
    [JsonStringEnumMemberName("preview")]
    Preview,
    [JsonStringEnumMemberName("thumbnail")]
    Thumbnail,
}
