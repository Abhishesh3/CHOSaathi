using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Performance
{
    public int Sno { get; set; }

    public int PerformanceId { get; set; }

    public int StaffId { get; set; }

    public string? ReviewDate { get; set; }

    public string? Rating { get; set; }

    public string? Comments { get; set; }

    public string? CreatedOn { get; set; }
}
