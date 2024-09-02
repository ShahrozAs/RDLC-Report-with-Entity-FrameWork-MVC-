using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvIgpmaster
{
    public int IgpNo { get; set; }

    public string Site { get; set; } = null!;

    public string? IgpType { get; set; }

    public DateTime? IgpDate { get; set; }

    public string? StoreLocation { get; set; }

    public string? PoNo { get; set; }

    public DateTime? PoDate { get; set; }

    public string? ManualIgpNo { get; set; }

    public DateTime? ManualIgpDate { get; set; }

    public string? AccountCode { get; set; }

    public string? SecurityGuard { get; set; }

    public string? DcNo { get; set; }

    public DateTime? DcDate { get; set; }

    public string? Remarks { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
