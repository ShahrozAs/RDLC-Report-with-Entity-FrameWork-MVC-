using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewAccountBalance
{
    public string? ControlAccount { get; set; }

    public string? ControlDescription { get; set; }

    public string? AccountCode { get; set; }

    public string? AccountName { get; set; }

    public string Site { get; set; } = null!;

    public bool? CarryForward { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? TotalDebit { get; set; }

    public decimal? TotalCredit { get; set; }

    public decimal? Balance { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public bool? Payable { get; set; }

    public bool? Receivable { get; set; }
}
