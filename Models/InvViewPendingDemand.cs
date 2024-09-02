using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewPendingDemand
{
    public int DemandNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemUnit { get; set; }

    public decimal? RequiredQty { get; set; }

    public decimal? PoQuantity { get; set; }

    public decimal? BalanceQuantity { get; set; }

    public long SerialNo { get; set; }
}
