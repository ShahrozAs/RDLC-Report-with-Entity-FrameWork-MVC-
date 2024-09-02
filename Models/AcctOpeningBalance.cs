using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctOpeningBalance
{
    public string AccountCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public decimal? OpeningBalance { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
