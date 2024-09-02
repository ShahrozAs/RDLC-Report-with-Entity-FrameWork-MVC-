using System;
using System.Collections.Generic;

namespace RDLC_with_Entity_FrameWork.Models;

public partial class InvItemCoding
{
    public string ItemCode { get; set; } = null!;

    public string Site { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? ParentCode { get; set; }

    public string? ItemDescription { get; set; }

    public string? ItemSpecification { get; set; }

    public string? ItemUnit { get; set; }

    public int? Width { get; set; }

    public int? ItemMinimumQty { get; set; }

    public int? ItemMaximumQty { get; set; }

    public int? ItemReOrderLevel { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public bool? Status { get; set; }

    public string? EnterBy { get; set; }

    public DateTime? EnteryTime { get; set; }

    public string? EditBy { get; set; }

    public DateTime? EditTime { get; set; }
}
