using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Queue command to execute
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueueCommand
{
    [JsonStringEnumMemberName("start")]
    Start,
    [JsonStringEnumMemberName("pause")]
    Pause,
    [JsonStringEnumMemberName("resume")]
    Resume,
    [JsonStringEnumMemberName("empty")]
    Empty,
    [JsonStringEnumMemberName("clear-failed")]
    ClearFailed,
}
