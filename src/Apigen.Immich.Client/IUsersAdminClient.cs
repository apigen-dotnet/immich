using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Users (admin) operations
/// </summary>
public interface IUsersAdminClient
{
  /// <summary>
  /// Search users
  /// Operation: GET /admin/users
  /// </summary>
  Task<List<UserAdminResponseDto>> SearchUsersAdminAsync(SearchUsersAdminRequest? request = null);

  /// <summary>
  /// Create a user
  /// Operation: POST /admin/users
  /// </summary>
  Task<UserAdminResponseDto> CreateUserAdminAsync(Apigen.Immich.Models.UserAdminCreateDto userAdminCreateDto);

  /// <summary>
  /// Delete a user
  /// Operation: DELETE /admin/users/{id}
  /// </summary>
  Task<UserAdminResponseDto> DeleteAsync(string id, Apigen.Immich.Models.UserAdminDeleteDto userAdminDeleteDto);

  /// <summary>
  /// Retrieve a user
  /// Operation: GET /admin/users/{id}
  /// </summary>
  Task<UserAdminResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a user
  /// Operation: PUT /admin/users/{id}
  /// </summary>
  Task<UserAdminResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UserAdminUpdateDto userAdminUpdateDto);

  /// <summary>
  /// Retrieve user preferences
  /// Operation: GET /admin/users/{id}/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> GetUserPreferencesAdminAsync(string id);

  /// <summary>
  /// Update user preferences
  /// Operation: PUT /admin/users/{id}/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> UpdateUserPreferencesAdminAsync(string id, Apigen.Immich.Models.UserPreferencesUpdateDto userPreferencesUpdateDto);

  /// <summary>
  /// Restore a deleted user
  /// Operation: POST /admin/users/{id}/restore
  /// </summary>
  Task<UserAdminResponseDto> RestoreUserAdminAsync(string id);

  /// <summary>
  /// Retrieve user sessions
  /// Operation: GET /admin/users/{id}/sessions
  /// </summary>
  Task<List<SessionResponseDto>> GetUserSessionsAdminAsync(string id);

  /// <summary>
  /// Retrieve user statistics
  /// Operation: GET /admin/users/{id}/statistics
  /// </summary>
  Task<AssetStatsResponseDto> GetUserStatisticsAdminAsync(string id, GetUserStatisticsAdminRequest? request = null);

}
