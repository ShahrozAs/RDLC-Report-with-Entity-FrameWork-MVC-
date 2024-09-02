using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvStoreChild
{
    public int TransactionNo { get; set; }

    public string TransactionType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? BalanceQtyRoll { get; set; }

    public decimal? ReceivedQty { get; set; }

    public decimal? ReceivedQtyRolls { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? IssueQtyRoll { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ExValue { get; set; }

    public decimal? GstPercent { get; set; }

    public decimal? GstAmount { get; set; }

    public decimal? Value { get; set; }

    public decimal? CutLength { get; set; }

    public int? StoreId { get; set; }

    public int? ToStoreId { get; set; }

    public bool? OtherUnit { get; set; }

    public long SerialNo { get; set; }

    public virtual InvStoreMaster InvStoreMaster { get; set; } = null!;
}
