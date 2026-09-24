using System.ComponentModel.DataAnnotations;

namespace ContactTogetherApi.Dtos;

/// <summary>
/// Payload for creating a <c>TblEmployee</c> row. Lengths mirror the columns; the flag-ish fields
/// (<see cref="DefaultLanguage"/>, <see cref="IsEnable"/>) are strings because the schema stores
/// them as <c>nvarchar(10)</c>.
/// </summary>
public class CreateEmployeeRequest
{
    [Required]
    [MaxLength(100)]
    public string UserName { get; set; } = string.Empty;

    /// <summary>Plain-text password; stored as an ASP.NET Core PBKDF2 hash, never as given.</summary>
    [Required]
    [MaxLength(255)]
    public string Password { get; set; } = string.Empty;

    /// <summary><c>TblGender.Id</c>.</summary>
    [Required]
    [MaxLength(50)]
    public string GenderId { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? SalutationTh { get; set; }

    [Required]
    [MaxLength(200)]
    public string FirstnameTh { get; set; } = string.Empty;

    [MaxLength(200)]
    public string? LastnameTh { get; set; }

    [MaxLength(100)]
    public string? SalutationEn { get; set; }

    /// <summary>
    /// The column is <c>NOT NULL</c> but there is often no English name for a Thai-only record, so
    /// this is optional here and stored as an empty string when omitted.
    /// </summary>
    [MaxLength(200)]
    public string? FirstnameEn { get; set; }

    [MaxLength(200)]
    public string? LastnameEn { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? ContactDetail { get; set; }

    [MaxLength(100)]
    public string? Position { get; set; }

    /// <summary>Defaults to the time the row is created.</summary>
    public DateTime? DateHire { get; set; }

    public DateTime? DateExpire { get; set; }

    /// <summary><c>TblRole.Id</c>.</summary>
    [Required]
    [MaxLength(50)]
    public string RoleId { get; set; } = string.Empty;

    /// <summary><c>TblOrganization.Id</c>. Optional - the column is nullable.</summary>
    [MaxLength(50)]
    public string? OrganizationId { get; set; }

    [MaxLength(10)]
    public string DefaultLanguage { get; set; } = "T";

    [Range(1, 1000)]
    public int DefaultRowPerPage { get; set; } = 100;

    [MaxLength(10)]
    public string IsEnable { get; set; } = "T";
}