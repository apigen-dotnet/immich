using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Duplicates operations
/// </summary>
public partial interface IDuplicatesClient
{
  /// <summary>
  /// Delete duplicates
  /// Operation: DELETE /duplicates
  /// </summary>
  Task DeleteDuplicatesAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve duplicates
  /// Operation: GET /duplicates
  /// </summary>
  Task<List<DuplicateResponseDto>> GetAssetDuplicatesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Resolve duplicate groups
  /// Operation: POST /duplicates/resolve
  /// </summary>
  Task<List<BulkIdResponseDto>> ResolveDuplicatesAsync(Apigen.Immich.Models.DuplicateResolveDto duplicateResolveDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a duplicate
  /// Operation: DELETE /duplicates/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

}
