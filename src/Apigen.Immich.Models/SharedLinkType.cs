using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Shared link type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SharedLinkType
{
    [JsonStringEnumMemberName("ALBUM")]
    Album,
    [JsonStringEnumMemberName("INDIVIDUAL")]
    Individual,
}
