namespace ContactTogetherApi.Auth;

/// <summary>
/// Keeps track of JWT ids (jti) that have been logged out before their natural expiry.
/// </summary>
public interface ITokenRevocationStore
{
    /// <summary>Revokes a token id until <paramref name="expiresAtUtc"/>, after which it expires on its own.</summary>
    void Revoke(string tokenId, DateTime expiresAtUtc);

    bool IsRevoked(string tokenId);
}
