using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for API keys operations
/// </summary>
public interface IApiKeysClient
{
  /// <summary>
  /// List all API keys
  /// Operation: GET /api-keys
  /// </summary>
  Task<List<ApiKeyResponseDto>> GetApiKeysAsync();

  /// <summary>
  /// Create an API key
  /// Operation: POST /api-keys
  /// </summary>
  Task<ApiKeyCreateResponseDto> CreateApiKeyAsync(Apigen.Immich.Models.ApiKeyCreateDto apiKeyCreateDto);

  /// <summary>
  /// Retrieve the current API key
  /// Operation: GET /api-keys/me
  /// </summary>
  Task<ApiKeyResponseDto> GetMyApiKeyAsync();

  /// <summary>
  /// Delete an API key
  /// Operation: DELETE /api-keys/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve an API key
  /// Operation: GET /api-keys/{id}
  /// </summary>
  Task<ApiKeyResponseDto> GetAsync(string id);

  /// <summary>
  /// Update an API key
  /// Operation: PUT /api-keys/{id}
  /// </summary>
  Task<ApiKeyResponseDto> UpdateAsync(string id, Apigen.Immich.Models.ApiKeyUpdateDto apiKeyUpdateDto);

}
