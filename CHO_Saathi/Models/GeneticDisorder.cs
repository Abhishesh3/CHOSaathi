using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class GeneticDisorder
{
    public int Sno { get; set; }

    public int GeneticDisorderId { get; set; }

    public int PatientId { get; set; }

    public string Disorder { get; set; } = null!;

    public string? InheritedFrom { get; set; }

    public string? Remarks { get; set; }

    public string? RecordedOn { get; set; }
}
