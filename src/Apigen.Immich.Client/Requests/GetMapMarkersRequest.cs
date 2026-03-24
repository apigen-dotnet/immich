using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve map markers
/// Operation: GET /map/markers
/// </summary>
public class GetMapMarkersRequest : BaseRequest
{
  /// <summary>
  /// Filter assets created after this date
  /// </summary>
  [JsonPropertyName("fileCreatedAfter")]
  public string? FileCreatedAfter { get; set; }

  /// <summary>
  /// Filter assets created before this date
  /// </summary>
  [JsonPropertyName("fileCreatedBefore")]
  public string? FileCreatedBefore { get; set; }

  /// <summary>
  /// Filter by archived status
  /// </summary>
  [JsonPropertyName("isArchived")]
  public bool? IsArchived { get; set; }

  /// <summary>
  /// Filter by favorite status
  /// </summary>
  [JsonPropertyName("isFavorite")]
  public bool? IsFavorite { get; set; }

  /// <summary>
  /// Include partner assets
  /// </summary>
  [JsonPropertyName("withPartners")]
  public bool? WithPartners { get; set; }

  /// <summary>
  /// Include shared album assets
  /// </summary>
  [JsonPropertyName("withSharedAlbums")]
  public bool? WithSharedAlbums { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (FileCreatedAfter != null)
      queryParams["fileCreatedAfter"] = FileCreatedAfter;
    if (FileCreatedBefore != null)
      queryParams["fileCreatedBefore"] = FileCreatedBefore;
    if (IsArchived != null)
      queryParams["isArchived"] = IsArchived;
    if (IsFavorite != null)
      queryParams["isFavorite"] = IsFavorite;
    if (WithPartners != null)
      queryParams["withPartners"] = WithPartners;
    if (WithSharedAlbums != null)
      queryParams["withSharedAlbums"] = WithSharedAlbums;

    return queryParams.ToQueryString();
  }
}
