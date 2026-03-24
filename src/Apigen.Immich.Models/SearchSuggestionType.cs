using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SearchSuggestionType
{
    [JsonStringEnumMemberName("country")]
    Country,
    [JsonStringEnumMemberName("state")]
    State,
    [JsonStringEnumMemberName("city")]
    City,
    [JsonStringEnumMemberName("camera-make")]
    CameraMake,
    [JsonStringEnumMemberName("camera-model")]
    CameraModel,
    [JsonStringEnumMemberName("camera-lens-model")]
    CameraLensModel,
}
