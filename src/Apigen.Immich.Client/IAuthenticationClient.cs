using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Authentication operations
/// </summary>
public partial interface IAuthenticationClient
{
  /// <summary>
  /// Register admin
  /// Operation: POST /auth/admin-sign-up
  /// </summary>
  Task<UserAdminResponseDto> SignUpAdminAsync(Apigen.Immich.Models.SignUpDto signUpDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Change password
  /// Operation: POST /auth/change-password
  /// </summary>
  Task<UserAdminResponseDto> ChangePasswordAsync(Apigen.Immich.Models.ChangePasswordDto changePasswordDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Login
  /// Operation: POST /auth/login
  /// </summary>
  Task<LoginResponseDto> LoginAsync(Apigen.Immich.Models.LoginCredentialDto loginCredentialDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Logout
  /// Operation: POST /auth/logout
  /// </summary>
  Task<LogoutResponseDto> LogoutAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Reset pin code
  /// Operation: DELETE /auth/pin-code
  /// </summary>
  Task ResetPinCodeAsync(Apigen.Immich.Models.PinCodeResetDto pinCodeResetDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Setup pin code
  /// Operation: POST /auth/pin-code
  /// </summary>
  Task SetupPinCodeAsync(Apigen.Immich.Models.PinCodeSetupDto pinCodeSetupDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Change pin code
  /// Operation: PUT /auth/pin-code
  /// </summary>
  Task ChangePinCodeAsync(Apigen.Immich.Models.PinCodeChangeDto pinCodeChangeDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Lock auth session
  /// Operation: POST /auth/session/lock
  /// </summary>
  Task LockAuthSessionAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Unlock auth session
  /// Operation: POST /auth/session/unlock
  /// </summary>
  Task UnlockAuthSessionAsync(Apigen.Immich.Models.SessionUnlockDto sessionUnlockDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Retrieve auth status
  /// Operation: GET /auth/status
  /// </summary>
  Task<AuthStatusResponseDto> GetAuthStatusAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Validate access token
  /// Operation: POST /auth/validateToken
  /// </summary>
  Task<ValidateAccessTokenResponseDto> ValidateAccessTokenAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Start OAuth
  /// Operation: POST /oauth/authorize
  /// </summary>
  Task<OAuthAuthorizeResponseDto> StartOAuthAsync(Apigen.Immich.Models.OAuthConfigDto oAuthConfigDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Finish OAuth
  /// Operation: POST /oauth/callback
  /// </summary>
  Task<LoginResponseDto> FinishOAuthAsync(Apigen.Immich.Models.OAuthCallbackDto oAuthCallbackDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Link OAuth account
  /// Operation: POST /oauth/link
  /// </summary>
  Task<UserAdminResponseDto> LinkOAuthAccountAsync(Apigen.Immich.Models.OAuthCallbackDto oAuthCallbackDto, CancellationToken cancellationToken = default);

  /// <summary>
  /// Redirect OAuth to mobile
  /// Operation: GET /oauth/mobile-redirect
  /// </summary>
  Task RedirectOAuthToMobileAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// Unlink OAuth account
  /// Operation: POST /oauth/unlink
  /// </summary>
  Task<UserAdminResponseDto> UnlinkOAuthAccountAsync(CancellationToken cancellationToken = default);

}
