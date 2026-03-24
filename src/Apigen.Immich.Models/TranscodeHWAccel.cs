using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Transcode hardware acceleration
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TranscodeHWAccel
{
    [JsonStringEnumMemberName("nvenc")]
    Nvenc,
    [JsonStringEnumMemberName("qsv")]
    Qsv,
    [JsonStringEnumMemberName("vaapi")]
    Vaapi,
    [JsonStringEnumMemberName("rkmpp")]
    Rkmpp,
    [JsonStringEnumMemberName("disabled")]
    Disabled,
}
