using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Faces operations
/// </summary>
public interface IFacesClient
{
  /// <summary>
  /// Retrieve faces for asset
  /// Operation: GET /faces
  /// </summary>
  Task<List<AssetFaceResponseDto>> GetFacesAsync(GetFacesRequest? request = null);

  /// <summary>
  /// Create a face
  /// Operation: POST /faces
  /// </summary>
  Task CreateAsync(Apigen.Immich.Models.AssetFaceCreateDto assetFaceCreateDto);

  /// <summary>
  /// Delete a face
  /// Operation: DELETE /faces/{id}
  /// </summary>
  Task DeleteAsync(string id, Apigen.Immich.Models.AssetFaceDeleteDto assetFaceDeleteDto);

  /// <summary>
  /// Re-assign a face to another person
  /// Operation: PUT /faces/{id}
  /// </summary>
  Task<PersonResponseDto> UpdateAsync(string id, Apigen.Immich.Models.FaceDto faceDto);

}
