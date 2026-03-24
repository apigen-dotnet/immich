using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Get random assets
/// Operation: GET /assets/random
/// </summary>
public class GetRandomRequest : BaseRequest
{
  /// <summary>
  /// Number of random assets to return
  /// </summary>
  [JsonPropertyName("count")]
  public decimal? Count { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Count != null)
      queryParams["count"] = Count;

    return queryParams.ToQueryString();
  }
}
