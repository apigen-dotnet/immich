using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve queue jobs
/// Operation: GET /queues/{name}/jobs
/// </summary>
public class GetQueueJobsRequest : BaseRequest
{
  /// <summary>
  /// Filter jobs by status
  /// </summary>
  [JsonPropertyName("status")]
  public string[]? Status { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Status != null)
      queryParams["status"] = Status;

    return queryParams.ToQueryString();
  }
}
