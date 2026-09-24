using System;
using System.Collections.Generic;

namespace ContactTogetherApi.Models;

public partial class TblAttachment
{
    public string Id { get; set; } = null!;

    public string? ServiceId { get; set; }

    public byte[]? FileContent { get; set; }

    public string? FileName { get; set; }

    public int? FileSize { get; set; }

    public string? FileType { get; set; }

    public string? IsEnable { get; set; }

    public DateTime? Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Updated { get; set; }

    public string? UpdatedBy { get; set; }
}
