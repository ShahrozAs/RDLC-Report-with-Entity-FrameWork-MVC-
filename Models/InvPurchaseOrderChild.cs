using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvPurchaseOrderChild
{
    public int PurchaseOrderNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? PoQuantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExValue { get; set; }

    public decimal? GstPercent { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? Value { get; set; }

    public int? DemandNo { get; set; }

    public int? DemandSerialNo { get; set; }

    public bool? IgpStatus { get; set; }

    public long SerialNo { get; set; }

    public virtual InvPurchaseOrderMaster InvPurchaseOrderMaster { get; set; } = null!;
}
