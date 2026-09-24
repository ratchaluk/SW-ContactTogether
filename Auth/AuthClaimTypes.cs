namespace ContactTogetherApi.Auth;

/// <summary>
/// Short claim names used in the issued JWTs. Inbound claim mapping is turned off in
/// <c>Program.cs</c>, so these reach the controllers exactly as written here.
/// </summary>
public static class AuthClaimTypes
{
    /// <summary>Value of <c>TblEmployee.RoleId</c>.</summary>
    public const string Role = "role";

    /// <summary>Value of <c>TblEmployee.OrganizationId</c>.</summary>
    public const string OrganizationId = "org";

    /// <summary>Value of <c>TblEmployee.DefaultLanguage</c>.</summary>
    public const string Language = "lang";
}
