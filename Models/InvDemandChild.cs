using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvDemandChild
{
    public int DemandNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? DemandQty { get; set; }

    public decimal? RequiredQty { get; set; }

    public string? Remarks { get; set; }

    public int? RowNo { get; set; }

    public long SerialNo { get; set; }

    public virtual InvDemandMaster InvDemandMaster { get; set; } = null!;
}
