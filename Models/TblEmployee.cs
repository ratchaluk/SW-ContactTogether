using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblEmployee
{
    public string Id { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string GenderId { get; set; } = null!;

    public string? SalutationTh { get; set; }

    public string FirstnameTh { get; set; } = null!;

    public string? LastnameTh { get; set; }

    public string? SalutationEn { get; set; }

    public string FirstnameEn { get; set; } = null!;

    public string? LastnameEn { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? ContactDetail { get; set; }

    public string? Position { get; set; }

    public DateTime? DateHire { get; set; }

    public DateTime? DateExpire { get; set; }

    public string RoleId { get; set; } = null!;

    public string? OrganizationId { get; set; }

    public string DefaultLanguage { get; set; } = null!;

    public int DefaultRowPerPage { get; set; }

    public byte[]? PictureProfile { get; set; }

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
