using System;
using System.Collections.Generic;

namespace CHO_Saathi.Models;

public partial class Admission
{
    public int Sno { get; set; }

    public int AdmissionId { get; set; }

    public int PatientId { get; set; }

    public string Hospital { get; set; } = null!;

    public string? Reason { get; set; }

    public string? AdmissionDate { get; set; }

    public string? DischargeDate { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedOn { get; set; }
}
