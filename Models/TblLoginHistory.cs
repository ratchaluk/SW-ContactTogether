using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblLoginHistory
{
    public string Id { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string? UserName { get; set; }

    public string IpAddress { get; set; } = null!;

    public DateTime LoginDate { get; set; }

    public string Remark { get; set; } = null!;
}
