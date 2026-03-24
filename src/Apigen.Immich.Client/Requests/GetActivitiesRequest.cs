using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for List all activities
/// Operation: GET /activities
/// </summary>
public class GetActivitiesRequest : BaseRequest
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

  /// <summary>
  /// Filter by activity level
  /// </summary>
  [JsonPropertyName("level")]
  public string? Level { get; set; }

  /// <summary>
  /// Filter by activity type
  /// </summary>
  [JsonPropertyName("type")]
  public string? Type { get; set; }

  /// <summary>
  /// Filter by user ID
  /// </summary>
  [JsonPropertyName("userId")]
  public string? UserId { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AlbumId != null)
      queryParams["albumId"] = AlbumId;
    if (AssetId != null)
      queryParams["assetId"] = AssetId;
    if (Level != null)
      queryParams["level"] = Level;
    if (Type != null)
      queryParams["type"] = Type;
    if (UserId != null)
      queryParams["userId"] = UserId;

    return queryParams.ToQueryString();
  }
}
