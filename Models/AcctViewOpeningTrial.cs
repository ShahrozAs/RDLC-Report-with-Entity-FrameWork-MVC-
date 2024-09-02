using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewOpeningTrial
{
    public string MainAccount { get; set; } = null!;

    public string? MainDescription { get; set; }

    public string? SubmainAccount { get; set; }

    public string? SubmainDescription { get; set; }

    public string? ControlAccount { get; set; }

    public string? ControlDescription { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string? Site { get; set; }

    public decimal? OpeningBalance { get; set; }

    public bool? CarryForward { get; set; }

    public bool? Payable { get; set; }

    public bool? Receivable { get; set; }

    public bool? Status { get; set; }
}
