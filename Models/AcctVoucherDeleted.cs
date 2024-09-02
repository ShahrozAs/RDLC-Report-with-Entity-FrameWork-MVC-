using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctVoucherDeleted
{
    public int? VoucherNo { get; set; }

    public string? VoucherType { get; set; }

    public string? Site { get; set; }

    public int? VoucherMonth { get; set; }

    public DateTime? VoucherDate { get; set; }

    public bool? Approved { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public int SerialNo { get; set; }
}
