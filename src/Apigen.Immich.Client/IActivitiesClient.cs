using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Activities operations
/// </summary>
public interface IActivitiesClient
{
  /// <summary>
  /// List all activities
  /// Operation: GET /activities
  /// </summary>
  Task<List<ActivityResponseDto>> GetActivitiesAsync(GetActivitiesRequest? request = null);

  /// <summary>
  /// Create an activity
  /// Operation: POST /activities
  /// </summary>
  Task<ActivityResponseDto> CreateActivityAsync(Apigen.Immich.Models.ActivityCreateDto activityCreateDto);

  /// <summary>
  /// Retrieve activity statistics
  /// Operation: GET /activities/statistics
  /// </summary>
  Task<ActivityStatisticsResponseDto> GetActivityStatisticsAsync(GetActivityStatisticsRequest? request = null);

  /// <summary>
  /// Delete an activity
  /// Operation: DELETE /activities/{id}
  /// </summary>
  Task DeleteAsync(string id);

}
