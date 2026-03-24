using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MemoryType
{
    [JsonStringEnumMemberName("on_this_day")]
    OnThisDay,
}
