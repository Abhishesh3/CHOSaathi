using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Allergy
{
    public int Sno { get; set; }

    public int AllergyId { get; set; }

    public int PatientId { get; set; }

    public string Allergen { get; set; } = null!;

    public string? Reaction { get; set; }

    public string? Severity { get; set; }

    public string? RecordedOn { get; set; }
}
