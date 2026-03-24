using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Album user role
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlbumUserRole
{
    [JsonStringEnumMemberName("editor")]
    Editor,
    [JsonStringEnumMemberName("viewer")]
    Viewer,
}
