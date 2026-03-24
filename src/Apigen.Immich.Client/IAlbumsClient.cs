using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Albums operations
/// </summary>
public interface IAlbumsClient
{
  /// <summary>
  /// List all albums
  /// Operation: GET /albums
  /// </summary>
  Task<List<AlbumResponseDto>> GetAllAlbumsAsync(GetAllAlbumsRequest? request = null);

  /// <summary>
  /// Create an album
  /// Operation: POST /albums
  /// </summary>
  Task<AlbumResponseDto> CreateAsync(Apigen.Immich.Models.CreateAlbumDto createAlbumDto);

  /// <summary>
  /// Add assets to albums
  /// Operation: PUT /albums/assets
  /// </summary>
  Task<AlbumsAddAssetsResponseDto> AddAssetsToAlbumsAsync(Apigen.Immich.Models.AlbumsAddAssetsDto albumsAddAssetsDto, AddAssetsToAlbumsRequest? request = null);

  /// <summary>
  /// Retrieve album statistics
  /// Operation: GET /albums/statistics
  /// </summary>
  Task<AlbumStatisticsResponseDto> GetAlbumStatisticsAsync();

  /// <summary>
  /// Delete an album
  /// Operation: DELETE /albums/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve an album
  /// Operation: GET /albums/{id}
  /// </summary>
  Task<AlbumResponseDto> GetAsync(string id, GetAlbumInfoRequest? request = null);

  /// <summary>
  /// Update an album
  /// Operation: PATCH /albums/{id}
  /// </summary>
  Task<AlbumResponseDto> UpdateAlbumInfoAsync(string id, Apigen.Immich.Models.UpdateAlbumDto updateAlbumDto);

  /// <summary>
  /// Remove assets from an album
  /// Operation: DELETE /albums/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> RemoveAssetFromAlbumAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Add assets to an album
  /// Operation: PUT /albums/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> AddAssetsToAlbumAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto, AddAssetsToAlbumRequest? request = null);

  /// <summary>
  /// Remove user from album
  /// Operation: DELETE /albums/{id}/user/{userId}
  /// </summary>
  Task DeleteAsync(string id, string userId);

  /// <summary>
  /// Update user role
  /// Operation: PUT /albums/{id}/user/{userId}
  /// </summary>
  Task UpdateAsync(string id, string userId, Apigen.Immich.Models.UpdateAlbumUserDto updateAlbumUserDto);

  /// <summary>
  /// Share album with users
  /// Operation: PUT /albums/{id}/users
  /// </summary>
  Task<AlbumResponseDto> AddUsersToAlbumAsync(string id, Apigen.Immich.Models.AddUsersDto addUsersDto);

}
