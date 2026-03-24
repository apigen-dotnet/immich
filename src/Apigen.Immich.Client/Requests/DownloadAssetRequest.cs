using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Download original asset
/// Operation: GET /assets/{id}/original
/// </summary>
public class DownloadAssetRequest : BaseRequest
{
  /// <summary>
  /// Return edited asset if available
  /// </summary>
  [JsonPropertyName("edited")]
  public bool? Edited { get; set; }

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

    if (Edited != null)
      queryParams["edited"] = Edited;
    if (Key != null)
      queryParams["key"] = Key;
    if (Slug != null)
      queryParams["slug"] = Slug;

    return queryParams.ToQueryString();
  }
}
