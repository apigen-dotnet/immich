using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Apigen.Immich.Models;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Client for Plugins operations
/// </summary>
public class PluginsClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal PluginsClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// List all plugins
  /// Operation: GET /plugins
  /// </summary>
  public async Task<List<PluginResponseDto>> GetPluginsAsync()
  {
    string url = "plugins";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    List<PluginResponseDto>? result = JsonSerializer.Deserialize<List<PluginResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<PluginResponseDto>();
  }


  /// <summary>
  /// List all plugin triggers
  /// Operation: GET /plugins/triggers
  /// </summary>
  public async Task<List<PluginTriggerResponseDto>> GetPluginTriggersAsync()
  {
    string url = "plugins/triggers";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    List<PluginTriggerResponseDto>? result = JsonSerializer.Deserialize<List<PluginTriggerResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<PluginTriggerResponseDto>();
  }


  /// <summary>
  /// Retrieve a plugin
  /// Operation: GET /plugins/{id}
  /// </summary>
  public async Task<PluginResponseDto> GetAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "plugins/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    PluginResponseDto? result = JsonSerializer.Deserialize<PluginResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new PluginResponseDto();
  }


}
