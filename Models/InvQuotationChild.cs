using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvQuotationChild
{
    public int TransactionNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Value { get; set; }

    public int SerialNo { get; set; }

    public virtual InvQuotationMaster InvQuotationMaster { get; set; } = null!;
}
