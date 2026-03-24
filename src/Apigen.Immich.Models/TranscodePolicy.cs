using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Transcode policy
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TranscodePolicy
{
    [JsonStringEnumMemberName("all")]
    All,
    [JsonStringEnumMemberName("optimal")]
    Optimal,
    [JsonStringEnumMemberName("bitrate")]
    Bitrate,
    [JsonStringEnumMemberName("required")]
    Required,
    [JsonStringEnumMemberName("disabled")]
    Disabled,
}
