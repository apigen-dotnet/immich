using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Libraries operations
/// </summary>
public interface ILibrariesClient
{
  /// <summary>
  /// Retrieve libraries
  /// Operation: GET /libraries
  /// </summary>
  Task<List<LibraryResponseDto>> GetAllLibrariesAsync();

  /// <summary>
  /// Create a library
  /// Operation: POST /libraries
  /// </summary>
  Task<LibraryResponseDto> CreateLibraryAsync(Apigen.Immich.Models.CreateLibraryDto createLibraryDto);

  /// <summary>
  /// Delete a library
  /// Operation: DELETE /libraries/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a library
  /// Operation: GET /libraries/{id}
  /// </summary>
  Task<LibraryResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a library
  /// Operation: PUT /libraries/{id}
  /// </summary>
  Task<LibraryResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UpdateLibraryDto updateLibraryDto);

  /// <summary>
  /// Scan a library
  /// Operation: POST /libraries/{id}/scan
  /// </summary>
  Task ScanLibraryAsync(string id);

  /// <summary>
  /// Retrieve library statistics
  /// Operation: GET /libraries/{id}/statistics
  /// </summary>
  Task<LibraryStatsResponseDto> GetLibraryStatisticsAsync(string id);

  /// <summary>
  /// Validate library settings
  /// Operation: POST /libraries/{id}/validate
  /// </summary>
  Task<ValidateLibraryResponseDto> ValidateAsync(string id, Apigen.Immich.Models.ValidateLibraryDto validateLibraryDto);

}
