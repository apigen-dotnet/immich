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
/// Client for System metadata operations
/// </summary>
public class SystemMetadataClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal SystemMetadataClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Retrieve admin onboarding
  /// Operation: GET /system-metadata/admin-onboarding
  /// </summary>
  public async Task<AdminOnboardingUpdateDto> GetAdminOnboardingAsync()
  {
    string url = "system-metadata/admin-onboarding";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    AdminOnboardingUpdateDto? result = JsonSerializer.Deserialize<AdminOnboardingUpdateDto>(responseContent, JsonConfig.Default);
    return result ?? new AdminOnboardingUpdateDto();
  }


  /// <summary>
  /// Update admin onboarding
  /// Operation: POST /system-metadata/admin-onboarding
  /// </summary>
  public async Task UpdateAdminOnboardingAsync(Apigen.Immich.Models.AdminOnboardingUpdateDto adminOnboardingUpdateDto)
  {
    string url = "system-metadata/admin-onboarding";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(adminOnboardingUpdateDto, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "POST", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PostAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// Retrieve reverse geocoding state
  /// Operation: GET /system-metadata/reverse-geocoding-state
  /// </summary>
  public async Task<ReverseGeocodingStateResponseDto> GetReverseGeocodingStateAsync()
  {
    string url = "system-metadata/reverse-geocoding-state";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    ReverseGeocodingStateResponseDto? result = JsonSerializer.Deserialize<ReverseGeocodingStateResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new ReverseGeocodingStateResponseDto();
  }


  /// <summary>
  /// Retrieve version check state
  /// Operation: GET /system-metadata/version-check-state
  /// </summary>
  public async Task<VersionCheckStateResponseDto> GetVersionCheckStateAsync()
  {
    string url = "system-metadata/version-check-state";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    VersionCheckStateResponseDto? result = JsonSerializer.Deserialize<VersionCheckStateResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new VersionCheckStateResponseDto();
  }


}
