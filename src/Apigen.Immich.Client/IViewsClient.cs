using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Views operations
/// </summary>
public interface IViewsClient
{
  /// <summary>
  /// Retrieve assets by original path
  /// Operation: GET /view/folder
  /// </summary>
  Task<List<AssetResponseDto>> GetAssetsByOriginalPathAsync(GetAssetsByOriginalPathRequest? request = null);

  /// <summary>
  /// Retrieve unique paths
  /// Operation: GET /view/folder/unique-paths
  /// </summary>
  Task<JsonElement> GetUniqueOriginalPathsAsync();

}
