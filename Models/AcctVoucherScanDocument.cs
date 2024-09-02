using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctVoucherScanDocument
{
    public int DocumentNo { get; set; }

    public int VoucherNo { get; set; }

    public string VoucherType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public int VoucherMonth { get; set; }

    public byte[]? ScanDocument { get; set; }

    public long SerialNo { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
