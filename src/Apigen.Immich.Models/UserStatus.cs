using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// User status
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserStatus
{
    [JsonStringEnumMemberName("active")]
    Active,
    [JsonStringEnumMemberName("removing")]
    Removing,
    [JsonStringEnumMemberName("deleted")]
    Deleted,
}
