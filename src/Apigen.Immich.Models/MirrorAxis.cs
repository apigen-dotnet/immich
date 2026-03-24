using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Axis to mirror along
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MirrorAxis
{
    [JsonStringEnumMemberName("horizontal")]
    Horizontal,
    [JsonStringEnumMemberName("vertical")]
    Vertical,
}
