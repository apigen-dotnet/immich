using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Target video codec
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoCodec
{
    [JsonStringEnumMemberName("h264")]
    H264,
    [JsonStringEnumMemberName("hevc")]
    Hevc,
    [JsonStringEnumMemberName("vp9")]
    Vp9,
    [JsonStringEnumMemberName("av1")]
    Av1,
}
