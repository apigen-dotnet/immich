using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// User metadata key
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserMetadataKey
{
    [JsonStringEnumMemberName("preferences")]
    Preferences,
    [JsonStringEnumMemberName("license")]
    License,
    [JsonStringEnumMemberName("onboarding")]
    Onboarding,
}
