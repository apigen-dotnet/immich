using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Add assets to a shared link
/// Operation: PUT /shared-links/{id}/assets
/// </summary>
public class AddSharedLinkAssetsRequest : BaseRequest
{
  /// <summary>
  /// key
  /// </summary>
  [JsonPropertyName("key")]
  public string? Key { get; set; }

  /// <summary>
  /// slug
  /// </summary>
  [JsonPropertyName("slug")]
  public string? Slug { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Key != null)
      queryParams["key"] = Key;
    if (Slug != null)
      queryParams["slug"] = Slug;

    return queryParams.ToQueryString();
  }
}
