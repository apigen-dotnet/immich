using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Tags operations
/// </summary>
public interface ITagsClient
{
  /// <summary>
  /// Retrieve tags
  /// Operation: GET /tags
  /// </summary>
  Task<List<TagResponseDto>> GetAllTagsAsync();

  /// <summary>
  /// Create a tag
  /// Operation: POST /tags
  /// </summary>
  Task<TagResponseDto> CreateAsync(Apigen.Immich.Models.TagCreateDto tagCreateDto);

  /// <summary>
  /// Upsert tags
  /// Operation: PUT /tags
  /// </summary>
  Task<List<TagResponseDto>> UpsertTagsAsync(Apigen.Immich.Models.TagUpsertDto tagUpsertDto);

  /// <summary>
  /// Tag assets
  /// Operation: PUT /tags/assets
  /// </summary>
  Task<TagBulkAssetsResponseDto> BulkTagAssetsAsync(Apigen.Immich.Models.TagBulkAssetsDto tagBulkAssetsDto);

  /// <summary>
  /// Delete a tag
  /// Operation: DELETE /tags/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Retrieve a tag
  /// Operation: GET /tags/{id}
  /// </summary>
  Task<TagResponseDto> GetAsync(string id);

  /// <summary>
  /// Update a tag
  /// Operation: PUT /tags/{id}
  /// </summary>
  Task<TagResponseDto> UpdateAsync(string id, Apigen.Immich.Models.TagUpdateDto tagUpdateDto);

  /// <summary>
  /// Untag assets
  /// Operation: DELETE /tags/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> UntagAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Tag assets
  /// Operation: PUT /tags/{id}/assets
  /// </summary>
  Task<List<BulkIdResponseDto>> TagAssetsAsync(string id, Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

}
