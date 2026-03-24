using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Timeline operations
/// </summary>
public interface ITimelineClient
{
  /// <summary>
  /// Get time bucket
  /// Operation: GET /timeline/bucket
  /// </summary>
  Task<TimeBucketAssetResponseDto> GetTimeBucketAsync(GetTimeBucketRequest? request = null);

  /// <summary>
  /// Get time buckets
  /// Operation: GET /timeline/buckets
  /// </summary>
  Task<List<TimeBucketsResponseDto>> GetTimeBucketsAsync(GetTimeBucketsRequest? request = null);

}
