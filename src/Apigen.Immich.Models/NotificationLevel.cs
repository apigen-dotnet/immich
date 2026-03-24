using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NotificationLevel
{
    [JsonStringEnumMemberName("success")]
    Success,
    [JsonStringEnumMemberName("error")]
    Error,
    [JsonStringEnumMemberName("warning")]
    Warning,
    [JsonStringEnumMemberName("info")]
    Info,
}
