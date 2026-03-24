using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for List all albums
/// Operation: GET /albums
/// </summary>
public class GetAllAlbumsRequest : BaseRequest
{
  /// <summary>
  /// Filter albums containing this asset ID (ignores shared parameter)
  /// </summary>
  [JsonPropertyName("assetId")]
  public string? AssetId { get; set; }

  /// <summary>
  /// Filter by shared status: true = only shared, false = not shared, undefined = all owned albums
  /// </summary>
  [JsonPropertyName("shared")]
  public bool? Shared { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AssetId != null)
      queryParams["assetId"] = AssetId;
    if (Shared != null)
      queryParams["shared"] = Shared;

    return queryParams.ToQueryString();
  }
}
