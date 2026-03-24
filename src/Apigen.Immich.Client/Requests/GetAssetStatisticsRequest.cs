using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Get asset statistics
/// Operation: GET /assets/statistics
/// </summary>
public class GetAssetStatisticsRequest : BaseRequest
{
  /// <summary>
  /// Filter by favorite status
  /// </summary>
  [JsonPropertyName("isFavorite")]
  public bool? IsFavorite { get; set; }

  /// <summary>
  /// Filter by trash status
  /// </summary>
  [JsonPropertyName("isTrashed")]
  public bool? IsTrashed { get; set; }

  /// <summary>
  /// Filter by visibility
  /// </summary>
  [JsonPropertyName("visibility")]
  public string? Visibility { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (IsFavorite != null)
      queryParams["isFavorite"] = IsFavorite;
    if (IsTrashed != null)
      queryParams["isTrashed"] = IsTrashed;
    if (Visibility != null)
      queryParams["visibility"] = Visibility;

    return queryParams.ToQueryString();
  }
}
