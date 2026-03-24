using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PartnerDirection
{
    [JsonStringEnumMemberName("shared-by")]
    SharedBy,
    [JsonStringEnumMemberName("shared-with")]
    SharedWith,
}
