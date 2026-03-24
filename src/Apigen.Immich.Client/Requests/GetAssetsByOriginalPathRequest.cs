using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve assets by original path
/// Operation: GET /view/folder
/// </summary>
public class GetAssetsByOriginalPathRequest : BaseRequest
{
  /// <summary>
  /// path
  /// </summary>
  [JsonPropertyName("path")]
  public string? Path { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Path != null)
      queryParams["path"] = Path;

    return queryParams.ToQueryString();
  }
}
