using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Search large assets
/// Operation: POST /search/large-assets
/// </summary>
public class SearchLargeAssetsRequest : BaseRequest
{
  /// <summary>
  /// Filter by album IDs
  /// </summary>
  [JsonPropertyName("albumIds")]
  public string[]? AlbumIds { get; set; }

  /// <summary>
  /// Filter by city name
  /// </summary>
  [JsonPropertyName("city")]
  public string? City { get; set; }

  /// <summary>
  /// Filter by country name
  /// </summary>
  [JsonPropertyName("country")]
  public string? Country { get; set; }

  /// <summary>
  /// Filter by creation date (after)
  /// </summary>
  [JsonPropertyName("createdAfter")]
  public string? CreatedAfter { get; set; }

  /// <summary>
  /// Filter by creation date (before)
  /// </summary>
  [JsonPropertyName("createdBefore")]
  public string? CreatedBefore { get; set; }

  /// <summary>
  /// Device ID to filter by
  /// </summary>
  [JsonPropertyName("deviceId")]
  public string? DeviceId { get; set; }

  /// <summary>
  /// Filter by encoded status
  /// </summary>
  [JsonPropertyName("isEncoded")]
  public bool? IsEncoded { get; set; }

  /// <summary>
  /// Filter by favorite status
  /// </summary>
  [JsonPropertyName("isFavorite")]
  public bool? IsFavorite { get; set; }

  /// <summary>
  /// Filter by motion photo status
  /// </summary>
  [JsonPropertyName("isMotion")]
  public bool? IsMotion { get; set; }

  /// <summary>
  /// Filter assets not in any album
  /// </summary>
  [JsonPropertyName("isNotInAlbum")]
  public bool? IsNotInAlbum { get; set; }

  /// <summary>
  /// Filter by offline status
  /// </summary>
  [JsonPropertyName("isOffline")]
  public bool? IsOffline { get; set; }

  /// <summary>
  /// Filter by lens model
  /// </summary>
  [JsonPropertyName("lensModel")]
  public string? LensModel { get; set; }

  /// <summary>
  /// Library ID to filter by
  /// </summary>
  [JsonPropertyName("libraryId")]
  public string? LibraryId { get; set; }

  /// <summary>
  /// Filter by camera make
  /// </summary>
  [JsonPropertyName("make")]
  public string? Make { get; set; }

  /// <summary>
  /// Minimum file size in bytes
  /// </summary>
  [JsonPropertyName("minFileSize")]
  public int? MinFileSize { get; set; }

  /// <summary>
  /// Filter by camera model
  /// </summary>
  [JsonPropertyName("model")]
  public string? Model { get; set; }

  /// <summary>
  /// Filter by OCR text content
  /// </summary>
  [JsonPropertyName("ocr")]
  public string? Ocr { get; set; }

  /// <summary>
  /// Filter by person IDs
  /// </summary>
  [JsonPropertyName("personIds")]
  public string[]? PersonIds { get; set; }

  /// <summary>
  /// Filter by rating [1-5], or null for unrated
  /// </summary>
  [JsonPropertyName("rating")]
  public decimal? Rating { get; set; }

  /// <summary>
  /// Number of results to return
  /// </summary>
  [JsonPropertyName("size")]
  public decimal? Size { get; set; }

  /// <summary>
  /// Filter by state/province name
  /// </summary>
  [JsonPropertyName("state")]
  public string? State { get; set; }

  /// <summary>
  /// Filter by tag IDs
  /// </summary>
  [JsonPropertyName("tagIds")]
  public string[]? TagIds { get; set; }

  /// <summary>
  /// Filter by taken date (after)
  /// </summary>
  [JsonPropertyName("takenAfter")]
  public string? TakenAfter { get; set; }

  /// <summary>
  /// Filter by taken date (before)
  /// </summary>
  [JsonPropertyName("takenBefore")]
  public string? TakenBefore { get; set; }

  /// <summary>
  /// Filter by trash date (after)
  /// </summary>
  [JsonPropertyName("trashedAfter")]
  public string? TrashedAfter { get; set; }

  /// <summary>
  /// Filter by trash date (before)
  /// </summary>
  [JsonPropertyName("trashedBefore")]
  public string? TrashedBefore { get; set; }

  /// <summary>
  /// Asset type filter
  /// </summary>
  [JsonPropertyName("type")]
  public string? Type { get; set; }

  /// <summary>
  /// Filter by update date (after)
  /// </summary>
  [JsonPropertyName("updatedAfter")]
  public string? UpdatedAfter { get; set; }

  /// <summary>
  /// Filter by update date (before)
  /// </summary>
  [JsonPropertyName("updatedBefore")]
  public string? UpdatedBefore { get; set; }

  /// <summary>
  /// Filter by visibility
  /// </summary>
  [JsonPropertyName("visibility")]
  public string? Visibility { get; set; }

  /// <summary>
  /// Include deleted assets
  /// </summary>
  [JsonPropertyName("withDeleted")]
  public bool? WithDeleted { get; set; }

  /// <summary>
  /// Include EXIF data in response
  /// </summary>
  [JsonPropertyName("withExif")]
  public bool? WithExif { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AlbumIds != null)
      queryParams["albumIds"] = AlbumIds;
    if (City != null)
      queryParams["city"] = City;
    if (Country != null)
      queryParams["country"] = Country;
    if (CreatedAfter != null)
      queryParams["createdAfter"] = CreatedAfter;
    if (CreatedBefore != null)
      queryParams["createdBefore"] = CreatedBefore;
    if (DeviceId != null)
      queryParams["deviceId"] = DeviceId;
    if (IsEncoded != null)
      queryParams["isEncoded"] = IsEncoded;
    if (IsFavorite != null)
      queryParams["isFavorite"] = IsFavorite;
    if (IsMotion != null)
      queryParams["isMotion"] = IsMotion;
    if (IsNotInAlbum != null)
      queryParams["isNotInAlbum"] = IsNotInAlbum;
    if (IsOffline != null)
      queryParams["isOffline"] = IsOffline;
    if (LensModel != null)
      queryParams["lensModel"] = LensModel;
    if (LibraryId != null)
      queryParams["libraryId"] = LibraryId;
    if (Make != null)
      queryParams["make"] = Make;
    if (MinFileSize != null)
      queryParams["minFileSize"] = MinFileSize;
    if (Model != null)
      queryParams["model"] = Model;
    if (Ocr != null)
      queryParams["ocr"] = Ocr;
    if (PersonIds != null)
      queryParams["personIds"] = PersonIds;
    if (Rating != null)
      queryParams["rating"] = Rating;
    if (Size != null)
      queryParams["size"] = Size;
    if (State != null)
      queryParams["state"] = State;
    if (TagIds != null)
      queryParams["tagIds"] = TagIds;
    if (TakenAfter != null)
      queryParams["takenAfter"] = TakenAfter;
    if (TakenBefore != null)
      queryParams["takenBefore"] = TakenBefore;
    if (TrashedAfter != null)
      queryParams["trashedAfter"] = TrashedAfter;
    if (TrashedBefore != null)
      queryParams["trashedBefore"] = TrashedBefore;
    if (Type != null)
      queryParams["type"] = Type;
    if (UpdatedAfter != null)
      queryParams["updatedAfter"] = UpdatedAfter;
    if (UpdatedBefore != null)
      queryParams["updatedBefore"] = UpdatedBefore;
    if (Visibility != null)
      queryParams["visibility"] = Visibility;
    if (WithDeleted != null)
      queryParams["withDeleted"] = WithDeleted;
    if (WithExif != null)
      queryParams["withExif"] = WithExif;

    return queryParams.ToQueryString();
  }
}
