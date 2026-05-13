using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Memories operations
/// </summary>
public partial interface IMemoriesClient
{
  /// <summary>
  /// Retrieve memories
  /// Operation: GET /memories
  /// </summary>
  Task<List<MemoryResponseDto>> SearchMemoriesAsync(SearchMemoriesRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a memory
  /// Operation: POST /memories
  /// </summary>
  Task<MemoryResponseDto> CreateMemoryAsync(Apigen.Immich.Models.MemoryCreateDto memoryCreateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve memories statistics
  /// Operation: GET /memories/statistics
  /// </summary>
  Task<MemoryStatisticsResponseDto> MemoriesStatisticsAsync(MemoriesStatisticsRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a memory
  /// Operation: DELETE /memories/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a memory
  /// Operation: GET /memories/{id}
  /// </summary>
  Task<MemoryResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a memory
  /// Operation: PUT /memories/{id}
  /// </summary>
  Task<MemoryResponseDto> UpdateAsync(string id, Apigen.Immich.Models.MemoryUpdateDto memoryUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove assets from a memory
  /// Operation: DELETE /memories/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> RemoveMemoryAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Add assets to a memory
  /// Operation: PUT /memories/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> AddMemoryAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto, CancellationToken cancellationToken = default);

}
