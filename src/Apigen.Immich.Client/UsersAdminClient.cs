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
/// Client for Users (admin) operations
/// </summary>
public class UsersAdminClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal UsersAdminClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Search users
  /// Operation: GET /admin/users
  /// </summary>
  public async Task<List<UserAdminResponseDto>> SearchUsersAdminAsync(SearchUsersAdminRequest? request = null)
  {
    string url = "admin/users".BuildUrl(request: request);

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
    List<UserAdminResponseDto>? result = JsonSerializer.Deserialize<List<UserAdminResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<UserAdminResponseDto>();
  }


  /// <summary>
  /// Create a user
  /// Operation: POST /admin/users
  /// </summary>
  public async Task<UserAdminResponseDto> CreateUserAdminAsync(Apigen.Immich.Models.UserAdminCreateDto userAdminCreateDto)
  {
    string url = "admin/users";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(userAdminCreateDto, JsonConfig.Default);
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
    UserAdminResponseDto? result = JsonSerializer.Deserialize<UserAdminResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserAdminResponseDto();
  }


  /// <summary>
  /// Delete a user
  /// Operation: DELETE /admin/users/{id}
  /// </summary>
  public async Task<UserAdminResponseDto> DeleteAsync(string id, Apigen.Immich.Models.UserAdminDeleteDto userAdminDeleteDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}".BuildUrl(pathParams);

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
    UserAdminResponseDto? result = JsonSerializer.Deserialize<UserAdminResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserAdminResponseDto();
  }


  /// <summary>
  /// Retrieve a user
  /// Operation: GET /admin/users/{id}
  /// </summary>
  public async Task<UserAdminResponseDto> GetAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}".BuildUrl(pathParams);

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
    UserAdminResponseDto? result = JsonSerializer.Deserialize<UserAdminResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserAdminResponseDto();
  }


  /// <summary>
  /// Update a user
  /// Operation: PUT /admin/users/{id}
  /// </summary>
  public async Task<UserAdminResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UserAdminUpdateDto userAdminUpdateDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(userAdminUpdateDto, JsonConfig.Default);
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
    UserAdminResponseDto? result = JsonSerializer.Deserialize<UserAdminResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserAdminResponseDto();
  }


  /// <summary>
  /// Retrieve user preferences
  /// Operation: GET /admin/users/{id}/preferences
  /// </summary>
  public async Task<UserPreferencesResponseDto> GetUserPreferencesAdminAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}/preferences".BuildUrl(pathParams);

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
    UserPreferencesResponseDto? result = JsonSerializer.Deserialize<UserPreferencesResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserPreferencesResponseDto();
  }


  /// <summary>
  /// Update user preferences
  /// Operation: PUT /admin/users/{id}/preferences
  /// </summary>
  public async Task<UserPreferencesResponseDto> UpdateUserPreferencesAdminAsync(string id, Apigen.Immich.Models.UserPreferencesUpdateDto userPreferencesUpdateDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}/preferences".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(userPreferencesUpdateDto, JsonConfig.Default);
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
    UserPreferencesResponseDto? result = JsonSerializer.Deserialize<UserPreferencesResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserPreferencesResponseDto();
  }


  /// <summary>
  /// Restore a deleted user
  /// Operation: POST /admin/users/{id}/restore
  /// </summary>
  public async Task<UserAdminResponseDto> RestoreUserAdminAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}/restore".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    HttpResponseMessage response = await _httpClient.PostAsync(url, null);
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
    UserAdminResponseDto? result = JsonSerializer.Deserialize<UserAdminResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new UserAdminResponseDto();
  }


  /// <summary>
  /// Retrieve user sessions
  /// Operation: GET /admin/users/{id}/sessions
  /// </summary>
  public async Task<List<SessionResponseDto>> GetUserSessionsAdminAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}/sessions".BuildUrl(pathParams);

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
    List<SessionResponseDto>? result = JsonSerializer.Deserialize<List<SessionResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<SessionResponseDto>();
  }


  /// <summary>
  /// Retrieve user statistics
  /// Operation: GET /admin/users/{id}/statistics
  /// </summary>
  public async Task<AssetStatsResponseDto> GetUserStatisticsAdminAsync(string id, GetUserStatisticsAdminRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "admin/users/{id}/statistics".BuildUrl(pathParams, request);

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
    AssetStatsResponseDto? result = JsonSerializer.Deserialize<AssetStatsResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new AssetStatsResponseDto();
  }


}
