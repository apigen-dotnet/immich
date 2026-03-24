using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Trash operations
/// </summary>
public interface ITrashClient
{
  /// <summary>
  /// Empty trash
  /// Operation: POST /trash/empty
  /// </summary>
  Task<TrashResponseDto> EmptyTrashAsync();

  /// <summary>
  /// Restore trash
  /// Operation: POST /trash/restore
  /// </summary>
  Task<TrashResponseDto> RestoreTrashAsync();

  /// <summary>
  /// Restore assets
  /// Operation: POST /trash/restore/assets
  /// </summary>
  Task<TrashResponseDto> RestoreAssetsAsync(Apigen.Immich.Models.BulkIdsDto bulkIdsDto);

}
