using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve all shared links
/// Operation: GET /shared-links
/// </summary>
public class GetAllSharedLinksRequest : BaseRequest
{
  /// <summary>
  /// Filter by album ID
  /// </summary>
  [JsonPropertyName("albumId")]
  public string? AlbumId { get; set; }

  /// <summary>
  /// Filter by shared link ID
  /// </summary>
  [JsonPropertyName("id")]
  public string? Id { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (AlbumId != null)
      queryParams["albumId"] = AlbumId;
    if (Id != null)
      queryParams["id"] = Id;

    return queryParams.ToQueryString();
  }
}
