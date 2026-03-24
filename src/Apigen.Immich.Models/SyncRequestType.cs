using System;
using System.Text.Json.Serialization;

namespace Apigen.Immich.Models;

/// <summary>
/// Sync request types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SyncRequestType
{
    [JsonStringEnumMemberName("AlbumsV1")]
    AlbumsV1,
    [JsonStringEnumMemberName("AlbumUsersV1")]
    AlbumUsersV1,
    [JsonStringEnumMemberName("AlbumToAssetsV1")]
    AlbumToAssetsV1,
    [JsonStringEnumMemberName("AlbumAssetsV1")]
    AlbumAssetsV1,
    [JsonStringEnumMemberName("AlbumAssetExifsV1")]
    AlbumAssetExifsV1,
    [JsonStringEnumMemberName("AssetsV1")]
    AssetsV1,
    [JsonStringEnumMemberName("AssetExifsV1")]
    AssetExifsV1,
    [JsonStringEnumMemberName("AssetEditsV1")]
    AssetEditsV1,
    [JsonStringEnumMemberName("AssetMetadataV1")]
    AssetMetadataV1,
    [JsonStringEnumMemberName("AuthUsersV1")]
    AuthUsersV1,
    [JsonStringEnumMemberName("MemoriesV1")]
    MemoriesV1,
    [JsonStringEnumMemberName("MemoryToAssetsV1")]
    MemoryToAssetsV1,
    [JsonStringEnumMemberName("PartnersV1")]
    PartnersV1,
    [JsonStringEnumMemberName("PartnerAssetsV1")]
    PartnerAssetsV1,
    [JsonStringEnumMemberName("PartnerAssetExifsV1")]
    PartnerAssetExifsV1,
    [JsonStringEnumMemberName("PartnerStacksV1")]
    PartnerStacksV1,
    [JsonStringEnumMemberName("StacksV1")]
    StacksV1,
    [JsonStringEnumMemberName("UsersV1")]
    UsersV1,
    [JsonStringEnumMemberName("PeopleV1")]
    PeopleV1,
    [JsonStringEnumMemberName("AssetFacesV1")]
    AssetFacesV1,
    [JsonStringEnumMemberName("AssetFacesV2")]
    AssetFacesV2,
    [JsonStringEnumMemberName("UserMetadataV1")]
    UserMetadataV1,
}
