using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Type of edit action to perform
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AssetEditAction
{
    [JsonStringEnumMemberName("crop")]
    Crop,
    [JsonStringEnumMemberName("rotate")]
    Rotate,
    [JsonStringEnumMemberName("mirror")]
    Mirror,
}
