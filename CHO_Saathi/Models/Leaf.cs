using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Leaf
{
    public int Sno { get; set; }

    public int LeaveId { get; set; }

    public int StaffId { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
