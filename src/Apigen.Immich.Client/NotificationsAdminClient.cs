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
/// Client for Notifications (admin) operations
/// </summary>
public class NotificationsAdminClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal NotificationsAdminClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Create a notification
  /// Operation: POST /admin/notifications
  /// </summary>
  public async Task<NotificationDto> CreateNotificationAsync(Apigen.Immich.Models.NotificationCreateDto notificationCreateDto)
  {
    string url = "admin/notifications";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(notificationCreateDto, JsonConfig.Default);
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
    NotificationDto? result = JsonSerializer.Deserialize<NotificationDto>(responseContent, JsonConfig.Default);
    return result ?? new NotificationDto();
  }


  /// <summary>
  /// Render email template
  /// Operation: POST /admin/notifications/templates/{name}
  /// </summary>
  public async Task<TemplateResponseDto> GetNotificationTemplateAdminAsync(string name, Apigen.Immich.Models.TemplateDto templateDto)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["name"] = name
    };
    string url = "admin/notifications/templates/{name}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(templateDto, JsonConfig.Default);
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
    TemplateResponseDto? result = JsonSerializer.Deserialize<TemplateResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new TemplateResponseDto();
  }


  /// <summary>
  /// Send test email
  /// Operation: POST /admin/notifications/test-email
  /// </summary>
  public async Task<TestEmailResponseDto> SendTestEmailAdminAsync(Apigen.Immich.Models.SystemConfigSmtpDto systemConfigSmtpDto)
  {
    string url = "admin/notifications/test-email";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.RequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(systemConfigSmtpDto, JsonConfig.Default);
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
    TestEmailResponseDto? result = JsonSerializer.Deserialize<TestEmailResponseDto>(responseContent, JsonConfig.Default);
    return result ?? new TestEmailResponseDto();
  }


}
