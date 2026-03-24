using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Storage folder
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StorageFolder
{
    [JsonStringEnumMemberName("encoded-video")]
    EncodedVideo,
    [JsonStringEnumMemberName("library")]
    Library,
    [JsonStringEnumMemberName("upload")]
    Upload,
    [JsonStringEnumMemberName("profile")]
    Profile,
    [JsonStringEnumMemberName("thumbs")]
    Thumbs,
    [JsonStringEnumMemberName("backups")]
    Backups,
}
