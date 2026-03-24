using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Shared links operations
/// </summary>
public interface ISharedLinksClient
{
  /// <summary>
  /// Retrieve all shared links
  /// Operation: GET /shared-links
  /// </summary>
  Task<List<SharedLinkResponseDto>> GetAllSharedLinksAsync(GetAllSharedLinksRequest? request = null);

  /// <summary>
  /// Create a shared link
  /// Operation: POST /shared-links
  /// </summary>
  Task<SharedLinkResponseDto> CreateSharedLinkAsync(Apigen.Immich.Models.SharedLinkCreateDto sharedLinkCreateDto);

  /// <summary>
  /// Shared link login
  /// Operation: POST /shared-links/login
  /// </summary>
  Task<SharedLinkResponseDto> SharedLinkLoginAsync(Apigen.Immich.Models.SharedLinkLoginDto sharedLinkLoginDto, SharedLinkLoginRequest? request = null);

  /// <summary>
  /// Retrieve current shared link
  /// Operation: GET /shared-links/me
  /// </summary>
  Task<SharedLinkResponseDto> GetMySharedLinkAsync(GetMySharedLinkRequest? request = null);

  /// <summary>
  /// Delete a shared link
  /// Operation: DELETE /shared-links/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a shared link
  /// Operation: GET /shared-links/{id}
  /// </summary>
  Task<SharedLinkResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a shared link
  /// Operation: PATCH /shared-links/{id}
  /// </summary>
  Task<SharedLinkResponseDto> UpdateSharedLinkAsync(string id, Apigen.Immich.Models.SharedLinkEditDto sharedLinkEditDto);

  /// <summary>
  /// Remove assets from a shared link
  /// Operation: DELETE /shared-links/{id}/assets
  /// </summary>
  Task<List<AssetIdsResponseDto>> RemoveSharedLinkAssetsAsync(string id, Apigen.Immich.Models.AssetIdsDto assetIdsDto);

  /// <summary>
  /// Add assets to a shared link
  /// Operation: PUT /shared-links/{id}/assets
  /// </summary>
  Task<List<AssetIdsResponseDto>> AddSharedLinkAssetsAsync(string id, Apigen.Immich.Models.AssetIdsDto assetIdsDto, AddSharedLinkAssetsRequest? request = null);

}
