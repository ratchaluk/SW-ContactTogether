using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblBroadcastGroup
{
    public string Id { get; set; } = null!;

    public string BroadcastId { get; set; } = null!;

    public int GroupId { get; set; }

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual TblBroadcast Broadcast { get; set; } = null!;
}
