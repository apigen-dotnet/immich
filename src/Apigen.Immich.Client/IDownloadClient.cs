using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Download operations
/// </summary>
public partial interface IDownloadClient
{
  /// <summary>
  /// Download asset archive
  /// Operation: POST /download/archive
  /// </summary>
  Task<Stream> DownloadArchiveAsync(Apigen.Immich.Models.DownloadArchiveDto downloadArchiveDto, DownloadArchiveRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve download information
  /// Operation: POST /download/info
  /// </summary>
  Task<DownloadResponseDto> GetDownloadInfoAsync(Apigen.Immich.Models.DownloadInfoDto downloadInfoDto, GetDownloadInfoRequest? request = null, CancellationToken cancellationToken = default);

}
