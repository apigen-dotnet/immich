using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Token endpoint auth method
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum OAuthTokenEndpointAuthMethod
{
    [JsonStringEnumMemberName("client_secret_post")]
    ClientSecretPost,
    [JsonStringEnumMemberName("client_secret_basic")]
    ClientSecretBasic,
}
