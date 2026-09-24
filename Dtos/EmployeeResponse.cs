namespace ContactTogetherApi.Dtos;

/// <summary>An employee row as returned to the caller. Never carries <c>UserPassword</c>.</summary>
public class EmployeeResponse
{
    public int StatusCode { get; set; }

    public string Id { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;

    public string GenderId { get; set; } = string.Empty;

    public string? SalutationTh { get; set; }

    public string FirstnameTh { get; set; } = string.Empty;

    public string? LastnameTh { get; set; }

    public string? SalutationEn { get; set; }

    public string FirstnameEn { get; set; } = string.Empty;

    public string? LastnameEn { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? ContactDetail { get; set; }

    public string? Position { get; set; }

    public DateTime? DateHire { get; set; }

    public DateTime? DateExpire { get; set; }

    public string RoleId { get; set; } = string.Empty;

    public string? OrganizationId { get; set; }

    public string DefaultLanguage { get; set; } = string.Empty;

    public int DefaultRowPerPage { get; set; }

    public string IsEnable { get; set; } = string.Empty;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = string.Empty;
}