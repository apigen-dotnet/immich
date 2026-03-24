using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Avatar color
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserAvatarColor
{
    [JsonStringEnumMemberName("primary")]
    Primary,
    [JsonStringEnumMemberName("pink")]
    Pink,
    [JsonStringEnumMemberName("red")]
    Red,
    [JsonStringEnumMemberName("yellow")]
    Yellow,
    [JsonStringEnumMemberName("blue")]
    Blue,
    [JsonStringEnumMemberName("green")]
    Green,
    [JsonStringEnumMemberName("purple")]
    Purple,
    [JsonStringEnumMemberName("orange")]
    Orange,
    [JsonStringEnumMemberName("gray")]
    Gray,
    [JsonStringEnumMemberName("amber")]
    Amber,
}
