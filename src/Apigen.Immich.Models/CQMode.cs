using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// CQ mode
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CQMode
{
    [JsonStringEnumMemberName("auto")]
    Auto,
    [JsonStringEnumMemberName("cqp")]
    Cqp,
    [JsonStringEnumMemberName("icq")]
    Icq,
}
