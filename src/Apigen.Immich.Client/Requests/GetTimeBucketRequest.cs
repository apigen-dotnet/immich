using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Get time bucket
/// Operation: GET /timeline/bucket
/// </summary>
public class GetTimeBucketRequest : BaseRequest
{
  /// <summary>
  /// Filter assets belonging to a specific album
  /// </summary>
  [JsonPropertyName("albumId")]
  public string? AlbumId { get; set; }

  /// <summary>
  /// Bounding box coordinates as west,south,east,north (WGS84)
  /// </summary>
  [JsonPropertyName("bbox")]
  public string? Bbox { get; set; }

  /// <summary>
  /// Filter by favorite status (true for favorites only, false for non-favorites only)
  /// </summary>
  [JsonPropertyName("isFavorite")]
  public bool? IsFavorite { get; set; }

  /// <summary>
  /// Filter by trash status (true for trashed assets only, false for non-trashed only)
  /// </summary>
  [JsonPropertyName("isTrashed")]
  public bool? IsTrashed { get; set; }

  /// <summary>
  /// key
  /// </summary>
  [JsonPropertyName("key")]
  public string? Key { get; set; }

  /// <summary>
  /// Sort order for assets within time buckets (ASC for oldest first, DESC for newest first)
  /// </summary>
  [JsonPropertyName("order")]
  public string? Order { get; set; }

  /// <summary>
  /// Filter assets containing a specific person (face recognition)
  /// </summary>
  [JsonPropertyName("personId")]
  public string? PersonId { get; set; }

  /// <summary>
  /// slug
  /// </summary>
  [JsonPropertyName("slug")]
  public string? Slug { get; set; }

  /// <summary>
  /// Filter assets with a specific tag
  /// </summary>
  [JsonPropertyName("tagId")]
  public string? TagId { get; set; }

  /// <summary>
  /// Time bucket identifier in YYYY-MM-DD format (e.g., &quot;2024-01-01&quot; for January 2024)
  /// </summary>
  [JsonPropertyName("timeBucket")]
  public string? TimeBucket { get; set; }

  /// <summary>
  /// Filter assets by specific user ID
  /// </summary>
  [JsonPropertyName("userId")]
  public string? UserId { get; set; }

  /// <summary>
  /// Filter by asset visibility status (ARCHIVE, TIMELINE, HIDDEN, LOCKED)
  /// </summary>
  [JsonPropertyName("visibility")]
  public string? Visibility { get; set; }

  /// <summary>
  /// Include location data in the response
  /// </summary>
  [JsonPropertyName("withCoordinates")]
  public bool? WithCoordinates { get; set; }

  /// <summary>
  /// Include assets shared by partners
  /// </summary>
  [JsonPropertyName("withPartners")]
  public bool? WithPartners { get; set; }

  /// <summary>
  /// Include stacked assets in the response. When true, only primary assets from stacks are returned.
  /// </summary>
  [JsonPropertyName("withStacked")]
  public bool? WithStacked { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AlbumId != null)
      queryParams["albumId"] = AlbumId;
    if (Bbox != null)
      queryParams["bbox"] = Bbox;
    if (IsFavorite != null)
      queryParams["isFavorite"] = IsFavorite;
    if (IsTrashed != null)
      queryParams["isTrashed"] = IsTrashed;
    if (Key != null)
      queryParams["key"] = Key;
    if (Order != null)
      queryParams["order"] = Order;
    if (PersonId != null)
      queryParams["personId"] = PersonId;
    if (Slug != null)
      queryParams["slug"] = Slug;
    if (TagId != null)
      queryParams["tagId"] = TagId;
    if (TimeBucket != null)
      queryParams["timeBucket"] = TimeBucket;
    if (UserId != null)
      queryParams["userId"] = UserId;
    if (Visibility != null)
      queryParams["visibility"] = Visibility;
    if (WithCoordinates != null)
      queryParams["withCoordinates"] = WithCoordinates;
    if (WithPartners != null)
      queryParams["withPartners"] = WithPartners;
    if (WithStacked != null)
      queryParams["withStacked"] = WithStacked;

    return queryParams.ToQueryString();
  }
}
