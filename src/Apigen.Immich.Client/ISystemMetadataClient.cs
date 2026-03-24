using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for System metadata operations
/// </summary>
public interface ISystemMetadataClient
{
  /// <summary>
  /// Retrieve admin onboarding
  /// Operation: GET /system-metadata/admin-onboarding
  /// </summary>
  Task<AdminOnboardingUpdateDto> GetAdminOnboardingAsync();

  /// <summary>
  /// Update admin onboarding
  /// Operation: POST /system-metadata/admin-onboarding
  /// </summary>
  Task UpdateAdminOnboardingAsync(Apigen.Immich.Models.AdminOnboardingUpdateDto adminOnboardingUpdateDto);

  /// <summary>
  /// Retrieve reverse geocoding state
  /// Operation: GET /system-metadata/reverse-geocoding-state
  /// </summary>
  Task<ReverseGeocodingStateResponseDto> GetReverseGeocodingStateAsync();

  /// <summary>
  /// Retrieve version check state
  /// Operation: GET /system-metadata/version-check-state
  /// </summary>
  Task<VersionCheckStateResponseDto> GetVersionCheckStateAsync();

}
