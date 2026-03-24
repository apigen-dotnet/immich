using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Duplicates operations
/// </summary>
public interface IDuplicatesClient
{
  /// <summary>
  /// Delete duplicates
  /// Operation: DELETE /duplicates
  /// </summary>
  Task DeleteDuplicatesAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Retrieve duplicates
  /// Operation: GET /duplicates
  /// </summary>
  Task<List<DuplicateResponseDto>> GetAssetDuplicatesAsync();

  /// <summary>
  /// Delete a duplicate
  /// Operation: DELETE /duplicates/{id}
  /// </summary>
  Task DeleteAsync(string id);

}
