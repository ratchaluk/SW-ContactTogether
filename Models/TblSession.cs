using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblSession
{
    public string Id { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string? ServerName { get; set; }

    public DateTime SessionTime { get; set; }
}
