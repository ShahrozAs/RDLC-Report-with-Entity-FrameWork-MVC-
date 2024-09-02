using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvOgpchild
{
    public int OgpNo { get; set; }

    public string Site { get; set; } = null!;

    public string? ItemCode { get; set; }

    public decimal? OgpQty { get; set; }

    public string? Remarks { get; set; }

    public long SerialNo { get; set; }
}
