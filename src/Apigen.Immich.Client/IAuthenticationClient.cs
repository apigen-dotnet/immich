using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Immich.Models;

#nullable enable

namespace Apigen.Immich.Client;

/// <summary>
/// Interface for Authentication operations
/// </summary>
public interface IAuthenticationClient
{
  /// <summary>
  /// Register admin
  /// Operation: POST /auth/admin-sign-up
  /// </summary>
  Task<UserAdminResponseDto> SignUpAdminAsync(Apigen.Immich.Models.SignUpDto signUpDto);

  /// <summary>
  /// Change password
  /// Operation: POST /auth/change-password
  /// </summary>
  Task<UserAdminResponseDto> ChangePasswordAsync(Apigen.Immich.Models.ChangePasswordDto changePasswordDto);

  /// <summary>
  /// Login
  /// Operation: POST /auth/login
  /// </summary>
  Task<LoginResponseDto> LoginAsync(Apigen.Immich.Models.LoginCredentialDto loginCredentialDto);

  /// <summary>
  /// Logout
  /// Operation: POST /auth/logout
  /// </summary>
  Task<LogoutResponseDto> LogoutAsync();

  /// <summary>
  /// Reset pin code
  /// Operation: DELETE /auth/pin-code
  /// </summary>
  Task ResetPinCodeAsync(Apigen.Immich.Models.PinCodeResetDto pinCodeResetDto);

  /// <summary>
  /// Setup pin code
  /// Operation: POST /auth/pin-code
  /// </summary>
  Task SetupPinCodeAsync(Apigen.Immich.Models.PinCodeSetupDto pinCodeSetupDto);

  /// <summary>
  /// Change pin code
  /// Operation: PUT /auth/pin-code
  /// </summary>
  Task ChangePinCodeAsync(Apigen.Immich.Models.PinCodeChangeDto pinCodeChangeDto);

  /// <summary>
  /// Lock auth session
  /// Operation: POST /auth/session/lock
  /// </summary>
  Task LockAuthSessionAsync();

  /// <summary>
  /// Unlock auth session
  /// Operation: POST /auth/session/unlock
  /// </summary>
  Task UnlockAuthSessionAsync(Apigen.Immich.Models.SessionUnlockDto sessionUnlockDto);

  /// <summary>
  /// Retrieve auth status
  /// Operation: GET /auth/status
  /// </summary>
  Task<AuthStatusResponseDto> GetAuthStatusAsync();

  /// <summary>
  /// Validate access token
  /// Operation: POST /auth/validateToken
  /// </summary>
  Task<ValidateAccessTokenResponseDto> ValidateAccessTokenAsync();

  /// <summary>
  /// Start OAuth
  /// Operation: POST /oauth/authorize
  /// </summary>
  Task<OAuthAuthorizeResponseDto> StartOAuthAsync(Apigen.Immich.Models.OAuthConfigDto oAuthConfigDto);

  /// <summary>
  /// Finish OAuth
  /// Operation: POST /oauth/callback
  /// </summary>
  Task<LoginResponseDto> FinishOAuthAsync(Apigen.Immich.Models.OAuthCallbackDto oAuthCallbackDto);

  /// <summary>
  /// Link OAuth account
  /// Operation: POST /oauth/link
  /// </summary>
  Task<UserAdminResponseDto> LinkOAuthAccountAsync(Apigen.Immich.Models.OAuthCallbackDto oAuthCallbackDto);

  /// <summary>
  /// Redirect OAuth to mobile
  /// Operation: GET /oauth/mobile-redirect
  /// </summary>
  Task RedirectOAuthToMobileAsync();

  /// <summary>
  /// Unlink OAuth account
  /// Operation: POST /oauth/unlink
  /// </summary>
  Task<UserAdminResponseDto> UnlinkOAuthAccountAsync();

}
