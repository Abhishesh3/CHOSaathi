using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MedicalHistory
{
    public int Sno { get; set; }

    public int HistoryId { get; set; }

    public int PatientId { get; set; }

    public string Condition { get; set; } = null!;

    public string? DiagnosedOn { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? RecordedOn { get; set; }
}
