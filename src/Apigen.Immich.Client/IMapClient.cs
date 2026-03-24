using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Map operations
/// </summary>
public interface IMapClient
{
  /// <summary>
  /// Retrieve map markers
  /// Operation: GET /map/markers
  /// </summary>
  Task<List<MapMarkerResponseDto>> GetMapMarkersAsync(GetMapMarkersRequest? request = null);

  /// <summary>
  /// Reverse geocode coordinates
  /// Operation: GET /map/reverse-geocode
  /// </summary>
  Task<List<MapReverseGeocodeResponseDto>> ReverseGeocodeAsync(ReverseGeocodeRequest? request = null);

}
