using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for System config operations
/// </summary>
public interface ISystemConfigClient
{
  /// <summary>
  /// Get system configuration
  /// Operation: GET /system-config
  /// </summary>
  Task<SystemConfigDto> GetConfigAsync();

  /// <summary>
  /// Update system configuration
  /// Operation: PUT /system-config
  /// </summary>
  Task<SystemConfigDto> UpdateConfigAsync(Apigen.Immich.Models.SystemConfigDto systemConfigDto);

  /// <summary>
  /// Get system configuration defaults
  /// Operation: GET /system-config/defaults
  /// </summary>
  Task<SystemConfigDto> GetConfigDefaultsAsync();

  /// <summary>
  /// Get storage template options
  /// Operation: GET /system-config/storage-template-options
  /// </summary>
  Task<SystemConfigTemplateStorageOptionDto> GetStorageTemplateOptionsAsync();

}
