using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Search operations
/// </summary>
public interface ISearchClient
{
  /// <summary>
  /// Retrieve assets by city
  /// Operation: GET /search/cities
  /// </summary>
  Task<List<AssetResponseDto>> GetAssetsByCityAsync();

  /// <summary>
  /// Retrieve explore data
  /// Operation: GET /search/explore
  /// </summary>
  Task<List<SearchExploreResponseDto>> GetExploreDataAsync();

  /// <summary>
  /// Search large assets
  /// Operation: POST /search/large-assets
  /// </summary>
  Task<List<AssetResponseDto>> SearchLargeAssetsAsync(SearchLargeAssetsRequest? request = null);

  /// <summary>
  /// Search assets by metadata
  /// Operation: POST /search/metadata
  /// </summary>
  Task<SearchResponseDto> SearchAssetsAsync(Apigen.Immich.Models.MetadataSearchDto metadataSearchDto);

  /// <summary>
  /// Search people
  /// Operation: GET /search/person
  /// </summary>
  Task<List<PersonResponseDto>> SearchPersonAsync(SearchPersonRequest? request = null);

  /// <summary>
  /// Search places
  /// Operation: GET /search/places
  /// </summary>
  Task<List<PlacesResponseDto>> SearchPlacesAsync(SearchPlacesRequest? request = null);

  /// <summary>
  /// Search random assets
  /// Operation: POST /search/random
  /// </summary>
  Task<List<AssetResponseDto>> SearchRandomAsync(Apigen.Immich.Models.RandomSearchDto randomSearchDto);

  /// <summary>
  /// Smart asset search
  /// Operation: POST /search/smart
  /// </summary>
  Task<SearchResponseDto> SearchSmartAsync(Apigen.Immich.Models.SmartSearchDto smartSearchDto);

  /// <summary>
  /// Search asset statistics
  /// Operation: POST /search/statistics
  /// </summary>
  Task<SearchStatisticsResponseDto> SearchAssetStatisticsAsync(Apigen.Immich.Models.StatisticsSearchDto statisticsSearchDto);

  /// <summary>
  /// Retrieve search suggestions
  /// Operation: GET /search/suggestions
  /// </summary>
  Task<JsonElement> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest? request = null);

}
