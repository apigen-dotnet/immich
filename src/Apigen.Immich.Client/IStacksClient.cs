using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Stacks operations
/// </summary>
public interface IStacksClient
{
  /// <summary>
  /// Delete stacks
  /// Operation: DELETE /stacks
  /// </summary>
  Task DeleteStacksAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Retrieve stacks
  /// Operation: GET /stacks
  /// </summary>
  Task<List<StackResponseDto>> SearchStacksAsync(SearchStacksRequest? request = null);

  /// <summary>
  /// Create a stack
  /// Operation: POST /stacks
  /// </summary>
  Task<StackResponseDto> CreateAsync(Apigen.Immich.Models.StackCreateDto stackCreateDto);

  /// <summary>
  /// Delete a stack
  /// Operation: DELETE /stacks/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a stack
  /// Operation: GET /stacks/{id}
  /// </summary>
  Task<StackResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a stack
  /// Operation: PUT /stacks/{id}
  /// </summary>
  Task<StackResponseDto> UpdateAsync(string id, Apigen.Immich.Models.StackUpdateDto stackUpdateDto);

  /// <summary>
  /// Remove an asset from a stack
  /// Operation: DELETE /stacks/{id}/assets/{assetId}
  /// </summary>
  Task DeleteAsync(string assetId, string id);

}
