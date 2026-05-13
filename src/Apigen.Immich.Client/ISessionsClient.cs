using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Sessions operations
/// </summary>
public partial interface ISessionsClient
{
  /// <summary>
  /// Delete all sessions
  /// Operation: DELETE /sessions
  /// </summary>
  Task DeleteAllSessionsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve sessions
  /// Operation: GET /sessions
  /// </summary>
  Task<List<SessionResponseDto>> GetSessionsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a session
  /// Operation: POST /sessions
  /// </summary>
  Task<SessionCreateResponseDto> CreateAsync(Apigen.Immich.Models.SessionCreateDto sessionCreateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete a session
  /// Operation: DELETE /sessions/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a session
  /// Operation: PUT /sessions/{id}
  /// </summary>
  Task<SessionResponseDto> UpdateAsync(string id, Apigen.Immich.Models.SessionUpdateDto sessionUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Lock a session
  /// Operation: POST /sessions/{id}/lock
  /// </summary>
  Task LockSessionAsync(string id, CancellationToken cancellationToken = default);

}
