using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Users operations
/// </summary>
public partial interface IUsersClient
{
  /// <summary>
  /// Get all users
  /// Operation: GET /users
  /// </summary>
  Task<List<UserResponseDto>> SearchUsersAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get current user
  /// Operation: GET /users/me
  /// </summary>
  Task<UserAdminResponseDto> GetMyUserAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Update current user
  /// Operation: PUT /users/me
  /// </summary>
  Task<UserAdminResponseDto> UpdateMyUserAsync(Apigen.Immich.Models.UserUpdateMeDto userUpdateMeDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete user product key
  /// Operation: DELETE /users/me/license
  /// </summary>
  Task DeleteUserLicenseAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve user product key
  /// Operation: GET /users/me/license
  /// </summary>
  Task<LicenseResponseDto> GetUserLicenseAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Set user product key
  /// Operation: PUT /users/me/license
  /// </summary>
  Task<LicenseResponseDto> SetUserLicenseAsync(Apigen.Immich.Models.LicenseKeyDto licenseKeyDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete user onboarding
  /// Operation: DELETE /users/me/onboarding
  /// </summary>
  Task DeleteUserOnboardingAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve user onboarding
  /// Operation: GET /users/me/onboarding
  /// </summary>
  Task<OnboardingResponseDto> GetUserOnboardingAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Update user onboarding
  /// Operation: PUT /users/me/onboarding
  /// </summary>
  Task<OnboardingResponseDto> SetUserOnboardingAsync(Apigen.Immich.Models.OnboardingDto onboardingDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get my preferences
  /// Operation: GET /users/me/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> GetMyPreferencesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Update my preferences
  /// Operation: PUT /users/me/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> UpdateMyPreferencesAsync(Apigen.Immich.Models.UserPreferencesUpdateDto userPreferencesUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete user profile image
  /// Operation: DELETE /users/profile-image
  /// </summary>
  Task DeleteProfileImageAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Create user profile image
  /// Operation: POST /users/profile-image
  /// </summary>
  Task<CreateProfileImageResponseDto> CreateProfileImageAsync(Apigen.Immich.Models.CreateProfileImageDto createProfileImageDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a user
  /// Operation: GET /users/{id}
  /// </summary>
  Task<UserResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve user profile image
  /// Operation: GET /users/{id}/profile-image
  /// </summary>
  Task<Stream> GetProfileImageAsync(string id, CancellationToken cancellationToken = default);

}
