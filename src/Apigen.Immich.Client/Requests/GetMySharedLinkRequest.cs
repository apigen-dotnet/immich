using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve current shared link
/// Operation: GET /shared-links/me
/// </summary>
public class GetMySharedLinkRequest : BaseRequest
{
  /// <summary>
  /// key
  /// </summary>
  [JsonPropertyName("key")]
  public string? Key { get; set; }

  /// <summary>
  /// Link password
  /// </summary>
  [JsonPropertyName("password")]
  public string? Password { get; set; }

  /// <summary>
  /// slug
  /// </summary>
  [JsonPropertyName("slug")]
  public string? Slug { get; set; }

  /// <summary>
  /// Access token
  /// </summary>
  [JsonPropertyName("token")]
  public string? Token { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Key != null)
      queryParams["key"] = Key;
    if (Password != null)
      queryParams["password"] = Password;
    if (Slug != null)
      queryParams["slug"] = Slug;
    if (Token != null)
      queryParams["token"] = Token;

    return queryParams.ToQueryString();
  }
}
