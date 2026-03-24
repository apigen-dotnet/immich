using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Partners operations
/// </summary>
public interface IPartnersClient
{
  /// <summary>
  /// Retrieve partners
  /// Operation: GET /partners
  /// </summary>
  Task<List<PartnerResponseDto>> GetPartnersAsync(GetPartnersRequest? request = null);

  /// <summary>
  /// Create a partner
  /// Operation: POST /partners
  /// </summary>
  Task<PartnerResponseDto> CreateAsync(Apigen.Immich.Models.PartnerCreateDto partnerCreateDto);

  /// <summary>
  /// Remove a partner
  /// Operation: DELETE /partners/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Create a partner
  /// Operation: POST /partners/{id}
  /// </summary>
  Task<PartnerResponseDto> CreatePartnerDeprecatedAsync(string id);

  /// <summary>
  /// Update a partner
  /// Operation: PUT /partners/{id}
  /// </summary>
  Task<PartnerResponseDto> UpdateAsync(string id, Apigen.Immich.Models.PartnerUpdateDto partnerUpdateDto);

}
