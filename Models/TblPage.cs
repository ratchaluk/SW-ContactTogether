using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblPage
{
    public string Id { get; set; } = null!;

    public string PageNameTh { get; set; } = null!;

    public string PageNameEn { get; set; } = null!;

    public string PageFileName { get; set; } = null!;

    public string ControlId { get; set; } = null!;

    public string PageAdmin { get; set; } = null!;

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
