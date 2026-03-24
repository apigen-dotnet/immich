using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Users operations
/// </summary>
public interface IUsersClient
{
  /// <summary>
  /// Get all users
  /// Operation: GET /users
  /// </summary>
  Task<List<UserResponseDto>> SearchUsersAsync();

  /// <summary>
  /// Get current user
  /// Operation: GET /users/me
  /// </summary>
  Task<UserAdminResponseDto> GetMyUserAsync();

  /// <summary>
  /// Update current user
  /// Operation: PUT /users/me
  /// </summary>
  Task<UserAdminResponseDto> UpdateMyUserAsync(Apigen.Immich.Models.UserUpdateMeDto userUpdateMeDto);

  /// <summary>
  /// Delete user product key
  /// Operation: DELETE /users/me/license
  /// </summary>
  Task DeleteUserLicenseAsync();

  /// <summary>
  /// Retrieve user product key
  /// Operation: GET /users/me/license
  /// </summary>
  Task<LicenseResponseDto> GetUserLicenseAsync();

  /// <summary>
  /// Set user product key
  /// Operation: PUT /users/me/license
  /// </summary>
  Task<LicenseResponseDto> SetUserLicenseAsync(Apigen.Immich.Models.LicenseKeyDto licenseKeyDto);

  /// <summary>
  /// Delete user onboarding
  /// Operation: DELETE /users/me/onboarding
  /// </summary>
  Task DeleteUserOnboardingAsync();

  /// <summary>
  /// Retrieve user onboarding
  /// Operation: GET /users/me/onboarding
  /// </summary>
  Task<OnboardingResponseDto> GetUserOnboardingAsync();

  /// <summary>
  /// Update user onboarding
  /// Operation: PUT /users/me/onboarding
  /// </summary>
  Task<OnboardingResponseDto> SetUserOnboardingAsync(Apigen.Immich.Models.OnboardingDto onboardingDto);

  /// <summary>
  /// Get my preferences
  /// Operation: GET /users/me/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> GetMyPreferencesAsync();

  /// <summary>
  /// Update my preferences
  /// Operation: PUT /users/me/preferences
  /// </summary>
  Task<UserPreferencesResponseDto> UpdateMyPreferencesAsync(Apigen.Immich.Models.UserPreferencesUpdateDto userPreferencesUpdateDto);

  /// <summary>
  /// Delete user profile image
  /// Operation: DELETE /users/profile-image
  /// </summary>
  Task DeleteProfileImageAsync();

  /// <summary>
  /// Create user profile image
  /// Operation: POST /users/profile-image
  /// </summary>
  Task<CreateProfileImageResponseDto> CreateProfileImageAsync(Apigen.Immich.Models.CreateProfileImageDto createProfileImageDto);

  /// <summary>
  /// Retrieve a user
  /// Operation: GET /users/{id}
  /// </summary>
  Task<UserResponseDto> GetAsync(string id);

  /// <summary>
  /// Retrieve user profile image
  /// Operation: GET /users/{id}/profile-image
  /// </summary>
  Task<Stream> GetProfileImageAsync(string id);

}
