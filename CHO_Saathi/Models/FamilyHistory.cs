using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class FamilyHistory
{
    public int Sno { get; set; }

    public int FamilyHistoryId { get; set; }

    public int PatientId { get; set; }

    public string Relation { get; set; } = null!;

    public string? Condition { get; set; }

    public string? AgeOfOnset { get; set; }

    public string? Remarks { get; set; }

    public string? RecordedOn { get; set; }
}
