using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctViewCharOfAccount
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

    public bool? BankCode { get; set; }

    public bool? CashCode { get; set; }

    public bool? CarryForward { get; set; }

    public bool? Payable { get; set; }

    public bool? Receivable { get; set; }

    public bool? Budget { get; set; }

    public bool? ProfitLoss { get; set; }

    public bool? BalanceSheet { get; set; }

    public bool? PaymentStop { get; set; }

    public bool? Status { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? MobileNo { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Stn { get; set; }

    public string? Cnic { get; set; }

    public string? Ntn { get; set; }

    public int? CityId { get; set; }

    public string? CityName { get; set; }

    public bool? IncomeTaxStatus { get; set; }

    public decimal? IncomeTaxPercent { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public string? ParentCode { get; set; }

    public int? SortOrder { get; set; }
}
