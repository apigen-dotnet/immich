using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Sync operations
/// </summary>
public interface ISyncClient
{
  /// <summary>
  /// Delete acknowledgements
  /// Operation: DELETE /sync/ack
  /// </summary>
  Task DeleteSyncAckAsync(Apigen.Immich.Models.SyncAckDeleteDto syncAckDeleteDto);

  /// <summary>
  /// Retrieve acknowledgements
  /// Operation: GET /sync/ack
  /// </summary>
  Task<List<SyncAckDto>> GetSyncAckAsync();

  /// <summary>
  /// Acknowledge changes
  /// Operation: POST /sync/ack
  /// </summary>
  Task SendSyncAckAsync(Apigen.Immich.Models.SyncAckSetDto syncAckSetDto);

  /// <summary>
  /// Get delta sync for user
  /// Operation: POST /sync/delta-sync
  /// </summary>
  Task<AssetDeltaSyncResponseDto> GetDeltaSyncAsync(Apigen.Immich.Models.AssetDeltaSyncDto assetDeltaSyncDto);

  /// <summary>
  /// Get full sync for user
  /// Operation: POST /sync/full-sync
  /// </summary>
  Task<List<AssetResponseDto>> GetFullSyncForUserAsync(Apigen.Immich.Models.AssetFullSyncDto assetFullSyncDto);

  /// <summary>
  /// Stream sync changes
  /// Operation: POST /sync/stream
  /// </summary>
  Task GetSyncStreamAsync(Apigen.Immich.Models.SyncStreamDto syncStreamDto);

}
