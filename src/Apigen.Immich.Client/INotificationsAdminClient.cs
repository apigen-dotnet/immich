using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Notifications (admin) operations
/// </summary>
public interface INotificationsAdminClient
{
  /// <summary>
  /// Create a notification
  /// Operation: POST /admin/notifications
  /// </summary>
  Task<NotificationDto> CreateNotificationAsync(Apigen.Immich.Models.NotificationCreateDto notificationCreateDto);

  /// <summary>
  /// Render email template
  /// Operation: POST /admin/notifications/templates/{name}
  /// </summary>
  Task<TemplateResponseDto> GetNotificationTemplateAdminAsync(string name, Apigen.Immich.Models.TemplateDto templateDto);

  /// <summary>
  /// Send test email
  /// Operation: POST /admin/notifications/test-email
  /// </summary>
  Task<TestEmailResponseDto> SendTestEmailAdminAsync(Apigen.Immich.Models.SystemConfigSmtpDto systemConfigSmtpDto);

}
