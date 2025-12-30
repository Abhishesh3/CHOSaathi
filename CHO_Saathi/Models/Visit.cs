using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Visit
{
    public int Sno { get; set; }

    public int VisitId { get; set; }

    public int PatientId { get; set; }

    public string? VisitDate { get; set; }

    public string? Purpose { get; set; }

    public string? Outcome { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
