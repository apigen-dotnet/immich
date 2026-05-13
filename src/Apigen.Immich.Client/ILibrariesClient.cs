using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Libraries operations
/// </summary>
public partial interface ILibrariesClient
{
  /// <summary>
  /// Retrieve libraries
  /// Operation: GET /libraries
  /// </summary>
  Task<List<LibraryResponseDto>> GetAllLibrariesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a library
  /// Operation: POST /libraries
  /// </summary>
  Task<LibraryResponseDto> CreateLibraryAsync(Apigen.Immich.Models.CreateLibraryDto createLibraryDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a library
  /// Operation: DELETE /libraries/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a library
  /// Operation: GET /libraries/{id}
  /// </summary>
  Task<LibraryResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a library
  /// Operation: PUT /libraries/{id}
  /// </summary>
  Task<LibraryResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UpdateLibraryDto updateLibraryDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Scan a library
  /// Operation: POST /libraries/{id}/scan
  /// </summary>
  Task ScanLibraryAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve library statistics
  /// Operation: GET /libraries/{id}/statistics
  /// </summary>
  Task<LibraryStatsResponseDto> GetLibraryStatisticsAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Validate library settings
  /// Operation: POST /libraries/{id}/validate
  /// </summary>
  Task<ValidateLibraryResponseDto> ValidateAsync(string id, Apigen.Immich.Models.ValidateLibraryDto validateLibraryDto, CancellationToken cancellationToken = default);

}
