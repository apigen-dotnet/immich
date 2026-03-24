using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Database Backups (admin) operations
/// </summary>
public interface IDatabaseBackupsAdminClient
{
  /// <summary>
  /// Delete database backup
  /// Operation: DELETE /admin/database-backups
  /// </summary>
  Task DeleteDatabaseBackupAsync(Apigen.Immich.Models.DatabaseBackupDeleteDto databaseBackupDeleteDto);

  /// <summary>
  /// List database backups
  /// Operation: GET /admin/database-backups
  /// </summary>
  Task<DatabaseBackupListResponseDto> ListDatabaseBackupsAsync();

  /// <summary>
  /// Start database backup restore flow
  /// Operation: POST /admin/database-backups/start-restore
  /// </summary>
  Task StartDatabaseRestoreFlowAsync();

  /// <summary>
  /// Upload database backup
  /// Operation: POST /admin/database-backups/upload
  /// </summary>
  Task UploadDatabaseBackupAsync(Apigen.Immich.Models.DatabaseBackupUploadDto databaseBackupUploadDto);

  /// <summary>
  /// Download database backup
  /// Operation: GET /admin/database-backups/{filename}
  /// </summary>
  Task<object> GetAsync(string filename);

}
