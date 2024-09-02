using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctVoucherType
{
    public int VoucherId { get; set; }

    public string Site { get; set; } = null!;

    public string? VoucherType { get; set; }

    public string? VoucherDescription { get; set; }

    public string? Category { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
