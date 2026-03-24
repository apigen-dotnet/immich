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
/// Client for Shared links operations
/// </summary>
public class SharedLinksClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal SharedLinksClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Retrieve all shared links
  /// Operation: GET /shared-links
  /// </summary>
  public async Task<List<SharedLinkResponseDto>> GetAllSharedLinksAsync(GetAllSharedLinksRequest? request = null)
  {
    string url = "shared-links".BuildUrl(request: request);

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
    List<SharedLinkResponseDto>? result = JsonSerializer.Deserialize<List<SharedLinkResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<SharedLinkResponseDto>();
  }


  /// <summary>
  /// Create a shared link
  /// Operation: POST /shared-links
  /// </summary>
  public async Task<SharedLinkResponseDto> CreateSharedLinkAsync(Apigen.Immich.Models.SharedLinkCreateDto sharedLinkCreateDto)
  {
    string url = "shared-links";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(sharedLinkCreateDto, JsonConfig.Default);
    HttpClientLog.RequestBody(_logger, "POST", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PostAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    SharedLinkResponseDto? result = JsonSerializer.Deserialize<SharedLinkResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new SharedLinkResponseDto();
  }


  /// <summary>
  /// Shared link login
  /// Operation: POST /shared-links/login
  /// </summary>
  public async Task<SharedLinkResponseDto> SharedLinkLoginAsync(Apigen.Immich.Models.SharedLinkLoginDto sharedLinkLoginDto, SharedLinkLoginRequest? request = null)
  {
    string url = "shared-links/login".BuildUrl(request: request);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(sharedLinkLoginDto, JsonConfig.Default);
    HttpClientLog.RequestBody(_logger, "POST", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PostAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    SharedLinkResponseDto? result = JsonSerializer.Deserialize<SharedLinkResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new SharedLinkResponseDto();
  }


  /// <summary>
  /// Retrieve current shared link
  /// Operation: GET /shared-links/me
  /// </summary>
  public async Task<SharedLinkResponseDto> GetMySharedLinkAsync(GetMySharedLinkRequest? request = null)
  {
    string url = "shared-links/me".BuildUrl(request: request);

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
    SharedLinkResponseDto? result = JsonSerializer.Deserialize<SharedLinkResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new SharedLinkResponseDto();
  }


  /// <summary>
  /// Delete a shared link
  /// Operation: DELETE /shared-links/{id}
  /// </summary>
  public async Task DeleteAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "shared-links/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "DELETE", url);
    HttpResponseMessage response = await _httpClient.DeleteAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "DELETE", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "DELETE", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// Retrieve a shared link
  /// Operation: GET /shared-links/{id}
  /// </summary>
  public async Task<SharedLinkResponseDto> GetAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "shared-links/{id}".BuildUrl(pathParams);

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
    SharedLinkResponseDto? result = JsonSerializer.Deserialize<SharedLinkResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new SharedLinkResponseDto();
  }


  /// <summary>
  /// Update a shared link
  /// Operation: PATCH /shared-links/{id}
  /// </summary>
  public async Task<SharedLinkResponseDto> UpdateSharedLinkAsync(string id, Apigen.Immich.Models.SharedLinkEditDto sharedLinkEditDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "shared-links/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "PATCH", url);
    string json = JsonSerializer.Serialize(sharedLinkEditDto, JsonConfig.Default);
    HttpClientLog.RequestBody(_logger, "PATCH", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PatchAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "PATCH", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "PATCH", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    SharedLinkResponseDto? result = JsonSerializer.Deserialize<SharedLinkResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new SharedLinkResponseDto();
  }


  /// <summary>
  /// Remove assets from a shared link
  /// Operation: DELETE /shared-links/{id}/assets
  /// </summary>
  public async Task<List<AssetIdsResponseDto>> RemoveSharedLinkAssetsAsync(string id, Apigen.Immich.Models.AssetIdsDto assetIdsDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "shared-links/{id}/assets".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "DELETE", url);
    HttpResponseMessage response = await _httpClient.DeleteAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "DELETE", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "DELETE", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    List<AssetIdsResponseDto>? result = JsonSerializer.Deserialize<List<AssetIdsResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<AssetIdsResponseDto>();
  }


  /// <summary>
  /// Add assets to a shared link
  /// Operation: PUT /shared-links/{id}/assets
  /// </summary>
  public async Task<List<AssetIdsResponseDto>> AddSharedLinkAssetsAsync(string id, Apigen.Immich.Models.AssetIdsDto assetIdsDto, AddSharedLinkAssetsRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "shared-links/{id}/assets".BuildUrl(pathParams, request);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(assetIdsDto, JsonConfig.Default);
    HttpClientLog.RequestBody(_logger, "PUT", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PutAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.RequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.RequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }

    HttpClientLog.ResponseBody(_logger, url, responseContent);
    List<AssetIdsResponseDto>? result = JsonSerializer.Deserialize<List<AssetIdsResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<AssetIdsResponseDto>();
  }


}
