using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblBroadcast
{
    public string Id { get; set; } = null!;

    public int? Seq { get; set; }

    public string TitleTh { get; set; } = null!;

    public string? TitleEn { get; set; }

    public string DescriptionTh { get; set; } = null!;

    public string? DescriptionEn { get; set; }

    public DateTime DateStart { get; set; }

    public DateTime? DateExpire { get; set; }

    public string BroadcastType { get; set; } = null!;

    public string? HaveGroup { get; set; }

    public string Remark { get; set; } = null!;

    public string IsEnable { get; set; } = null!;

    public DateTime Created { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime Updated { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual ICollection<TblBroadcastGroup> TblBroadcastGroups { get; set; } = new List<TblBroadcastGroup>();
}
