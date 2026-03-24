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
/// Client for Timeline operations
/// </summary>
public class TimelineClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal TimelineClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Get time bucket
  /// Operation: GET /timeline/bucket
  /// </summary>
  public async Task<TimeBucketAssetResponseDto> GetTimeBucketAsync(GetTimeBucketRequest? request = null)
  {
    string url = "timeline/bucket".BuildUrl(request: request);

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
    TimeBucketAssetResponseDto? result = JsonSerializer.Deserialize<TimeBucketAssetResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new TimeBucketAssetResponseDto();
  }


  /// <summary>
  /// Get time buckets
  /// Operation: GET /timeline/buckets
  /// </summary>
  public async Task<List<TimeBucketsResponseDto>> GetTimeBucketsAsync(GetTimeBucketsRequest? request = null)
  {
    string url = "timeline/buckets".BuildUrl(request: request);

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
    List<TimeBucketsResponseDto>? result = JsonSerializer.Deserialize<List<TimeBucketsResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<TimeBucketsResponseDto>();
  }


}
