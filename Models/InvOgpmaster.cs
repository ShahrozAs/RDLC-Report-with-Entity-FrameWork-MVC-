using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvOgpmaster
{
    public int OgpNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? OgpDate { get; set; }

    public string? OgpType { get; set; }

    public string? StoreLocation { get; set; }

    public string? Driver { get; set; }

    public string? Through { get; set; }

    public string? AccountCode { get; set; }

    public string? DepartmentId { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
