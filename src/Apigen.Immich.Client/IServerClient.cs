using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Server operations
/// </summary>
public interface IServerClient
{
  /// <summary>
  /// Get server information
  /// Operation: GET /server/about
  /// </summary>
  Task<ServerAboutResponseDto> GetAboutInfoAsync();

  /// <summary>
  /// Get APK links
  /// Operation: GET /server/apk-links
  /// </summary>
  Task<ServerApkLinksDto> GetApkLinksAsync();

  /// <summary>
  /// Get config
  /// Operation: GET /server/config
  /// </summary>
  Task<ServerConfigDto> GetServerConfigAsync();

  /// <summary>
  /// Get features
  /// Operation: GET /server/features
  /// </summary>
  Task<ServerFeaturesDto> GetServerFeaturesAsync();

  /// <summary>
  /// Delete server product key
  /// Operation: DELETE /server/license
  /// </summary>
  Task DeleteServerLicenseAsync();

  /// <summary>
  /// Get product key
  /// Operation: GET /server/license
  /// </summary>
  Task<LicenseResponseDto> GetServerLicenseAsync();

  /// <summary>
  /// Set server product key
  /// Operation: PUT /server/license
  /// </summary>
  Task<LicenseResponseDto> SetServerLicenseAsync(Apigen.Immich.Models.LicenseKeyDto licenseKeyDto);

  /// <summary>
  /// Get supported media types
  /// Operation: GET /server/media-types
  /// </summary>
  Task<ServerMediaTypesResponseDto> GetSupportedMediaTypesAsync();

  /// <summary>
  /// Ping
  /// Operation: GET /server/ping
  /// </summary>
  Task<ServerPingResponse> PingServerAsync();

  /// <summary>
  /// Get statistics
  /// Operation: GET /server/statistics
  /// </summary>
  Task<ServerStatsResponseDto> GetServerStatisticsAsync();

  /// <summary>
  /// Get storage
  /// Operation: GET /server/storage
  /// </summary>
  Task<ServerStorageResponseDto> GetStorageAsync();

  /// <summary>
  /// Get theme
  /// Operation: GET /server/theme
  /// </summary>
  Task<ServerThemeDto> GetThemeAsync();

  /// <summary>
  /// Get server version
  /// Operation: GET /server/version
  /// </summary>
  Task<ServerVersionResponseDto> GetServerVersionAsync();

  /// <summary>
  /// Get version check status
  /// Operation: GET /server/version-check
  /// </summary>
  Task<VersionCheckStateResponseDto> GetVersionCheckAsync();

  /// <summary>
  /// Get version history
  /// Operation: GET /server/version-history
  /// </summary>
  Task<List<ServerVersionHistoryResponseDto>> GetVersionHistoryAsync();

}
