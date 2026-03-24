using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Retrieve notifications
/// Operation: GET /notifications
/// </summary>
public class GetNotificationsRequest : BaseRequest
{
  /// <summary>
  /// Filter by notification ID
  /// </summary>
  [JsonPropertyName("id")]
  public string? Id { get; set; }

  /// <summary>
  /// Filter by notification level
  /// </summary>
  [JsonPropertyName("level")]
  public string? Level { get; set; }

  /// <summary>
  /// Filter by notification type
  /// </summary>
  [JsonPropertyName("type")]
  public string? Type { get; set; }

  /// <summary>
  /// Filter by unread status
  /// </summary>
  [JsonPropertyName("unread")]
  public bool? Unread { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Id != null)
      queryParams["id"] = Id;
    if (Level != null)
      queryParams["level"] = Level;
    if (Type != null)
      queryParams["type"] = Type;
    if (Unread != null)
      queryParams["unread"] = Unread;

    return queryParams.ToQueryString();
  }
}
