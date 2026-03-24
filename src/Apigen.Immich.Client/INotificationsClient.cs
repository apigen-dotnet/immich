using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Notifications operations
/// </summary>
public interface INotificationsClient
{
  /// <summary>
  /// Delete notifications
  /// Operation: DELETE /notifications
  /// </summary>
  Task DeleteNotificationsAsync(Apigen.Immich.Models.NotificationDeleteAllDto notificationDeleteAllDto);

  /// <summary>
  /// Retrieve notifications
  /// Operation: GET /notifications
  /// </summary>
  Task<List<NotificationDto>> GetNotificationsAsync(GetNotificationsRequest? request = null);

  /// <summary>
  /// Update notifications
  /// Operation: PUT /notifications
  /// </summary>
  Task UpdateNotificationsAsync(Apigen.Immich.Models.NotificationUpdateAllDto notificationUpdateAllDto);

  /// <summary>
  /// Delete a notification
  /// Operation: DELETE /notifications/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// Get a notification
  /// Operation: GET /notifications/{id}
  /// </summary>
  Task<NotificationDto> GetAsync(string id);

  /// <summary>
  /// Update a notification
  /// Operation: PUT /notifications/{id}
  /// </summary>
  Task<NotificationDto> UpdateAsync(string id, Apigen.Immich.Models.NotificationUpdateDto notificationUpdateDto);

}
