using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblErrorLog
{
    public string Id { get; set; } = null!;

    public string ErrorOnPage { get; set; } = null!;

    public string ErrorOnFunction { get; set; } = null!;

    public string ErrorCode { get; set; } = null!;

    public string ErrorMessage { get; set; } = null!;

    public string InnerException { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime ErrorDate { get; set; }
}
