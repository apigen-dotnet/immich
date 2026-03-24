using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Get all people
/// Operation: GET /people
/// </summary>
public class GetAllPeopleRequest : BaseRequest
{
  /// <summary>
  /// Closest asset ID for similarity search
  /// </summary>
  [JsonPropertyName("closestAssetId")]
  public string? ClosestAssetId { get; set; }

  /// <summary>
  /// Closest person ID for similarity search
  /// </summary>
  [JsonPropertyName("closestPersonId")]
  public string? ClosestPersonId { get; set; }

  /// <summary>
  /// Page number for pagination
  /// </summary>
  [JsonPropertyName("page")]
  public decimal? Page { get; set; }

  /// <summary>
  /// Number of items per page
  /// </summary>
  [JsonPropertyName("size")]
  public decimal? Size { get; set; }

  /// <summary>
  /// Include hidden people
  /// </summary>
  [JsonPropertyName("withHidden")]
  public bool? WithHidden { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (ClosestAssetId != null)
      queryParams["closestAssetId"] = ClosestAssetId;
    if (ClosestPersonId != null)
      queryParams["closestPersonId"] = ClosestPersonId;
    if (Page != null)
      queryParams["page"] = Page;
    if (Size != null)
      queryParams["size"] = Size;
    if (WithHidden != null)
      queryParams["withHidden"] = WithHidden;

    return queryParams.ToQueryString();
  }
}
