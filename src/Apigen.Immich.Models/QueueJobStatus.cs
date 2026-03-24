using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum QueueJobStatus
{
    [JsonStringEnumMemberName("active")]
    Active,
    [JsonStringEnumMemberName("failed")]
    Failed,
    [JsonStringEnumMemberName("completed")]
    Completed,
    [JsonStringEnumMemberName("delayed")]
    Delayed,
    [JsonStringEnumMemberName("waiting")]
    Waiting,
    [JsonStringEnumMemberName("paused")]
    Paused,
}
