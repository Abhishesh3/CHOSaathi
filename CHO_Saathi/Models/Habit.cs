using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Habit
{
    public int Sno { get; set; }

    public int HabitId { get; set; }

    public int PatientId { get; set; }

    public string Habit1 { get; set; } = null!;

    public string? Frequency { get; set; }

    public string? Duration { get; set; }

    public string? Remarks { get; set; }

    public string? RecordedOn { get; set; }
}
