using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve memories
/// Operation: GET /memories
/// </summary>
public class SearchMemoriesRequest : BaseRequest
{
  /// <summary>
  /// Filter by date
  /// </summary>
  [JsonPropertyName("for")]
  public string? For { get; set; }

  /// <summary>
  /// Filter by saved status
  /// </summary>
  [JsonPropertyName("isSaved")]
  public bool? IsSaved { get; set; }

  /// <summary>
  /// Include trashed memories
  /// </summary>
  [JsonPropertyName("isTrashed")]
  public bool? IsTrashed { get; set; }

  /// <summary>
  /// Sort order
  /// </summary>
  [JsonPropertyName("order")]
  public string? Order { get; set; }

  /// <summary>
  /// Number of memories to return
  /// </summary>
  [JsonPropertyName("size")]
  public int? Size { get; set; }

  /// <summary>
  /// Memory type
  /// </summary>
  [JsonPropertyName("type")]
  public string? Type { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (For != null)
      queryParams["for"] = For;
    if (IsSaved != null)
      queryParams["isSaved"] = IsSaved;
    if (IsTrashed != null)
      queryParams["isTrashed"] = IsTrashed;
    if (Order != null)
      queryParams["order"] = Order;
    if (Size != null)
      queryParams["size"] = Size;
    if (Type != null)
      queryParams["type"] = Type;

    return queryParams.ToQueryString();
  }
}
