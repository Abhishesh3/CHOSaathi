using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Training
{
    public int Sno { get; set; }

    public int TrainingId { get; set; }

    public int StaffId { get; set; }

    public string Topic { get; set; } = null!;

    public string? Date { get; set; }

    public string? Duration { get; set; }

    public string? Trainer { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
