using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReactionType
{
    [JsonStringEnumMemberName("comment")]
    Comment,
    [JsonStringEnumMemberName("like")]
    Like,
}
