using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for People operations
/// </summary>
public partial interface IPeopleClient
{
  /// <summary>
  /// Delete people
  /// Operation: DELETE /people
  /// </summary>
  Task DeleteAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get all people
  /// Operation: GET /people
  /// </summary>
  Task<PeopleResponseDto> GetAllPeopleAsync(GetAllPeopleRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Create a person
  /// Operation: POST /people
  /// </summary>
  Task<PersonResponseDto> CreatePersonAsync(Apigen.Immich.Models.PersonCreateDto personCreateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update people
  /// Operation: PUT /people
  /// </summary>
  Task<List<BulkIdResponseDto>> UpdateAsync(Apigen.Immich.Models.PeopleUpdateDto peopleUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete person
  /// Operation: DELETE /people/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get a person
  /// Operation: GET /people/{id}
  /// </summary>
  Task<PersonResponseDto> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update person
  /// Operation: PUT /people/{id}
  /// </summary>
  Task<PersonResponseDto> UpdateAsync(string id, Apigen.Immich.Models.PersonUpdateDto personUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Merge people
  /// Operation: POST /people/{id}/merge
  /// </summary>
  Task<List<BulkIdResponseDto>> MergePersonAsync(string id, Apigen.Immich.Models.MergePersonDto mergePersonDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Reassign faces
  /// Operation: PUT /people/{id}/reassign
  /// </summary>
  Task<List<PersonResponseDto>> ReassignFacesAsync(string id, Apigen.Immich.Models.AssetFaceUpdateDto assetFaceUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get person statistics
  /// Operation: GET /people/{id}/statistics
  /// </summary>
  Task<PersonStatisticsResponseDto> GetPersonStatisticsAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get person thumbnail
  /// Operation: GET /people/{id}/thumbnail
  /// </summary>
  Task<Stream> GetPersonThumbnailAsync(string id, CancellationToken cancellationToken = default);

}
