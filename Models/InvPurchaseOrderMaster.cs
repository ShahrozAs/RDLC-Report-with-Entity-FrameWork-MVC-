using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvPurchaseOrderMaster
{
    public int PurchaseOrderNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? PurchaseOrderDate { get; set; }

    public string? AccountCode { get; set; }

    public string? Attention { get; set; }

    public string? PaymentTerms { get; set; }

    public string? DeliveryTime { get; set; }

    public string? Remarks { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? DiscountPercent { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? IncomeTaxPercent { get; set; }

    public decimal? IncomeTaxAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public virtual ICollection<InvPurchaseOrderChild> InvPurchaseOrderChildren { get; set; } = new List<InvPurchaseOrderChild>();
}
