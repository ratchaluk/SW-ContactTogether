using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblRunning
{
    public string Id { get; set; } = null!;

    public string RunningCode { get; set; } = null!;

    public string RunningFormat { get; set; } = null!;

    public int RunningNext { get; set; }

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
