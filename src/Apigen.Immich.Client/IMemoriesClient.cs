using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Memories operations
/// </summary>
public interface IMemoriesClient
{
  /// <summary>
  /// Retrieve memories
  /// Operation: GET /memories
  /// </summary>
  Task<List<MemoryResponseDto>> SearchMemoriesAsync(SearchMemoriesRequest? request = null);

  /// <summary>
  /// Create a memory
  /// Operation: POST /memories
  /// </summary>
  Task<MemoryResponseDto> CreateMemoryAsync(Apigen.Immich.Models.MemoryCreateDto memoryCreateDto);

  /// <summary>
  /// Retrieve memories statistics
  /// Operation: GET /memories/statistics
  /// </summary>
  Task<MemoryStatisticsResponseDto> MemoriesStatisticsAsync(MemoriesStatisticsRequest? request = null);

  /// <summary>
  /// Delete a memory
  /// Operation: DELETE /memories/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a memory
  /// Operation: GET /memories/{id}
  /// </summary>
  Task<MemoryResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a memory
  /// Operation: PUT /memories/{id}
  /// </summary>
  Task<MemoryResponseDto> UpdateAsync(string id, Apigen.Immich.Models.MemoryUpdateDto memoryUpdateDto);

  /// <summary>
  /// Remove assets from a memory
  /// Operation: DELETE /memories/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> RemoveMemoryAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Add assets to a memory
  /// Operation: PUT /memories/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> AddMemoryAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

}
