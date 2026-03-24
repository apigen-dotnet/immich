using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Plugins operations
/// </summary>
public interface IPluginsClient
{
  /// <summary>
  /// List all plugins
  /// Operation: GET /plugins
  /// </summary>
  Task<List<PluginResponseDto>> GetPluginsAsync();

  /// <summary>
  /// List all plugin triggers
  /// Operation: GET /plugins/triggers
  /// </summary>
  Task<List<PluginTriggerResponseDto>> GetPluginTriggersAsync();

  /// <summary>
  /// Retrieve a plugin
  /// Operation: GET /plugins/{id}
  /// </summary>
  Task<PluginResponseDto> GetAsync(string id);

}
