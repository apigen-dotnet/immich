using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Assets operations
/// </summary>
public partial interface IAssetsClient
{
  /// <summary>
  /// Delete assets
  /// Operation: DELETE /assets
  /// </summary>
  Task DeleteAssetsAsync(Apigen.Immich.Models.AssetBulkDeleteDto assetBulkDeleteDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Upload asset
  /// Operation: POST /assets
  /// </summary>
  Task<AssetMediaResponseDto> UploadAssetAsync(Apigen.Immich.Models.AssetMediaCreateDto assetMediaCreateDto, UploadAssetRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update assets
  /// Operation: PUT /assets
  /// </summary>
  Task UpdateAssetsAsync(Apigen.Immich.Models.AssetBulkUpdateDto assetBulkUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Check bulk upload
  /// Operation: POST /assets/bulk-upload-check
  /// </summary>
  Task<AssetBulkUploadCheckResponseDto> BulkAsync(Apigen.Immich.Models.AssetBulkUploadCheckDto assetBulkUploadCheckDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Copy asset
  /// Operation: PUT /assets/copy
  /// </summary>
  Task CopyAssetAsync(Apigen.Immich.Models.AssetCopyDto assetCopyDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve assets by device ID
  /// Operation: GET /assets/device/{deviceId}
  /// </summary>
  Task<JsonElement> GetAsync(string deviceId, CancellationToken cancellationToken = default);

  /// <summary>
  /// Check existing assets
  /// Operation: POST /assets/exist
  /// </summary>
  Task<CheckExistingAssetsResponseDto> CheckExistingAssetsAsync(Apigen.Immich.Models.CheckExistingAssetsDto checkExistingAssetsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Run an asset job
  /// Operation: POST /assets/jobs
  /// </summary>
  Task RunAssetJobsAsync(Apigen.Immich.Models.AssetJobsDto assetJobsDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete asset metadata
  /// Operation: DELETE /assets/metadata
  /// </summary>
  Task DeleteBulkAssetMetadataAsync(Apigen.Immich.Models.AssetMetadataBulkDeleteDto assetMetadataBulkDeleteDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Upsert asset metadata
  /// Operation: PUT /assets/metadata
  /// </summary>
  Task<List<AssetMetadataBulkResponseDto>> UpdateBulkAssetMetadataAsync(Apigen.Immich.Models.AssetMetadataBulkUpsertDto assetMetadataBulkUpsertDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get random assets
  /// Operation: GET /assets/random
  /// </summary>
  Task<List<AssetResponseDto>> GetRandomAsync(GetRandomRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get asset statistics
  /// Operation: GET /assets/statistics
  /// </summary>
  Task<AssetStatsResponseDto> GetAssetStatisticsAsync(GetAssetStatisticsRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve an asset
  /// Operation: GET /assets/{id}
  /// </summary>
  Task<AssetResponseDto> GetAsync(string id, GetAssetInfoRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update an asset
  /// Operation: PUT /assets/{id}
  /// </summary>
  Task<AssetResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UpdateAssetDto updateAssetDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Remove edits from an existing asset
  /// Operation: DELETE /assets/{id}/edits
  /// </summary>
  Task RemoveAssetEditsAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve edits for an existing asset
  /// Operation: GET /assets/{id}/edits
  /// </summary>
  Task<AssetEditsResponseDto> GetAssetEditsAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Apply edits to an existing asset
  /// Operation: PUT /assets/{id}/edits
  /// </summary>
  Task<AssetEditsResponseDto> EditAssetAsync(string id, Apigen.Immich.Models.AssetEditsCreateDto assetEditsCreateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Get asset metadata
  /// Operation: GET /assets/{id}/metadata
  /// </summary>
  Task<List<AssetMetadataResponseDto>> GetAssetMetadataAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update asset metadata
  /// Operation: PUT /assets/{id}/metadata
  /// </summary>
  Task<List<AssetMetadataResponseDto>> UpdateAssetMetadataAsync(string id, Apigen.Immich.Models.AssetMetadataUpsertDto assetMetadataUpsertDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Delete asset metadata by key
  /// Operation: DELETE /assets/{id}/metadata/{key}
  /// </summary>
  Task DeleteAsync(string id, string key, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve asset metadata by key
  /// Operation: GET /assets/{id}/metadata/{key}
  /// </summary>
  Task<AssetMetadataResponseDto> GetAsync(string id, string key, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve asset OCR data
  /// Operation: GET /assets/{id}/ocr
  /// </summary>
  Task<List<AssetOcrResponseDto>> GetAssetOcrAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Download original asset
  /// Operation: GET /assets/{id}/original
  /// </summary>
  Task<Stream> DownloadAssetAsync(string id, DownloadAssetRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Replace asset
  /// Operation: PUT /assets/{id}/original
  /// </summary>
  Task<AssetMediaResponseDto> ReplaceAssetAsync(string id, Apigen.Immich.Models.AssetMediaReplaceDto assetMediaReplaceDto, ReplaceAssetRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// View asset thumbnail
  /// Operation: GET /assets/{id}/thumbnail
  /// </summary>
  Task<Stream> ViewAssetAsync(string id, ViewAssetRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Play asset video
  /// Operation: GET /assets/{id}/video/playback
  /// </summary>
  Task<Stream> PlayAssetVideoAsync(string id, PlayAssetVideoRequest? request = null, CancellationToken cancellationToken = default);

}
