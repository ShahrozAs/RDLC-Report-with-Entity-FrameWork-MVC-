using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewIgp
{
    public int IgpNo { get; set; }

    public string Site { get; set; } = null!;

    public string? IgpType { get; set; }

    public DateTime? IgpDate { get; set; }

    public string? PoNo { get; set; }

    public DateTime? PoDate { get; set; }

    public string? ManualIgpNo { get; set; }

    public DateTime? ManualIgpDate { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? SecurityGuard { get; set; }

    public string? DcNo { get; set; }

    public DateTime? DcDate { get; set; }

    public string? Remarks { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemSpecification { get; set; }

    public string? ItemUnit { get; set; }

    public decimal? IgpQty { get; set; }

    public int? DemandNo { get; set; }

    public string? DepartmentName { get; set; }

    public string? RemarksChild { get; set; }

    public bool? GrnStatus { get; set; }

    public long SerialNo { get; set; }

    public string? EnterBy { get; set; }

    public string? StoreLocation { get; set; }

    public string? WorkOrderNo { get; set; }
}
