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
/// Client for Queues operations
/// </summary>
public class QueuesClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal QueuesClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// List all queues
  /// Operation: GET /queues
  /// </summary>
  public async Task<List<QueueResponseDto>> GetQueuesAsync()
  {
    string url = "queues";

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
    List<QueueResponseDto>? result = JsonSerializer.Deserialize<List<QueueResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<QueueResponseDto>();
  }


  /// <summary>
  /// Retrieve a queue
  /// Operation: GET /queues/{name}
  /// </summary>
  public async Task<QueueResponseDto> GetAsync(string name)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["name"] = name
    };
    string url = "queues/{name}".BuildUrl(pathParams);

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
    QueueResponseDto? result = JsonSerializer.Deserialize<QueueResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new QueueResponseDto();
  }


  /// <summary>
  /// Update a queue
  /// Operation: PUT /queues/{name}
  /// </summary>
  public async Task<QueueResponseDto> UpdateAsync(string name, Apigen.Immich.Models.QueueUpdateDto queueUpdateDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["name"] = name
    };
    string url = "queues/{name}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(queueUpdateDto, JsonConfig.Default);
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
    QueueResponseDto? result = JsonSerializer.Deserialize<QueueResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new QueueResponseDto();
  }


  /// <summary>
  /// Empty a queue
  /// Operation: DELETE /queues/{name}/jobs
  /// </summary>
  public async Task EmptyQueueAsync(string name, Apigen.Immich.Models.QueueDeleteDto queueDeleteDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["name"] = name
    };
    string url = "queues/{name}/jobs".BuildUrl(pathParams);

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
  /// Retrieve queue jobs
  /// Operation: GET /queues/{name}/jobs
  /// </summary>
  public async Task<List<QueueJobResponseDto>> GetQueueJobsAsync(string name, GetQueueJobsRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["name"] = name
    };
    string url = "queues/{name}/jobs".BuildUrl(pathParams, request);

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
    List<QueueJobResponseDto>? result = JsonSerializer.Deserialize<List<QueueJobResponseDto>>(responseContent, JsonConfig.Default);
    return result ?? new List<QueueJobResponseDto>();
  }


}
