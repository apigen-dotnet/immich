using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Sessions operations
/// </summary>
public interface ISessionsClient
{
  /// <summary>
  /// Delete all sessions
  /// Operation: DELETE /sessions
  /// </summary>
  Task DeleteAllSessionsAsync();

  /// <summary>
  /// Retrieve sessions
  /// Operation: GET /sessions
  /// </summary>
  Task<List<SessionResponseDto>> GetSessionsAsync();

  /// <summary>
  /// Create a session
  /// Operation: POST /sessions
  /// </summary>
  Task<SessionCreateResponseDto> CreateAsync(Apigen.Immich.Models.SessionCreateDto sessionCreateDto);

  /// <summary>
  /// Delete a session
  /// Operation: DELETE /sessions/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Update a session
  /// Operation: PUT /sessions/{id}
  /// </summary>
  Task<SessionResponseDto> UpdateAsync(string id, Apigen.Immich.Models.SessionUpdateDto sessionUpdateDto);

  /// <summary>
  /// Lock a session
  /// Operation: POST /sessions/{id}/lock
  /// </summary>
  Task LockSessionAsync(string id);

}
