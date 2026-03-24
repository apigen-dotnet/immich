using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for People operations
/// </summary>
public interface IPeopleClient
{
  /// <summary>
  /// Delete people
  /// Operation: DELETE /people
  /// </summary>
  Task DeleteAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

  /// <summary>
  /// Get all people
  /// Operation: GET /people
  /// </summary>
  Task<PeopleResponseDto> GetAllPeopleAsync(GetAllPeopleRequest? request = null);

  /// <summary>
  /// Create a person
  /// Operation: POST /people
  /// </summary>
  Task<PersonResponseDto> CreatePersonAsync(Apigen.Immich.Models.PersonCreateDto personCreateDto);

  /// <summary>
  /// Update people
  /// Operation: PUT /people
  /// </summary>
  Task<List<BulkIdResponseDto>> UpdateAsync(Apigen.Immich.Models.PeopleUpdateDto peopleUpdateDto);

  /// <summary>
  /// Delete person
  /// Operation: DELETE /people/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Get a person
  /// Operation: GET /people/{id}
  /// </summary>
  Task<PersonResponseDto> GetAsync(string id);

  /// <summary>
  /// Update person
  /// Operation: PUT /people/{id}
  /// </summary>
  Task<PersonResponseDto> UpdateAsync(string id, Apigen.Immich.Models.PersonUpdateDto personUpdateDto);

  /// <summary>
  /// Merge people
  /// Operation: POST /people/{id}/merge
  /// </summary>
  Task<List<BulkIdResponseDto>> MergePersonAsync(string id, Apigen.Immich.Models.MergePersonDto mergePersonDto);

  /// <summary>
  /// Reassign faces
  /// Operation: PUT /people/{id}/reassign
  /// </summary>
  Task<List<PersonResponseDto>> ReassignFacesAsync(string id, Apigen.Immich.Models.AssetFaceUpdateDto assetFaceUpdateDto);

  /// <summary>
  /// Get person statistics
  /// Operation: GET /people/{id}/statistics
  /// </summary>
  Task<PersonStatisticsResponseDto> GetPersonStatisticsAsync(string id);

  /// <summary>
  /// Get person thumbnail
  /// Operation: GET /people/{id}/thumbnail
  /// </summary>
  Task<Stream> GetPersonThumbnailAsync(string id);

}
