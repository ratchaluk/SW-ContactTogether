using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblRemark
{
    public string Id { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
