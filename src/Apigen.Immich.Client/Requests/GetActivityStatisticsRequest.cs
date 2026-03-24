using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve activity statistics
/// Operation: GET /activities/statistics
/// </summary>
public class GetActivityStatisticsRequest : BaseRequest
{
  /// <summary>
  /// Album ID
  /// </summary>
  [JsonPropertyName("albumId")]
  public string? AlbumId { get; set; }

  /// <summary>
  /// Asset ID (if activity is for an asset)
  /// </summary>
  [JsonPropertyName("assetId")]
  public string? AssetId { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AlbumId != null)
      queryParams["albumId"] = AlbumId;
    if (AssetId != null)
      queryParams["assetId"] = AssetId;

    return queryParams.ToQueryString();
  }
}
