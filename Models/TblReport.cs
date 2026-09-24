using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblReport
{
    public string ReportId { get; set; } = null!;

    public string? ReportDescription { get; set; }

    public string? ReportName { get; set; }

    public string? ReportFileName { get; set; }

    public string? ReportServername { get; set; }

    public string? ReportDatabasename { get; set; }

    public string? ReportUsername { get; set; }

    public string? ReportPassword { get; set; }

    public string? ReportIntegratedsecurity { get; set; }

    public string? Target { get; set; }

    public string? Displaygrouptree { get; set; }

    public string? Enable { get; set; }

    public DateTime? Recdate { get; set; }

    public string? Recuser { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateuser { get; set; }

    public virtual ICollection<TblReportParameter> TblReportParameters { get; set; } = new List<TblReportParameter>();
}
