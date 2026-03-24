using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReactionLevel
{
    [JsonStringEnumMemberName("album")]
    Album,
    [JsonStringEnumMemberName("asset")]
    Asset,
}
