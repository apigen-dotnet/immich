using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve faces for asset
/// Operation: GET /faces
/// </summary>
public class GetFacesRequest : BaseRequest
{
  /// <summary>
  /// Face ID
  /// </summary>
  [JsonPropertyName("id")]
  public string? Id { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Id != null)
      queryParams["id"] = Id;

    return queryParams.ToQueryString();
  }
}
