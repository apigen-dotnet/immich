using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Assets operations
/// </summary>
public interface IAssetsClient
{
  /// <summary>
  /// Delete assets
  /// Operation: DELETE /assets
  /// </summary>
  Task DeleteAssetsAsync(Apigen.Immich.Models.AssetBulkDeleteDto assetBulkDeleteDto);

  /// <summary>
  /// Upload asset
  /// Operation: POST /assets
  /// </summary>
  Task<AssetMediaResponseDto> UploadAssetAsync(Apigen.Immich.Models.AssetMediaCreateDto assetMediaCreateDto, UploadAssetRequest? request = null);

  /// <summary>
  /// Update assets
  /// Operation: PUT /assets
  /// </summary>
  Task UpdateAssetsAsync(Apigen.Immich.Models.AssetBulkUpdateDto assetBulkUpdateDto);

  /// <summary>
  /// Check bulk upload
  /// Operation: POST /assets/bulk-upload-check
  /// </summary>
  Task<AssetBulkUploadCheckResponseDto> BulkAsync(Apigen.Immich.Models.AssetBulkUploadCheckDto assetBulkUploadCheckDto);

  /// <summary>
  /// Copy asset
  /// Operation: PUT /assets/copy
  /// </summary>
  Task CopyAssetAsync(Apigen.Immich.Models.AssetCopyDto assetCopyDto);

  /// <summary>
  /// Retrieve assets by device ID
  /// Operation: GET /assets/device/{deviceId}
  /// </summary>
  Task<JsonElement> GetAsync(string deviceId);

  /// <summary>
  /// Check existing assets
  /// Operation: POST /assets/exist
  /// </summary>
  Task<CheckExistingAssetsResponseDto> CheckExistingAssetsAsync(Apigen.Immich.Models.CheckExistingAssetsDto checkExistingAssetsDto);

  /// <summary>
  /// Run an asset job
  /// Operation: POST /assets/jobs
  /// </summary>
  Task RunAssetJobsAsync(Apigen.Immich.Models.AssetJobsDto assetJobsDto);

  /// <summary>
  /// Delete asset metadata
  /// Operation: DELETE /assets/metadata
  /// </summary>
  Task DeleteBulkAssetMetadataAsync(Apigen.Immich.Models.AssetMetadataBulkDeleteDto assetMetadataBulkDeleteDto);

  /// <summary>
  /// Upsert asset metadata
  /// Operation: PUT /assets/metadata
  /// </summary>
  Task<List<AssetMetadataBulkResponseDto>> UpdateBulkAssetMetadataAsync(Apigen.Immich.Models.AssetMetadataBulkUpsertDto assetMetadataBulkUpsertDto);

  /// <summary>
  /// Get random assets
  /// Operation: GET /assets/random
  /// </summary>
  Task<List<AssetResponseDto>> GetRandomAsync(GetRandomRequest? request = null);

  /// <summary>
  /// Get asset statistics
  /// Operation: GET /assets/statistics
  /// </summary>
  Task<AssetStatsResponseDto> GetAssetStatisticsAsync(GetAssetStatisticsRequest? request = null);

  /// <summary>
  /// Retrieve an asset
  /// Operation: GET /assets/{id}
  /// </summary>
  Task<AssetResponseDto> GetAsync(string id, GetAssetInfoRequest? request = null);

  /// <summary>
  /// Update an asset
  /// Operation: PUT /assets/{id}
  /// </summary>
  Task<AssetResponseDto> UpdateAsync(string id, Apigen.Immich.Models.UpdateAssetDto updateAssetDto);

  /// <summary>
  /// Remove edits from an existing asset
  /// Operation: DELETE /assets/{id}/edits
  /// </summary>
  Task RemoveAssetEditsAsync(string id);

  /// <summary>
  /// Retrieve edits for an existing asset
  /// Operation: GET /assets/{id}/edits
  /// </summary>
  Task<AssetEditsResponseDto> GetAssetEditsAsync(string id);

  /// <summary>
  /// Apply edits to an existing asset
  /// Operation: PUT /assets/{id}/edits
  /// </summary>
  Task<AssetEditsResponseDto> EditAssetAsync(string id, Apigen.Immich.Models.AssetEditsCreateDto assetEditsCreateDto);

  /// <summary>
  /// Get asset metadata
  /// Operation: GET /assets/{id}/metadata
  /// </summary>
  Task<List<AssetMetadataResponseDto>> GetAssetMetadataAsync(string id);

  /// <summary>
  /// Update asset metadata
  /// Operation: PUT /assets/{id}/metadata
  /// </summary>
  Task<List<AssetMetadataResponseDto>> UpdateAssetMetadataAsync(string id, Apigen.Immich.Models.AssetMetadataUpsertDto assetMetadataUpsertDto);

  /// <summary>
  /// Delete asset metadata by key
  /// Operation: DELETE /assets/{id}/metadata/{key}
  /// </summary>
  Task DeleteAsync(string id, string key);

  /// <summary>
  /// Retrieve asset metadata by key
  /// Operation: GET /assets/{id}/metadata/{key}
  /// </summary>
  Task<AssetMetadataResponseDto> GetAsync(string id, string key);

  /// <summary>
  /// Retrieve asset OCR data
  /// Operation: GET /assets/{id}/ocr
  /// </summary>
  Task<List<AssetOcrResponseDto>> GetAssetOcrAsync(string id);

  /// <summary>
  /// Download original asset
  /// Operation: GET /assets/{id}/original
  /// </summary>
  Task<object> DownloadAssetAsync(string id, DownloadAssetRequest? request = null);

  /// <summary>
  /// Replace asset
  /// Operation: PUT /assets/{id}/original
  /// </summary>
  Task<AssetMediaResponseDto> ReplaceAssetAsync(string id, Apigen.Immich.Models.AssetMediaReplaceDto assetMediaReplaceDto, ReplaceAssetRequest? request = null);

  /// <summary>
  /// View asset thumbnail
  /// Operation: GET /assets/{id}/thumbnail
  /// </summary>
  Task<object> ViewAssetAsync(string id, ViewAssetRequest? request = null);

  /// <summary>
  /// Play asset video
  /// Operation: GET /assets/{id}/video/playback
  /// </summary>
  Task<object> PlayAssetVideoAsync(string id, PlayAssetVideoRequest? request = null);

}
