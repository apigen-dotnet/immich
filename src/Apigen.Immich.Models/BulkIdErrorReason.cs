using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Error reason
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BulkIdErrorReason
{
    [JsonStringEnumMemberName("duplicate")]
    Duplicate,
    [JsonStringEnumMemberName("no_permission")]
    NoPermission,
    [JsonStringEnumMemberName("not_found")]
    NotFound,
    [JsonStringEnumMemberName("unknown")]
    Unknown,
}
