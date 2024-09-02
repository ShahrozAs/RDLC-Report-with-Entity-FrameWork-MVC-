using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class AcctVoucherMaster
{
    public int VoucherNo { get; set; }

    public string VoucherType { get; set; } = null!;

    public string Site { get; set; } = null!;

    public int VoucherMonth { get; set; }

    public DateTime? VoucherDate { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? Unit { get; set; }

    public string? Remarks { get; set; }

    public bool? PdcVoucher { get; set; }

    public bool? Checked { get; set; }

    public string? CheckedBy { get; set; }

    public DateTime? CheckedTime { get; set; }

    public bool? Approved { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedTime { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    //public virtual ICollection<AcctVoucherChild> AcctVoucherChildren { get; set; } = new List<AcctVoucherChild>();
}
