using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class EmergencyVisit
{
    public int Sno { get; set; }

    public int EmergencyId { get; set; }

    public int PatientId { get; set; }

    public string? Reason { get; set; }

    public string? VisitDate { get; set; }

    public string? Outcome { get; set; }

    public string? CreatedOn { get; set; }
}
