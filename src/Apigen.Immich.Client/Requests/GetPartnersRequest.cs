using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve partners
/// Operation: GET /partners
/// </summary>
public class GetPartnersRequest : BaseRequest
{
  /// <summary>
  /// Partner direction
  /// </summary>
  [JsonPropertyName("direction")]
  public string? Direction { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Direction != null)
      queryParams["direction"] = Direction;

    return queryParams.ToQueryString();
  }
}
