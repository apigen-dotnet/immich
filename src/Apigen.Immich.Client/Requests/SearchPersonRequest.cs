using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Search people
/// Operation: GET /search/person
/// </summary>
public class SearchPersonRequest : BaseRequest
{
  /// <summary>
  /// Person name to search for
  /// </summary>
  [JsonPropertyName("name")]
  public string? Name { get; set; }

  /// <summary>
  /// Include hidden people
  /// </summary>
  [JsonPropertyName("withHidden")]
  public bool? WithHidden { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Name != null)
      queryParams["name"] = Name;
    if (WithHidden != null)
      queryParams["withHidden"] = WithHidden;

    return queryParams.ToQueryString();
  }
}
