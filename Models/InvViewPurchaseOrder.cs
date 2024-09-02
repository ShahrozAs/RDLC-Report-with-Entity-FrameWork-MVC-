using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewPurchaseOrder
{
    public int PurchaseOrderNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? PurchaseOrderDate { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

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

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemSpecification { get; set; }

    public string? ItemUnit { get; set; }

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
}
