using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Shift
{
    public int Sno { get; set; }

    public int ShiftId { get; set; }

    public int StaffId { get; set; }

    public string? ShiftDate { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
