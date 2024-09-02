using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvViewLocation
{
    public string MainCode { get; set; } = null!;

    public string? MainHead { get; set; }

    public string? SubmainCode { get; set; }

    public string? SubmainHead { get; set; }

    public string? LocationCode { get; set; }

    public string? Site { get; set; }

    public string? ParentCode { get; set; }

    public string? LocationName { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
