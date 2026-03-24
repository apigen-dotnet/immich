using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Face detection source type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SourceType
{
    [JsonStringEnumMemberName("machine-learning")]
    MachineLearning,
    [JsonStringEnumMemberName("exif")]
    Exif,
    [JsonStringEnumMemberName("manual")]
    Manual,
}
