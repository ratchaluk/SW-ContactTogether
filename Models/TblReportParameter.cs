using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblReportParameter
{
    public string Id { get; set; } = null!;

    public string ReportId { get; set; } = null!;

    public string? ParameterName { get; set; }

    public string? ParameterType { get; set; }

    public string? ParameterDescription { get; set; }

    public string? ParameterDefault { get; set; }

    public string? ObjectType { get; set; }

    public string? DatabaseType { get; set; }

    public string? ConnectionString { get; set; }

    public string? SqlSelect { get; set; }

    public string? SqlValue { get; set; }

    public string? SqlField { get; set; }

    public string? SqlTable { get; set; }

    public string? SqlCondition { get; set; }

    public string? SqlOrder { get; set; }

    public string? Postback { get; set; }

    public string Enable { get; set; } = null!;

    public DateTime? Recdate { get; set; }

    public string? Recuser { get; set; }

    public DateTime? Updatedate { get; set; }

    public string? Updateuser { get; set; }

    public virtual TblReport Report { get; set; } = null!;
}
