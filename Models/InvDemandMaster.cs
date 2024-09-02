using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvDemandMaster
{
    public int DemandNo { get; set; }

    public string Site { get; set; } = null!;

    public DateTime? DemandDate { get; set; }

    public string? DepartmentCode { get; set; }

    public bool? Approved { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }

    public virtual ICollection<InvDemandChild> InvDemandChildren { get; set; } = new List<InvDemandChild>();
}
