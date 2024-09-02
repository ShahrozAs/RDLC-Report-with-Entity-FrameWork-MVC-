using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewInvoice
{
    public int TransactionNo { get; set; }

    public string Site { get; set; } = null!;

    public string TransactionType { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public int? InvoiceNo { get; set; }

    public string? DcNo { get; set; }

    public DateTime? DcDate { get; set; }

    public string? AccountCode { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? AccountName { get; set; }

    public string? Cnic { get; set; }

    public string? Address { get; set; }

    public string? Ntn { get; set; }

    public string? Stn { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public bool? Transferred { get; set; }

    public string? EnterBy { get; set; }

    public string? SubmainCode { get; set; }

    public string? SubmainDescription { get; set; }

    public string? ControlCode { get; set; }

    public string? ControlDescription { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemUnit { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExValue { get; set; }

    public decimal? GstPercent { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? Value { get; set; }

    public int SerialNo { get; set; }

    public string? TermsConditions { get; set; }

    public decimal? ReceiveQty { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public string? ContactPerson { get; set; }

    public string? MobileNo { get; set; }

    public string? SaleOrderNo { get; set; }

    public bool? Checked { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CheckedTime { get; set; }

    public bool? Approved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AfterDiscountAmount { get; set; }

    public decimal? FurtherTaxPercent { get; set; }

    public decimal? FurtherTaxAmount { get; set; }
}
