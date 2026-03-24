using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve search suggestions
/// Operation: GET /search/suggestions
/// </summary>
public class GetSearchSuggestionsRequest : BaseRequest
{
  /// <summary>
  /// Filter by country
  /// </summary>
  [JsonPropertyName("country")]
  public string? Country { get; set; }

  /// <summary>
  /// Include null values in suggestions
  /// </summary>
  [JsonPropertyName("includeNull")]
  public bool? IncludeNull { get; set; }

  /// <summary>
  /// Filter by lens model
  /// </summary>
  [JsonPropertyName("lensModel")]
  public string? LensModel { get; set; }

  /// <summary>
  /// Filter by camera make
  /// </summary>
  [JsonPropertyName("make")]
  public string? Make { get; set; }

  /// <summary>
  /// Filter by camera model
  /// </summary>
  [JsonPropertyName("model")]
  public string? Model { get; set; }

  /// <summary>
  /// Filter by state/province
  /// </summary>
  [JsonPropertyName("state")]
  public string? State { get; set; }

  /// <summary>
  /// Suggestion type
  /// </summary>
  [JsonPropertyName("type")]
  public string? Type { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Country != null)
      queryParams["country"] = Country;
    if (IncludeNull != null)
      queryParams["includeNull"] = IncludeNull;
    if (LensModel != null)
      queryParams["lensModel"] = LensModel;
    if (Make != null)
      queryParams["make"] = Make;
    if (Model != null)
      queryParams["model"] = Model;
    if (State != null)
      queryParams["state"] = State;
    if (Type != null)
      queryParams["type"] = Type;

    return queryParams.ToQueryString();
  }
}
