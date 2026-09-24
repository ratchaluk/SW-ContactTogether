using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblService
{
    public string Id { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string StatusId { get; set; } = null!;

    public string OwnerId { get; set; } = null!;

    public DateTime DateOpened { get; set; }

    public DateTime? DateClosed { get; set; }

    public string ChannelIncomingId { get; set; } = null!;

    public string CallBack { get; set; } = null!;

    public string? ChannelOutgoingId { get; set; }

    public string? AccountId { get; set; }

    public string Summary { get; set; } = null!;

    public string? Detail { get; set; }

    public string? ServiceArea { get; set; }

    public string? OrganizationId { get; set; }

    public DateTime? OnScene { get; set; }

    public string? ServiceReference { get; set; }

    public string? ServiceReferenceLink { get; set; }

    public string? AreaId { get; set; }

    public string? Remark { get; set; }

    public string? LevelSeverityId { get; set; }

    public string? LevelPriorityId { get; set; }

    public string? LevelSecretId { get; set; }

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual TblStatus Status { get; set; } = null!;
}
