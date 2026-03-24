using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Job name
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetJobName
{
    [JsonStringEnumMemberName("refresh-faces")]
    RefreshFaces,
    [JsonStringEnumMemberName("refresh-metadata")]
    RefreshMetadata,
    [JsonStringEnumMemberName("regenerate-thumbnail")]
    RegenerateThumbnail,
    [JsonStringEnumMemberName("transcode-video")]
    TranscodeVideo,
}
