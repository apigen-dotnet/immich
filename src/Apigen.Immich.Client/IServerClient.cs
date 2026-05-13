using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Server operations
/// </summary>
public partial interface IServerClient
{
  /// <summary>
  /// Get server information
  /// Operation: GET /server/about
  /// </summary>
  Task<ServerAboutResponseDto> GetAboutInfoAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get APK links
  /// Operation: GET /server/apk-links
  /// </summary>
  Task<ServerApkLinksDto> GetApkLinksAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get config
  /// Operation: GET /server/config
  /// </summary>
  Task<ServerConfigDto> GetServerConfigAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get features
  /// Operation: GET /server/features
  /// </summary>
  Task<ServerFeaturesDto> GetServerFeaturesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete server product key
  /// Operation: DELETE /server/license
  /// </summary>
  Task DeleteServerLicenseAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get product key
  /// Operation: GET /server/license
  /// </summary>
  Task<LicenseResponseDto> GetServerLicenseAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Set server product key
  /// Operation: PUT /server/license
  /// </summary>
  Task<LicenseResponseDto> SetServerLicenseAsync(Apigen.Immich.Models.LicenseKeyDto licenseKeyDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get supported media types
  /// Operation: GET /server/media-types
  /// </summary>
  Task<ServerMediaTypesResponseDto> GetSupportedMediaTypesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Ping
  /// Operation: GET /server/ping
  /// </summary>
  Task<ServerPingResponse> PingServerAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get statistics
  /// Operation: GET /server/statistics
  /// </summary>
  Task<ServerStatsResponseDto> GetServerStatisticsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get storage
  /// Operation: GET /server/storage
  /// </summary>
  Task<ServerStorageResponseDto> GetStorageAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get theme
  /// Operation: GET /server/theme
  /// </summary>
  Task<ServerThemeDto> GetThemeAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get server version
  /// Operation: GET /server/version
  /// </summary>
  Task<ServerVersionResponseDto> GetServerVersionAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get version check status
  /// Operation: GET /server/version-check
  /// </summary>
  Task<VersionCheckStateResponseDto> GetVersionCheckAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Get version history
  /// Operation: GET /server/version-history
  /// </summary>
  Task<List<ServerVersionHistoryResponseDto>> GetVersionHistoryAsync(CancellationToken cancellationToken = default);

}
