using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class LabResult
{
    public int Sno { get; set; }

    public int ResultId { get; set; }

    public int PatientId { get; set; }

    public int TestId { get; set; }

    public string? Result { get; set; }

    public string? Unit { get; set; }

    public string? ReferenceRange { get; set; }

    public string? RecordedOn { get; set; }
}
