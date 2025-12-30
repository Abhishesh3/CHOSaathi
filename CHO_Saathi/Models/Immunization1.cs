using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Immunization1
{
    public int Sno { get; set; }

    public int ImmunizationId { get; set; }

    public int PatientId { get; set; }

    public string Vaccine { get; set; } = null!;

    public string? Dose { get; set; }

    public string? Date { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
