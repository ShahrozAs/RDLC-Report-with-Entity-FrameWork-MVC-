using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvQuotationMaster
{
    public int TransactionNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public DateTime? ValidityDate { get; set; }

    public string? DeliveryDays { get; set; }

    public string? Company { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public string? Remarks { get; set; }

    public string? Taxes { get; set; }

    public string? DeliveryLocation { get; set; }

    public string? Terms { get; set; }

    public string? AccountCode { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public virtual ICollection<InvQuotationChild> InvQuotationChildren { get; set; } = new List<InvQuotationChild>();
}
