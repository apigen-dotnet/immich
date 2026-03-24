using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Maintenance action
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MaintenanceAction
{
    [JsonStringEnumMemberName("start")]
    Start,
    [JsonStringEnumMemberName("end")]
    End,
    [JsonStringEnumMemberName("select_database_restore")]
    SelectDatabaseRestore,
    [JsonStringEnumMemberName("restore_database")]
    RestoreDatabase,
}
