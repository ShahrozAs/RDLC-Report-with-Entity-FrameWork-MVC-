using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctInvoiceChild
{
    public int TransactionNo { get; set; }

    public string Site { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? ReceiveQty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExValue { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AfterDiscountAmount { get; set; }

    public decimal? GstPercent { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? FurtherTaxPercent { get; set; }

    public decimal? FurtherTaxAmount { get; set; }

    public decimal? Value { get; set; }

    public int SerialNo { get; set; }

    public virtual AcctInvoiceMaster AcctInvoiceMaster { get; set; } = null!;
}
