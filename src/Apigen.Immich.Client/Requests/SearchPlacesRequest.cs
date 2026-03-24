using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Search places
/// Operation: GET /search/places
/// </summary>
public class SearchPlacesRequest : BaseRequest
{
  /// <summary>
  /// Place name to search for
  /// </summary>
  [JsonPropertyName("name")]
  public string? Name { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Name != null)
      queryParams["name"] = Name;

    return queryParams.ToQueryString();
  }
}
