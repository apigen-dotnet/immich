using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Colorspace
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Colorspace
{
    [JsonStringEnumMemberName("srgb")]
    Srgb,
    [JsonStringEnumMemberName("p3")]
    P3,
}
