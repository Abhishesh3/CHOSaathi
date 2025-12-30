using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class HealthCamp
{
    public int Sno { get; set; }

    public int CampId { get; set; }

    public int PatientId { get; set; }

    public string CampName { get; set; } = null!;

    public string? Date { get; set; }

    public string? Services { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
