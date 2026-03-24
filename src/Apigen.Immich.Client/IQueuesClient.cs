using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Queues operations
/// </summary>
public interface IQueuesClient
{
  /// <summary>
  /// List all queues
  /// Operation: GET /queues
  /// </summary>
  Task<List<QueueResponseDto>> GetQueuesAsync();

  /// <summary>
  /// Retrieve a queue
  /// Operation: GET /queues/{name}
  /// </summary>
  Task<QueueResponseDto> GetAsync(string name);

  /// <summary>
  /// Update a queue
  /// Operation: PUT /queues/{name}
  /// </summary>
  Task<QueueResponseDto> UpdateAsync(string name, Apigen.Immich.Models.QueueUpdateDto queueUpdateDto);

  /// <summary>
  /// Empty a queue
  /// Operation: DELETE /queues/{name}/jobs
  /// </summary>
  Task EmptyQueueAsync(string name, Apigen.Immich.Models.QueueDeleteDto queueDeleteDto);

  /// <summary>
  /// Retrieve queue jobs
  /// Operation: GET /queues/{name}/jobs
  /// </summary>
  Task<List<QueueJobResponseDto>> GetQueueJobsAsync(string name, GetQueueJobsRequest? request = null);

}
