using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LogLevel
{
    [JsonStringEnumMemberName("verbose")]
    Verbose,
    [JsonStringEnumMemberName("debug")]
    Debug,
    [JsonStringEnumMemberName("log")]
    Log,
    [JsonStringEnumMemberName("warn")]
    Warn,
    [JsonStringEnumMemberName("error")]
    Error,
    [JsonStringEnumMemberName("fatal")]
    Fatal,
}
