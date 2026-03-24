using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve stacks
/// Operation: GET /stacks
/// </summary>
public class SearchStacksRequest : BaseRequest
{
  /// <summary>
  /// Filter by primary asset ID
  /// </summary>
  [JsonPropertyName("primaryAssetId")]
  public string? PrimaryAssetId { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (PrimaryAssetId != null)
      queryParams["primaryAssetId"] = PrimaryAssetId;

    return queryParams.ToQueryString();
  }
}
