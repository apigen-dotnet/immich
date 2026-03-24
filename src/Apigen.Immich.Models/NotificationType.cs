using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NotificationType
{
    [JsonStringEnumMemberName("JobFailed")]
    JobFailed,
    [JsonStringEnumMemberName("BackupFailed")]
    BackupFailed,
    [JsonStringEnumMemberName("SystemMessage")]
    SystemMessage,
    [JsonStringEnumMemberName("AlbumInvite")]
    AlbumInvite,
    [JsonStringEnumMemberName("AlbumUpdate")]
    AlbumUpdate,
    [JsonStringEnumMemberName("Custom")]
    Custom,
}
