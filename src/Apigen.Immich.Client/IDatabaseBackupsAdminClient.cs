using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Database Backups (admin) operations
/// </summary>
public partial interface IDatabaseBackupsAdminClient
{
  /// <summary>
  /// Delete database backup
  /// Operation: DELETE /admin/database-backups
  /// </summary>
  Task DeleteDatabaseBackupAsync(Apigen.Immich.Models.DatabaseBackupDeleteDto databaseBackupDeleteDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// List database backups
  /// Operation: GET /admin/database-backups
  /// </summary>
  Task<DatabaseBackupListResponseDto> ListDatabaseBackupsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Start database backup restore flow
  /// Operation: POST /admin/database-backups/start-restore
  /// </summary>
  Task StartDatabaseRestoreFlowAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Upload database backup
  /// Operation: POST /admin/database-backups/upload
  /// </summary>
  Task UploadDatabaseBackupAsync(Apigen.Immich.Models.DatabaseBackupUploadDto databaseBackupUploadDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Download database backup
  /// Operation: GET /admin/database-backups/{filename}
  /// </summary>
  Task<Stream> GetAsync(string filename, CancellationToken cancellationToken = default);

}
