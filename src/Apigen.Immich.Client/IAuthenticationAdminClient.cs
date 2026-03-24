using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Authentication (admin) operations
/// </summary>
public interface IAuthenticationAdminClient
{
  /// <summary>
  /// Unlink all OAuth accounts
  /// Operation: POST /admin/auth/unlink-all
  /// </summary>
  Task UnlinkAllOAuthAccountsAdminAsync();

}
