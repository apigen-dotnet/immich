using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Search operations
/// </summary>
public partial interface ISearchClient
{
  /// <summary>
  /// Retrieve assets by city
  /// Operation: GET /search/cities
  /// </summary>
  Task<List<AssetResponseDto>> GetAssetsByCityAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve explore data
  /// Operation: GET /search/explore
  /// </summary>
  Task<List<SearchExploreResponseDto>> GetExploreDataAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Search large assets
  /// Operation: POST /search/large-assets
  /// </summary>
  Task<List<AssetResponseDto>> SearchLargeAssetsAsync(SearchLargeAssetsRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Search assets by metadata
  /// Operation: POST /search/metadata
  /// </summary>
  Task<SearchResponseDto> SearchAssetsAsync(Apigen.Immich.Models.MetadataSearchDto metadataSearchDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Search people
  /// Operation: GET /search/person
  /// </summary>
  Task<List<PersonResponseDto>> SearchPersonAsync(SearchPersonRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Search places
  /// Operation: GET /search/places
  /// </summary>
  Task<List<PlacesResponseDto>> SearchPlacesAsync(SearchPlacesRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Search random assets
  /// Operation: POST /search/random
  /// </summary>
  Task<List<AssetResponseDto>> SearchRandomAsync(Apigen.Immich.Models.RandomSearchDto randomSearchDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Smart asset search
  /// Operation: POST /search/smart
  /// </summary>
  Task<SearchResponseDto> SearchSmartAsync(Apigen.Immich.Models.SmartSearchDto smartSearchDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Search asset statistics
  /// Operation: POST /search/statistics
  /// </summary>
  Task<SearchStatisticsResponseDto> SearchAssetStatisticsAsync(Apigen.Immich.Models.StatisticsSearchDto statisticsSearchDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve search suggestions
  /// Operation: GET /search/suggestions
  /// </summary>
  Task<JsonElement> GetSearchSuggestionsAsync(GetSearchSuggestionsRequest? request = null, CancellationToken cancellationToken = default);

}
