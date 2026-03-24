using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MemorySearchOrder
{
    [JsonStringEnumMemberName("asc")]
    Asc,
    [JsonStringEnumMemberName("desc")]
    Desc,
    [JsonStringEnumMemberName("random")]
    Random,
}
