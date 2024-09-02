using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewAccountTotal
{
    public string MainAccount { get; set; } = null!;

    public string? MainDescription { get; set; }

    public string SubmainAccount { get; set; } = null!;

    public string? SubmainDescription { get; set; }

    public string ControlAccount { get; set; } = null!;

    public string? ControlDescription { get; set; }

    public string AccountCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string? AccountName { get; set; }

    public decimal? TotalDebit { get; set; }

    public decimal? TotalCredit { get; set; }

    public decimal? OpeningBalance { get; set; }

    public bool? CarryForward { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public bool? Payable { get; set; }

    public bool? Receivable { get; set; }
}
