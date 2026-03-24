using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Job name
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ManualJobName
{
    [JsonStringEnumMemberName("person-cleanup")]
    PersonCleanup,
    [JsonStringEnumMemberName("tag-cleanup")]
    TagCleanup,
    [JsonStringEnumMemberName("user-cleanup")]
    UserCleanup,
    [JsonStringEnumMemberName("memory-cleanup")]
    MemoryCleanup,
    [JsonStringEnumMemberName("memory-create")]
    MemoryCreate,
    [JsonStringEnumMemberName("backup-database")]
    BackupDatabase,
}
