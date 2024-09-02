using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctVoucherChild
{
    public int VoucherNo { get; set; }

    public string VoucherType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public int VoucherMonth { get; set; }

    public string? AccountCode { get; set; }

    public string? ProjectCode { get; set; }

    public string? VendorCode { get; set; }

    public string? Narration { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? ChequeNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? InvoiceNo { get; set; }

    public bool? CreditStatus { get; set; }

    public bool? BankReconciliation { get; set; }

    public DateTime? ReconciliationDate { get; set; }

    public string? Mark { get; set; }

    public int? RecordNo { get; set; }

    public long SerialNo { get; set; }

    //public virtual AcctVoucherMaster AcctVoucherMaster { get; set; } = null!;
}
