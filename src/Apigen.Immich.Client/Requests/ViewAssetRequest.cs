using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for View asset thumbnail
/// Operation: GET /assets/{id}/thumbnail
/// </summary>
public class ViewAssetRequest : BaseRequest
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
  /// Asset media size
  /// </summary>
  [JsonPropertyName("size")]
  public string? Size { get; set; }

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
    if (Size != null)
      queryParams["size"] = Size;
    if (Slug != null)
      queryParams["slug"] = Slug;

    return queryParams.ToQueryString();
  }
}
