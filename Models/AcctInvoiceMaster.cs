using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctInvoiceMaster
{
    public int TransactionNo { get; set; }

    public string Site { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public int? InvoiceNo { get; set; }

    public int? DcReturnNo { get; set; }

    public string? SaleOrderNo { get; set; }

    public string? DcNo { get; set; }

    public DateTime? DcDate { get; set; }

    public string? AccountCode { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? TermsConditions { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public bool? Transferred { get; set; }

    public bool? Checked { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CheckedTime { get; set; }

    public bool? Approved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public virtual ICollection<AcctInvoiceChild> AcctInvoiceChildren { get; set; } = new List<AcctInvoiceChild>();
}
