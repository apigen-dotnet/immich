using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Download operations
/// </summary>
public interface IDownloadClient
{
  /// <summary>
  /// Download asset archive
  /// Operation: POST /download/archive
  /// </summary>
  Task<Stream> DownloadArchiveAsync(Apigen.Immich.Models.DownloadArchiveDto downloadArchiveDto, DownloadArchiveRequest? request = null);

  /// <summary>
  /// Retrieve download information
  /// Operation: POST /download/info
  /// </summary>
  Task<DownloadResponseDto> GetDownloadInfoAsync(Apigen.Immich.Models.DownloadInfoDto downloadInfoDto, GetDownloadInfoRequest? request = null);

}
