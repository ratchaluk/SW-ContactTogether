using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblReopenedLog
{
    public string SrId { get; set; } = null!;

    public int Line { get; set; }

    public string ReopenComment { get; set; } = null!;

    public DateTime Closed { get; set; }

    public string ClosedBy { get; set; } = null!;

    public DateTime Reopened { get; set; }

    public string ReopenedBy { get; set; } = null!;
}
