using Microsoft.Extensions.Caching.Memory;

namespace ContactTogetherApi.Auth;

/// <summary>
/// In-process revocation list. Entries drop out by themselves once the token would have expired,
/// so the list never grows beyond the tokens still in flight.
/// </summary>
/// <remarks>
/// Because it is in-process, a restart or a second instance behind a load balancer forgets the
/// revocations. Swap this for a distributed cache (Redis) or a database table if the API is scaled out.
/// </remarks>
public class MemoryTokenRevocationStore : ITokenRevocationStore
{
    private readonly IMemoryCache _cache;

    public MemoryTokenRevocationStore(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void Revoke(string tokenId, DateTime expiresAtUtc)
    {
        // Already-expired tokens are rejected by the normal lifetime validation, no need to store them.
        if (expiresAtUtc <= DateTime.UtcNow)
        {
            return;
        }

        _cache.Set(CacheKey(tokenId), true, expiresAtUtc);
    }

    public bool IsRevoked(string tokenId) => _cache.TryGetValue(CacheKey(tokenId), out _);

    private static string CacheKey(string tokenId) => $"revoked-jti:{tokenId}";
}
