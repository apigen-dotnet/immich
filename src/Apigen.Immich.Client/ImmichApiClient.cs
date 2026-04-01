using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Apigen.Immich.Models;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Main API client for accessing all resources
/// </summary>
public class ImmichApiClient
{
  private readonly HttpClient _httpClient;
  private readonly bool _disposeHttpClient;
  private readonly ILogger? _logger;

  /// <summary>
  /// Client for Activities operations
  /// </summary>
  public ActivitiesClient Activities { get; }

  /// <summary>
  /// Client for Authentication (admin) operations
  /// </summary>
  public AuthenticationAdminClient AuthenticationAdmin { get; }

  /// <summary>
  /// Client for Database Backups (admin) operations
  /// </summary>
  public DatabaseBackupsAdminClient DatabaseBackupsAdmin { get; }

  /// <summary>
  /// Client for Maintenance (admin) operations
  /// </summary>
  public MaintenanceAdminClient MaintenanceAdmin { get; }

  /// <summary>
  /// Client for Notifications (admin) operations
  /// </summary>
  public NotificationsAdminClient NotificationsAdmin { get; }

  /// <summary>
  /// Client for Users (admin) operations
  /// </summary>
  public UsersAdminClient UsersAdmin { get; }

  /// <summary>
  /// Client for Albums operations
  /// </summary>
  public AlbumsClient Albums { get; }

  /// <summary>
  /// Client for API keys operations
  /// </summary>
  public ApiKeysClient ApiKeys { get; }

  /// <summary>
  /// Client for Assets operations
  /// </summary>
  public AssetsClient Assets { get; }

  /// <summary>
  /// Client for Authentication operations
  /// </summary>
  public AuthenticationClient Authentication { get; }

  /// <summary>
  /// Client for Download operations
  /// </summary>
  public DownloadClient Download { get; }

  /// <summary>
  /// Client for Duplicates operations
  /// </summary>
  public DuplicatesClient Duplicates { get; }

  /// <summary>
  /// Client for Faces operations
  /// </summary>
  public FacesClient Faces { get; }

  /// <summary>
  /// Client for Jobs operations
  /// </summary>
  public JobsClient Jobs { get; }

  /// <summary>
  /// Client for Libraries operations
  /// </summary>
  public LibrariesClient Libraries { get; }

  /// <summary>
  /// Client for Map operations
  /// </summary>
  public MapClient Map { get; }

  /// <summary>
  /// Client for Memories operations
  /// </summary>
  public MemoriesClient Memories { get; }

  /// <summary>
  /// Client for Notifications operations
  /// </summary>
  public NotificationsClient Notifications { get; }

  /// <summary>
  /// Client for Partners operations
  /// </summary>
  public PartnersClient Partners { get; }

  /// <summary>
  /// Client for People operations
  /// </summary>
  public PeopleClient People { get; }

  /// <summary>
  /// Client for Plugins operations
  /// </summary>
  public PluginsClient Plugins { get; }

  /// <summary>
  /// Client for Queues operations
  /// </summary>
  public QueuesClient Queues { get; }

  /// <summary>
  /// Client for Search operations
  /// </summary>
  public SearchClient Search { get; }

  /// <summary>
  /// Client for Server operations
  /// </summary>
  public ServerClient Server { get; }

  /// <summary>
  /// Client for Sessions operations
  /// </summary>
  public SessionsClient Sessions { get; }

  /// <summary>
  /// Client for Shared links operations
  /// </summary>
  public SharedLinksClient SharedLinks { get; }

  /// <summary>
  /// Client for Stacks operations
  /// </summary>
  public StacksClient Stacks { get; }

  /// <summary>
  /// Client for Sync operations
  /// </summary>
  public SyncClient Sync { get; }

  /// <summary>
  /// Client for System config operations
  /// </summary>
  public SystemConfigClient SystemConfig { get; }

  /// <summary>
  /// Client for System metadata operations
  /// </summary>
  public SystemMetadataClient SystemMetadata { get; }

  /// <summary>
  /// Client for Tags operations
  /// </summary>
  public TagsClient Tags { get; }

  /// <summary>
  /// Client for Timeline operations
  /// </summary>
  public TimelineClient Timeline { get; }

  /// <summary>
  /// Client for Trash operations
  /// </summary>
  public TrashClient Trash { get; }

  /// <summary>
  /// Client for Users operations
  /// </summary>
  public UsersClient Users { get; }

  /// <summary>
  /// Client for Views operations
  /// </summary>
  public ViewsClient Views { get; }

  /// <summary>
  /// Client for Workflows operations
  /// </summary>
  public WorkflowsClient Workflows { get; }

  /// <summary>
  /// Initialize client with a pre-configured HttpClient
  /// </summary>
  /// <param name="httpClient">Pre-configured HttpClient with base address, auth headers, etc.</param>
  /// <param name="logger">Optional logger for request/response logging</param>
  public ImmichApiClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _disposeHttpClient = false;
    _logger = logger;

    Activities = new ActivitiesClient(_httpClient, _logger);
    AuthenticationAdmin = new AuthenticationAdminClient(_httpClient, _logger);
    DatabaseBackupsAdmin = new DatabaseBackupsAdminClient(_httpClient, _logger);
    MaintenanceAdmin = new MaintenanceAdminClient(_httpClient, _logger);
    NotificationsAdmin = new NotificationsAdminClient(_httpClient, _logger);
    UsersAdmin = new UsersAdminClient(_httpClient, _logger);
    Albums = new AlbumsClient(_httpClient, _logger);
    ApiKeys = new ApiKeysClient(_httpClient, _logger);
    Assets = new AssetsClient(_httpClient, _logger);
    Authentication = new AuthenticationClient(_httpClient, _logger);
    Download = new DownloadClient(_httpClient, _logger);
    Duplicates = new DuplicatesClient(_httpClient, _logger);
    Faces = new FacesClient(_httpClient, _logger);
    Jobs = new JobsClient(_httpClient, _logger);
    Libraries = new LibrariesClient(_httpClient, _logger);
    Map = new MapClient(_httpClient, _logger);
    Memories = new MemoriesClient(_httpClient, _logger);
    Notifications = new NotificationsClient(_httpClient, _logger);
    Partners = new PartnersClient(_httpClient, _logger);
    People = new PeopleClient(_httpClient, _logger);
    Plugins = new PluginsClient(_httpClient, _logger);
    Queues = new QueuesClient(_httpClient, _logger);
    Search = new SearchClient(_httpClient, _logger);
    Server = new ServerClient(_httpClient, _logger);
    Sessions = new SessionsClient(_httpClient, _logger);
    SharedLinks = new SharedLinksClient(_httpClient, _logger);
    Stacks = new StacksClient(_httpClient, _logger);
    Sync = new SyncClient(_httpClient, _logger);
    SystemConfig = new SystemConfigClient(_httpClient, _logger);
    SystemMetadata = new SystemMetadataClient(_httpClient, _logger);
    Tags = new TagsClient(_httpClient, _logger);
    Timeline = new TimelineClient(_httpClient, _logger);
    Trash = new TrashClient(_httpClient, _logger);
    Users = new UsersClient(_httpClient, _logger);
    Views = new ViewsClient(_httpClient, _logger);
    Workflows = new WorkflowsClient(_httpClient, _logger);
  }

  private ImmichApiClient(HttpClient httpClient, bool disposeHttpClient, ILogger? logger)
  {
    _httpClient = httpClient;
    _disposeHttpClient = disposeHttpClient;
    _logger = logger;

    Activities = new ActivitiesClient(_httpClient, _logger);
    AuthenticationAdmin = new AuthenticationAdminClient(_httpClient, _logger);
    DatabaseBackupsAdmin = new DatabaseBackupsAdminClient(_httpClient, _logger);
    MaintenanceAdmin = new MaintenanceAdminClient(_httpClient, _logger);
    NotificationsAdmin = new NotificationsAdminClient(_httpClient, _logger);
    UsersAdmin = new UsersAdminClient(_httpClient, _logger);
    Albums = new AlbumsClient(_httpClient, _logger);
    ApiKeys = new ApiKeysClient(_httpClient, _logger);
    Assets = new AssetsClient(_httpClient, _logger);
    Authentication = new AuthenticationClient(_httpClient, _logger);
    Download = new DownloadClient(_httpClient, _logger);
    Duplicates = new DuplicatesClient(_httpClient, _logger);
    Faces = new FacesClient(_httpClient, _logger);
    Jobs = new JobsClient(_httpClient, _logger);
    Libraries = new LibrariesClient(_httpClient, _logger);
    Map = new MapClient(_httpClient, _logger);
    Memories = new MemoriesClient(_httpClient, _logger);
    Notifications = new NotificationsClient(_httpClient, _logger);
    Partners = new PartnersClient(_httpClient, _logger);
    People = new PeopleClient(_httpClient, _logger);
    Plugins = new PluginsClient(_httpClient, _logger);
    Queues = new QueuesClient(_httpClient, _logger);
    Search = new SearchClient(_httpClient, _logger);
    Server = new ServerClient(_httpClient, _logger);
    Sessions = new SessionsClient(_httpClient, _logger);
    SharedLinks = new SharedLinksClient(_httpClient, _logger);
    Stacks = new StacksClient(_httpClient, _logger);
    Sync = new SyncClient(_httpClient, _logger);
    SystemConfig = new SystemConfigClient(_httpClient, _logger);
    SystemMetadata = new SystemMetadataClient(_httpClient, _logger);
    Tags = new TagsClient(_httpClient, _logger);
    Timeline = new TimelineClient(_httpClient, _logger);
    Trash = new TrashClient(_httpClient, _logger);
    Users = new UsersClient(_httpClient, _logger);
    Views = new ViewsClient(_httpClient, _logger);
    Workflows = new WorkflowsClient(_httpClient, _logger);
  }

  /// <summary>
  /// Create client with Bearer token authentication
  /// </summary>
  public static ImmichApiClient WithBearer(string bearerToken, string baseUrl = "/api", ILogger? logger = null)
  {
    HttpClient httpClient = CreateTokenAuthHttpClient(bearerToken, baseUrl, "Authorization", true);
    return new ImmichApiClient(httpClient, true, logger);
  }

  /// <summary>
  /// Create client with cookie-based authentication
  /// </summary>
  public static ImmichApiClient WithCookie(string sessionToken, string baseUrl = "/api", ILogger? logger = null)
  {
    HttpClient httpClient = CreateCookieAuthHttpClient(sessionToken, "immich_access_token", baseUrl);
    return new ImmichApiClient(httpClient, true, logger);
  }

  /// <summary>
  /// Create client with x-api-key authentication
  /// </summary>
  public static ImmichApiClient WithApiKey(string apiKey, string baseUrl = "/api", ILogger? logger = null)
  {
    HttpClient httpClient = CreateTokenAuthHttpClient(apiKey, baseUrl, "x-api-key", false);
    return new ImmichApiClient(httpClient, true, logger);
  }

  private static HttpClient CreateTokenAuthHttpClient(string apiToken, string baseUrl, string headerName, bool useBearer)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    if (useBearer)
    {
      client.DefaultRequestHeaders.Add(headerName, $"Bearer {apiToken}");
    }
    else
    {
      client.DefaultRequestHeaders.Add(headerName, apiToken);
    }

    return client;
  }

  private static HttpClient CreateBasicAuthHttpClient(string username, string password, string baseUrl)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    string credentials = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
    client.DefaultRequestHeaders.Add("Authorization", $"Basic {credentials}");

    return client;
  }

  private static HttpClient CreateCookieAuthHttpClient(string token, string cookieName, string baseUrl)
  {
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    System.Net.CookieContainer cookies = new();
    cookies.Add(new Uri(normalizedBaseUrl), new System.Net.Cookie(cookieName, token));
    HttpClientHandler handler = new() { CookieContainer = cookies };
    HttpClient client = new(handler) { BaseAddress = new Uri(normalizedBaseUrl) };

    return client;
  }

  /// <summary>
  /// Dispose resources
  /// </summary>
  public void Dispose()
  {
    if (_disposeHttpClient)
    {
      _httpClient?.Dispose();
    }
  }
}
