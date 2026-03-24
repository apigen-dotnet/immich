using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Jobs operations
/// </summary>
public interface IJobsClient
{
  /// <summary>
  /// Retrieve queue counts and status
  /// Operation: GET /jobs
  /// </summary>
  Task<QueuesResponseLegacyDto> GetQueuesLegacyAsync();

  /// <summary>
  /// Create a manual job
  /// Operation: POST /jobs
  /// </summary>
  Task CreateAsync(Apigen.Immich.Models.JobCreateDto jobCreateDto);

  /// <summary>
  /// Run jobs
  /// Operation: PUT /jobs/{name}
  /// </summary>
  Task<QueueResponseLegacyDto> UpdateAsync(string name, Apigen.Immich.Models.QueueCommandDto queueCommandDto);

}
