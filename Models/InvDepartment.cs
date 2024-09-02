using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvDepartment
{
    public string DepartmentCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string? ParentCode { get; set; }

    public string? DepartmentName { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
