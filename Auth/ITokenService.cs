using ContactTogetherApi.Models;

namespace ContactTogetherApi.Auth;

public interface ITokenService
{
    AccessToken CreateToken(TblEmployee employee);
}

/// <param name="Token">The signed JWT.</param>
/// <param name="TokenId">The <c>jti</c> claim, used to revoke the token on logout.</param>
/// <param name="ExpiresAtUtc">Expiry of the token.</param>
public record AccessToken(string Token, string TokenId, DateTime ExpiresAtUtc);
