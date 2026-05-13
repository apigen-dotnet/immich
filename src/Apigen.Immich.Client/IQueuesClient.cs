using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Queues operations
/// </summary>
public partial interface IQueuesClient
{
  /// <summary>
  /// List all queues
  /// Operation: GET /queues
  /// </summary>
  Task<List<QueueResponseDto>> GetQueuesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve a queue
  /// Operation: GET /queues/{name}
  /// </summary>
  Task<QueueResponseDto> GetAsync(string name, CancellationToken cancellationToken = default);

  /// <summary>
  /// Update a queue
  /// Operation: PUT /queues/{name}
  /// </summary>
  Task<QueueResponseDto> UpdateAsync(string name, Apigen.Immich.Models.QueueUpdateDto queueUpdateDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Empty a queue
  /// Operation: DELETE /queues/{name}/jobs
  /// </summary>
  Task EmptyQueueAsync(string name, Apigen.Immich.Models.QueueDeleteDto queueDeleteDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve queue jobs
  /// Operation: GET /queues/{name}/jobs
  /// </summary>
  Task<List<QueueJobResponseDto>> GetQueueJobsAsync(string name, GetQueueJobsRequest? request = null, CancellationToken cancellationToken = default);

}
