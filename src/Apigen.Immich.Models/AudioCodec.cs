using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Target audio codec
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AudioCodec
{
    [JsonStringEnumMemberName("mp3")]
    Mp3,
    [JsonStringEnumMemberName("aac")]
    Aac,
    [JsonStringEnumMemberName("libopus")]
    Libopus,
    [JsonStringEnumMemberName("opus")]
    Opus,
    [JsonStringEnumMemberName("pcm_s16le")]
    PcmS16Le,
}
