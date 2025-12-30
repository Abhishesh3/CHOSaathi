using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class MedicationHistory
{
    public int Sno { get; set; }

    public int HistoryId { get; set; }

    public int PatientId { get; set; }

    public string Medicine { get; set; } = null!;

    public string? Dosage { get; set; }

    public string? Frequency { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
