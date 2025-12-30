using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Radiology
{
    public int Sno { get; set; }

    public int RadiologyId { get; set; }

    public int PatientId { get; set; }

    public string TestName { get; set; } = null!;

    public string? Result { get; set; }

    public string? Findings { get; set; }

    public string? RecordedOn { get; set; }
}
