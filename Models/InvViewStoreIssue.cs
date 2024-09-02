using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewStoreIssue
{
    public int TransactionNo { get; set; }

    public string TransactionType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public int? IgpNo { get; set; }

    public DateTime? IgpDate { get; set; }

    public string? PoNo { get; set; }

    public DateTime? PoDate { get; set; }

    public string? ManualIgpNo { get; set; }

    public DateTime? ManualIgpDate { get; set; }

    public int? StoreId { get; set; }

    public string? StoreName { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public string? DcNo { get; set; }

    public DateTime? DcDate { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? DemandNo { get; set; }

    public DateTime? DemandDate { get; set; }

    public string? DocumentNo { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? Remarks { get; set; }

    public string? BuiltyNo { get; set; }

    public string? VehicleNo { get; set; }

    public int? ToStoreId { get; set; }

    public string? ToStoreName { get; set; }

    public decimal? LoadingCharges { get; set; }

    public decimal? FreightCharges { get; set; }

    public decimal? CottingCharges { get; set; }

    public int? PurchaseNo { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? NetAmount { get; set; }

    public bool? Transferred { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ParentCode { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemSpecification { get; set; }

    public string? ItemUnit { get; set; }

    public int? Width { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExValue { get; set; }

    public decimal? GstPercent { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? Value { get; set; }

    public long SerialNo { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? BalanceQtyRoll { get; set; }

    public decimal? IssueQtyRoll { get; set; }

    public int? IssueNo { get; set; }

    public decimal? ReceivedQty { get; set; }

    public decimal? ReceivedQtyRolls { get; set; }

    public string? SubmainCode { get; set; }

    public string? SubmainDescription { get; set; }
}
