using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Asset sort order
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetOrder
{
    [JsonStringEnumMemberName("asc")]
    Asc,
    [JsonStringEnumMemberName("desc")]
    Desc,
}
