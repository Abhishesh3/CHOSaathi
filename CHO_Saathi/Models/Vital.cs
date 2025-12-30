using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Vital
{
    public int Sno { get; set; }

    public int PatientId { get; set; }

    public string? Height { get; set; }

    public string? Weight { get; set; }

    public string? Bp { get; set; }

    public string? Pulse { get; set; }

    public string? Temperature { get; set; }

    public string? RecordedOn { get; set; }
}
