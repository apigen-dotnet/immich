using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Tone mapping
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ToneMapping
{
    [JsonStringEnumMemberName("hable")]
    Hable,
    [JsonStringEnumMemberName("mobius")]
    Mobius,
    [JsonStringEnumMemberName("reinhard")]
    Reinhard,
    [JsonStringEnumMemberName("disabled")]
    Disabled,
}
