using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblRolePage
{
    public string Id { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public string PageId { get; set; } = null!;

    public string IsInsert { get; set; } = null!;

    public string IsUpdate { get; set; } = null!;

    public string IsDelete { get; set; } = null!;

    public string IsSearch { get; set; } = null!;

    public string IsDownload { get; set; } = null!;

    public string IsPrint { get; set; } = null!;

    public string IsOpen { get; set; } = null!;

    public string IsAdmin { get; set; } = null!;

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual TblRole Role { get; set; } = null!;
}
