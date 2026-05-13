using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Plugins operations
/// </summary>
public partial interface IPluginsClient
{
  /// <summary>
  /// List all plugins
  /// Operation: GET /plugins
  /// </summary>
  Task<List<PluginResponseDto>> GetPluginsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// List all plugin triggers
  /// Operation: GET /plugins/triggers
  /// </summary>
  Task<List<PluginTriggerResponseDto>> GetPluginTriggersAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a plugin
  /// Operation: GET /plugins/{id}
  /// </summary>
  Task<PluginResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

}
