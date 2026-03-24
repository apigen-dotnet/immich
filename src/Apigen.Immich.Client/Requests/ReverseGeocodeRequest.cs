using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Request parameters for Reverse geocode coordinates
/// Operation: GET /map/reverse-geocode
/// </summary>
public class ReverseGeocodeRequest : BaseRequest
{
  /// <summary>
  /// Latitude (-90 to 90)
  /// </summary>
  [JsonPropertyName("lat")]
  public decimal? Lat { get; set; }

  /// <summary>
  /// Longitude (-180 to 180)
  /// </summary>
  [JsonPropertyName("lon")]
  public decimal? Lon { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Lat != null)
      queryParams["lat"] = Lat;
    if (Lon != null)
      queryParams["lon"] = Lon;

    return queryParams.ToQueryString();
  }
}
