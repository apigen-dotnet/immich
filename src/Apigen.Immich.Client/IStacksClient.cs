using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Stacks operations
/// </summary>
public partial interface IStacksClient
{
  /// <summary>
  /// Delete stacks
  /// Operation: DELETE /stacks
  /// </summary>
  Task DeleteStacksAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve stacks
  /// Operation: GET /stacks
  /// </summary>
  Task<List<StackResponseDto>> SearchStacksAsync(SearchStacksRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a stack
  /// Operation: POST /stacks
  /// </summary>
  Task<StackResponseDto> CreateAsync(Apigen.Immich.Models.StackCreateDto stackCreateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a stack
  /// Operation: DELETE /stacks/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a stack
  /// Operation: GET /stacks/{id}
  /// </summary>
  Task<StackResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a stack
  /// Operation: PUT /stacks/{id}
  /// </summary>
  Task<StackResponseDto> UpdateAsync(string id, Apigen.Immich.Models.StackUpdateDto stackUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove an asset from a stack
  /// Operation: DELETE /stacks/{id}/assets/{assetId}
  /// </summary>
  Task DeleteAsync(string assetId, string id, CancellationToken cancellationToken = default);

}
