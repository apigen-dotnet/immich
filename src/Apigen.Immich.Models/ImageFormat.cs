using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Image format
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ImageFormat
{
    [JsonStringEnumMemberName("jpeg")]
    Jpeg,
    [JsonStringEnumMemberName("webp")]
    Webp,
}
