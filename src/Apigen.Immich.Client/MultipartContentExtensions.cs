using System.Net.Http;
using System.Text.Json;
using Apigen.Immich.Models;

namespace Apigen.Immich.Client;

internal static class MultipartContentExtensions
{
  public static MultipartFormDataContent ToMultipartContent(this Apigen.Immich.Models.DatabaseBackupUploadDto databaseBackupUploadDto)
  {
    MultipartFormDataContent content = new();
    if (databaseBackupUploadDto.File != null)
    {
      content.Add(new ByteArrayContent(databaseBackupUploadDto.File), "file", "file.bin");
    }
    return content;
  }
  public static MultipartFormDataContent ToMultipartContent(this Apigen.Immich.Models.AssetMediaCreateDto assetMediaCreateDto)
  {
    MultipartFormDataContent content = new();
    content.Add(new ByteArrayContent(assetMediaCreateDto.AssetData), "assetData", assetMediaCreateDto.Filename ?? "assetData.bin");
    if (assetMediaCreateDto.DeviceAssetId != null)
      content.Add(new StringContent(assetMediaCreateDto.DeviceAssetId), "deviceAssetId");
    if (assetMediaCreateDto.DeviceId != null)
      content.Add(new StringContent(assetMediaCreateDto.DeviceId), "deviceId");
    if (assetMediaCreateDto.Duration != null)
      content.Add(new StringContent(assetMediaCreateDto.Duration), "duration");
    content.Add(new StringContent(assetMediaCreateDto.FileCreatedAt.ToString("O")), "fileCreatedAt");
    content.Add(new StringContent(assetMediaCreateDto.FileModifiedAt.ToString("O")), "fileModifiedAt");
    if (assetMediaCreateDto.IsFavorite != null)
      content.Add(new StringContent(assetMediaCreateDto.IsFavorite.Value.ToString().ToLowerInvariant()), "isFavorite");
    if (assetMediaCreateDto.LivePhotoVideoId != null)
      content.Add(new StringContent(assetMediaCreateDto.LivePhotoVideoId.Value.ToString()), "livePhotoVideoId");
    if (assetMediaCreateDto.Metadata != null)
      content.Add(new StringContent(JsonSerializer.Serialize(assetMediaCreateDto.Metadata, JsonConfig.Default)), "metadata");
    if (assetMediaCreateDto.SidecarData != null)
    {
      content.Add(new ByteArrayContent(assetMediaCreateDto.SidecarData), "sidecarData", assetMediaCreateDto.Filename ?? "sidecarData.bin");
    }
    if (assetMediaCreateDto.Visibility != null)
      content.Add(new StringContent(assetMediaCreateDto.Visibility.ToString() ?? ""), "visibility");
    return content;
  }
  public static MultipartFormDataContent ToMultipartContent(this Apigen.Immich.Models.AssetMediaReplaceDto assetMediaReplaceDto)
  {
    MultipartFormDataContent content = new();
    content.Add(new ByteArrayContent(assetMediaReplaceDto.AssetData), "assetData", assetMediaReplaceDto.Filename ?? "assetData.bin");
    if (assetMediaReplaceDto.DeviceAssetId != null)
      content.Add(new StringContent(assetMediaReplaceDto.DeviceAssetId), "deviceAssetId");
    if (assetMediaReplaceDto.DeviceId != null)
      content.Add(new StringContent(assetMediaReplaceDto.DeviceId), "deviceId");
    if (assetMediaReplaceDto.Duration != null)
      content.Add(new StringContent(assetMediaReplaceDto.Duration), "duration");
    content.Add(new StringContent(assetMediaReplaceDto.FileCreatedAt.ToString("O")), "fileCreatedAt");
    content.Add(new StringContent(assetMediaReplaceDto.FileModifiedAt.ToString("O")), "fileModifiedAt");
    return content;
  }
  public static MultipartFormDataContent ToMultipartContent(this Apigen.Immich.Models.CreateProfileImageDto createProfileImageDto)
  {
    MultipartFormDataContent content = new();
    content.Add(new ByteArrayContent(createProfileImageDto.File), "file", "file.bin");
    return content;
  }
}
