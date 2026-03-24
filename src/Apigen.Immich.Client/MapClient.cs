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
/// Client for Map operations
/// </summary>
public class MapClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal MapClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Retrieve map markers
  /// Operation: GET /map/markers
  /// </summary>
  public async Task<List<MapMarkerResponseDto>> GetMapMarkersAsync(GetMapMarkersRequest? request = null)
  {
    string url = "map/markers".BuildUrl(request: request);

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
    List<MapMarkerResponseDto>? result = JsonSerializer.Deserialize<List<MapMarkerResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<MapMarkerResponseDto>();
  }


  /// <summary>
  /// Reverse geocode coordinates
  /// Operation: GET /map/reverse-geocode
  /// </summary>
  public async Task<List<MapReverseGeocodeResponseDto>> ReverseGeocodeAsync(ReverseGeocodeRequest? request = null)
  {
    string url = "map/reverse-geocode".BuildUrl(request: request);

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
    List<MapReverseGeocodeResponseDto>? result = JsonSerializer.Deserialize<List<MapReverseGeocodeResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<MapReverseGeocodeResponseDto>();
  }


}
