using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvOpeningBalance
{
    public string ItemCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public decimal? ItemOpeningQty { get; set; }

    public decimal? ItemOpeningRate { get; set; }

    public decimal? ItemOpeningValue { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
