using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewDemand
{
    public int DemandNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? DemandDate { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public bool? Approved { get; set; }

    public string? EnterBy { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemSpecification { get; set; }

    public string? ItemUnit { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? DemandQty { get; set; }

    public decimal? RequiredQty { get; set; }

    public string? Remarks { get; set; }

    public int? RowNo { get; set; }

    public long SerialNo { get; set; }
}
