using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewVoucher
{
    public int VoucherNo { get; set; }

    public string VoucherType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public int VoucherMonth { get; set; }

    public string? VoucherDescription { get; set; }

    public string? Category { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public string? Remarks { get; set; }

    public bool? Checked { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CheckedTime { get; set; }

    public bool? Approved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public DateTime? EnteryTime { get; set; }

    public DateTime? EditTime { get; set; }

    public string? EnterBy { get; set; }

    public string? EditBy { get; set; }

    public string? MainAccount { get; set; }

    public string? MainDescription { get; set; }

    public string? SubmainAccount { get; set; }

    public string? SubmainDescription { get; set; }

    public string? ControlAccount { get; set; }

    public string? ControlDescription { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public bool? CarryForward { get; set; }

    public bool? Payable { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? MobileNo { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Stn { get; set; }

    public string? Cnic { get; set; }

    public string? Ntn { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? Narration { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? ChequeNo { get; set; }

    public string? ChequeDate { get; set; }

    public string? Mark { get; set; }

    public long SerialNo { get; set; }

    public int? RecordNo { get; set; }

    public bool? BankCode { get; set; }

    public bool? CashCode { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? Unit { get; set; }

    public bool? PdcVoucher { get; set; }

    public string? VendorCode { get; set; }

    public bool? BankReconciliation { get; set; }

    public DateTime? ReconciliationDate { get; set; }

    public bool? ProfitLoss { get; set; }

    public bool? BalanceSheet { get; set; }

    public bool? IncomeTaxStatus { get; set; }

    public decimal? IncomeTaxPercent { get; set; }

    public bool? Receivable { get; set; }

    public bool? Budget { get; set; }

    public bool? Status { get; set; }

    public bool? CreditStatus { get; set; }

    public string? InvoiceNo { get; set; }
}
