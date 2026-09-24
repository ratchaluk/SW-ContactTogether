using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblContact
{
    public string Id { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string ContactDetail { get; set; } = null!;

    public DateTime ContactStart { get; set; }

    public DateTime? ContactEnd { get; set; }

    public string? MenuIvr { get; set; }

    public string ChannelId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public virtual TblChannel Channel { get; set; } = null!;
}
