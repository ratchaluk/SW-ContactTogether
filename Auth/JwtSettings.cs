namespace ContactTogetherApi.Auth;

/// <summary>
/// Bound from the "Jwt" configuration section. The signing key belongs in user secrets /
/// environment variables, never in a committed appsettings file.
/// </summary>
public class JwtSettings
{
    public const string SectionName = "Jwt";

    public string Issuer { get; set; } = "ContactTogetherApi";

    public string Audience { get; set; } = "ContactTogetherApi";

    /// <summary>HMAC-SHA256 signing key. Must be at least 32 characters.</summary>
    public string Key { get; set; } = string.Empty;

    public int ExpiresMinutes { get; set; } = 60;
}
