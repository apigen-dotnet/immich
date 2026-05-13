using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Maintenance (admin) operations
/// </summary>
public partial interface IMaintenanceAdminClient
{
  /// <summary>
  /// Set maintenance mode
  /// Operation: POST /admin/maintenance
  /// </summary>
  Task SetMaintenanceModeAsync(Apigen.Immich.Models.SetMaintenanceModeDto setMaintenanceModeDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Detect existing install
  /// Operation: GET /admin/maintenance/detect-install
  /// </summary>
  Task<MaintenanceDetectInstallResponseDto> DetectPriorInstallAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Log into maintenance mode
  /// Operation: POST /admin/maintenance/login
  /// </summary>
  Task<MaintenanceAuthDto> MaintenanceLoginAsync(Apigen.Immich.Models.MaintenanceLoginDto maintenanceLoginDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get maintenance mode status
  /// Operation: GET /admin/maintenance/status
  /// </summary>
  Task<MaintenanceStatusResponseDto> GetMaintenanceStatusAsync(CancellationToken cancellationToken = default);

}
