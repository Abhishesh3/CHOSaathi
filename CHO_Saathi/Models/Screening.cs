using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Screening
{
    public int Sno { get; set; }

    public int ScreeningId { get; set; }

    public int PatientId { get; set; }

    public string Type { get; set; } = null!;

    public string? Result { get; set; }

    public string? RecordedOn { get; set; }
}
