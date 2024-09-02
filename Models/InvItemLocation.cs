using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvItemLocation
{
    public string LocationCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string? ParentCode { get; set; }

    public string? LocationName { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
