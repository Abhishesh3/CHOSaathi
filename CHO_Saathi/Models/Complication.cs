using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Complication
{
    public int Sno { get; set; }

    public int ComplicationId { get; set; }

    public int PatientId { get; set; }

    public string? Description { get; set; }

    public string? Severity { get; set; }

    public string? RecordedOn { get; set; }
}
