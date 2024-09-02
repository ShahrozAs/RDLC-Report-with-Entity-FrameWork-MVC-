using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvIgpchild
{
    public int IgpNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? IgpQty { get; set; }

    public int? DemandNo { get; set; }

    public string? DepartmentName { get; set; }

    public string? RemarksChild { get; set; }

    public bool? GrnStatus { get; set; }

    public long SerialNo { get; set; }
}
