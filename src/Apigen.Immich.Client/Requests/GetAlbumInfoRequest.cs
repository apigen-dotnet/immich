using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve an album
/// Operation: GET /albums/{id}
/// </summary>
public class GetAlbumInfoRequest : BaseRequest
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

  /// <summary>
  /// Exclude assets from response
  /// </summary>
  [JsonPropertyName("withoutAssets")]
  public bool? WithoutAssets { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Key != null)
      queryParams["key"] = Key;
    if (Slug != null)
      queryParams["slug"] = Slug;
    if (WithoutAssets != null)
      queryParams["withoutAssets"] = WithoutAssets;

    return queryParams.ToQueryString();
  }
}
