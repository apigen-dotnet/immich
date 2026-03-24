using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Search users
/// Operation: GET /admin/users
/// </summary>
public class SearchUsersAdminRequest : BaseRequest
{
  /// <summary>
  /// User ID filter
  /// </summary>
  [JsonPropertyName("id")]
  public string? Id { get; set; }

  /// <summary>
  /// Include deleted users
  /// </summary>
  [JsonPropertyName("withDeleted")]
  public bool? WithDeleted { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Id != null)
      queryParams["id"] = Id;
    if (WithDeleted != null)
      queryParams["withDeleted"] = WithDeleted;

    return queryParams.ToQueryString();
  }
}
