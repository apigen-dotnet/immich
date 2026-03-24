using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Maintenance (admin) operations
/// </summary>
public interface IMaintenanceAdminClient
{
  /// <summary>
  /// Set maintenance mode
  /// Operation: POST /admin/maintenance
  /// </summary>
  Task SetMaintenanceModeAsync(Apigen.Immich.Models.SetMaintenanceModeDto setMaintenanceModeDto);

  /// <summary>
  /// Detect existing install
  /// Operation: GET /admin/maintenance/detect-install
  /// </summary>
  Task<MaintenanceDetectInstallResponseDto> DetectPriorInstallAsync();

  /// <summary>
  /// Log into maintenance mode
  /// Operation: POST /admin/maintenance/login
  /// </summary>
  Task<MaintenanceAuthDto> MaintenanceLoginAsync(Apigen.Immich.Models.MaintenanceLoginDto maintenanceLoginDto);

  /// <summary>
  /// Get maintenance mode status
  /// Operation: GET /admin/maintenance/status
  /// </summary>
  Task<MaintenanceStatusResponseDto> GetMaintenanceStatusAsync();

}
