using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Accepted containers
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoContainer
{
    [JsonStringEnumMemberName("mov")]
    Mov,
    [JsonStringEnumMemberName("mp4")]
    Mp4,
    [JsonStringEnumMemberName("ogg")]
    Ogg,
    [JsonStringEnumMemberName("webm")]
    Webm,
}
